
namespace Graphs
{
    partial class Form2
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
            this.tbAnsQue = new System.Windows.Forms.TextBox();
            this.tBxStartVerticle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button1.Location = new System.Drawing.Point(923, 458);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(446, 122);
            this.button1.TabIndex = 0;
            this.button1.Text = "Get graph";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbAnsQue
            // 
            this.tbAnsQue.Location = new System.Drawing.Point(923, 634);
            this.tbAnsQue.Name = "tbAnsQue";
            this.tbAnsQue.Size = new System.Drawing.Size(446, 26);
            this.tbAnsQue.TabIndex = 1;
            // 
            // tBxStartVerticle
            // 
            this.tBxStartVerticle.Location = new System.Drawing.Point(1076, 602);
            this.tBxStartVerticle.Name = "tBxStartVerticle";
            this.tBxStartVerticle.Size = new System.Drawing.Size(100, 26);
            this.tBxStartVerticle.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(923, 602);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Write start verticle:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 753);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBxStartVerticle);
            this.Controls.Add(this.tbAnsQue);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Click += new System.EventHandler(this.Form2_Click_1);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form2_Paint);
            this.DoubleClick += new System.EventHandler(this.Form2_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbAnsQue;
        private System.Windows.Forms.TextBox tBxStartVerticle;
        private System.Windows.Forms.Label label1;
    }
}