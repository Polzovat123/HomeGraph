
namespace Graphs
{
    partial class Form3
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
            this.button1 = new System.Windows.Forms.Button();
            this.tbOut1 = new System.Windows.Forms.TextBox();
            this.tbOut2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1137, 421);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tbOut1
            // 
            this.tbOut1.Location = new System.Drawing.Point(1137, 488);
            this.tbOut1.Name = "tbOut1";
            this.tbOut1.Size = new System.Drawing.Size(206, 22);
            this.tbOut1.TabIndex = 1;
            // 
            // tbOut2
            // 
            this.tbOut2.Location = new System.Drawing.Point(1137, 527);
            this.tbOut2.Name = "tbOut2";
            this.tbOut2.Size = new System.Drawing.Size(206, 22);
            this.tbOut2.TabIndex = 2;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1450, 625);
            this.Controls.Add(this.tbOut2);
            this.Controls.Add(this.tbOut1);
            this.Controls.Add(this.button1);
            this.Name = "Form3";
            this.Text = "Sablin Dmitry PRO227";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.Click += new System.EventHandler(this.Form2_Click_1);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form3_Paint);
            this.DoubleClick += new System.EventHandler(this.Form2_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbOut1;
        private System.Windows.Forms.TextBox tbOut2;
    }
}