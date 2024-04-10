namespace PAtric
{
    partial class Main_menu
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
            this.panelMenuButton = new System.Windows.Forms.Panel();
            this.panelDesctop = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenuButton
            // 
            this.panelMenuButton.Location = new System.Drawing.Point(3, 3);
            this.panelMenuButton.MaximumSize = new System.Drawing.Size(185, 800);
            this.panelMenuButton.MinimumSize = new System.Drawing.Size(185, 800);
            this.panelMenuButton.Name = "panelMenuButton";
            this.panelMenuButton.Size = new System.Drawing.Size(185, 800);
            this.panelMenuButton.TabIndex = 1;
            // 
            // panelDesctop
            // 
            this.panelDesctop.Location = new System.Drawing.Point(194, 3);
            this.panelDesctop.MaximumSize = new System.Drawing.Size(1800, 868);
            this.panelDesctop.MinimumSize = new System.Drawing.Size(837, 800);
            this.panelDesctop.Name = "panelDesctop";
            this.panelDesctop.Size = new System.Drawing.Size(1587, 800);
            this.panelDesctop.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panelMenuButton);
            this.flowLayoutPanel1.Controls.Add(this.panelDesctop);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1784, 829);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // Main_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1784, 829);
            this.Controls.Add(this.flowLayoutPanel1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(1800, 868);
            this.Name = "Main_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Система управления парикмахерской";
            this.Load += new System.EventHandler(this.Main_menu_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panelMenuButton;
        public System.Windows.Forms.Panel panelDesctop;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

