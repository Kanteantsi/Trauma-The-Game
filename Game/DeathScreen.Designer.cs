namespace Game
{
    public partial class DeathScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeathScreen));
            this.ToMainMenu = new System.Windows.Forms.Button();
            this.DeathhText = new ZBobb.AlphaBlendTextBox();
            this.SuspendLayout();
            // 
            // ToMainMenu
            // 
            this.ToMainMenu.BackColor = System.Drawing.Color.Transparent;
            this.ToMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ToMainMenu.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToMainMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ToMainMenu.Location = new System.Drawing.Point(774, 819);
            this.ToMainMenu.Name = "ToMainMenu";
            this.ToMainMenu.Size = new System.Drawing.Size(353, 59);
            this.ToMainMenu.TabIndex = 1;
            this.ToMainMenu.Text = "Конец игры";
            this.ToMainMenu.UseVisualStyleBackColor = false;
            this.ToMainMenu.Click += new System.EventHandler(this.ToMainMenu_Click);
            // 
            // DeathhText
            // 
            this.DeathhText.BackAlpha = 1;
            this.DeathhText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DeathhText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DeathhText.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeathhText.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DeathhText.Location = new System.Drawing.Point(536, 395);
            this.DeathhText.Multiline = true;
            this.DeathhText.Name = "DeathhText";
            this.DeathhText.Size = new System.Drawing.Size(806, 385);
            this.DeathhText.TabIndex = 2;
            this.DeathhText.Text = "Вы погибли в неравной битве. Никто никогда не вспомнит о вас, и ваши тела так и н" +
    "е будут найдены, разодранные дикими зверями.";
            this.DeathhText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DeathScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.DeathhText);
            this.Controls.Add(this.ToMainMenu);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeathScreen";
            this.Text = "Конец игры";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ToMainMenu;
        public ZBobb.AlphaBlendTextBox DeathhText;
    }
}