using LiveCharts.Views;

namespace LiveCharts
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
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.SectionListBox = new System.Windows.Forms.ListBox();
            this.RightPanel = new System.Windows.Forms.Panel();
            this.pie = new LiveCharts.Views.VisitsPieChart();
            this.CenterPanel = new System.Windows.Forms.Panel();
            this.cartesian = new LiveCharts.Views.VisitsCartesianCharts();
            this.LeftPanel.SuspendLayout();
            this.RightPanel.SuspendLayout();
            this.CenterPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.Controls.Add(this.SectionListBox);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(114, 450);
            this.LeftPanel.TabIndex = 0;
            // 
            // SectionListBox
            // 
            this.SectionListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SectionListBox.FormattingEnabled = true;
            this.SectionListBox.Location = new System.Drawing.Point(0, 0);
            this.SectionListBox.Name = "SectionListBox";
            this.SectionListBox.Size = new System.Drawing.Size(114, 450);
            this.SectionListBox.TabIndex = 0;
            this.SectionListBox.SelectedIndexChanged += new System.EventHandler(this.SectionListBox_SelectedIndexChanged);
            // 
            // RightPanel
            // 
            this.RightPanel.Controls.Add(this.pie);
            this.RightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightPanel.Location = new System.Drawing.Point(484, 0);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(316, 450);
            this.RightPanel.TabIndex = 1;
            // 
            // pie
            // 
            this.pie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pie.Location = new System.Drawing.Point(0, 0);
            this.pie.Name = "pie";
            this.pie.Size = new System.Drawing.Size(316, 450);
            this.pie.TabIndex = 0;
            this.pie.Text = "pieChart1";
            // 
            // CenterPanel
            // 
            this.CenterPanel.Controls.Add(this.cartesian);
            this.CenterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CenterPanel.Location = new System.Drawing.Point(114, 0);
            this.CenterPanel.Name = "CenterPanel";
            this.CenterPanel.Size = new System.Drawing.Size(370, 450);
            this.CenterPanel.TabIndex = 2;
            // 
            // cartesian
            // 
            this.cartesian.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cartesian.Location = new System.Drawing.Point(0, 0);
            this.cartesian.Name = "cartesian";
            this.cartesian.Size = new System.Drawing.Size(370, 450);
            this.cartesian.TabIndex = 0;
            this.cartesian.Text = "cartesianChart1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CenterPanel);
            this.Controls.Add(this.RightPanel);
            this.Controls.Add(this.LeftPanel);
            this.Name = "MainForm";
            this.Text = "Оказание услуг в салоне красоты";
            this.LeftPanel.ResumeLayout(false);
            this.RightPanel.ResumeLayout(false);
            this.CenterPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.ListBox SectionListBox;
        private System.Windows.Forms.Panel RightPanel;
        private VisitsPieChart pie;
        private System.Windows.Forms.Panel CenterPanel;
        private VisitsCartesianCharts cartesian;
    }
}

