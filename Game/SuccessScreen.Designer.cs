namespace Game
{
    partial class SuccessScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuccessScreen));
            this.ToMainMenu = new System.Windows.Forms.Button();
            this.SuccesssMessage = new ZBobb.AlphaBlendTextBox();
            this.SuspendLayout();
            // 
            // ToMainMenu
            // 
            this.ToMainMenu.BackColor = System.Drawing.Color.Transparent;
            this.ToMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ToMainMenu.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToMainMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ToMainMenu.Location = new System.Drawing.Point(822, 966);
            this.ToMainMenu.Name = "ToMainMenu";
            this.ToMainMenu.Size = new System.Drawing.Size(261, 45);
            this.ToMainMenu.TabIndex = 1;
            this.ToMainMenu.Text = "Конец игры";
            this.ToMainMenu.UseVisualStyleBackColor = false;
            this.ToMainMenu.Click += new System.EventHandler(this.ToMainMenu_Click);
            // 
            // SuccesssMessage
            // 
            this.SuccesssMessage.BackAlpha = 10;
            this.SuccesssMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SuccesssMessage.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SuccesssMessage.Location = new System.Drawing.Point(518, 237);
            this.SuccesssMessage.Multiline = true;
            this.SuccesssMessage.Name = "SuccesssMessage";
            this.SuccesssMessage.Size = new System.Drawing.Size(854, 481);
            this.SuccesssMessage.TabIndex = 2;
            this.SuccesssMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SuccessScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.SuccesssMessage);
            this.Controls.Add(this.ToMainMenu);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SuccessScreen";
            this.Text = "Победа";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SuccessScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ToMainMenu;
        public ZBobb.AlphaBlendTextBox SuccesssMessage;
    }
}