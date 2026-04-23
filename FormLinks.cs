using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Google.Protobuf.Reflection.UninterpretedOption.Types;

namespace Menu_14
{
    public partial class FormLinks : Form
    {
        private string currentFolderPath = "";
        public FormLinks()
        {
            InitializeComponent();
            // Подписываемся на событие клика мыши
            triadElements.MouseClick += TriadElements_MouseClick;
        }
        private void TriadElements_MouseClick(object sender, MouseEventArgs e)
        {
            // Проверяем, что нажата левая кнопка мыши
            if (e.Button == MouseButtons.Left)
            {
                // Получаем индекс элемента под курсором
                int index = triadElements.IndexFromPoint(e.Location);

                if (index != ListBox.NoMatches)
                {
                    string clickedItem = triadElements.Items[index].ToString();

                    // Проверяем, является ли элемент ссылкой (начинается с http:// или https://)
                    if (clickedItem.StartsWith("http://") || clickedItem.StartsWith("https://"))
                    {
                        try
                        {
                            // Открываем ссылку в браузере по умолчанию
                            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                            {
                                FileName = clickedItem,
                                UseShellExecute = true
                            });
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Не удалось открыть ссылку: {ex.Message}",
                                          "Ошибка",
                                          MessageBoxButtons.OK,
                                          MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
        public static void workFormLinks(string nameRu, string NameLat, string listLinks)
        {
            FormLinks form = new FormLinks();
            form.labelNameRuShow.Text = nameRu;
            form.nameLat.Text = NameLat;
            string folderPath = ConfigurationManager.AppSettings["catSubCutFotos"] + NameLat;
            string firstFile = Directory.EnumerateFiles(folderPath).FirstOrDefault();
            if (firstFile != null)
            {
                form.pictureBox1.Image = Image.FromFile(firstFile); //change 44
            }
            else
            {
                Console.WriteLine("Файлов не найдено.");
            }

            if (listLinks.Length > 1)
            {
                form.richTextBox1.Text = listLinks;
                form.currentFolderPath = ConfigurationManager.AppSettings["catSubCutFotos"] + NameLat;
           
                // Очищаем ListBox перед добавлением
                form.triadElements.Items.Clear();
   
                // Настройки подключения к базе данных в файле App.config
                PlantDataService service = new PlantDataService();
                // Пример 2: Получить ссылки для конкретного латинского названия
                string searchName = NameLat; // пример названия
                PlantLink[] links = service.GetPlantLinksArray(searchName);

                int triadCount = links.Length; // колличество строк в БД с таким же именем растения
 
                // Цикл для создания нескольких триад
                for (int i = 0; i < triadCount; i++)
                {
                    // 1. Строка текста   $"Элемент {i}: Это текстовая строка, текстовая строка, текстовая строка..."
                    string textString = links[i].Head;

                    // 2. Ссылка (гиперссылка)   
                    string link = links[i].Link; 

                    // 3. Пробельная строка (пустая строка для разделения)
                    string emptyLine = " ";

                    // Добавляем все три элемента триады в ListBox
                    form.triadElements.Items.Add(new ListBoxItem { Text = textString, IsLink = false });
                    form.triadElements.Items.Add(new ListBoxItem { Text = link, IsLink = true });
                    form.triadElements.Items.Add(new ListBoxItem { Text = emptyLine, IsLink = false });
                }
            }
            else
            {
                form.richTextBox1.Text = "Материал не подобран, пока.";
            }
            form.Show();                        // или form.ShowDialog();
        }
        // Класс для хранения элементов
        public class ListBoxItem
        {
            public string Text { get; set; }
            public bool IsLink { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }

        // Обработчик DrawItem
        private void form_triadElements_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            ListBox listBox = sender as ListBox;
            ListBoxItem item = listBox.Items[e.Index] as ListBoxItem;

            if (item == null) return;

            e.DrawBackground();

            Color textColor = item.IsLink ? Color.Blue : Color.Black;

            using (Brush brush = new SolidBrush(textColor))
            {
                e.Graphics.DrawString(item.Text, e.Font, brush, e.Bounds);
            }

            e.DrawFocusRectangle();
        }

        private void FormLinks_Load(object sender, EventArgs e)
        {         }
        public void pictureBox1_Click(object sender, EventArgs e) // запуск FastStone с указаным каталогом
        {
             // Путь к FastStone Image Viewer (обычно в Program Files)
            string fastStonePath = ConfigurationManager.AppSettings["FastStone"];

            // Запускаем FastStone с параметром (путь к изображению)
            Process.Start(fastStonePath, $"\"{currentFolderPath}\"");
        }
    }
}
