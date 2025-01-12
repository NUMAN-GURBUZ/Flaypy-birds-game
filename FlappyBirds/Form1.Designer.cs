namespace FlappyBirds
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ground = new System.Windows.Forms.PictureBox();
            this.FlappyBırds = new System.Windows.Forms.PictureBox();
            this.PipeDown = new System.Windows.Forms.PictureBox();
            this.PipeTop = new System.Windows.Forms.PictureBox();
            this.scoreText = new System.Windows.Forms.Label();
            this.Gametimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlappyBırds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeTop)).BeginInit();
            this.SuspendLayout();
            // 
            // ground
            // 
            this.ground.Image = ((System.Drawing.Image)(resources.GetObject("ground.Image")));
            this.ground.Location = new System.Drawing.Point(-1, 503);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(620, 112);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 1;
            this.ground.TabStop = false;
            // 
            // FlappyBırds
            // 
            this.FlappyBırds.Image = global::FlappyBirds.Properties.Resources.bird_1_;
            this.FlappyBırds.Location = new System.Drawing.Point(75, 240);
            this.FlappyBırds.Name = "FlappyBırds";
            this.FlappyBırds.Size = new System.Drawing.Size(66, 56);
            this.FlappyBırds.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FlappyBırds.TabIndex = 2;
            this.FlappyBırds.TabStop = false;
            // 
            // PipeDown
            // 
            this.PipeDown.Image = ((System.Drawing.Image)(resources.GetObject("PipeDown.Image")));
            this.PipeDown.Location = new System.Drawing.Point(371, 346);
            this.PipeDown.Name = "PipeDown";
            this.PipeDown.Size = new System.Drawing.Size(86, 160);
            this.PipeDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PipeDown.TabIndex = 3;
            this.PipeDown.TabStop = false;
            // 
            // PipeTop
            // 
            this.PipeTop.Image = ((System.Drawing.Image)(resources.GetObject("PipeTop.Image")));
            this.PipeTop.Location = new System.Drawing.Point(477, -2);
            this.PipeTop.Name = "PipeTop";
            this.PipeTop.Size = new System.Drawing.Size(86, 171);
            this.PipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PipeTop.TabIndex = 4;
            this.PipeTop.TabStop = false;
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.Font = new System.Drawing.Font("Palatino Linotype", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.scoreText.Location = new System.Drawing.Point(211, 548);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(156, 51);
            this.scoreText.TabIndex = 5;
            this.scoreText.Text = "Score: 0";
            this.scoreText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Gametimer
            // 
            this.Gametimer.Enabled = true;
            this.Gametimer.Interval = 20;
            this.Gametimer.Tick += new System.EventHandler(this.gameTimer);
            // 
            // Form1
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.Info;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 627);
            this.Controls.Add(this.FlappyBırds);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.PipeTop);
            this.Controls.Add(this.PipeDown);
            this.Controls.Add(this.ground);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gameTop);
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlappyBırds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeTop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox FlappyBırds;
        private System.Windows.Forms.PictureBox PipeDown;
        private System.Windows.Forms.PictureBox PipeTop;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.Timer Gametimer;
    }
}

