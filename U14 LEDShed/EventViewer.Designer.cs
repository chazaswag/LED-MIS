namespace U14_LEDShed
{
    partial class EventViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventViewer));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.iconLedShed = new System.Windows.Forms.PictureBox();
            this.tblStock = new System.Windows.Forms.DataGridView();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label14 = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtcompanyname = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.txtevebtdetails = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtevebtname = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtevebtlocation = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.EventDetailsBox = new System.Windows.Forms.GroupBox();
            this.btnViewEvent = new System.Windows.Forms.Button();
            this.lstEvents = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconLedShed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStock)).BeginInit();
            this.EventDetailsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.iconLedShed);
            this.groupBox1.Location = new System.Drawing.Point(2, -16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.Size = new System.Drawing.Size(803, 102);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(662, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Event viewer";
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
            // tblStock
            // 
            this.tblStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item,
            this.Amount,
            this.Cost,
            this.Total});
            this.tblStock.Location = new System.Drawing.Point(334, 142);
            this.tblStock.Name = "tblStock";
            this.tblStock.Size = new System.Drawing.Size(443, 250);
            this.tblStock.TabIndex = 107;
            // 
            // Item
            // 
            this.Item.Frozen = true;
            this.Item.HeaderText = "Item";
            this.Item.Name = "Item";
            this.Item.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Amount
            // 
            this.Amount.Frozen = true;
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            // 
            // Cost
            // 
            this.Cost.Frozen = true;
            this.Cost.HeaderText = "Cost";
            this.Cost.Name = "Cost";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(187, 89);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 13);
            this.label14.TabIndex = 106;
            this.label14.Text = "Company Name";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(12, 419);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(146, 20);
            this.txtPhoneNumber.TabIndex = 101;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(18, 403);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(78, 13);
            this.label16.TabIndex = 102;
            this.label16.Text = "Phone Number";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(18, 351);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 13);
            this.label15.TabIndex = 104;
            this.label15.Text = "Email Address";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(12, 367);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(304, 28);
            this.txtEmail.TabIndex = 103;
            // 
            // txtcompanyname
            // 
            this.txtcompanyname.Location = new System.Drawing.Point(181, 105);
            this.txtcompanyname.Name = "txtcompanyname";
            this.txtcompanyname.Size = new System.Drawing.Size(146, 20);
            this.txtcompanyname.TabIndex = 105;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(85, 314);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(146, 20);
            this.dateTimePicker1.TabIndex = 100;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(85, 288);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(146, 20);
            this.dateTimePicker2.TabIndex = 99;
            // 
            // txtevebtdetails
            // 
            this.txtevebtdetails.Location = new System.Drawing.Point(12, 160);
            this.txtevebtdetails.Multiline = true;
            this.txtevebtdetails.Name = "txtevebtdetails";
            this.txtevebtdetails.Size = new System.Drawing.Size(304, 60);
            this.txtevebtdetails.TabIndex = 92;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 320);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 98;
            this.label8.Text = "End Date:";
            // 
            // txtevebtname
            // 
            this.txtevebtname.Location = new System.Drawing.Point(12, 105);
            this.txtevebtname.Name = "txtevebtname";
            this.txtevebtname.Size = new System.Drawing.Size(146, 20);
            this.txtevebtname.TabIndex = 90;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 294);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 97;
            this.label9.Text = "Start Date:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 89);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 13);
            this.label13.TabIndex = 91;
            this.label13.Text = "Event Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 273);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 96;
            this.label10.Text = "Event Dates";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 144);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 13);
            this.label12.TabIndex = 93;
            this.label12.Text = "Event Details";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 234);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 13);
            this.label11.TabIndex = 95;
            this.label11.Text = "Event Location";
            // 
            // txtevebtlocation
            // 
            this.txtevebtlocation.Location = new System.Drawing.Point(12, 250);
            this.txtevebtlocation.Name = "txtevebtlocation";
            this.txtevebtlocation.Size = new System.Drawing.Size(146, 20);
            this.txtevebtlocation.TabIndex = 94;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(333, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 89;
            this.label7.Text = "Equipment";
            // 
            // EventDetailsBox
            // 
            this.EventDetailsBox.BackColor = System.Drawing.SystemColors.GrayText;
            this.EventDetailsBox.Controls.Add(this.label3);
            this.EventDetailsBox.Controls.Add(this.btnViewEvent);
            this.EventDetailsBox.Controls.Add(this.lstEvents);
            this.EventDetailsBox.Location = new System.Drawing.Point(2, 85);
            this.EventDetailsBox.Name = "EventDetailsBox";
            this.EventDetailsBox.Size = new System.Drawing.Size(800, 368);
            this.EventDetailsBox.TabIndex = 108;
            this.EventDetailsBox.TabStop = false;
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
            // lstEvents
            // 
            this.lstEvents.FormattingEnabled = true;
            this.lstEvents.Location = new System.Drawing.Point(257, 82);
            this.lstEvents.Name = "lstEvents";
            this.lstEvents.Size = new System.Drawing.Size(287, 173);
            this.lstEvents.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(500, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 109;
            this.label2.Text = "Total cost:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(354, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Select an Event";
            // 
            // EventViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EventDetailsBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tblStock);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtcompanyname);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.txtevebtdetails);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtevebtname);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtevebtlocation);
            this.Controls.Add(this.label7);
            this.Name = "EventViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EventViewer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconLedShed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStock)).EndInit();
            this.EventDetailsBox.ResumeLayout(false);
            this.EventDetailsBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox iconLedShed;
        private System.Windows.Forms.DataGridView tblStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtcompanyname;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox txtevebtdetails;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtevebtname;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtevebtlocation;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox EventDetailsBox;
        private System.Windows.Forms.Button btnViewEvent;
        private System.Windows.Forms.ListBox lstEvents;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}