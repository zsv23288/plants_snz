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
     //       public string NameLatTo = NameLat;
            form.richTextBox1.Text = listLinks;
            string folderPath =  ConfigurationManager.AppSettings["catSubCutFotos"] +  NameLat;
            form.currentFolderPath = ConfigurationManager.AppSettings["catSubCutFotos"] + NameLat;
            // Получаем первый файл или null, если папка пуста
            string firstFile = Directory.EnumerateFiles(folderPath).FirstOrDefault();

            if (firstFile != null)
            {
                form.pictureBox1.Image = Image.FromFile(firstFile);
            }
            else
            {
                Console.WriteLine("Файлов не найдено.");
            }
            // Очищаем ListBox перед добавлением
            form.triadElements.Items.Clear();
            // Настройки подключения к базе данных
            string server = "localhost";
            string database = "snz_flora";
            string userId = "root";
            string port = "3306";
            string password = "root";

            PlantDataService service = new PlantDataService(server, database, userId, password);
            // Пример 2: Получить ссылки для конкретного латинского названия
            string searchName = "Quercus robur"; // пример названия
            PlantLink[] links = service.GetPlantLinksArray(searchName);

            // Количество триад
            int triadCount = 3;

            // Цикл для создания нескольких триад
            for (int i = 1; i <= triadCount; i++)
            {
                // 1. Строка текста
                string textString = $"Элемент {i}: Это текстовая строка, текстовая строка, текстовая строка...";

                // 2. Ссылка (гиперссылка)
                string link = $"https://www.74.ru"; // /item{i}

                // 3. Пробельная строка (пустая строка для разделения)
                string emptyLine = "";

                // Добавляем все три элемента триады в ListBox
                form.triadElements.Items.Add(textString);
                form.triadElements.Items.Add(link);
                form.triadElements.Items.Add(emptyLine);
            }
            form.Show();                        // или form.ShowDialog();
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
