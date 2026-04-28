using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu_14
{
    public partial class FormQuestionnaire : Form
    {
        public string QuestionnaireText { get; private set; }
        public bool IsSaved { get; private set; }

        public FormQuestionnaire()
        {
            InitializeComponent();
            IsSaved = false;
        }

        private void InitializeComponent()
        {
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.richTextBoxQuestion = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();

            // richTextBoxQuestion
            this.richTextBoxQuestion.Location = new System.Drawing.Point(12, 12);
            this.richTextBoxQuestion.Size = new System.Drawing.Size(223, 130);
            this.richTextBoxQuestion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;

            // btnSave
            this.btnSave.Text = "Сохранить";
            this.btnSave.Location = new System.Drawing.Point(60, 148);
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.Click += new EventHandler(this.btnSave_Click);

            // btnCancel
            this.btnCancel.Text = "Отказ";
            this.btnCancel.Location = new System.Drawing.Point(141, 148);
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.Click += new EventHandler(this.btnCancel_Click);

            // FormQuestionnaire
            this.ClientSize = new System.Drawing.Size(251, 200);
            this.Controls.Add(this.richTextBoxQuestion);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Введите данные";
            this.ResumeLayout(false);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            QuestionnaireText = richTextBoxQuestion.Text;
            IsSaved = true;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            IsSaved = false;
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.RichTextBox richTextBoxQuestion;
    }
}
