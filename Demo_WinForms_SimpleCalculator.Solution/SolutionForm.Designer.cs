namespace Demo_WinForms_SimpleCalculator
{
    partial class form_Solution
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
            this.picBox_Body = new System.Windows.Forms.PictureBox();
            this.lbl_FormTitle = new System.Windows.Forms.Label();
            this.lbl_NumberOfPeople = new System.Windows.Forms.Label();
            this.lbl_BodyType = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Body)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox_Body
            // 
            this.picBox_Body.Location = new System.Drawing.Point(12, 12);
            this.picBox_Body.Name = "picBox_Body";
            this.picBox_Body.Size = new System.Drawing.Size(138, 212);
            this.picBox_Body.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_Body.TabIndex = 0;
            this.picBox_Body.TabStop = false;
            // 
            // lbl_FormTitle
            // 
            this.lbl_FormTitle.AutoSize = true;
            this.lbl_FormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FormTitle.Location = new System.Drawing.Point(172, 12);
            this.lbl_FormTitle.Name = "lbl_FormTitle";
            this.lbl_FormTitle.Size = new System.Drawing.Size(231, 31);
            this.lbl_FormTitle.TabIndex = 1;
            this.lbl_FormTitle.Text = "Number of People";
            // 
            // lbl_NumberOfPeople
            // 
            this.lbl_NumberOfPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NumberOfPeople.Location = new System.Drawing.Point(207, 60);
            this.lbl_NumberOfPeople.Name = "lbl_NumberOfPeople";
            this.lbl_NumberOfPeople.Size = new System.Drawing.Size(160, 69);
            this.lbl_NumberOfPeople.TabIndex = 2;
            this.lbl_NumberOfPeople.Text = "NOP";
            this.lbl_NumberOfPeople.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_BodyType
            // 
            this.lbl_BodyType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BodyType.Location = new System.Drawing.Point(207, 129);
            this.lbl_BodyType.Name = "lbl_BodyType";
            this.lbl_BodyType.Size = new System.Drawing.Size(160, 33);
            this.lbl_BodyType.TabIndex = 3;
            this.lbl_BodyType.Text = "Body Type";
            this.lbl_BodyType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(332, 189);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(75, 35);
            this.btn_Close.TabIndex = 4;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // form_Solution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 236);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.lbl_BodyType);
            this.Controls.Add(this.lbl_NumberOfPeople);
            this.Controls.Add(this.lbl_FormTitle);
            this.Controls.Add(this.picBox_Body);
            this.Name = "form_Solution";
            this.Load += new System.EventHandler(this.form_Solution_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Body)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox_Body;
        private System.Windows.Forms.Label lbl_FormTitle;
        private System.Windows.Forms.Label lbl_NumberOfPeople;
        private System.Windows.Forms.Label lbl_BodyType;
        private System.Windows.Forms.Button btn_Close;
    }
}