namespace Game
{
    partial class SavesScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SavesScreen));
            this.Slot1 = new System.Windows.Forms.Button();
            this.Slot2 = new System.Windows.Forms.Button();
            this.Slot3 = new System.Windows.Forms.Button();
            this.ToMainMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Slot1
            // 
            this.Slot1.BackColor = System.Drawing.Color.Transparent;
            this.Slot1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Slot1.BackgroundImage")));
            this.Slot1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Slot1.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Slot1.Image = ((System.Drawing.Image)(resources.GetObject("Slot1.Image")));
            this.Slot1.Location = new System.Drawing.Point(592, 883);
            this.Slot1.Name = "Slot1";
            this.Slot1.Size = new System.Drawing.Size(392, 56);
            this.Slot1.TabIndex = 0;
            this.Slot1.Text = "Slot1";
            this.Slot1.UseVisualStyleBackColor = false;
            this.Slot1.Click += new System.EventHandler(this.Slot1_Click);
            // 
            // Slot2
            // 
            this.Slot2.BackColor = System.Drawing.Color.Transparent;
            this.Slot2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Slot2.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Slot2.Location = new System.Drawing.Point(732, 497);
            this.Slot2.Name = "Slot2";
            this.Slot2.Size = new System.Drawing.Size(392, 61);
            this.Slot2.TabIndex = 1;
            this.Slot2.Text = "Slot2";
            this.Slot2.UseVisualStyleBackColor = false;
            this.Slot2.Visible = false;
            this.Slot2.Click += new System.EventHandler(this.Slot2_Click);
            // 
            // Slot3
            // 
            this.Slot3.BackColor = System.Drawing.Color.Transparent;
            this.Slot3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Slot3.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Slot3.Location = new System.Drawing.Point(732, 638);
            this.Slot3.Name = "Slot3";
            this.Slot3.Size = new System.Drawing.Size(392, 61);
            this.Slot3.TabIndex = 2;
            this.Slot3.Text = "Slot3";
            this.Slot3.UseVisualStyleBackColor = false;
            this.Slot3.Visible = false;
            this.Slot3.Click += new System.EventHandler(this.Slot3_Click);
            // 
            // ToMainMenu
            // 
            this.ToMainMenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ToMainMenu.BackColor = System.Drawing.Color.Transparent;
            this.ToMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ToMainMenu.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToMainMenu.Location = new System.Drawing.Point(732, 886);
            this.ToMainMenu.Name = "ToMainMenu";
            this.ToMainMenu.Size = new System.Drawing.Size(392, 54);
            this.ToMainMenu.TabIndex = 28;
            this.ToMainMenu.Text = "В главное меню";
            this.ToMainMenu.UseVisualStyleBackColor = false;
            this.ToMainMenu.Click += new System.EventHandler(this.ToMainMenu_Click);
            // 
            // SavesScreen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.ToMainMenu);
            this.Controls.Add(this.Slot3);
            this.Controls.Add(this.Slot2);
            this.Controls.Add(this.Slot1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SavesScreen";
            this.Text = "SavesScreen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SavesScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Slot1;
        private System.Windows.Forms.Button Slot2;
        private System.Windows.Forms.Button Slot3;
        private System.Windows.Forms.Button ToMainMenu;
    }
}