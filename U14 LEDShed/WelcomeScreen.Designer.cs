namespace U14_LEDShed
{
    partial class WelcomeScreen
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
        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeScreen));
            this.btnNewEvent = new System.Windows.Forms.Button();
            this.btnViewEvent = new System.Windows.Forms.Button();
            this.btnNewFreelancer = new System.Windows.Forms.Button();
            this.btnEditFreelancer = new System.Windows.Forms.Button();
            this.iconLedShed = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.eventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newEventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editEventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.freelancerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFreelancerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editFreelancerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconLedShed)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNewEvent
            // 
            this.btnNewEvent.Location = new System.Drawing.Point(41, 163);
            this.btnNewEvent.Name = "btnNewEvent";
            this.btnNewEvent.Size = new System.Drawing.Size(141, 46);
            this.btnNewEvent.TabIndex = 11;
            this.btnNewEvent.Text = "Add a New event";
            this.btnNewEvent.UseVisualStyleBackColor = true;
            this.btnNewEvent.Click += new System.EventHandler(this.btnNewEvent_Click);
            // 
            // btnViewEvent
            // 
            this.btnViewEvent.Location = new System.Drawing.Point(232, 163);
            this.btnViewEvent.Name = "btnViewEvent";
            this.btnViewEvent.Size = new System.Drawing.Size(141, 46);
            this.btnViewEvent.TabIndex = 12;
            this.btnViewEvent.Text = "View your event";
            this.btnViewEvent.UseVisualStyleBackColor = true;
            this.btnViewEvent.Click += new System.EventHandler(this.btnViewEvent_Click);
            // 
            // btnNewFreelancer
            // 
            this.btnNewFreelancer.Location = new System.Drawing.Point(41, 302);
            this.btnNewFreelancer.Name = "btnNewFreelancer";
            this.btnNewFreelancer.Size = new System.Drawing.Size(141, 46);
            this.btnNewFreelancer.TabIndex = 13;
            this.btnNewFreelancer.Text = "Add a New Freelancer";
            this.btnNewFreelancer.UseVisualStyleBackColor = true;
            this.btnNewFreelancer.Click += new System.EventHandler(this.btnNewFreelancer_Click);
            // 
            // btnEditFreelancer
            // 
            this.btnEditFreelancer.Location = new System.Drawing.Point(232, 302);
            this.btnEditFreelancer.Name = "btnEditFreelancer";
            this.btnEditFreelancer.Size = new System.Drawing.Size(141, 46);
            this.btnEditFreelancer.TabIndex = 14;
            this.btnEditFreelancer.Text = "View your Freelancer";
            this.btnEditFreelancer.UseVisualStyleBackColor = true;
            this.btnEditFreelancer.Click += new System.EventHandler(this.btnEditFreelancer_Click);
            // 
            // iconLedShed
            // 
            this.iconLedShed.Image = ((System.Drawing.Image)(resources.GetObject("iconLedShed.Image")));
            this.iconLedShed.Location = new System.Drawing.Point(0, 44);
            this.iconLedShed.Margin = new System.Windows.Forms.Padding(0);
            this.iconLedShed.Name = "iconLedShed";
            this.iconLedShed.Size = new System.Drawing.Size(596, 73);
            this.iconLedShed.TabIndex = 5;
            this.iconLedShed.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(662, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Main Menu";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.menuStrip1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.iconLedShed);
            this.groupBox1.Location = new System.Drawing.Point(2, -16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.Size = new System.Drawing.Size(803, 124);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eventToolStripMenuItem,
            this.freelancerToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 13);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(803, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // eventToolStripMenuItem
            // 
            this.eventToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newEventToolStripMenuItem,
            this.editEventToolStripMenuItem});
            this.eventToolStripMenuItem.Name = "eventToolStripMenuItem";
            this.eventToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.eventToolStripMenuItem.Text = "Event";
            // 
            // newEventToolStripMenuItem
            // 
            this.newEventToolStripMenuItem.Name = "newEventToolStripMenuItem";
            this.newEventToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.newEventToolStripMenuItem.Text = "New event";
            // 
            // editEventToolStripMenuItem
            // 
            this.editEventToolStripMenuItem.Name = "editEventToolStripMenuItem";
            this.editEventToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.editEventToolStripMenuItem.Text = "Edit event";
            // 
            // freelancerToolStripMenuItem
            // 
            this.freelancerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFreelancerToolStripMenuItem,
            this.editFreelancerToolStripMenuItem});
            this.freelancerToolStripMenuItem.Name = "freelancerToolStripMenuItem";
            this.freelancerToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.freelancerToolStripMenuItem.Text = "Freelancer";
            // 
            // newFreelancerToolStripMenuItem
            // 
            this.newFreelancerToolStripMenuItem.Name = "newFreelancerToolStripMenuItem";
            this.newFreelancerToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.newFreelancerToolStripMenuItem.Text = "New Freelancer";
            // 
            // editFreelancerToolStripMenuItem
            // 
            this.editFreelancerToolStripMenuItem.Name = "editFreelancerToolStripMenuItem";
            this.editFreelancerToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.editFreelancerToolStripMenuItem.Text = "Edit Freelancer";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveFileToolStripMenuItem,
            this.openFileDataToolStripMenuItem});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            this.saveFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveFileToolStripMenuItem.Text = "Save File";
            this.saveFileToolStripMenuItem.Click += new System.EventHandler(this.saveFileToolStripMenuItem_Click);
            // 
            // openFileDataToolStripMenuItem
            // 
            this.openFileDataToolStripMenuItem.Name = "openFileDataToolStripMenuItem";
            this.openFileDataToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openFileDataToolStripMenuItem.Text = "Open File Data";
            this.openFileDataToolStripMenuItem.Click += new System.EventHandler(this.openFileDataToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(408, 138);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(370, 250);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // WelcomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnEditFreelancer);
            this.Controls.Add(this.btnNewFreelancer);
            this.Controls.Add(this.btnViewEvent);
            this.Controls.Add(this.btnNewEvent);
            this.Controls.Add(this.groupBox1);
            this.Name = "WelcomeScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "-";
            this.Load += new System.EventHandler(this.WelcomeScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconLedShed)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnNewEvent;
        private System.Windows.Forms.Button btnViewEvent;
        private System.Windows.Forms.Button btnNewFreelancer;
        private System.Windows.Forms.Button btnEditFreelancer;
        private System.Windows.Forms.PictureBox iconLedShed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eventToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newEventToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editEventToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem freelancerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newFreelancerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editFreelancerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileDataToolStripMenuItem;
    }
}