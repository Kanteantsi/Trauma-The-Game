namespace Game
{
    partial class StartingScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartingScreen));
            this.label1 = new System.Windows.Forms.Label();
            this.CreatingCharacter = new System.Windows.Forms.Button();
            this.GameClose = new System.Windows.Forms.Button();
            this.ToMainMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(48, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1765, 114);
            this.label1.TabIndex = 0;
            this.label1.Text = "Приветствую тебя, Путник! Садись к нашему костру и послушай истории, а также расс" +
    "кажи свою.\r\n Здесь каждый готов тебя выслушать, и никто не осудит.  Как тебя зов" +
    "ут, и откуда ты родом?";
            // 
            // CreatingCharacter
            // 
            this.CreatingCharacter.BackColor = System.Drawing.Color.Transparent;
            this.CreatingCharacter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CreatingCharacter.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreatingCharacter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CreatingCharacter.Location = new System.Drawing.Point(498, 455);
            this.CreatingCharacter.Name = "CreatingCharacter";
            this.CreatingCharacter.Size = new System.Drawing.Size(772, 65);
            this.CreatingCharacter.TabIndex = 1;
            this.CreatingCharacter.Text = "Создание персонажа";
            this.CreatingCharacter.UseVisualStyleBackColor = false;
            this.CreatingCharacter.Click += new System.EventHandler(this.CreatingCharacter_Click);
            // 
            // GameClose
            // 
            this.GameClose.BackColor = System.Drawing.Color.Transparent;
            this.GameClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GameClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GameClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GameClose.Location = new System.Drawing.Point(1500, 938);
            this.GameClose.Name = "GameClose";
            this.GameClose.Size = new System.Drawing.Size(348, 48);
            this.GameClose.TabIndex = 2;
            this.GameClose.Text = "Сдаться";
            this.GameClose.UseVisualStyleBackColor = false;
            this.GameClose.Click += new System.EventHandler(this.GameClose_Click);
            // 
            // ToMainMenu
            // 
            this.ToMainMenu.BackColor = System.Drawing.Color.Transparent;
            this.ToMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ToMainMenu.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToMainMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ToMainMenu.Location = new System.Drawing.Point(673, 784);
            this.ToMainMenu.Name = "ToMainMenu";
            this.ToMainMenu.Size = new System.Drawing.Size(440, 93);
            this.ToMainMenu.TabIndex = 29;
            this.ToMainMenu.Text = "В главное меню";
            this.ToMainMenu.UseVisualStyleBackColor = false;
            this.ToMainMenu.Click += new System.EventHandler(this.ToMainMenu_Click);
            // 
            // StartingScreen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.ToMainMenu);
            this.Controls.Add(this.GameClose);
            this.Controls.Add(this.CreatingCharacter);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StartingScreen";
            this.Text = "Начало приключения";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.StartingScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CreatingCharacter;
        private System.Windows.Forms.Button GameClose;
        private System.Windows.Forms.Button ToMainMenu;
    }
}