namespace ANimationHArj
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.dragon = new System.Windows.Forms.PictureBox();
            this.tmr = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dragon)).BeginInit();
            this.SuspendLayout();
            // 
            // dragon
            // 
            this.dragon.BackColor = System.Drawing.Color.Transparent;
            this.dragon.Image = ((System.Drawing.Image)(resources.GetObject("dragon.Image")));
            this.dragon.Location = new System.Drawing.Point(12, 142);
            this.dragon.Name = "dragon";
            this.dragon.Size = new System.Drawing.Size(232, 131);
            this.dragon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dragon.TabIndex = 0;
            this.dragon.TabStop = false;
            // 
            // tmr
            // 
            this.tmr.Interval = 10;
            this.tmr.Tick += new System.EventHandler(this.tmr_Tick);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 457);
            this.Controls.Add(this.dragon);
            this.Name = "Game";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Game_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dragon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox dragon;
        private System.Windows.Forms.Timer tmr;
    }
}

