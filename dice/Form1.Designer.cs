namespace dice
{
    partial class Form1
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
            this.lbxdiceroll = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblcounter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbxdiceroll
            // 
            this.lbxdiceroll.Location = new System.Drawing.Point(466, 96);
            this.lbxdiceroll.Name = "lbxdiceroll";
            this.lbxdiceroll.Size = new System.Drawing.Size(176, 93);
            this.lbxdiceroll.TabIndex = 0;
            this.lbxdiceroll.Text = "roll the dice";
            this.lbxdiceroll.UseVisualStyleBackColor = true;
            this.lbxdiceroll.Click += new System.EventHandler(this.Lbxdiceroll_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(71, 96);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(309, 264);
            this.listBox1.TabIndex = 1;
            // 
            // lblcounter
            // 
            this.lblcounter.BackColor = System.Drawing.SystemColors.Info;
            this.lblcounter.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcounter.Location = new System.Drawing.Point(466, 213);
            this.lblcounter.Name = "lblcounter";
            this.lblcounter.Size = new System.Drawing.Size(146, 153);
            this.lblcounter.TabIndex = 2;
            this.lblcounter.Click += new System.EventHandler(this.Lblcounter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblcounter);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lbxdiceroll);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button lbxdiceroll;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblcounter;
    }
}

