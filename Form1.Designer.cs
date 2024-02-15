namespace nr_prim
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
            this.checkbutton = new System.Windows.Forms.Button();
            this.primenumbertextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // checkbutton
            // 
            this.checkbutton.Location = new System.Drawing.Point(283, 237);
            this.checkbutton.Name = "checkbutton";
            this.checkbutton.Size = new System.Drawing.Size(239, 98);
            this.checkbutton.TabIndex = 0;
            this.checkbutton.Text = "check";
            this.checkbutton.UseVisualStyleBackColor = true;
            this.checkbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // primenumbertextbox
            // 
            this.primenumbertextbox.Location = new System.Drawing.Point(232, 160);
            this.primenumbertextbox.Name = "primenumbertextbox";
            this.primenumbertextbox.Size = new System.Drawing.Size(335, 22);
            this.primenumbertextbox.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.primenumbertextbox);
            this.Controls.Add(this.checkbutton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button checkbutton;
        private System.Windows.Forms.TextBox primenumbertextbox;
    }
}

