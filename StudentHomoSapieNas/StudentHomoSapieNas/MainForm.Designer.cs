namespace StudentHomoSapieNas
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.StudentInfoRichTextBox = new System.Windows.Forms.RichTextBox();
            this.HomoSappiensInfoRichTextBox = new System.Windows.Forms.RichTextBox();
            this.StudentLabel = new System.Windows.Forms.Label();
            this.HomaSappiensLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StudentInfoRichTextBox
            // 
            this.StudentInfoRichTextBox.Location = new System.Drawing.Point(53, 63);
            this.StudentInfoRichTextBox.Name = "StudentInfoRichTextBox";
            this.StudentInfoRichTextBox.Size = new System.Drawing.Size(197, 149);
            this.StudentInfoRichTextBox.TabIndex = 0;
            this.StudentInfoRichTextBox.Text = "";
            // 
            // HomoSappiensInfoRichTextBox
            // 
            this.HomoSappiensInfoRichTextBox.Location = new System.Drawing.Point(333, 63);
            this.HomoSappiensInfoRichTextBox.Name = "HomoSappiensInfoRichTextBox";
            this.HomoSappiensInfoRichTextBox.Size = new System.Drawing.Size(204, 149);
            this.HomoSappiensInfoRichTextBox.TabIndex = 1;
            this.HomoSappiensInfoRichTextBox.Text = "";
            // 
            // StudentLabel
            // 
            this.StudentLabel.AutoSize = true;
            this.StudentLabel.Location = new System.Drawing.Point(67, 35);
            this.StudentLabel.Name = "StudentLabel";
            this.StudentLabel.Size = new System.Drawing.Size(124, 13);
            this.StudentLabel.TabIndex = 2;
            this.StudentLabel.Text = "Информация о студент";
            // 
            // HomaSappiensLabel
            // 
            this.HomaSappiensLabel.AutoSize = true;
            this.HomaSappiensLabel.Location = new System.Drawing.Point(351, 35);
            this.HomaSappiensLabel.Name = "HomaSappiensLabel";
            this.HomaSappiensLabel.Size = new System.Drawing.Size(186, 13);
            this.HomaSappiensLabel.TabIndex = 3;
            this.HomaSappiensLabel.Text = "Информация о человеке разумном";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 252);
            this.Controls.Add(this.HomaSappiensLabel);
            this.Controls.Add(this.StudentLabel);
            this.Controls.Add(this.HomoSappiensInfoRichTextBox);
            this.Controls.Add(this.StudentInfoRichTextBox);
            this.Name = "MainForm";
            this.Text = "Наследование";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox StudentInfoRichTextBox;
        private System.Windows.Forms.RichTextBox HomoSappiensInfoRichTextBox;
        private System.Windows.Forms.Label StudentLabel;
        private System.Windows.Forms.Label HomaSappiensLabel;
    }
}

