namespace Demo_WinForms_SimpleCalculator
{
    partial class CalculatorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculatorForm));
            this.lbl_FormTitle = new System.Windows.Forms.Label();
            this.picBox_TelephoneStuffing = new System.Windows.Forms.PictureBox();
            this.lbl_Length = new System.Windows.Forms.Label();
            this.txtBox_Length = new System.Windows.Forms.TextBox();
            this.txtBox_Width = new System.Windows.Forms.TextBox();
            this.lbl_Width = new System.Windows.Forms.Label();
            this.txtBox_Height = new System.Windows.Forms.TextBox();
            this.lbl_Height = new System.Windows.Forms.Label();
            this.grpBox_Units = new System.Windows.Forms.GroupBox();
            this.radBtn_Metric = new System.Windows.Forms.RadioButton();
            this.radBtn_English = new System.Windows.Forms.RadioButton();
            this.lbl_BodyType = new System.Windows.Forms.Label();
            this.cmbBox_BodyType = new System.Windows.Forms.ComboBox();
            this.lbl_ErrorMessage = new System.Windows.Forms.Label();
            this.btn_CalculatePeople = new System.Windows.Forms.Button();
            this.btn_Help = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_TelephoneStuffing)).BeginInit();
            this.grpBox_Units.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_FormTitle
            // 
            this.lbl_FormTitle.AutoSize = true;
            this.lbl_FormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FormTitle.Location = new System.Drawing.Point(293, 9);
            this.lbl_FormTitle.Name = "lbl_FormTitle";
            this.lbl_FormTitle.Size = new System.Drawing.Size(400, 31);
            this.lbl_FormTitle.TabIndex = 0;
            this.lbl_FormTitle.Text = "Phone Booth Stuffing Calculator";
            // 
            // picBox_TelephoneStuffing
            // 
            this.picBox_TelephoneStuffing.Image = ((System.Drawing.Image)(resources.GetObject("picBox_TelephoneStuffing.Image")));
            this.picBox_TelephoneStuffing.Location = new System.Drawing.Point(12, 12);
            this.picBox_TelephoneStuffing.Name = "picBox_TelephoneStuffing";
            this.picBox_TelephoneStuffing.Size = new System.Drawing.Size(229, 312);
            this.picBox_TelephoneStuffing.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_TelephoneStuffing.TabIndex = 1;
            this.picBox_TelephoneStuffing.TabStop = false;
            // 
            // lbl_Length
            // 
            this.lbl_Length.AutoSize = true;
            this.lbl_Length.Location = new System.Drawing.Point(275, 103);
            this.lbl_Length.Name = "lbl_Length";
            this.lbl_Length.Size = new System.Drawing.Size(74, 17);
            this.lbl_Length.TabIndex = 2;
            this.lbl_Length.Text = "Length (ft)";
            // 
            // txtBox_Length
            // 
            this.txtBox_Length.Location = new System.Drawing.Point(387, 98);
            this.txtBox_Length.Name = "txtBox_Length";
            this.txtBox_Length.Size = new System.Drawing.Size(100, 22);
            this.txtBox_Length.TabIndex = 0;
            // 
            // txtBox_Width
            // 
            this.txtBox_Width.Location = new System.Drawing.Point(387, 126);
            this.txtBox_Width.Name = "txtBox_Width";
            this.txtBox_Width.Size = new System.Drawing.Size(100, 22);
            this.txtBox_Width.TabIndex = 1;
            // 
            // lbl_Width
            // 
            this.lbl_Width.AutoSize = true;
            this.lbl_Width.Location = new System.Drawing.Point(275, 131);
            this.lbl_Width.Name = "lbl_Width";
            this.lbl_Width.Size = new System.Drawing.Size(66, 17);
            this.lbl_Width.TabIndex = 4;
            this.lbl_Width.Text = "Width (ft)";
            // 
            // txtBox_Height
            // 
            this.txtBox_Height.Location = new System.Drawing.Point(387, 154);
            this.txtBox_Height.Name = "txtBox_Height";
            this.txtBox_Height.Size = new System.Drawing.Size(100, 22);
            this.txtBox_Height.TabIndex = 2;
            // 
            // lbl_Height
            // 
            this.lbl_Height.AutoSize = true;
            this.lbl_Height.Location = new System.Drawing.Point(275, 159);
            this.lbl_Height.Name = "lbl_Height";
            this.lbl_Height.Size = new System.Drawing.Size(71, 17);
            this.lbl_Height.TabIndex = 6;
            this.lbl_Height.Text = "Height (ft)";
            // 
            // grpBox_Units
            // 
            this.grpBox_Units.Controls.Add(this.radBtn_Metric);
            this.grpBox_Units.Controls.Add(this.radBtn_English);
            this.grpBox_Units.Location = new System.Drawing.Point(279, 50);
            this.grpBox_Units.Name = "grpBox_Units";
            this.grpBox_Units.Size = new System.Drawing.Size(258, 37);
            this.grpBox_Units.TabIndex = 8;
            this.grpBox_Units.TabStop = false;
            this.grpBox_Units.Text = "Units";
            // 
            // radBtn_Metric
            // 
            this.radBtn_Metric.AutoSize = true;
            this.radBtn_Metric.Location = new System.Drawing.Point(168, 10);
            this.radBtn_Metric.Name = "radBtn_Metric";
            this.radBtn_Metric.Size = new System.Drawing.Size(67, 21);
            this.radBtn_Metric.TabIndex = 1;
            this.radBtn_Metric.Text = "Metric";
            this.radBtn_Metric.UseVisualStyleBackColor = true;
            this.radBtn_Metric.CheckedChanged += new System.EventHandler(this.radBtn_Metric_CheckedChanged);
            // 
            // radBtn_English
            // 
            this.radBtn_English.AutoSize = true;
            this.radBtn_English.Checked = true;
            this.radBtn_English.Location = new System.Drawing.Point(78, 10);
            this.radBtn_English.Name = "radBtn_English";
            this.radBtn_English.Size = new System.Drawing.Size(75, 21);
            this.radBtn_English.TabIndex = 0;
            this.radBtn_English.TabStop = true;
            this.radBtn_English.Text = "English";
            this.radBtn_English.UseVisualStyleBackColor = true;
            this.radBtn_English.CheckedChanged += new System.EventHandler(this.radBtn_English_CheckedChanged);
            // 
            // lbl_BodyType
            // 
            this.lbl_BodyType.AutoSize = true;
            this.lbl_BodyType.Location = new System.Drawing.Point(276, 197);
            this.lbl_BodyType.Name = "lbl_BodyType";
            this.lbl_BodyType.Size = new System.Drawing.Size(76, 17);
            this.lbl_BodyType.TabIndex = 9;
            this.lbl_BodyType.Text = "Body Type";
            // 
            // cmbBox_BodyType
            // 
            this.cmbBox_BodyType.FormattingEnabled = true;
            this.cmbBox_BodyType.Items.AddRange(new object[] {
            "Short and Skinny",
            "Tall and Skinny",
            "Short and Robust",
            "Tall and Robust"});
            this.cmbBox_BodyType.Location = new System.Drawing.Point(387, 188);
            this.cmbBox_BodyType.Name = "cmbBox_BodyType";
            this.cmbBox_BodyType.Size = new System.Drawing.Size(150, 24);
            this.cmbBox_BodyType.TabIndex = 3;
            // 
            // lbl_ErrorMessage
            // 
            this.lbl_ErrorMessage.AutoSize = true;
            this.lbl_ErrorMessage.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_ErrorMessage.Location = new System.Drawing.Point(509, 101);
            this.lbl_ErrorMessage.MaximumSize = new System.Drawing.Size(300, 0);
            this.lbl_ErrorMessage.Name = "lbl_ErrorMessage";
            this.lbl_ErrorMessage.Size = new System.Drawing.Size(0, 17);
            this.lbl_ErrorMessage.TabIndex = 10;
            // 
            // btn_CalculatePeople
            // 
            this.btn_CalculatePeople.Location = new System.Drawing.Point(278, 260);
            this.btn_CalculatePeople.Name = "btn_CalculatePeople";
            this.btn_CalculatePeople.Size = new System.Drawing.Size(259, 33);
            this.btn_CalculatePeople.TabIndex = 11;
            this.btn_CalculatePeople.Text = "Calculate Maximum People";
            this.btn_CalculatePeople.UseVisualStyleBackColor = true;
            this.btn_CalculatePeople.Click += new System.EventHandler(this.btn_CalculatePeople_Click);
            // 
            // btn_Help
            // 
            this.btn_Help.Location = new System.Drawing.Point(578, 260);
            this.btn_Help.Name = "btn_Help";
            this.btn_Help.Size = new System.Drawing.Size(75, 33);
            this.btn_Help.TabIndex = 12;
            this.btn_Help.Text = "Help";
            this.btn_Help.UseVisualStyleBackColor = true;
            this.btn_Help.Click += new System.EventHandler(this.btn_Help_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(675, 260);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(75, 33);
            this.btn_Close.TabIndex = 13;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 336);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Help);
            this.Controls.Add(this.btn_CalculatePeople);
            this.Controls.Add(this.lbl_ErrorMessage);
            this.Controls.Add(this.cmbBox_BodyType);
            this.Controls.Add(this.lbl_BodyType);
            this.Controls.Add(this.grpBox_Units);
            this.Controls.Add(this.txtBox_Height);
            this.Controls.Add(this.lbl_Height);
            this.Controls.Add(this.txtBox_Width);
            this.Controls.Add(this.lbl_Width);
            this.Controls.Add(this.txtBox_Length);
            this.Controls.Add(this.lbl_Length);
            this.Controls.Add(this.picBox_TelephoneStuffing);
            this.Controls.Add(this.lbl_FormTitle);
            this.Name = "CalculatorForm";
            this.Load += new System.EventHandler(this.CalculatorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_TelephoneStuffing)).EndInit();
            this.grpBox_Units.ResumeLayout(false);
            this.grpBox_Units.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_FormTitle;
        private System.Windows.Forms.PictureBox picBox_TelephoneStuffing;
        private System.Windows.Forms.Label lbl_Length;
        private System.Windows.Forms.TextBox txtBox_Length;
        private System.Windows.Forms.TextBox txtBox_Width;
        private System.Windows.Forms.Label lbl_Width;
        private System.Windows.Forms.TextBox txtBox_Height;
        private System.Windows.Forms.Label lbl_Height;
        private System.Windows.Forms.GroupBox grpBox_Units;
        private System.Windows.Forms.RadioButton radBtn_Metric;
        private System.Windows.Forms.RadioButton radBtn_English;
        private System.Windows.Forms.Label lbl_BodyType;
        private System.Windows.Forms.ComboBox cmbBox_BodyType;
        private System.Windows.Forms.Label lbl_ErrorMessage;
        private System.Windows.Forms.Button btn_CalculatePeople;
        private System.Windows.Forms.Button btn_Help;
        private System.Windows.Forms.Button btn_Close;
    }
}

