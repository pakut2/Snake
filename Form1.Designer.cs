namespace snake
{
    partial class FormSnake
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameSpeedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.slowerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ultraFastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ultraFastHardMasterExtraPremiumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveASDWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shortcutsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startCtlSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseResumeCtlSpaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartCtlRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inOrderToCheckHighScoresSeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelBackground = new System.Windows.Forms.Panel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.labelScore = new System.Windows.Forms.Label();
            this.labelHighScore = new System.Windows.Forms.Label();
            this.labelHighScorePoints = new System.Windows.Forms.Label();
            this.labelScorePoints = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.pauseToolStripMenuItem,
            this.restartToolStripMenuItem,
            this.gameSpeedToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(28, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip.Size = new System.Drawing.Size(467, 31);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.startToolStripMenuItem.Size = new System.Drawing.Size(68, 27);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // pauseToolStripMenuItem
            // 
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            this.pauseToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Space)));
            this.pauseToolStripMenuItem.Size = new System.Drawing.Size(83, 27);
            this.pauseToolStripMenuItem.Text = "Pause";
            this.pauseToolStripMenuItem.Click += new System.EventHandler(this.pauseToolStripMenuItem_Click);
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(91, 27);
            this.restartToolStripMenuItem.Text = "Restart";
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.restartToolStripMenuItem_Click);
            // 
            // gameSpeedToolStripMenuItem
            // 
            this.gameSpeedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slowerToolStripMenuItem,
            this.fasterToolStripMenuItem,
            this.ultraFastToolStripMenuItem,
            this.ultraFastHardMasterExtraPremiumToolStripMenuItem});
            this.gameSpeedToolStripMenuItem.Name = "gameSpeedToolStripMenuItem";
            this.gameSpeedToolStripMenuItem.Size = new System.Drawing.Size(157, 27);
            this.gameSpeedToolStripMenuItem.Text = "Game Speed";
            // 
            // slowerToolStripMenuItem
            // 
            this.slowerToolStripMenuItem.Name = "slowerToolStripMenuItem";
            this.slowerToolStripMenuItem.Size = new System.Drawing.Size(514, 28);
            this.slowerToolStripMenuItem.Text = "Slow";
            this.slowerToolStripMenuItem.Click += new System.EventHandler(this.slowerToolStripMenuItem_Click);
            // 
            // fasterToolStripMenuItem
            // 
            this.fasterToolStripMenuItem.Name = "fasterToolStripMenuItem";
            this.fasterToolStripMenuItem.Size = new System.Drawing.Size(514, 28);
            this.fasterToolStripMenuItem.Text = "Fast";
            this.fasterToolStripMenuItem.Click += new System.EventHandler(this.fasterToolStripMenuItem_Click);
            // 
            // ultraFastToolStripMenuItem
            // 
            this.ultraFastToolStripMenuItem.Name = "ultraFastToolStripMenuItem";
            this.ultraFastToolStripMenuItem.Size = new System.Drawing.Size(514, 28);
            this.ultraFastToolStripMenuItem.Text = "Ultra Fast";
            this.ultraFastToolStripMenuItem.Click += new System.EventHandler(this.ultraFastToolStripMenuItem_Click);
            // 
            // ultraFastHardMasterExtraPremiumToolStripMenuItem
            // 
            this.ultraFastHardMasterExtraPremiumToolStripMenuItem.Name = "ultraFastHardMasterExtraPremiumToolStripMenuItem";
            this.ultraFastHardMasterExtraPremiumToolStripMenuItem.Size = new System.Drawing.Size(514, 28);
            this.ultraFastHardMasterExtraPremiumToolStripMenuItem.Text = "Ultra Super Fast Hard Master Extra Premium";
            this.ultraFastHardMasterExtraPremiumToolStripMenuItem.Click += new System.EventHandler(this.ultraFastHardMasterExtraPremiumToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.controlsToolStripMenuItem,
            this.shortcutsToolStripMenuItem,
            this.scoresToolStripMenuItem});
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(60, 27);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // controlsToolStripMenuItem
            // 
            this.controlsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moveASDWToolStripMenuItem});
            this.controlsToolStripMenuItem.Name = "controlsToolStripMenuItem";
            this.controlsToolStripMenuItem.Size = new System.Drawing.Size(182, 28);
            this.controlsToolStripMenuItem.Text = "Controls";
            // 
            // moveASDWToolStripMenuItem
            // 
            this.moveASDWToolStripMenuItem.Name = "moveASDWToolStripMenuItem";
            this.moveASDWToolStripMenuItem.Size = new System.Drawing.Size(347, 28);
            this.moveASDWToolStripMenuItem.Text = "Move: ASDW / Arrow Keys";
            // 
            // shortcutsToolStripMenuItem
            // 
            this.shortcutsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startCtlSToolStripMenuItem,
            this.pauseResumeCtlSpaceToolStripMenuItem,
            this.restartCtlRToolStripMenuItem});
            this.shortcutsToolStripMenuItem.Name = "shortcutsToolStripMenuItem";
            this.shortcutsToolStripMenuItem.Size = new System.Drawing.Size(182, 28);
            this.shortcutsToolStripMenuItem.Text = "Shortcuts";
            // 
            // startCtlSToolStripMenuItem
            // 
            this.startCtlSToolStripMenuItem.Name = "startCtlSToolStripMenuItem";
            this.startCtlSToolStripMenuItem.Size = new System.Drawing.Size(383, 28);
            this.startCtlSToolStripMenuItem.Text = "Start: Ctrl + S";
            // 
            // pauseResumeCtlSpaceToolStripMenuItem
            // 
            this.pauseResumeCtlSpaceToolStripMenuItem.Name = "pauseResumeCtlSpaceToolStripMenuItem";
            this.pauseResumeCtlSpaceToolStripMenuItem.Size = new System.Drawing.Size(383, 28);
            this.pauseResumeCtlSpaceToolStripMenuItem.Text = "Pause / Resume: Ctrl + Space";
            // 
            // restartCtlRToolStripMenuItem
            // 
            this.restartCtlRToolStripMenuItem.Name = "restartCtlRToolStripMenuItem";
            this.restartCtlRToolStripMenuItem.Size = new System.Drawing.Size(383, 28);
            this.restartCtlRToolStripMenuItem.Text = "Restart: Ctrl + R";
            // 
            // scoresToolStripMenuItem
            // 
            this.scoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inOrderToCheckHighScoresSeeToolStripMenuItem});
            this.scoresToolStripMenuItem.Name = "scoresToolStripMenuItem";
            this.scoresToolStripMenuItem.Size = new System.Drawing.Size(182, 28);
            this.scoresToolStripMenuItem.Text = "Scores";
            // 
            // inOrderToCheckHighScoresSeeToolStripMenuItem
            // 
            this.inOrderToCheckHighScoresSeeToolStripMenuItem.Name = "inOrderToCheckHighScoresSeeToolStripMenuItem";
            this.inOrderToCheckHighScoresSeeToolStripMenuItem.Size = new System.Drawing.Size(571, 28);
            this.inOrderToCheckHighScoresSeeToolStripMenuItem.Text = "In order to check scores see Scores/highScore.txt";
            // 
            // panelBackground
            // 
            this.panelBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(176)))), ((int)(((byte)(97)))));
            this.panelBackground.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.panelBackground.Location = new System.Drawing.Point(60, 90);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Size = new System.Drawing.Size(400, 400);
            this.panelBackground.TabIndex = 1;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelScore.Location = new System.Drawing.Point(162, 498);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(143, 46);
            this.labelScore.TabIndex = 2;
            this.labelScore.Text = "Score:";
            // 
            // labelHighScore
            // 
            this.labelHighScore.AutoSize = true;
            this.labelHighScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelHighScore.Location = new System.Drawing.Point(117, 41);
            this.labelHighScore.Name = "labelHighScore";
            this.labelHighScore.Size = new System.Drawing.Size(241, 46);
            this.labelHighScore.TabIndex = 3;
            this.labelHighScore.Text = "High Score:";
            // 
            // labelHighScorePoints
            // 
            this.labelHighScorePoints.AutoSize = true;
            this.labelHighScorePoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelHighScorePoints.Location = new System.Drawing.Point(353, 41);
            this.labelHighScorePoints.Name = "labelHighScorePoints";
            this.labelHighScorePoints.Size = new System.Drawing.Size(43, 46);
            this.labelHighScorePoints.TabIndex = 5;
            this.labelHighScorePoints.Text = "0";
            // 
            // labelScorePoints
            // 
            this.labelScorePoints.AutoSize = true;
            this.labelScorePoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelScorePoints.Location = new System.Drawing.Point(305, 498);
            this.labelScorePoints.Name = "labelScorePoints";
            this.labelScorePoints.Size = new System.Drawing.Size(43, 46);
            this.labelScorePoints.TabIndex = 6;
            this.labelScorePoints.Text = "0";
            // 
            // FormSnake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(532, 553);
            this.Controls.Add(this.labelScorePoints);
            this.Controls.Add(this.labelHighScorePoints);
            this.Controls.Add(this.labelHighScore);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.panelBackground);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(203)))), ((int)(((byte)(38)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSnake";
            this.Text = "Snake";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormSnake_KeyDown);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameSpeedToolStripMenuItem;
        private System.Windows.Forms.Panel panelBackground;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolStripMenuItem slowerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ultraFastToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ultraFastHardMasterExtraPremiumToolStripMenuItem;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelHighScore;
        private System.Windows.Forms.Label labelHighScorePoints;
        private System.Windows.Forms.Label labelScorePoints;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shortcutsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startCtlSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseResumeCtlSpaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartCtlRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveASDWToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inOrderToCheckHighScoresSeeToolStripMenuItem;
    }
}

