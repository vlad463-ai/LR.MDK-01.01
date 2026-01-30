namespace MovieRental
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
            this.ListBoxGenre = new System.Windows.Forms.ListBox();
            this.comboBoxMovie = new System.Windows.Forms.ComboBox();
            this.pictureBoxFilm = new System.Windows.Forms.PictureBox();
            this.ButtonReport = new System.Windows.Forms.Button();
            this.LabelText = new System.Windows.Forms.Label();
            this.RichTextBoxInfo = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFilm)).BeginInit();
            this.SuspendLayout();
            // 
            // ListBoxGenre
            // 
            this.ListBoxGenre.Dock = System.Windows.Forms.DockStyle.Left;
            this.ListBoxGenre.FormattingEnabled = true;
            this.ListBoxGenre.Location = new System.Drawing.Point(0, 0);
            this.ListBoxGenre.Name = "ListBoxGenre";
            this.ListBoxGenre.Size = new System.Drawing.Size(168, 450);
            this.ListBoxGenre.TabIndex = 0;
            this.ListBoxGenre.SelectedIndexChanged += new System.EventHandler(this.ListBoxGenre_SelectedIndexChanged);
            // 
            // comboBoxMovie
            // 
            this.comboBoxMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxMovie.FormattingEnabled = true;
            this.comboBoxMovie.Location = new System.Drawing.Point(174, 113);
            this.comboBoxMovie.Name = "comboBoxMovie";
            this.comboBoxMovie.Size = new System.Drawing.Size(241, 32);
            this.comboBoxMovie.TabIndex = 1;
          
            // 
            // pictureBoxFilm
            // 
            this.pictureBoxFilm.Location = new System.Drawing.Point(432, 0);
            this.pictureBoxFilm.Name = "pictureBoxFilm";
            this.pictureBoxFilm.Size = new System.Drawing.Size(356, 263);
            this.pictureBoxFilm.TabIndex = 2;
            this.pictureBoxFilm.TabStop = false;
            // 
            // ButtonReport
            // 
            this.ButtonReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonReport.Location = new System.Drawing.Point(224, 322);
            this.ButtonReport.Name = "ButtonReport";
            this.ButtonReport.Size = new System.Drawing.Size(114, 61);
            this.ButtonReport.TabIndex = 3;
            this.ButtonReport.Text = "Отчёт";
            this.ButtonReport.UseVisualStyleBackColor = true;
            this.ButtonReport.Click += new System.EventHandler(this.ButtonReport_Click);
            // 
            // LabelText
            // 
            this.LabelText.AutoSize = true;
            this.LabelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelText.Location = new System.Drawing.Point(197, 45);
            this.LabelText.Name = "LabelText";
            this.LabelText.Size = new System.Drawing.Size(184, 25);
            this.LabelText.TabIndex = 4;
            this.LabelText.Text = "Выберите фильм";
            // 
            // RichTextBoxInfo
            // 
            this.RichTextBoxInfo.Location = new System.Drawing.Point(432, 280);
            this.RichTextBoxInfo.Name = "RichTextBoxInfo";
            this.RichTextBoxInfo.Size = new System.Drawing.Size(356, 158);
            this.RichTextBoxInfo.TabIndex = 5;
            this.RichTextBoxInfo.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RichTextBoxInfo);
            this.Controls.Add(this.LabelText);
            this.Controls.Add(this.ButtonReport);
            this.Controls.Add(this.pictureBoxFilm);
            this.Controls.Add(this.comboBoxMovie);
            this.Controls.Add(this.ListBoxGenre);
            this.Name = "MainForm";
            this.Text = "Показ фильмов в кинотеатре";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFilm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBoxGenre;
        private System.Windows.Forms.ComboBox comboBoxMovie;
        private System.Windows.Forms.PictureBox pictureBoxFilm;
        private System.Windows.Forms.Button ButtonReport;
        private System.Windows.Forms.Label LabelText;
        private System.Windows.Forms.RichTextBox RichTextBoxInfo;
    }
}

