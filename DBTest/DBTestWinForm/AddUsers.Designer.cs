namespace DBTestWinForm
{
    partial class AddUsers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
            this.login = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.adduserss = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.age = new System.Windows.Forms.NumericUpDown();
            this.Oke = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.age)).BeginInit();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login.Location = new System.Drawing.Point(101, 15);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(221, 22);
            this.login.TabIndex = 0;
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password.Location = new System.Drawing.Point(101, 64);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(221, 22);
            this.password.TabIndex = 1;
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.Location = new System.Drawing.Point(101, 110);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(221, 22);
            this.name.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(14, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(14, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(14, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Имя";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(14, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Возраст";
            // 
            // adduserss
            // 
            this.adduserss.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adduserss.Location = new System.Drawing.Point(53, 195);
            this.adduserss.Name = "adduserss";
            this.adduserss.Size = new System.Drawing.Size(80, 26);
            this.adduserss.TabIndex = 8;
            this.adduserss.Text = "ОК";
            this.adduserss.UseVisualStyleBackColor = true;
            this.adduserss.Click += new System.EventHandler(this.button1_Click);
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clear.Location = new System.Drawing.Point(139, 195);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(84, 26);
            this.Clear.TabIndex = 9;
            this.Clear.Text = "Отмена";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // age
            // 
            this.age.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.age.Location = new System.Drawing.Point(101, 156);
            this.age.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(221, 22);
            this.age.TabIndex = 10;
            this.age.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // Oke
            // 
            this.Oke.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Oke.Location = new System.Drawing.Point(229, 195);
            this.Oke.Name = "Oke";
            this.Oke.Size = new System.Drawing.Size(93, 26);
            this.Oke.TabIndex = 11;
            this.Oke.Text = "Применить";
            this.Oke.UseVisualStyleBackColor = true;
            this.Oke.Click += new System.EventHandler(this.Oke_Click);
            // 
            // AddUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 233);
            this.Controls.Add(this.Oke);
            this.Controls.Add(this.age);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.adduserss);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name);
            this.Controls.Add(this.password);
            this.Controls.Add(this.login);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddUsers";
            this.Text = "Создание пользователя";
            ((System.ComponentModel.ISupportInitialize)(this.age)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button adduserss;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.NumericUpDown age;
        private System.Windows.Forms.Button Oke;
    }
}