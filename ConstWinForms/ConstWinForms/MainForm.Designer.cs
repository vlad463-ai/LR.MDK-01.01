namespace ConstWinForms
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NumberLabel = new System.Windows.Forms.Label();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.ImageBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(460, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "st1Lable";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(683, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "st2Lable";
            // 
            // NameBox
            // 
            this.NameBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.NameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameBox.FormattingEnabled = true;
            this.NameBox.ItemHeight = 24;
            this.NameBox.Location = new System.Drawing.Point(0, 0);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(120, 411);
            this.NameBox.TabIndex = 2;
            this.NameBox.SelectedIndexChanged += new System.EventHandler(this.NameBox_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.NumberLabel);
            this.panel1.Controls.Add(this.ScoreLabel);
            this.panel1.Controls.Add(this.AgeLabel);
            this.panel1.Controls.Add(this.ImageBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(120, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(698, 411);
            this.panel1.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(6, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Номер билета: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(19, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ср. балл:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(20, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Возраст:";
            // 
            // NumberLabel
            // 
            this.NumberLabel.AutoSize = true;
            this.NumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberLabel.Location = new System.Drawing.Point(174, 267);
            this.NumberLabel.Name = "NumberLabel";
            this.NumberLabel.Size = new System.Drawing.Size(60, 24);
            this.NumberLabel.TabIndex = 3;
            this.NumberLabel.Text = "label5";
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ScoreLabel.Location = new System.Drawing.Point(174, 171);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(60, 24);
            this.ScoreLabel.TabIndex = 2;
            this.ScoreLabel.Text = "label4";
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AgeLabel.Location = new System.Drawing.Point(174, 85);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(60, 24);
            this.AgeLabel.TabIndex = 1;
            this.AgeLabel.Text = "label3";
            // 
            // ImageBox1
            // 
            this.ImageBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.ImageBox1.Location = new System.Drawing.Point(256, 0);
            this.ImageBox1.Name = "ImageBox1";
            this.ImageBox1.Size = new System.Drawing.Size(442, 411);
            this.ImageBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageBox1.TabIndex = 0;
            this.ImageBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 411);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox NameBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label NumberLabel;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.PictureBox ImageBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

