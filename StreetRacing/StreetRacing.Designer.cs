
namespace StreetRacing
{
    partial class StreetRacing
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StreetRacing));
            this.roadtrack = new System.Windows.Forms.Panel();
            this.Tree2 = new System.Windows.Forms.PictureBox();
            this.Tree1 = new System.Windows.Forms.PictureBox();
            this.award = new System.Windows.Forms.PictureBox();
            this.Explosion = new System.Windows.Forms.PictureBox();
            this.Player = new System.Windows.Forms.PictureBox();
            this.Car2 = new System.Windows.Forms.PictureBox();
            this.Car1 = new System.Windows.Forms.PictureBox();
            this.PbRoad = new System.Windows.Forms.PictureBox();
            this.PBRoad2 = new System.Windows.Forms.PictureBox();
            this.BtnStart = new System.Windows.Forms.Button();
            this.LblTitel = new System.Windows.Forms.Label();
            this.LblScore = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.roadtrack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tree2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tree1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.award)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Explosion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbRoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBRoad2)).BeginInit();
            this.SuspendLayout();
            // 
            // roadtrack
            // 
            this.roadtrack.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.roadtrack.BackColor = System.Drawing.Color.Black;
            this.roadtrack.Controls.Add(this.Tree2);
            this.roadtrack.Controls.Add(this.Tree1);
            this.roadtrack.Controls.Add(this.award);
            this.roadtrack.Controls.Add(this.Explosion);
            this.roadtrack.Controls.Add(this.Player);
            this.roadtrack.Controls.Add(this.Car2);
            this.roadtrack.Controls.Add(this.Car1);
            this.roadtrack.Controls.Add(this.PbRoad);
            this.roadtrack.Controls.Add(this.PBRoad2);
            this.roadtrack.Location = new System.Drawing.Point(12, 47);
            this.roadtrack.Name = "roadtrack";
            this.roadtrack.Size = new System.Drawing.Size(475, 519);
            this.roadtrack.TabIndex = 0;
            // 
            // Tree2
            // 
            this.Tree2.BackColor = System.Drawing.Color.Transparent;
            this.Tree2.Image = global::StreetRacing.Properties.Resources.Tree1;
            this.Tree2.Location = new System.Drawing.Point(408, 153);
            this.Tree2.Name = "Tree2";
            this.Tree2.Size = new System.Drawing.Size(64, 64);
            this.Tree2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Tree2.TabIndex = 7;
            this.Tree2.TabStop = false;
            // 
            // Tree1
            // 
            this.Tree1.BackColor = System.Drawing.Color.Transparent;
            this.Tree1.Image = global::StreetRacing.Properties.Resources.Tree1;
            this.Tree1.Location = new System.Drawing.Point(3, 3);
            this.Tree1.Name = "Tree1";
            this.Tree1.Size = new System.Drawing.Size(64, 64);
            this.Tree1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Tree1.TabIndex = 6;
            this.Tree1.TabStop = false;
            // 
            // award
            // 
            this.award.Image = global::StreetRacing.Properties.Resources.bronze;
            this.award.Location = new System.Drawing.Point(113, 240);
            this.award.Name = "award";
            this.award.Size = new System.Drawing.Size(250, 100);
            this.award.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.award.TabIndex = 5;
            this.award.TabStop = false;
            // 
            // Explosion
            // 
            this.Explosion.Image = global::StreetRacing.Properties.Resources.explosion;
            this.Explosion.Location = new System.Drawing.Point(88, 355);
            this.Explosion.Name = "Explosion";
            this.Explosion.Size = new System.Drawing.Size(64, 64);
            this.Explosion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Explosion.TabIndex = 4;
            this.Explosion.TabStop = false;
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Black;
            this.Player.Image = ((System.Drawing.Image)(resources.GetObject("Player.Image")));
            this.Player.Location = new System.Drawing.Point(216, 413);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(50, 105);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Player.TabIndex = 3;
            this.Player.TabStop = false;
            // 
            // Car2
            // 
            this.Car2.Image = global::StreetRacing.Properties.Resources.carGrey;
            this.Car2.Location = new System.Drawing.Point(359, 49);
            this.Car2.Name = "Car2";
            this.Car2.Size = new System.Drawing.Size(50, 100);
            this.Car2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Car2.TabIndex = 2;
            this.Car2.TabStop = false;
            this.Car2.Tag = "carRight";
            // 
            // Car1
            // 
            this.Car1.Image = global::StreetRacing.Properties.Resources.carGreen;
            this.Car1.Location = new System.Drawing.Point(80, 116);
            this.Car1.Name = "Car1";
            this.Car1.Size = new System.Drawing.Size(50, 101);
            this.Car1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Car1.TabIndex = 1;
            this.Car1.TabStop = false;
            this.Car1.Tag = "carLeft";
            // 
            // PbRoad
            // 
            this.PbRoad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PbRoad.Image = global::StreetRacing.Properties.Resources.roadTrack;
            this.PbRoad.Location = new System.Drawing.Point(1, -519);
            this.PbRoad.Name = "PbRoad";
            this.PbRoad.Size = new System.Drawing.Size(475, 519);
            this.PbRoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbRoad.TabIndex = 0;
            this.PbRoad.TabStop = false;
            // 
            // PBRoad2
            // 
            this.PBRoad2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PBRoad2.Image = global::StreetRacing.Properties.Resources.roadTrack;
            this.PBRoad2.Location = new System.Drawing.Point(0, 0);
            this.PBRoad2.Name = "PBRoad2";
            this.PBRoad2.Size = new System.Drawing.Size(475, 519);
            this.PBRoad2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBRoad2.TabIndex = 5;
            this.PBRoad2.TabStop = false;
            // 
            // BtnStart
            // 
            this.BtnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStart.Location = new System.Drawing.Point(13, 615);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(474, 35);
            this.BtnStart.TabIndex = 1;
            this.BtnStart.Text = "START";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.RestartGame);
            // 
            // LblTitel
            // 
            this.LblTitel.AutoSize = true;
            this.LblTitel.Font = new System.Drawing.Font("Blazed", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitel.ForeColor = System.Drawing.Color.Red;
            this.LblTitel.Location = new System.Drawing.Point(75, 3);
            this.LblTitel.Name = "LblTitel";
            this.LblTitel.Size = new System.Drawing.Size(368, 41);
            this.LblTitel.TabIndex = 2;
            this.LblTitel.Text = "Street Racing";
            // 
            // LblScore
            // 
            this.LblScore.AutoSize = true;
            this.LblScore.Font = new System.Drawing.Font("Blazed", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblScore.ForeColor = System.Drawing.Color.DarkRed;
            this.LblScore.Location = new System.Drawing.Point(9, 567);
            this.LblScore.Name = "LblScore";
            this.LblScore.Size = new System.Drawing.Size(188, 35);
            this.LblScore.TabIndex = 3;
            this.LblScore.Text = "Score: 0";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 674);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(480, 98);
            this.label2.TabIndex = 4;
            this.label2.Text = "Drücke die Pfeiltasten Links und Rechts um das Fahrzeug zu bewegen. Und berühre k" +
    "eine anderen Fahrzeuge. Halte durch solange du kannst !";
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 10;
            this.gameTimer.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Blazed", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 577);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 35);
            this.label1.TabIndex = 3;
            this.label1.Text = "Score: 0";
            // 
            // StreetRacing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(499, 781);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblScore);
            this.Controls.Add(this.LblTitel);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.roadtrack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "StreetRacing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Street Racing V.1 | by Runenmeister (c) 12/2023";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            this.roadtrack.ResumeLayout(false);
            this.roadtrack.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tree2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tree1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.award)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Explosion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbRoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBRoad2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel roadtrack;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Label LblTitel;
        private System.Windows.Forms.Label LblScore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox PbRoad;
        private System.Windows.Forms.PictureBox award;
        private System.Windows.Forms.PictureBox Explosion;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.PictureBox Car2;
        private System.Windows.Forms.PictureBox Car1;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox PBRoad2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Tree1;
        private System.Windows.Forms.PictureBox Tree2;
    }
}

