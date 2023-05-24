namespace U14_LEDShed
{
    partial class Freelancer_Viewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Freelancer_Viewer));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.iconLedShed = new System.Windows.Forms.PictureBox();
            this.lstEvents = new System.Windows.Forms.ListBox();
            this.btnViewEvent = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.EventDetailsBox = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.previousjobs = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.specialism = new System.Windows.Forms.TextBox();
            this.avaliability = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.region = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.notes = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.VAT = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.NiN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sortcode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dailyrate = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.PhoneNumber = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.webaddress = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconLedShed)).BeginInit();
            this.EventDetailsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.iconLedShed);
            this.groupBox1.Location = new System.Drawing.Point(0, -14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.Size = new System.Drawing.Size(803, 102);
            this.groupBox1.TabIndex = 123;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(662, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Freelancer viewer";
            // 
            // iconLedShed
            // 
            this.iconLedShed.Image = ((System.Drawing.Image)(resources.GetObject("iconLedShed.Image")));
            this.iconLedShed.Location = new System.Drawing.Point(0, 25);
            this.iconLedShed.Margin = new System.Windows.Forms.Padding(0);
            this.iconLedShed.Name = "iconLedShed";
            this.iconLedShed.Size = new System.Drawing.Size(601, 73);
            this.iconLedShed.TabIndex = 5;
            this.iconLedShed.TabStop = false;
            // 
            // lstEvents
            // 
            this.lstEvents.FormattingEnabled = true;
            this.lstEvents.Location = new System.Drawing.Point(257, 82);
            this.lstEvents.Name = "lstEvents";
            this.lstEvents.Size = new System.Drawing.Size(287, 173);
            this.lstEvents.TabIndex = 19;
            // 
            // btnViewEvent
            // 
            this.btnViewEvent.Location = new System.Drawing.Point(460, 263);
            this.btnViewEvent.Name = "btnViewEvent";
            this.btnViewEvent.Size = new System.Drawing.Size(75, 23);
            this.btnViewEvent.TabIndex = 20;
            this.btnViewEvent.Text = "Load Event";
            this.btnViewEvent.UseVisualStyleBackColor = true;
            this.btnViewEvent.Click += new System.EventHandler(this.btnViewEvent_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(354, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Select a Freelancer";
            // 
            // EventDetailsBox
            // 
            this.EventDetailsBox.BackColor = System.Drawing.SystemColors.GrayText;
            this.EventDetailsBox.Controls.Add(this.label4);
            this.EventDetailsBox.Controls.Add(this.btnViewEvent);
            this.EventDetailsBox.Controls.Add(this.lstEvents);
            this.EventDetailsBox.Location = new System.Drawing.Point(-2, 87);
            this.EventDetailsBox.Name = "EventDetailsBox";
            this.EventDetailsBox.Size = new System.Drawing.Size(800, 378);
            this.EventDetailsBox.TabIndex = 124;
            this.EventDetailsBox.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(200, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 136;
            this.label7.Text = "Previous Jobs";
            // 
            // previousjobs
            // 
            this.previousjobs.Location = new System.Drawing.Point(183, 304);
            this.previousjobs.Multiline = true;
            this.previousjobs.Name = "previousjobs";
            this.previousjobs.Size = new System.Drawing.Size(195, 60);
            this.previousjobs.TabIndex = 135;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 134;
            this.label2.Text = "Specialism";
            // 
            // specialism
            // 
            this.specialism.Location = new System.Drawing.Point(202, 119);
            this.specialism.Name = "specialism";
            this.specialism.Size = new System.Drawing.Size(146, 20);
            this.specialism.TabIndex = 133;
            // 
            // avaliability
            // 
            this.avaliability.Location = new System.Drawing.Point(12, 344);
            this.avaliability.Name = "avaliability";
            this.avaliability.Size = new System.Drawing.Size(146, 20);
            this.avaliability.TabIndex = 132;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 320);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 131;
            this.label10.Text = "Avaliability";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 253);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 130;
            this.label11.Text = "Region";
            // 
            // region
            // 
            this.region.Location = new System.Drawing.Point(12, 277);
            this.region.Name = "region";
            this.region.Size = new System.Drawing.Size(146, 20);
            this.region.TabIndex = 129;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 155);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 13);
            this.label12.TabIndex = 128;
            this.label12.Text = "Profession Notes";
            // 
            // notes
            // 
            this.notes.Location = new System.Drawing.Point(12, 171);
            this.notes.Multiline = true;
            this.notes.Name = "notes";
            this.notes.Size = new System.Drawing.Size(253, 60);
            this.notes.TabIndex = 127;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 103);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 126;
            this.label13.Text = "Name";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(12, 119);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(146, 20);
            this.name.TabIndex = 125;
            // 
            // VAT
            // 
            this.VAT.AutoSize = true;
            this.VAT.Location = new System.Drawing.Point(616, 300);
            this.VAT.Name = "VAT";
            this.VAT.Size = new System.Drawing.Size(15, 14);
            this.VAT.TabIndex = 144;
            this.VAT.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(613, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 143;
            this.label6.Text = "VAT Registered?";
            // 
            // NiN
            // 
            this.NiN.Location = new System.Drawing.Point(607, 171);
            this.NiN.Name = "NiN";
            this.NiN.Size = new System.Drawing.Size(146, 20);
            this.NiN.TabIndex = 142;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(613, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 13);
            this.label3.TabIndex = 141;
            this.label3.Text = "National Insurance Number";
            // 
            // sortcode
            // 
            this.sortcode.Location = new System.Drawing.Point(607, 119);
            this.sortcode.Name = "sortcode";
            this.sortcode.Size = new System.Drawing.Size(146, 20);
            this.sortcode.TabIndex = 140;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(613, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 139;
            this.label5.Text = "Sort Code";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(414, 270);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 138;
            this.label8.Text = "Daily Rate";
            // 
            // dailyrate
            // 
            this.dailyrate.Location = new System.Drawing.Point(408, 294);
            this.dailyrate.Name = "dailyrate";
            this.dailyrate.Size = new System.Drawing.Size(146, 20);
            this.dailyrate.TabIndex = 137;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(412, 101);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 13);
            this.label14.TabIndex = 150;
            this.label14.Text = "Web Address";
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.Location = new System.Drawing.Point(408, 171);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(146, 20);
            this.PhoneNumber.TabIndex = 145;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(414, 155);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(78, 13);
            this.label16.TabIndex = 146;
            this.label16.Text = "Phone Number";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(414, 206);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 13);
            this.label15.TabIndex = 148;
            this.label15.Text = "Email Address";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(404, 222);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(384, 28);
            this.txtEmail.TabIndex = 147;
            // 
            // webaddress
            // 
            this.webaddress.Location = new System.Drawing.Point(406, 119);
            this.webaddress.Name = "webaddress";
            this.webaddress.Size = new System.Drawing.Size(146, 20);
            this.webaddress.TabIndex = 149;
            // 
            // Freelancer_Viewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EventDetailsBox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.PhoneNumber);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.webaddress);
            this.Controls.Add(this.VAT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.NiN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sortcode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dailyrate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.previousjobs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.specialism);
            this.Controls.Add(this.avaliability);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.region);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.notes);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.name);
            this.Controls.Add(this.groupBox1);
            this.Name = "Freelancer_Viewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Freelancer_Viewer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconLedShed)).EndInit();
            this.EventDetailsBox.ResumeLayout(false);
            this.EventDetailsBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox iconLedShed;
        private System.Windows.Forms.ListBox lstEvents;
        private System.Windows.Forms.Button btnViewEvent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox EventDetailsBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox previousjobs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox specialism;
        private System.Windows.Forms.TextBox avaliability;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox region;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox notes;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.CheckBox VAT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NiN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sortcode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox dailyrate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox PhoneNumber;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox webaddress;
    }
}