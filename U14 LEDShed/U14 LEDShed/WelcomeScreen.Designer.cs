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
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeScreen));
            this.btnNewEvent = new System.Windows.Forms.Button();
            this.btnViewEvent = new System.Windows.Forms.Button();
            this.btnNewFreelancer = new System.Windows.Forms.Button();
            this.btnEditFreelancer = new System.Windows.Forms.Button();
            this.iconLedShed = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconLedShed)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNewEvent
            // 
            this.btnNewEvent.Location = new System.Drawing.Point(52, 121);
            this.btnNewEvent.Name = "btnNewEvent";
            this.btnNewEvent.Size = new System.Drawing.Size(141, 46);
            this.btnNewEvent.TabIndex = 11;
            this.btnNewEvent.Text = "Add a New event";
            this.btnNewEvent.UseVisualStyleBackColor = true;
            this.btnNewEvent.Click += new System.EventHandler(this.btnNewEvent_Click);
            // 
            // btnViewEvent
            // 
            this.btnViewEvent.Location = new System.Drawing.Point(52, 203);
            this.btnViewEvent.Name = "btnViewEvent";
            this.btnViewEvent.Size = new System.Drawing.Size(141, 46);
            this.btnViewEvent.TabIndex = 12;
            this.btnViewEvent.Text = "View your event";
            this.btnViewEvent.UseVisualStyleBackColor = true;
            this.btnViewEvent.Click += new System.EventHandler(this.btnViewEvent_Click);
            // 
            // btnNewFreelancer
            // 
            this.btnNewFreelancer.Location = new System.Drawing.Point(52, 282);
            this.btnNewFreelancer.Name = "btnNewFreelancer";
            this.btnNewFreelancer.Size = new System.Drawing.Size(141, 46);
            this.btnNewFreelancer.TabIndex = 13;
            this.btnNewFreelancer.Text = "Add a New Freelancer";
            this.btnNewFreelancer.UseVisualStyleBackColor = true;
            // 
            // btnEditFreelancer
            // 
            this.btnEditFreelancer.Location = new System.Drawing.Point(52, 359);
            this.btnEditFreelancer.Name = "btnEditFreelancer";
            this.btnEditFreelancer.Size = new System.Drawing.Size(141, 46);
            this.btnEditFreelancer.TabIndex = 14;
            this.btnEditFreelancer.Text = "Edit your Freelancer";
            this.btnEditFreelancer.UseVisualStyleBackColor = true;
            // 
            // iconLedShed
            // 
            this.iconLedShed.Image = ((System.Drawing.Image)(resources.GetObject("iconLedShed.Image")));
            this.iconLedShed.Location = new System.Drawing.Point(0, 25);
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
            this.label1.Location = new System.Drawing.Point(662, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Main Menu";
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
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // WelcomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}