namespace WindowsFormsSolution.Models.Classes
{
    partial class SubmeetingPopup
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
            this.label1 = new System.Windows.Forms.Label();
            this.HovedpunktcomboBox = new System.Windows.Forms.ComboBox();
            this.HovedpunktLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UnderpunktrichTextBox1 = new System.Windows.Forms.RichTextBox();
            this.CreateButtom = new System.Windows.Forms.Button();
            this.AnnullereButtom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(221, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tilføj Underpunkt";
            // 
            // HovedpunktcomboBox
            // 
            this.HovedpunktcomboBox.FormattingEnabled = true;
            this.HovedpunktcomboBox.Location = new System.Drawing.Point(17, 122);
            this.HovedpunktcomboBox.Name = "HovedpunktcomboBox";
            this.HovedpunktcomboBox.Size = new System.Drawing.Size(636, 24);
            this.HovedpunktcomboBox.TabIndex = 1;
            // 
            // HovedpunktLabel
            // 
            this.HovedpunktLabel.AutoSize = true;
            this.HovedpunktLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HovedpunktLabel.Location = new System.Drawing.Point(15, 94);
            this.HovedpunktLabel.Name = "HovedpunktLabel";
            this.HovedpunktLabel.Size = new System.Drawing.Size(123, 25);
            this.HovedpunktLabel.TabIndex = 2;
            this.HovedpunktLabel.Text = "Hovedpunkt:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Underpunkt:";
            // 
            // UnderpunktrichTextBox1
            // 
            this.UnderpunktrichTextBox1.Location = new System.Drawing.Point(17, 187);
            this.UnderpunktrichTextBox1.Name = "UnderpunktrichTextBox1";
            this.UnderpunktrichTextBox1.Size = new System.Drawing.Size(631, 191);
            this.UnderpunktrichTextBox1.TabIndex = 5;
            this.UnderpunktrichTextBox1.Text = "";
            // 
            // CreateButtom
            // 
            this.CreateButtom.Location = new System.Drawing.Point(345, 410);
            this.CreateButtom.Name = "CreateButtom";
            this.CreateButtom.Size = new System.Drawing.Size(119, 48);
            this.CreateButtom.TabIndex = 8;
            this.CreateButtom.Text = "Tilføj";
            this.CreateButtom.UseVisualStyleBackColor = true;
            this.CreateButtom.Click += new System.EventHandler(this.button2_Click);
            // 
            // AnnullereButtom
            // 
            this.AnnullereButtom.Location = new System.Drawing.Point(217, 410);
            this.AnnullereButtom.Name = "AnnullereButtom";
            this.AnnullereButtom.Size = new System.Drawing.Size(100, 48);
            this.AnnullereButtom.TabIndex = 9;
            this.AnnullereButtom.Text = "Annullere";
            this.AnnullereButtom.UseVisualStyleBackColor = true;
            this.AnnullereButtom.Click += new System.EventHandler(this.AnnullereButtom_Click);
            // 
            // SubmeetingPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 470);
            this.Controls.Add(this.AnnullereButtom);
            this.Controls.Add(this.CreateButtom);
            this.Controls.Add(this.UnderpunktrichTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.HovedpunktLabel);
            this.Controls.Add(this.HovedpunktcomboBox);
            this.Controls.Add(this.label1);
            this.Name = "SubmeetingPopup";
            this.Text = "SubmeetingPopup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox HovedpunktcomboBox;
        private System.Windows.Forms.Label HovedpunktLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox UnderpunktrichTextBox1;
        private System.Windows.Forms.Button CreateButtom;
        private System.Windows.Forms.Button AnnullereButtom;
    }
}