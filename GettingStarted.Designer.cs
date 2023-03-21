
namespace LickBuilder
{
    partial class GettingStarted
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GettingStarted));
            this.LblSelection = new System.Windows.Forms.Label();
            this.cmDifficulties = new System.Windows.Forms.ComboBox();
            this.LblPictures = new System.Windows.Forms.Label();
            this.lblEasy = new System.Windows.Forms.Label();
            this.LblMedium = new System.Windows.Forms.Label();
            this.LblAdvanced = new System.Windows.Forms.Label();
            this.LblExpert = new System.Windows.Forms.Label();
            this.picMedium = new System.Windows.Forms.PictureBox();
            this.picExpert = new System.Windows.Forms.PictureBox();
            this.picEasy = new System.Windows.Forms.PictureBox();
            this.picAdvanced = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picMedium)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExpert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEasy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAdvanced)).BeginInit();
            this.SuspendLayout();
            // 
            // LblSelection
            // 
            this.LblSelection.AutoSize = true;
            this.LblSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSelection.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblSelection.Location = new System.Drawing.Point(75, 75);
            this.LblSelection.Name = "LblSelection";
            this.LblSelection.Size = new System.Drawing.Size(359, 42);
            this.LblSelection.TabIndex = 0;
            this.LblSelection.Text = "Select your difficulty:";
            // 
            // cmDifficulties
            // 
            this.cmDifficulties.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmDifficulties.DropDownWidth = 300;
            this.cmDifficulties.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmDifficulties.FormattingEnabled = true;
            this.cmDifficulties.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Advanced",
            "Expert"});
            this.cmDifficulties.Location = new System.Drawing.Point(469, 84);
            this.cmDifficulties.Name = "cmDifficulties";
            this.cmDifficulties.Size = new System.Drawing.Size(350, 50);
            this.cmDifficulties.TabIndex = 1;
            this.cmDifficulties.SelectedIndexChanged += new System.EventHandler(this.cmDifficulties_SelectedIndexChanged);
            // 
            // LblPictures
            // 
            this.LblPictures.AutoSize = true;
            this.LblPictures.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblPictures.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPictures.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblPictures.Location = new System.Drawing.Point(1143, 75);
            this.LblPictures.Name = "LblPictures";
            this.LblPictures.Size = new System.Drawing.Size(889, 37);
            this.LblPictures.TabIndex = 2;
            this.LblPictures.Text = "Click the pictures to see possible rudiments for each difficulty!";
            // 
            // lblEasy
            // 
            this.lblEasy.AutoSize = true;
            this.lblEasy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEasy.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEasy.Location = new System.Drawing.Point(406, 603);
            this.lblEasy.Name = "lblEasy";
            this.lblEasy.Size = new System.Drawing.Size(214, 37);
            this.lblEasy.TabIndex = 10;
            this.lblEasy.Text = "Level 1 - Easy";
            // 
            // LblMedium
            // 
            this.LblMedium.AutoSize = true;
            this.LblMedium.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMedium.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblMedium.Location = new System.Drawing.Point(1897, 603);
            this.LblMedium.Name = "LblMedium";
            this.LblMedium.Size = new System.Drawing.Size(259, 37);
            this.LblMedium.TabIndex = 11;
            this.LblMedium.Text = "Level 2 - Medium";
            // 
            // LblAdvanced
            // 
            this.LblAdvanced.AutoSize = true;
            this.LblAdvanced.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAdvanced.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblAdvanced.Location = new System.Drawing.Point(857, 1096);
            this.LblAdvanced.Name = "LblAdvanced";
            this.LblAdvanced.Size = new System.Drawing.Size(288, 37);
            this.LblAdvanced.TabIndex = 12;
            this.LblAdvanced.Text = "Level 3 - Advanced";
            // 
            // LblExpert
            // 
            this.LblExpert.AutoSize = true;
            this.LblExpert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblExpert.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblExpert.Location = new System.Drawing.Point(2070, 1096);
            this.LblExpert.Name = "LblExpert";
            this.LblExpert.Size = new System.Drawing.Size(237, 37);
            this.LblExpert.TabIndex = 13;
            this.LblExpert.Text = "Level 4 - Expert";
            // 
            // picMedium
            // 
            this.picMedium.Image = global::LickBuilder.Properties.Resources.five_stroke_roll;
            this.picMedium.Location = new System.Drawing.Point(1493, 179);
            this.picMedium.Name = "picMedium";
            this.picMedium.Size = new System.Drawing.Size(897, 421);
            this.picMedium.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMedium.TabIndex = 9;
            this.picMedium.TabStop = false;
            this.picMedium.Click += new System.EventHandler(this.picMedium_Click);
            // 
            // picExpert
            // 
            this.picExpert.Image = global::LickBuilder.Properties.Resources.single_stroke_roll;
            this.picExpert.Location = new System.Drawing.Point(1738, 680);
            this.picExpert.Name = "picExpert";
            this.picExpert.Size = new System.Drawing.Size(897, 398);
            this.picExpert.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picExpert.TabIndex = 8;
            this.picExpert.TabStop = false;
            this.picExpert.Click += new System.EventHandler(this.picExpert_Click);
            // 
            // picEasy
            // 
            this.picEasy.Image = global::LickBuilder.Properties.Resources.flam;
            this.picEasy.Location = new System.Drawing.Point(82, 179);
            this.picEasy.Name = "picEasy";
            this.picEasy.Size = new System.Drawing.Size(897, 421);
            this.picEasy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picEasy.TabIndex = 7;
            this.picEasy.TabStop = false;
            this.picEasy.Click += new System.EventHandler(this.picEasy_Click);
            // 
            // picAdvanced
            // 
            this.picAdvanced.Image = global::LickBuilder.Properties.Resources.pataflafla;
            this.picAdvanced.Location = new System.Drawing.Point(534, 680);
            this.picAdvanced.Name = "picAdvanced";
            this.picAdvanced.Size = new System.Drawing.Size(897, 398);
            this.picAdvanced.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAdvanced.TabIndex = 5;
            this.picAdvanced.TabStop = false;
            this.picAdvanced.Click += new System.EventHandler(this.picAdvanced_Click);
            // 
            // GettingStarted
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::LickBuilder.Properties.Resources.background2;
            this.ClientSize = new System.Drawing.Size(2740, 1729);
            this.Controls.Add(this.LblExpert);
            this.Controls.Add(this.LblAdvanced);
            this.Controls.Add(this.LblMedium);
            this.Controls.Add(this.lblEasy);
            this.Controls.Add(this.picMedium);
            this.Controls.Add(this.picExpert);
            this.Controls.Add(this.picEasy);
            this.Controls.Add(this.picAdvanced);
            this.Controls.Add(this.LblPictures);
            this.Controls.Add(this.cmDifficulties);
            this.Controls.Add(this.LblSelection);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GettingStarted";
            this.Text = "GettingStarted";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GettingStarted_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picMedium)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExpert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEasy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAdvanced)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblSelection;
        private System.Windows.Forms.ComboBox cmDifficulties;
        private System.Windows.Forms.Label LblPictures;
        private System.Windows.Forms.PictureBox picAdvanced;
        private System.Windows.Forms.PictureBox picEasy;
        private System.Windows.Forms.PictureBox picExpert;
        private System.Windows.Forms.PictureBox picMedium;
        private System.Windows.Forms.Label lblEasy;
        private System.Windows.Forms.Label LblMedium;
        private System.Windows.Forms.Label LblAdvanced;
        private System.Windows.Forms.Label LblExpert;
    }
}