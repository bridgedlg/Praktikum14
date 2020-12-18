
namespace Praktikum14
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
            this.labelinput = new System.Windows.Forms.Label();
            this.textboxinput = new System.Windows.Forms.TextBox();
            this.buttonreverse = new System.Windows.Forms.Button();
            this.buttonu = new System.Windows.Forms.Button();
            this.labeloutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelinput
            // 
            this.labelinput.AutoSize = true;
            this.labelinput.Location = new System.Drawing.Point(33, 62);
            this.labelinput.Name = "labelinput";
            this.labelinput.Size = new System.Drawing.Size(46, 20);
            this.labelinput.TabIndex = 0;
            this.labelinput.Text = "Input";
            this.labelinput.Click += new System.EventHandler(this.label1_Click);
            // 
            // textboxinput
            // 
            this.textboxinput.Location = new System.Drawing.Point(37, 97);
            this.textboxinput.Name = "textboxinput";
            this.textboxinput.Size = new System.Drawing.Size(255, 26);
            this.textboxinput.TabIndex = 1;
            // 
            // buttonreverse
            // 
            this.buttonreverse.Location = new System.Drawing.Point(37, 163);
            this.buttonreverse.Name = "buttonreverse";
            this.buttonreverse.Size = new System.Drawing.Size(98, 38);
            this.buttonreverse.TabIndex = 2;
            this.buttonreverse.Text = "Reverse";
            this.buttonreverse.UseVisualStyleBackColor = true;
            this.buttonreverse.Click += new System.EventHandler(this.buttonreverse_Click);
            // 
            // buttonu
            // 
            this.buttonu.Location = new System.Drawing.Point(191, 163);
            this.buttonu.Name = "buttonu";
            this.buttonu.Size = new System.Drawing.Size(101, 38);
            this.buttonu.TabIndex = 3;
            this.buttonu.Text = "Urutkan";
            this.buttonu.UseVisualStyleBackColor = true;
            this.buttonu.Click += new System.EventHandler(this.button2_Click);
            // 
            // labeloutput
            // 
            this.labeloutput.AutoSize = true;
            this.labeloutput.Location = new System.Drawing.Point(33, 253);
            this.labeloutput.Name = "labeloutput";
            this.labeloutput.Size = new System.Drawing.Size(58, 20);
            this.labeloutput.TabIndex = 4;
            this.labeloutput.Text = "Output";
            this.labeloutput.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labeloutput);
            this.Controls.Add(this.buttonu);
            this.Controls.Add(this.buttonreverse);
            this.Controls.Add(this.textboxinput);
            this.Controls.Add(this.labelinput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelinput;
        private System.Windows.Forms.TextBox textboxinput;
        private System.Windows.Forms.Button buttonreverse;
        private System.Windows.Forms.Button buttonu;
        private System.Windows.Forms.Label labeloutput;
    }
}

