namespace PraktikumWEek8
{
    partial class formHasilPertandingan
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
            this.cbHomeTeam = new System.Windows.Forms.ComboBox();
            this.cbAwayTeam = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblHomeCaptain = new System.Windows.Forms.Label();
            this.lblHomeManager = new System.Windows.Forms.Label();
            this.lblAwayCaptain = new System.Windows.Forms.Label();
            this.lblAwayManager = new System.Windows.Forms.Label();
            this.lblStadiumCapacity = new System.Windows.Forms.Label();
            this.lblStadiumName = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbHomeTeam
            // 
            this.cbHomeTeam.FormattingEnabled = true;
            this.cbHomeTeam.Location = new System.Drawing.Point(58, 35);
            this.cbHomeTeam.Name = "cbHomeTeam";
            this.cbHomeTeam.Size = new System.Drawing.Size(224, 24);
            this.cbHomeTeam.TabIndex = 0;
            this.cbHomeTeam.SelectedIndexChanged += new System.EventHandler(this.cbHomeTeam_SelectedIndexChanged);
            // 
            // cbAwayTeam
            // 
            this.cbAwayTeam.FormattingEnabled = true;
            this.cbAwayTeam.Location = new System.Drawing.Point(444, 35);
            this.cbAwayTeam.Name = "cbAwayTeam";
            this.cbAwayTeam.Size = new System.Drawing.Size(224, 24);
            this.cbAwayTeam.TabIndex = 1;
            this.cbAwayTeam.SelectedIndexChanged += new System.EventHandler(this.cbAwayTeam_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(353, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "VS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Manager  :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Captain     :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(441, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Captain     :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(441, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Manager  :";
            // 
            // lblHomeCaptain
            // 
            this.lblHomeCaptain.AutoSize = true;
            this.lblHomeCaptain.Location = new System.Drawing.Point(131, 119);
            this.lblHomeCaptain.Name = "lblHomeCaptain";
            this.lblHomeCaptain.Size = new System.Drawing.Size(107, 16);
            this.lblHomeCaptain.TabIndex = 8;
            this.lblHomeCaptain.Text = "- Captain Name -";
            // 
            // lblHomeManager
            // 
            this.lblHomeManager.AutoSize = true;
            this.lblHomeManager.Location = new System.Drawing.Point(131, 87);
            this.lblHomeManager.Name = "lblHomeManager";
            this.lblHomeManager.Size = new System.Drawing.Size(115, 16);
            this.lblHomeManager.TabIndex = 7;
            this.lblHomeManager.Text = "- Manager Name -";
            // 
            // lblAwayCaptain
            // 
            this.lblAwayCaptain.AutoSize = true;
            this.lblAwayCaptain.Location = new System.Drawing.Point(517, 119);
            this.lblAwayCaptain.Name = "lblAwayCaptain";
            this.lblAwayCaptain.Size = new System.Drawing.Size(107, 16);
            this.lblAwayCaptain.TabIndex = 10;
            this.lblAwayCaptain.Text = "- Captain Name -";
            // 
            // lblAwayManager
            // 
            this.lblAwayManager.AutoSize = true;
            this.lblAwayManager.Location = new System.Drawing.Point(517, 87);
            this.lblAwayManager.Name = "lblAwayManager";
            this.lblAwayManager.Size = new System.Drawing.Size(115, 16);
            this.lblAwayManager.TabIndex = 9;
            this.lblAwayManager.Text = "- Manager Name -";
            // 
            // lblStadiumCapacity
            // 
            this.lblStadiumCapacity.AutoSize = true;
            this.lblStadiumCapacity.Location = new System.Drawing.Point(342, 223);
            this.lblStadiumCapacity.Name = "lblStadiumCapacity";
            this.lblStadiumCapacity.Size = new System.Drawing.Size(126, 16);
            this.lblStadiumCapacity.TabIndex = 14;
            this.lblStadiumCapacity.Text = "- Stadium Capacity -";
            // 
            // lblStadiumName
            // 
            this.lblStadiumName.AutoSize = true;
            this.lblStadiumName.Location = new System.Drawing.Point(342, 191);
            this.lblStadiumName.Name = "lblStadiumName";
            this.lblStadiumName.Size = new System.Drawing.Size(110, 16);
            this.lblStadiumName.TabIndex = 13;
            this.lblStadiumName.Text = "- Stadium Name -";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(269, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Capacity :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(269, 191);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 16);
            this.label9.TabIndex = 11;
            this.label9.Text = "Stadium  :";
            // 
            // formHasilPertandingan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 412);
            this.Controls.Add(this.lblStadiumCapacity);
            this.Controls.Add(this.lblStadiumName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblAwayCaptain);
            this.Controls.Add(this.lblAwayManager);
            this.Controls.Add(this.lblHomeCaptain);
            this.Controls.Add(this.lblHomeManager);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbAwayTeam);
            this.Controls.Add(this.cbHomeTeam);
            this.Name = "formHasilPertandingan";
            this.Text = "Hasil Pertandingan";
            this.Load += new System.EventHandler(this.formHasilPertandingan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbHomeTeam;
        private System.Windows.Forms.ComboBox cbAwayTeam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblHomeCaptain;
        private System.Windows.Forms.Label lblHomeManager;
        private System.Windows.Forms.Label lblAwayCaptain;
        private System.Windows.Forms.Label lblAwayManager;
        private System.Windows.Forms.Label lblStadiumCapacity;
        private System.Windows.Forms.Label lblStadiumName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

