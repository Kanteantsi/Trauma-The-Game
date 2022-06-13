namespace Game
{
    partial class TraumaMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TraumaMainMenu));
            this.StartNewGame = new System.Windows.Forms.Button();
            this.GameClose = new System.Windows.Forms.Button();
            this.LoadOldGame = new System.Windows.Forms.Button();
            this.PlayMusic = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartNewGame
            // 
            this.StartNewGame.BackColor = System.Drawing.Color.Transparent;
            this.StartNewGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.StartNewGame.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartNewGame.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.StartNewGame.Location = new System.Drawing.Point(150, 838);
            this.StartNewGame.Name = "StartNewGame";
            this.StartNewGame.Size = new System.Drawing.Size(421, 99);
            this.StartNewGame.TabIndex = 0;
            this.StartNewGame.Text = "Начать новую игру";
            this.StartNewGame.UseVisualStyleBackColor = false;
            this.StartNewGame.Click += new System.EventHandler(this.StartGame_Click);
            // 
            // GameClose
            // 
            this.GameClose.BackColor = System.Drawing.Color.Transparent;
            this.GameClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GameClose.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GameClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GameClose.Location = new System.Drawing.Point(1359, 840);
            this.GameClose.Name = "GameClose";
            this.GameClose.Size = new System.Drawing.Size(421, 99);
            this.GameClose.TabIndex = 1;
            this.GameClose.Text = "Сдаться";
            this.GameClose.UseVisualStyleBackColor = false;
            this.GameClose.Click += new System.EventHandler(this.CloseGame);
            // 
            // LoadOldGame
            // 
            this.LoadOldGame.BackColor = System.Drawing.Color.Transparent;
            this.LoadOldGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LoadOldGame.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoadOldGame.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LoadOldGame.Location = new System.Drawing.Point(766, 840);
            this.LoadOldGame.Name = "LoadOldGame";
            this.LoadOldGame.Size = new System.Drawing.Size(410, 99);
            this.LoadOldGame.TabIndex = 2;
            this.LoadOldGame.Text = "Загрузить игру";
            this.LoadOldGame.UseVisualStyleBackColor = false;
            this.LoadOldGame.Click += new System.EventHandler(this.LoadOldGame_Click);
            // 
            // PlayMusic
            // 
            this.PlayMusic.BackColor = System.Drawing.Color.Transparent;
            this.PlayMusic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PlayMusic.BackgroundImage")));
            this.PlayMusic.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PlayMusic.ForeColor = System.Drawing.Color.Transparent;
            this.PlayMusic.Location = new System.Drawing.Point(1583, 86);
            this.PlayMusic.Name = "PlayMusic";
            this.PlayMusic.Size = new System.Drawing.Size(100, 102);
            this.PlayMusic.TabIndex = 3;
            this.PlayMusic.UseVisualStyleBackColor = false;
            this.PlayMusic.Click += new System.EventHandler(this.PlayMusic_Click);
            // 
            // TraumaMainMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.PlayMusic);
            this.Controls.Add(this.LoadOldGame);
            this.Controls.Add(this.GameClose);
            this.Controls.Add(this.StartNewGame);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TraumaMainMenu";
            this.Text = "Trauma";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Trauma_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartNewGame;
        private System.Windows.Forms.Button GameClose;
        private System.Windows.Forms.Button LoadOldGame;
        private System.Windows.Forms.Button PlayMusic;
    }
}

