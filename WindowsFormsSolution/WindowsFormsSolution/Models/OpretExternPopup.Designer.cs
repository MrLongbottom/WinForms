namespace WindowsFormsSolution.Models
{
    partial class OpretExternPopup
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
            this.OpretEksternLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CreateExternNameBox = new System.Windows.Forms.TextBox();
            this.CreatExternEmailBox = new System.Windows.Forms.TextBox();
            this.CreatExternEmailLabel = new System.Windows.Forms.Label();
            this.CreateExternTLFBOx = new System.Windows.Forms.TextBox();
            this.OpretEksternTLFLabel = new System.Windows.Forms.Label();
            this.CreateExternCancelButtom = new System.Windows.Forms.Button();
            this.CreateExternCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OpretEksternLabel
            // 
            this.OpretEksternLabel.AutoSize = true;
            this.OpretEksternLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpretEksternLabel.Location = new System.Drawing.Point(13, 13);
            this.OpretEksternLabel.Name = "OpretEksternLabel";
            this.OpretEksternLabel.Size = new System.Drawing.Size(168, 29);
            this.OpretEksternLabel.TabIndex = 0;
            this.OpretEksternLabel.Text = "Opret Ekstern";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Navn";
            // 
            // CreateExternNameBox
            // 
            this.CreateExternNameBox.Location = new System.Drawing.Point(18, 81);
            this.CreateExternNameBox.Name = "CreateExternNameBox";
            this.CreateExternNameBox.Size = new System.Drawing.Size(285, 22);
            this.CreateExternNameBox.TabIndex = 2;
            // 
            // CreatExternEmailBox
            // 
            this.CreatExternEmailBox.Location = new System.Drawing.Point(18, 129);
            this.CreatExternEmailBox.Name = "CreatExternEmailBox";
            this.CreatExternEmailBox.Size = new System.Drawing.Size(285, 22);
            this.CreatExternEmailBox.TabIndex = 4;
            // 
            // CreatExternEmailLabel
            // 
            this.CreatExternEmailLabel.AutoSize = true;
            this.CreatExternEmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreatExternEmailLabel.Location = new System.Drawing.Point(14, 106);
            this.CreatExternEmailLabel.Name = "CreatExternEmailLabel";
            this.CreatExternEmailLabel.Size = new System.Drawing.Size(57, 20);
            this.CreatExternEmailLabel.TabIndex = 3;
            this.CreatExternEmailLabel.Text = "E-mail";
            // 
            // CreateExternTLFBOx
            // 
            this.CreateExternTLFBOx.Location = new System.Drawing.Point(18, 177);
            this.CreateExternTLFBOx.Name = "CreateExternTLFBOx";
            this.CreateExternTLFBOx.Size = new System.Drawing.Size(285, 22);
            this.CreateExternTLFBOx.TabIndex = 6;
            // 
            // OpretEksternTLFLabel
            // 
            this.OpretEksternTLFLabel.AutoSize = true;
            this.OpretEksternTLFLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpretEksternTLFLabel.Location = new System.Drawing.Point(14, 154);
            this.OpretEksternTLFLabel.Name = "OpretEksternTLFLabel";
            this.OpretEksternTLFLabel.Size = new System.Drawing.Size(51, 20);
            this.OpretEksternTLFLabel.TabIndex = 5;
            this.OpretEksternTLFLabel.Text = "tlf. nr.";
            // 
            // CreateExternCancelButtom
            // 
            this.CreateExternCancelButtom.Location = new System.Drawing.Point(18, 220);
            this.CreateExternCancelButtom.Name = "CreateExternCancelButtom";
            this.CreateExternCancelButtom.Size = new System.Drawing.Size(109, 39);
            this.CreateExternCancelButtom.TabIndex = 7;
            this.CreateExternCancelButtom.Text = "Annullere";
            this.CreateExternCancelButtom.UseVisualStyleBackColor = true;
            this.CreateExternCancelButtom.Click += new System.EventHandler(this.CreateExternCancelButtom_Click);
            // 
            // CreateExternCreate
            // 
            this.CreateExternCreate.Location = new System.Drawing.Point(198, 220);
            this.CreateExternCreate.Name = "CreateExternCreate";
            this.CreateExternCreate.Size = new System.Drawing.Size(105, 39);
            this.CreateExternCreate.TabIndex = 8;
            this.CreateExternCreate.Text = "Opret";
            this.CreateExternCreate.UseVisualStyleBackColor = true;
            this.CreateExternCreate.Click += new System.EventHandler(this.CreateExternCreate_Click);
            // 
            // OpretExternPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 271);
            this.Controls.Add(this.CreateExternCreate);
            this.Controls.Add(this.CreateExternCancelButtom);
            this.Controls.Add(this.CreateExternTLFBOx);
            this.Controls.Add(this.OpretEksternTLFLabel);
            this.Controls.Add(this.CreatExternEmailBox);
            this.Controls.Add(this.CreatExternEmailLabel);
            this.Controls.Add(this.CreateExternNameBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OpretEksternLabel);
            this.Name = "OpretExternPopup";
            this.Text = "OpretExternPopup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OpretEksternLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CreateExternNameBox;
        private System.Windows.Forms.TextBox CreatExternEmailBox;
        private System.Windows.Forms.Label CreatExternEmailLabel;
        private System.Windows.Forms.TextBox CreateExternTLFBOx;
        private System.Windows.Forms.Label OpretEksternTLFLabel;
        private System.Windows.Forms.Button CreateExternCancelButtom;
        private System.Windows.Forms.Button CreateExternCreate;
    }
}