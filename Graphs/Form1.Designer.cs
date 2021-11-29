
namespace Graphs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnRGR = new System.Windows.Forms.Button();
            this.btnLAB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(536, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(329, 99);
            this.button1.TabIndex = 2;
            this.button1.Text = "DFS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(460, 97);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(476, 22);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Программа";
            // 
            // btnRGR
            // 
            this.btnRGR.Location = new System.Drawing.Point(536, 353);
            this.btnRGR.Name = "btnRGR";
            this.btnRGR.Size = new System.Drawing.Size(329, 97);
            this.btnRGR.TabIndex = 4;
            this.btnRGR.Text = "RGR";
            this.btnRGR.UseVisualStyleBackColor = true;
            this.btnRGR.Click += new System.EventHandler(this.btnRGR_Click);
            // 
            // btnLAB
            // 
            this.btnLAB.Location = new System.Drawing.Point(536, 474);
            this.btnLAB.Name = "btnLAB";
            this.btnLAB.Size = new System.Drawing.Size(329, 99);
            this.btnLAB.TabIndex = 5;
            this.btnLAB.Text = "Laboratory";
            this.btnLAB.UseVisualStyleBackColor = true;
            this.btnLAB.Click += new System.EventHandler(this.btnLAB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1453, 678);
            this.Controls.Add(this.btnLAB);
            this.Controls.Add(this.btnRGR);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "York\'s Graph";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnRGR;
        private System.Windows.Forms.Button btnLAB;
    }
}

