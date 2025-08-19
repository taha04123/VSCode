namespace OBLIG5
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
            btnLoggPå = new Button();
            txtNavn = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnLoggPå
            // 
            btnLoggPå.Location = new Point(118, 118);
            btnLoggPå.Name = "btnLoggPå";
            btnLoggPå.Size = new Size(247, 39);
            btnLoggPå.TabIndex = 0;
            btnLoggPå.Text = "Logg På";
            btnLoggPå.UseVisualStyleBackColor = true;
            btnLoggPå.Click += btnLoggPå_Click;
            // 
            // txtNavn
            // 
            txtNavn.Location = new Point(75, 42);
            txtNavn.Name = "txtNavn";
            txtNavn.Size = new Size(358, 31);
            txtNavn.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 42);
            label1.Name = "label1";
            label1.Size = new Size(57, 25);
            label1.TabIndex = 2;
            label1.Text = "Navn:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 198);
            Controls.Add(label1);
            Controls.Add(txtNavn);
            Controls.Add(btnLoggPå);
            Name = "Form1";
            Text = "Innlogging";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLoggPå;
        private TextBox txtNavn;
        private Label label1;
    }
}
