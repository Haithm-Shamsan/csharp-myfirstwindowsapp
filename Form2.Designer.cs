namespace MyFirstWindowsApp
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
            this.Button = new System.Windows.Forms.Button();
            this.BoxMassageForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Button
            // 
            this.Button.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button.Location = new System.Drawing.Point(118, 137);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(208, 118);
            this.Button.TabIndex = 0;
            this.Button.Text = "btnShow";
            this.Button.UseVisualStyleBackColor = true;
            this.Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // BoxMassageForm
            // 
            this.BoxMassageForm.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxMassageForm.Location = new System.Drawing.Point(486, 137);
            this.BoxMassageForm.Name = "BoxMassageForm";
            this.BoxMassageForm.Size = new System.Drawing.Size(208, 118);
            this.BoxMassageForm.TabIndex = 1;
            this.BoxMassageForm.Text = "BoxMassageForm";
            this.BoxMassageForm.UseVisualStyleBackColor = true;
            this.BoxMassageForm.Click += new System.EventHandler(this.BoxMassageForm_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BoxMassageForm);
            this.Controls.Add(this.Button);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Button;
        private System.Windows.Forms.Button BoxMassageForm;
    }
}