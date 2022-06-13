namespace Game
{
    partial class ChooseScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseScreen));
            this.Variant1 = new System.Windows.Forms.Button();
            this.Variant2 = new System.Windows.Forms.Button();
            this.Variant3 = new System.Windows.Forms.Button();
            this.Variant4 = new System.Windows.Forms.Button();
            this.QuestionThatPushesTheQuest = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ToMainMenu = new System.Windows.Forms.Button();
            this.QuestionThatPushesTheQuests = new ZBobb.AlphaBlendTextBox();
            this.SuspendLayout();
            // 
            // Variant1
            // 
            this.Variant1.BackColor = System.Drawing.Color.Transparent;
            this.Variant1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Variant1.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Variant1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Variant1.Location = new System.Drawing.Point(33, 591);
            this.Variant1.Name = "Variant1";
            this.Variant1.Size = new System.Drawing.Size(791, 158);
            this.Variant1.TabIndex = 0;
            this.Variant1.Text = "За гномьим щитом";
            this.Variant1.UseVisualStyleBackColor = false;
            this.Variant1.Click += new System.EventHandler(this.Variant1_Click);
            // 
            // Variant2
            // 
            this.Variant2.BackColor = System.Drawing.Color.Transparent;
            this.Variant2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Variant2.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Variant2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Variant2.Location = new System.Drawing.Point(1082, 591);
            this.Variant2.Name = "Variant2";
            this.Variant2.Size = new System.Drawing.Size(784, 158);
            this.Variant2.TabIndex = 1;
            this.Variant2.Text = "За орочьим топором";
            this.Variant2.UseVisualStyleBackColor = false;
            this.Variant2.Click += new System.EventHandler(this.Variant2_Click);
            // 
            // Variant3
            // 
            this.Variant3.BackColor = System.Drawing.Color.Transparent;
            this.Variant3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Variant3.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Variant3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Variant3.Location = new System.Drawing.Point(33, 787);
            this.Variant3.Name = "Variant3";
            this.Variant3.Size = new System.Drawing.Size(791, 158);
            this.Variant3.TabIndex = 2;
            this.Variant3.Text = "За эльфийским луком";
            this.Variant3.UseVisualStyleBackColor = false;
            this.Variant3.Click += new System.EventHandler(this.Variant3_Click);
            // 
            // Variant4
            // 
            this.Variant4.BackColor = System.Drawing.Color.Transparent;
            this.Variant4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Variant4.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Variant4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Variant4.Location = new System.Drawing.Point(1082, 787);
            this.Variant4.Name = "Variant4";
            this.Variant4.Size = new System.Drawing.Size(784, 158);
            this.Variant4.TabIndex = 3;
            this.Variant4.Text = "За зачарованными перчатками";
            this.Variant4.UseVisualStyleBackColor = false;
            this.Variant4.Click += new System.EventHandler(this.Variant4_Click);
            // 
            // QuestionThatPushesTheQuest
            // 
            this.QuestionThatPushesTheQuest.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.QuestionThatPushesTheQuest.BackColor = System.Drawing.Color.White;
            this.QuestionThatPushesTheQuest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QuestionThatPushesTheQuest.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuestionThatPushesTheQuest.Location = new System.Drawing.Point(915, 733);
            this.QuestionThatPushesTheQuest.Multiline = true;
            this.QuestionThatPushesTheQuest.Name = "QuestionThatPushesTheQuest";
            this.QuestionThatPushesTheQuest.ReadOnly = true;
            this.QuestionThatPushesTheQuest.Size = new System.Drawing.Size(10, 10);
            this.QuestionThatPushesTheQuest.TabIndex = 30;
            this.QuestionThatPushesTheQuest.Text = resources.GetString("QuestionThatPushesTheQuest.Text");
            this.QuestionThatPushesTheQuest.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.QuestionThatPushesTheQuest.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(943, 650);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 37);
            this.label1.TabIndex = 32;
            this.label1.Text = "1";
            this.label1.Visible = false;
            // 
            // ToMainMenu
            // 
            this.ToMainMenu.BackColor = System.Drawing.Color.Transparent;
            this.ToMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ToMainMenu.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToMainMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ToMainMenu.Location = new System.Drawing.Point(864, 936);
            this.ToMainMenu.Name = "ToMainMenu";
            this.ToMainMenu.Size = new System.Drawing.Size(181, 63);
            this.ToMainMenu.TabIndex = 33;
            this.ToMainMenu.Text = "В меню";
            this.ToMainMenu.UseVisualStyleBackColor = false;
            this.ToMainMenu.Click += new System.EventHandler(this.ToMainMenu_Click);
            // 
            // QuestionThatPushesTheQuests
            // 
            this.QuestionThatPushesTheQuests.BackAlpha = 20;
            this.QuestionThatPushesTheQuests.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.QuestionThatPushesTheQuests.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.QuestionThatPushesTheQuests.Enabled = false;
            this.QuestionThatPushesTheQuests.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuestionThatPushesTheQuests.ForeColor = System.Drawing.Color.White;
            this.QuestionThatPushesTheQuests.Location = new System.Drawing.Point(457, 28);
            this.QuestionThatPushesTheQuests.Multiline = true;
            this.QuestionThatPushesTheQuests.Name = "QuestionThatPushesTheQuests";
            this.QuestionThatPushesTheQuests.Size = new System.Drawing.Size(1047, 534);
            this.QuestionThatPushesTheQuests.TabIndex = 35;
            this.QuestionThatPushesTheQuests.Text = resources.GetString("QuestionThatPushesTheQuests.Text");
            this.QuestionThatPushesTheQuests.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ChooseScreen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.QuestionThatPushesTheQuests);
            this.Controls.Add(this.ToMainMenu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Variant4);
            this.Controls.Add(this.Variant3);
            this.Controls.Add(this.Variant2);
            this.Controls.Add(this.Variant1);
            this.Controls.Add(this.QuestionThatPushesTheQuest);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChooseScreen";
            this.Text = "Trauma";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ChooseScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Variant1;
        private System.Windows.Forms.Button Variant2;
        private System.Windows.Forms.Button Variant3;
        private System.Windows.Forms.Button Variant4;
        private System.Windows.Forms.TextBox QuestionThatPushesTheQuest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ToMainMenu;
        private ZBobb.AlphaBlendTextBox QuestionThatPushesTheQuests;
    }
}