namespace PigRace
{
    partial class FormBets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBets));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.udBet = new System.Windows.Forms.NumericUpDown();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblCashLeft = new System.Windows.Forms.Label();
            this.btnAllBets = new System.Windows.Forms.Button();
            this.cbxPunter = new System.Windows.Forms.ComboBox();
            this.radBacon = new System.Windows.Forms.RadioButton();
            this.radPork = new System.Windows.Forms.RadioButton();
            this.radHam = new System.Windows.Forms.RadioButton();
            this.radRibs = new System.Windows.Forms.RadioButton();
            this.lblBet1 = new System.Windows.Forms.Label();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblBroke = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb4 = new System.Windows.Forms.PictureBox();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.udBet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Punter:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Choose Pig to bet on: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Bet Amount: $";
            // 
            // udBet
            // 
            this.udBet.Location = new System.Drawing.Point(106, 251);
            this.udBet.Name = "udBet";
            this.udBet.Size = new System.Drawing.Size(61, 20);
            this.udBet.TabIndex = 5;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Enabled = false;
            this.btnConfirm.Location = new System.Drawing.Point(180, 250);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(111, 23);
            this.btnConfirm.TabIndex = 6;
            this.btnConfirm.Text = "Confirm Bet";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblCashLeft
            // 
            this.lblCashLeft.AutoSize = true;
            this.lblCashLeft.Location = new System.Drawing.Point(198, 76);
            this.lblCashLeft.Name = "lblCashLeft";
            this.lblCashLeft.Size = new System.Drawing.Size(0, 13);
            this.lblCashLeft.TabIndex = 8;
            // 
            // btnAllBets
            // 
            this.btnAllBets.Enabled = false;
            this.btnAllBets.Location = new System.Drawing.Point(106, 353);
            this.btnAllBets.Name = "btnAllBets";
            this.btnAllBets.Size = new System.Drawing.Size(132, 71);
            this.btnAllBets.TabIndex = 25;
            this.btnAllBets.Text = "Start Race!";
            this.btnAllBets.UseVisualStyleBackColor = true;
            this.btnAllBets.Click += new System.EventHandler(this.btnAllBets_Click);
            // 
            // cbxPunter
            // 
            this.cbxPunter.FormattingEnabled = true;
            this.cbxPunter.Location = new System.Drawing.Point(68, 72);
            this.cbxPunter.Name = "cbxPunter";
            this.cbxPunter.Size = new System.Drawing.Size(121, 21);
            this.cbxPunter.TabIndex = 34;
            this.cbxPunter.SelectedIndexChanged += new System.EventHandler(this.cbxPunter_SelectedIndexChanged);
            // 
            // radBacon
            // 
            this.radBacon.AutoSize = true;
            this.radBacon.Location = new System.Drawing.Point(17, 205);
            this.radBacon.Name = "radBacon";
            this.radBacon.Size = new System.Drawing.Size(56, 17);
            this.radBacon.TabIndex = 35;
            this.radBacon.TabStop = true;
            this.radBacon.Text = "Bacon";
            this.radBacon.UseVisualStyleBackColor = true;
            this.radBacon.Click += new System.EventHandler(this.radButton_CheckedChanged);
            // 
            // radPork
            // 
            this.radPork.AutoSize = true;
            this.radPork.Location = new System.Drawing.Point(106, 205);
            this.radPork.Name = "radPork";
            this.radPork.Size = new System.Drawing.Size(47, 17);
            this.radPork.TabIndex = 36;
            this.radPork.TabStop = true;
            this.radPork.Text = "Pork";
            this.radPork.UseVisualStyleBackColor = true;
            this.radPork.Click += new System.EventHandler(this.radButton_CheckedChanged);
            // 
            // radHam
            // 
            this.radHam.AutoSize = true;
            this.radHam.Location = new System.Drawing.Point(194, 205);
            this.radHam.Name = "radHam";
            this.radHam.Size = new System.Drawing.Size(47, 17);
            this.radHam.TabIndex = 37;
            this.radHam.TabStop = true;
            this.radHam.Text = "Ham";
            this.radHam.UseVisualStyleBackColor = true;
            this.radHam.Click += new System.EventHandler(this.radButton_CheckedChanged);
            // 
            // radRibs
            // 
            this.radRibs.AutoSize = true;
            this.radRibs.Location = new System.Drawing.Point(275, 205);
            this.radRibs.Name = "radRibs";
            this.radRibs.Size = new System.Drawing.Size(46, 17);
            this.radRibs.TabIndex = 38;
            this.radRibs.TabStop = true;
            this.radRibs.Text = "Ribs";
            this.radRibs.UseVisualStyleBackColor = true;
            this.radRibs.Click += new System.EventHandler(this.radButton_CheckedChanged);
            // 
            // lblBet1
            // 
            this.lblBet1.AutoSize = true;
            this.lblBet1.Location = new System.Drawing.Point(12, 285);
            this.lblBet1.Name = "lblBet1";
            this.lblBet1.Size = new System.Drawing.Size(0, 13);
            this.lblBet1.TabIndex = 39;
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.Location = new System.Drawing.Point(7, 7);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(315, 13);
            this.lblInstructions.TabIndex = 40;
            this.lblInstructions.Text = "Choose a pig to bet on and an amount for each punter";
            // 
            // lblBroke
            // 
            this.lblBroke.AutoSize = true;
            this.lblBroke.BackColor = System.Drawing.Color.Transparent;
            this.lblBroke.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBroke.Location = new System.Drawing.Point(9, 22);
            this.lblBroke.Name = "lblBroke";
            this.lblBroke.Size = new System.Drawing.Size(0, 13);
            this.lblBroke.TabIndex = 41;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.BackgroundImage = global::PigRace.Resource1.mud;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.Location = new System.Drawing.Point(628, 248);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(89, 89);
            this.pictureBox6.TabIndex = 47;
            this.pictureBox6.TabStop = false;
            // 
            // pb2
            // 
            this.pb2.BackColor = System.Drawing.Color.Transparent;
            this.pb2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb2.Location = new System.Drawing.Point(877, 247);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(89, 89);
            this.pb2.TabIndex = 45;
            this.pb2.TabStop = false;
            // 
            // pb4
            // 
            this.pb4.BackColor = System.Drawing.Color.Transparent;
            this.pb4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb4.Location = new System.Drawing.Point(387, 247);
            this.pb4.Name = "pb4";
            this.pb4.Size = new System.Drawing.Size(89, 89);
            this.pb4.TabIndex = 44;
            this.pb4.TabStop = false;
            // 
            // pb3
            // 
            this.pb3.BackColor = System.Drawing.Color.Transparent;
            this.pb3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb3.Location = new System.Drawing.Point(628, 493);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(89, 89);
            this.pb3.TabIndex = 43;
            this.pb3.TabStop = false;
            // 
            // pb1
            // 
            this.pb1.BackColor = System.Drawing.Color.Transparent;
            this.pb1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb1.Location = new System.Drawing.Point(628, 1);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(89, 89);
            this.pb1.TabIndex = 42;
            this.pb1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox4.Location = new System.Drawing.Point(262, 129);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(70, 70);
            this.pictureBox4.TabIndex = 32;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::PigRace.Resource1.pig4;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox3.Location = new System.Drawing.Point(180, 129);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(70, 70);
            this.pictureBox3.TabIndex = 30;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox2.Location = new System.Drawing.Point(97, 129);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(70, 70);
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PigRace.Resource1.pig3;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Location = new System.Drawing.Point(12, 129);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 70);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.LimeGreen;
            this.pictureBox5.BackgroundImage = global::PigRace.Resource1.track;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(387, 1);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(579, 581);
            this.pictureBox5.TabIndex = 48;
            this.pictureBox5.TabStop = false;
            // 
            // FormBets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.BackgroundImage = global::PigRace.Resource1.background;
            this.ClientSize = new System.Drawing.Size(968, 584);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pb4);
            this.Controls.Add(this.pb3);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.lblBroke);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.lblBet1);
            this.Controls.Add(this.radRibs);
            this.Controls.Add(this.radHam);
            this.Controls.Add(this.radPork);
            this.Controls.Add(this.radBacon);
            this.Controls.Add(this.cbxPunter);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAllBets);
            this.Controls.Add(this.lblCashLeft);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.udBet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox5);
            this.DoubleBuffered = true;
            this.Name = "FormBets";
            this.Text = "The Great Pig Race";
            this.TransparencyKey = System.Drawing.Color.Red;
            ((System.ComponentModel.ISupportInitialize)(this.udBet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown udBet;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblCashLeft;
        private System.Windows.Forms.Button btnAllBets;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.ComboBox cbxPunter;
        private System.Windows.Forms.RadioButton radBacon;
        private System.Windows.Forms.RadioButton radPork;
        private System.Windows.Forms.RadioButton radHam;
        private System.Windows.Forms.RadioButton radRibs;
        private System.Windows.Forms.Label lblBet1;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label lblBroke;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.PictureBox pb4;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.PictureBox pb1;
    }
}