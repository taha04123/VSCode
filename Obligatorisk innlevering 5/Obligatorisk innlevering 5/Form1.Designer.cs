namespace Obligatorisk_innlevering_5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNavn = new TextBox();
            btnRegistrering = new Button();
            SuspendLayout();
            // 
            // txtNavn
            // 
            txtNavn.Location = new Point(70, 66);
            txtNavn.Name = "txtNavn";
            txtNavn.Size = new Size(246, 31);
            txtNavn.TabIndex = 0;
            // 
            // btnRegistrering
            // 
            btnRegistrering.Location = new Point(106, 129);
            btnRegistrering.Name = "btnRegistrering";
            btnRegistrering.Size = new Size(159, 49);
            btnRegistrering.TabIndex = 1;
            btnRegistrering.Text = "Logg på";
            btnRegistrering.UseVisualStyleBackColor = true;
            btnRegistrering.Click += btnRegistrering_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(385, 231);
            Controls.Add(btnRegistrering);
            Controls.Add(txtNavn);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNavn;
        private Button btnRegistrering;
    }
}
