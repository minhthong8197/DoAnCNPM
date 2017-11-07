namespace DoAnCNPM.LopGiaoDien
{
    partial class FormCover
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnChange = new System.Windows.Forms.Button();
            this.plnChange = new System.Windows.Forms.Panel();
            this.plnChange.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnChange.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnChange.FlatAppearance.BorderSize = 0;
            this.btnChange.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.btnChange.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChange.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnChange.Location = new System.Drawing.Point(930, 0);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(90, 40);
            this.btnChange.TabIndex = 1;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = false;
            // 
            // plnChange
            // 
            this.plnChange.BackColor = System.Drawing.Color.Transparent;
            this.plnChange.Controls.Add(this.btnChange);
            this.plnChange.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.plnChange.Location = new System.Drawing.Point(0, 640);
            this.plnChange.Margin = new System.Windows.Forms.Padding(7);
            this.plnChange.Name = "plnChange";
            this.plnChange.Size = new System.Drawing.Size(1020, 40);
            this.plnChange.TabIndex = 2;
            // 
            // FormCover
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DoAnCNPM.Properties.Resources.CTXH;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.plnChange);
            this.Name = "FormCover";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 8, 8);
            this.Size = new System.Drawing.Size(1028, 688);
            this.plnChange.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Panel plnChange;
    }
}
