namespace U14_LEDShed
{
    partial class EventForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventForm));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnComplete = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.btnEventCosts = new System.Windows.Forms.Button();
            this.btnContact = new System.Windows.Forms.Button();
            this.btnEventDetails = new System.Windows.Forms.Button();
            this.iconLedShed = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCompleteEvent = new System.Windows.Forms.GroupBox();
            this.txtTotalCost = new System.Windows.Forms.Label();
            this.txtCateringCost = new System.Windows.Forms.Label();
            this.txtStaffingCost = new System.Windows.Forms.Label();
            this.txtTravelCost = new System.Windows.Forms.Label();
            this.txtAccomodationCost = new System.Windows.Forms.Label();
            this.btnTotalCalc = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tblStock = new System.Windows.Forms.DataGridView();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.CostDetailsBox = new System.Windows.Forms.GroupBox();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.EventContactBox = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.EventDetailsBox = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconLedShed)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.btnCompleteEvent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblStock)).BeginInit();
            this.CostDetailsBox.SuspendLayout();
            this.EventContactBox.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.EventDetailsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox2.Controls.Add(this.btnComplete);
            this.groupBox2.Controls.Add(this.btnStock);
            this.groupBox2.Controls.Add(this.btnEventCosts);
            this.groupBox2.Controls.Add(this.btnContact);
            this.groupBox2.Controls.Add(this.btnEventDetails);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(-7, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(278, 370);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // btnComplete
            // 
            this.btnComplete.Location = new System.Drawing.Point(81, 313);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(82, 29);
            this.btnComplete.TabIndex = 9;
            this.btnComplete.Text = "Complete";
            this.btnComplete.UseVisualStyleBackColor = true;
            this.btnComplete.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnStock
            // 
            this.btnStock.Location = new System.Drawing.Point(53, 179);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(141, 46);
            this.btnStock.TabIndex = 15;
            this.btnStock.Text = "Equipment Details";
            this.btnStock.UseVisualStyleBackColor = true;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // btnEventCosts
            // 
            this.btnEventCosts.Location = new System.Drawing.Point(53, 246);
            this.btnEventCosts.Name = "btnEventCosts";
            this.btnEventCosts.Size = new System.Drawing.Size(141, 46);
            this.btnEventCosts.TabIndex = 14;
            this.btnEventCosts.Text = "Total Costs";
            this.btnEventCosts.UseVisualStyleBackColor = true;
            this.btnEventCosts.Click += new System.EventHandler(this.btnEventCosts_Click);
            // 
            // btnContact
            // 
            this.btnContact.Location = new System.Drawing.Point(53, 111);
            this.btnContact.Name = "btnContact";
            this.btnContact.Size = new System.Drawing.Size(141, 46);
            this.btnContact.TabIndex = 13;
            this.btnContact.Text = "Contact Details";
            this.btnContact.UseVisualStyleBackColor = true;
            this.btnContact.Click += new System.EventHandler(this.btnContact_Click);
            // 
            // btnEventDetails
            // 
            this.btnEventDetails.Location = new System.Drawing.Point(53, 45);
            this.btnEventDetails.Name = "btnEventDetails";
            this.btnEventDetails.Size = new System.Drawing.Size(141, 46);
            this.btnEventDetails.TabIndex = 12;
            this.btnEventDetails.Text = "Event Details";
            this.btnEventDetails.UseVisualStyleBackColor = true;
            this.btnEventDetails.Click += new System.EventHandler(this.btnEventDetails_Click);
            // 
            // iconLedShed
            // 
            this.iconLedShed.Image = ((System.Drawing.Image)(resources.GetObject("iconLedShed.Image")));
            this.iconLedShed.Location = new System.Drawing.Point(0, 15);
            this.iconLedShed.Margin = new System.Windows.Forms.Padding(0);
            this.iconLedShed.Name = "iconLedShed";
            this.iconLedShed.Size = new System.Drawing.Size(601, 73);
            this.iconLedShed.TabIndex = 5;
            this.iconLedShed.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(662, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Event Form";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.groupBox3.Location = new System.Drawing.Point(0, 98);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 355);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.iconLedShed);
            this.groupBox1.Location = new System.Drawing.Point(2, -6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.Size = new System.Drawing.Size(803, 102);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnCompleteEvent
            // 
            this.btnCompleteEvent.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnCompleteEvent.Controls.Add(this.txtTotalCost);
            this.btnCompleteEvent.Controls.Add(this.txtCateringCost);
            this.btnCompleteEvent.Controls.Add(this.txtStaffingCost);
            this.btnCompleteEvent.Controls.Add(this.txtTravelCost);
            this.btnCompleteEvent.Controls.Add(this.txtAccomodationCost);
            this.btnCompleteEvent.Controls.Add(this.btnTotalCalc);
            this.btnCompleteEvent.Location = new System.Drawing.Point(269, 83);
            this.btnCompleteEvent.Name = "btnCompleteEvent";
            this.btnCompleteEvent.Size = new System.Drawing.Size(545, 378);
            this.btnCompleteEvent.TabIndex = 17;
            this.btnCompleteEvent.TabStop = false;
            // 
            // txtTotalCost
            // 
            this.txtTotalCost.AutoSize = true;
            this.txtTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalCost.Location = new System.Drawing.Point(113, 220);
            this.txtTotalCost.Name = "txtTotalCost";
            this.txtTotalCost.Size = new System.Drawing.Size(122, 25);
            this.txtTotalCost.TabIndex = 8;
            this.txtTotalCost.Text = "Total Cost: ";
            // 
            // txtCateringCost
            // 
            this.txtCateringCost.AutoSize = true;
            this.txtCateringCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCateringCost.Location = new System.Drawing.Point(80, 147);
            this.txtCateringCost.Name = "txtCateringCost";
            this.txtCateringCost.Size = new System.Drawing.Size(155, 25);
            this.txtCateringCost.TabIndex = 7;
            this.txtCateringCost.Text = "Catering Cost: ";
            // 
            // txtStaffingCost
            // 
            this.txtStaffingCost.AutoSize = true;
            this.txtStaffingCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffingCost.Location = new System.Drawing.Point(88, 113);
            this.txtStaffingCost.Name = "txtStaffingCost";
            this.txtStaffingCost.Size = new System.Drawing.Size(147, 25);
            this.txtStaffingCost.TabIndex = 6;
            this.txtStaffingCost.Text = "Staffing Cost: ";
            // 
            // txtTravelCost
            // 
            this.txtTravelCost.AutoSize = true;
            this.txtTravelCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTravelCost.Location = new System.Drawing.Point(101, 80);
            this.txtTravelCost.Name = "txtTravelCost";
            this.txtTravelCost.Size = new System.Drawing.Size(134, 25);
            this.txtTravelCost.TabIndex = 5;
            this.txtTravelCost.Text = "Travel Cost: ";
            // 
            // txtAccomodationCost
            // 
            this.txtAccomodationCost.AutoSize = true;
            this.txtAccomodationCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccomodationCost.Location = new System.Drawing.Point(26, 50);
            this.txtAccomodationCost.Name = "txtAccomodationCost";
            this.txtAccomodationCost.Size = new System.Drawing.Size(210, 25);
            this.txtAccomodationCost.TabIndex = 4;
            this.txtAccomodationCost.Text = "Accomodation Cost: ";
            // 
            // btnTotalCalc
            // 
            this.btnTotalCalc.Location = new System.Drawing.Point(133, 263);
            this.btnTotalCalc.Name = "btnTotalCalc";
            this.btnTotalCalc.Size = new System.Drawing.Size(82, 29);
            this.btnTotalCalc.TabIndex = 0;
            this.btnTotalCalc.Text = "Calculate";
            this.btnTotalCalc.UseVisualStyleBackColor = true;
            this.btnTotalCalc.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Select Equipment";
            // 
            // tblStock
            // 
            this.tblStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item,
            this.Amount,
            this.Cost,
            this.Total});
            this.tblStock.Location = new System.Drawing.Point(51, 54);
            this.tblStock.Name = "tblStock";
            this.tblStock.Size = new System.Drawing.Size(443, 270);
            this.tblStock.TabIndex = 9;
            this.tblStock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblStock_CellContentClick_1);
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
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(146, 22);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(90, 23);
            this.btnCalculate.TabIndex = 10;
            this.btnCalculate.Text = "Calculate Total";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(251, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Total Cost:";
            // 
            // CostDetailsBox
            // 
            this.CostDetailsBox.BackColor = System.Drawing.SystemColors.GrayText;
            this.CostDetailsBox.Controls.Add(this.label3);
            this.CostDetailsBox.Controls.Add(this.btnCalculate);
            this.CostDetailsBox.Controls.Add(this.tblStock);
            this.CostDetailsBox.Controls.Add(this.label7);
            this.CostDetailsBox.Location = new System.Drawing.Point(269, 85);
            this.CostDetailsBox.Name = "CostDetailsBox";
            this.CostDetailsBox.Size = new System.Drawing.Size(536, 368);
            this.CostDetailsBox.TabIndex = 12;
            this.CostDetailsBox.TabStop = false;
            this.CostDetailsBox.Visible = false;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(55, 60);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(146, 20);
            this.txtCompanyName.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(53, 163);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(384, 28);
            this.txtEmail.TabIndex = 2;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(63, 147);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 13);
            this.label15.TabIndex = 3;
            this.label15.Text = "Email Address";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(63, 96);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(78, 13);
            this.label16.TabIndex = 1;
            this.label16.Text = "Phone Number";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(57, 112);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(146, 20);
            this.txtPhoneNumber.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(61, 42);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 13);
            this.label14.TabIndex = 5;
            this.label14.Text = "Company Name";
            // 
            // EventContactBox
            // 
            this.EventContactBox.BackColor = System.Drawing.SystemColors.GrayText;
            this.EventContactBox.Controls.Add(this.label14);
            this.EventContactBox.Controls.Add(this.txtPhoneNumber);
            this.EventContactBox.Controls.Add(this.label16);
            this.EventContactBox.Controls.Add(this.label15);
            this.EventContactBox.Controls.Add(this.txtEmail);
            this.EventContactBox.Controls.Add(this.txtCompanyName);
            this.EventContactBox.Location = new System.Drawing.Point(269, 83);
            this.EventContactBox.Name = "EventContactBox";
            this.EventContactBox.Size = new System.Drawing.Size(533, 372);
            this.EventContactBox.TabIndex = 18;
            this.EventContactBox.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.GrayText;
            this.groupBox5.Controls.Add(this.dataGridView1);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Location = new System.Drawing.Point(269, 83);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(596, 466);
            this.groupBox5.TabIndex = 19;
            this.groupBox5.TabStop = false;
            this.groupBox5.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridView1.Location = new System.Drawing.Point(100, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(344, 270);
            this.dataGridView1.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Item";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Amount";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Cost";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Select Equipment";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(51, 45);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(146, 20);
            this.textBox5.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(57, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Event Name";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(51, 97);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(456, 60);
            this.textBox4.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(57, 81);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Event Details";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(51, 195);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(146, 20);
            this.textBox3.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(57, 179);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Event Location";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(57, 246);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Event Dates";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(69, 278);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Start Date:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(300, 278);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "End Date:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(133, 272);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(146, 20);
            this.dateTimePicker2.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(361, 272);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(146, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // EventDetailsBox
            // 
            this.EventDetailsBox.BackColor = System.Drawing.SystemColors.GrayText;
            this.EventDetailsBox.Controls.Add(this.dateTimePicker1);
            this.EventDetailsBox.Controls.Add(this.dateTimePicker2);
            this.EventDetailsBox.Controls.Add(this.label8);
            this.EventDetailsBox.Controls.Add(this.label9);
            this.EventDetailsBox.Controls.Add(this.label10);
            this.EventDetailsBox.Controls.Add(this.label11);
            this.EventDetailsBox.Controls.Add(this.textBox3);
            this.EventDetailsBox.Controls.Add(this.label12);
            this.EventDetailsBox.Controls.Add(this.textBox4);
            this.EventDetailsBox.Controls.Add(this.label13);
            this.EventDetailsBox.Controls.Add(this.textBox5);
            this.EventDetailsBox.Location = new System.Drawing.Point(269, 85);
            this.EventDetailsBox.Name = "EventDetailsBox";
            this.EventDetailsBox.Size = new System.Drawing.Size(545, 382);
            this.EventDetailsBox.TabIndex = 14;
            this.EventDetailsBox.TabStop = false;
            // 
            // EventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.EventDetailsBox);
            this.Controls.Add(this.CostDetailsBox);
            this.Controls.Add(this.btnCompleteEvent);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.EventContactBox);
            this.Name = "EventForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EventForm";
            this.Load += new System.EventHandler(this.EventForm_Load_1);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconLedShed)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.btnCompleteEvent.ResumeLayout(false);
            this.btnCompleteEvent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblStock)).EndInit();
            this.CostDetailsBox.ResumeLayout(false);
            this.CostDetailsBox.PerformLayout();
            this.EventContactBox.ResumeLayout(false);
            this.EventContactBox.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.EventDetailsBox.ResumeLayout(false);
            this.EventDetailsBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox iconLedShed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEventDetails;
        private System.Windows.Forms.Button btnEventCosts;
        private System.Windows.Forms.Button btnContact;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.GroupBox btnCompleteEvent;
        private System.Windows.Forms.Button btnTotalCalc;
        private System.Windows.Forms.Label txtAccomodationCost;
        private System.Windows.Forms.Label txtCateringCost;
        private System.Windows.Forms.Label txtStaffingCost;
        private System.Windows.Forms.Label txtTravelCost;
        private System.Windows.Forms.Label txtTotalCost;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView tblStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox CostDetailsBox;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox EventContactBox;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox EventDetailsBox;
    }
}