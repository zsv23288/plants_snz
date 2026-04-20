namespace Menu_14
{
    partial class Menu_14
    {
        /// <summary>
        /// Это класс Формы
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// Здесь эабавно
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_14));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.оснвныеДанныеИзBDMySQLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вывестиИзMySQLВТаблицуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ljfdbnmHfcnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очисткаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.папкиСФотографиямиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.протоколИзMySQLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bDРастенийВMySQLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тестМетодаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.записьПротоколаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.датаИзСтрокиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.числоИзСтрокиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.namelatListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проверкаНаличияПодкаталогаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заменаПоляTimelastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.запускFormLinksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(19, 19);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оснвныеДанныеИзBDMySQLToolStripMenuItem,
            this.ljfdbnmHfcnToolStripMenuItem,
            this.очисткаToolStripMenuItem,
            this.заToolStripMenuItem,
            this.тестМетодаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1819, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // оснвныеДанныеИзBDMySQLToolStripMenuItem
            // 
            this.оснвныеДанныеИзBDMySQLToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вывестиИзMySQLВТаблицуToolStripMenuItem});
            this.оснвныеДанныеИзBDMySQLToolStripMenuItem.Name = "оснвныеДанныеИзBDMySQLToolStripMenuItem";
            this.оснвныеДанныеИзBDMySQLToolStripMenuItem.Size = new System.Drawing.Size(218, 23);
            this.оснвныеДанныеИзBDMySQLToolStripMenuItem.Text = "оснвные данные из BD MySQL";
            this.оснвныеДанныеИзBDMySQLToolStripMenuItem.Click += new System.EventHandler(this.оснвныеДанныеИзBDMySQLToolStripMenuItem_Click);
            // 
            // вывестиИзMySQLВТаблицуToolStripMenuItem
            // 
            this.вывестиИзMySQLВТаблицуToolStripMenuItem.Name = "вывестиИзMySQLВТаблицуToolStripMenuItem";
            this.вывестиИзMySQLВТаблицуToolStripMenuItem.Size = new System.Drawing.Size(271, 26);
            this.вывестиИзMySQLВТаблицуToolStripMenuItem.Text = "вывести из MySQL в таблицу";
            this.вывестиИзMySQLВТаблицуToolStripMenuItem.Click += new System.EventHandler(this.вывестиИзMySQLВТаблицуToolStripMenuItem_Click);
            // 
            // ljfdbnmHfcnToolStripMenuItem
            // 
            this.ljfdbnmHfcnToolStripMenuItem.Name = "ljfdbnmHfcnToolStripMenuItem";
            this.ljfdbnmHfcnToolStripMenuItem.Size = new System.Drawing.Size(143, 23);
            this.ljfdbnmHfcnToolStripMenuItem.Text = "добавить растение";
            // 
            // очисткаToolStripMenuItem
            // 
            this.очисткаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.папкиСФотографиямиToolStripMenuItem,
            this.протоколИзMySQLToolStripMenuItem,
            this.bDРастенийВMySQLToolStripMenuItem});
            this.очисткаToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.очисткаToolStripMenuItem.Name = "очисткаToolStripMenuItem";
            this.очисткаToolStripMenuItem.Size = new System.Drawing.Size(73, 23);
            this.очисткаToolStripMenuItem.Text = "очистка";
            // 
            // папкиСФотографиямиToolStripMenuItem
            // 
            this.папкиСФотографиямиToolStripMenuItem.Name = "папкиСФотографиямиToolStripMenuItem";
            this.папкиСФотографиямиToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.папкиСФотографиямиToolStripMenuItem.Text = "папки с фотографиями";
            this.папкиСФотографиямиToolStripMenuItem.Click += new System.EventHandler(this.папкиСФотографиямиToolStripMenuItem_Click);
            // 
            // протоколИзMySQLToolStripMenuItem
            // 
            this.протоколИзMySQLToolStripMenuItem.Name = "протоколИзMySQLToolStripMenuItem";
            this.протоколИзMySQLToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.протоколИзMySQLToolStripMenuItem.Text = "протокол из MySQL";
            // 
            // bDРастенийВMySQLToolStripMenuItem
            // 
            this.bDРастенийВMySQLToolStripMenuItem.Name = "bDРастенийВMySQLToolStripMenuItem";
            this.bDРастенийВMySQLToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.bDРастенийВMySQLToolStripMenuItem.Text = "BD растений в MySQL";
            this.bDРастенийВMySQLToolStripMenuItem.Click += new System.EventHandler(this.bDПастенийВMySQLToolStripMenuItem_Click);
            // 
            // заToolStripMenuItem
            // 
            this.заToolStripMenuItem.Name = "заToolStripMenuItem";
            this.заToolStripMenuItem.Size = new System.Drawing.Size(185, 23);
            this.заToolStripMenuItem.Text = "записки и всё про проект";
            // 
            // тестМетодаToolStripMenuItem
            // 
            this.тестМетодаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.записьПротоколаToolStripMenuItem,
            this.датаИзСтрокиToolStripMenuItem,
            this.числоИзСтрокиToolStripMenuItem,
            this.namelatListToolStripMenuItem,
            this.проверкаНаличияПодкаталогаToolStripMenuItem,
            this.заменаПоляTimelastToolStripMenuItem,
            this.запускFormLinksToolStripMenuItem});
            this.тестМетодаToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.тестМетодаToolStripMenuItem.ForeColor = System.Drawing.Color.SaddleBrown;
            this.тестМетодаToolStripMenuItem.Name = "тестМетодаToolStripMenuItem";
            this.тестМетодаToolStripMenuItem.Size = new System.Drawing.Size(98, 23);
            this.тестМетодаToolStripMenuItem.Text = "тест метода";
            // 
            // записьПротоколаToolStripMenuItem
            // 
            this.записьПротоколаToolStripMenuItem.Name = "записьПротоколаToolStripMenuItem";
            this.записьПротоколаToolStripMenuItem.Size = new System.Drawing.Size(286, 26);
            this.записьПротоколаToolStripMenuItem.Text = "запись в протокол";
            this.записьПротоколаToolStripMenuItem.Click += new System.EventHandler(this.записьПротоколаToolStripMenuItem_Click);
            // 
            // датаИзСтрокиToolStripMenuItem
            // 
            this.датаИзСтрокиToolStripMenuItem.Name = "датаИзСтрокиToolStripMenuItem";
            this.датаИзСтрокиToolStripMenuItem.Size = new System.Drawing.Size(286, 26);
            this.датаИзСтрокиToolStripMenuItem.Text = "дата из строки";
            // 
            // числоИзСтрокиToolStripMenuItem
            // 
            this.числоИзСтрокиToolStripMenuItem.Name = "числоИзСтрокиToolStripMenuItem";
            this.числоИзСтрокиToolStripMenuItem.Size = new System.Drawing.Size(286, 26);
            this.числоИзСтрокиToolStripMenuItem.Text = "число из строки";
            // 
            // namelatListToolStripMenuItem
            // 
            this.namelatListToolStripMenuItem.Name = "namelatListToolStripMenuItem";
            this.namelatListToolStripMenuItem.Size = new System.Drawing.Size(286, 26);
            this.namelatListToolStripMenuItem.Text = "name_lat List";
            this.namelatListToolStripMenuItem.Click += new System.EventHandler(this.namelatListToolStripMenuItem_Click);
            // 
            // проверкаНаличияПодкаталогаToolStripMenuItem
            // 
            this.проверкаНаличияПодкаталогаToolStripMenuItem.Name = "проверкаНаличияПодкаталогаToolStripMenuItem";
            this.проверкаНаличияПодкаталогаToolStripMenuItem.Size = new System.Drawing.Size(286, 26);
            this.проверкаНаличияПодкаталогаToolStripMenuItem.Text = "проверка наличия подкаталога";
            this.проверкаНаличияПодкаталогаToolStripMenuItem.Click += new System.EventHandler(this.проверкаНаличияПодкаталогаToolStripMenuItem_Click);
            // 

            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(662, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 48;
            this.dataGridView1.Size = new System.Drawing.Size(1121, 805);
            this.dataGridView1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(516, 818);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 

            // Menu_14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1819, 990);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.ForeColor = System.Drawing.Color.Olive;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Menu_14";
            this.Text = "Победа над разумом!";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem оснвныеДанныеИзBDMySQLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ljfdbnmHfcnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очисткаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem папкиСФотографиямиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem протоколИзMySQLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bDРастенийВMySQLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem тестМетодаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem записьПротоколаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem датаИзСтрокиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem числоИзСтрокиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem namelatListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проверкаНаличияПодкаталогаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заменаПоляTimelastToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem вывестиИзMySQLВТаблицуToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem запускFormLinksToolStripMenuItem;
    }
}

