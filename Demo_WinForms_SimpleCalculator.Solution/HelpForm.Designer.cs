namespace Demo_WinForms_SimpleCalculator
{
    partial class HelpForm
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
            this.lvl_Directions = new System.Windows.Forms.Label();
            this.lbl_Directions = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvl_Directions
            // 
            this.lvl_Directions.AutoSize = true;
            this.lvl_Directions.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvl_Directions.Location = new System.Drawing.Point(12, 9);
            this.lvl_Directions.Name = "lvl_Directions";
            this.lvl_Directions.Size = new System.Drawing.Size(136, 31);
            this.lvl_Directions.TabIndex = 0;
            this.lvl_Directions.Text = "Directions";
            // 
            // lbl_Directions
            // 
            this.lbl_Directions.AutoSize = true;
            this.lbl_Directions.Location = new System.Drawing.Point(24, 66);
            this.lbl_Directions.MaximumSize = new System.Drawing.Size(400, 0);
            this.lbl_Directions.Name = "lbl_Directions";
            this.lbl_Directions.Size = new System.Drawing.Size(0, 17);
            this.lbl_Directions.TabIndex = 1;
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(18, 183);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(75, 33);
            this.btn_Close.TabIndex = 14;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 228);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.lbl_Directions);
            this.Controls.Add(this.lvl_Directions);
            this.Name = "HelpForm";
            this.Text = "Help";
            this.Load += new System.EventHandler(this.HelpForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lvl_Directions;
        private System.Windows.Forms.Label lbl_Directions;
        private System.Windows.Forms.Button btn_Close;
    }
}