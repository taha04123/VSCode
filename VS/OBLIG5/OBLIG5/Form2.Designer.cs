namespace OBLIG5
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
            label1 = new Label();
            txtBeløp = new TextBox();
            label2 = new Label();
            lblSaldo = new Label();
            btnSettInn = new Button();
            btnTaUt = new Button();
            btnLoggUt = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 28);
            label1.Name = "label1";
            label1.Size = new Size(61, 25);
            label1.TabIndex = 4;
            label1.Text = "Beløp:";
            // 
            // txtBeløp
            // 
            txtBeløp.Location = new Point(84, 28);
            txtBeløp.Name = "txtBeløp";
            txtBeløp.Size = new Size(358, 31);
            txtBeløp.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 157);
            label2.Name = "label2";
            label2.Size = new Size(61, 25);
            label2.TabIndex = 6;
            label2.Text = "Saldo:";
            // 
            // lblSaldo
            // 
            lblSaldo.BackColor = SystemColors.ControlLightLight;
            lblSaldo.BorderStyle = BorderStyle.Fixed3D;
            lblSaldo.Location = new Point(84, 157);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(358, 25);
            lblSaldo.TabIndex = 7;
            lblSaldo.Click += lblSaldo_Click;
            // 
            // btnSettInn
            // 
            btnSettInn.Location = new Point(84, 99);
            btnSettInn.Name = "btnSettInn";
            btnSettInn.Size = new Size(148, 39);
            btnSettInn.TabIndex = 8;
            btnSettInn.Text = "Sett inn penger";
            btnSettInn.UseVisualStyleBackColor = true;
            btnSettInn.Click += btnSettInn_Click;
            // 
            // btnTaUt
            // 
            btnTaUt.Location = new Point(305, 99);
            btnTaUt.Name = "btnTaUt";
            btnTaUt.Size = new Size(137, 39);
            btnTaUt.TabIndex = 9;
            btnTaUt.Text = "Ta ut penger";
            btnTaUt.UseVisualStyleBackColor = true;
            btnTaUt.Click += btnTaUt_Click;
            // 
            // btnLoggUt
            // 
            btnLoggUt.Location = new Point(477, 28);
            btnLoggUt.Name = "btnLoggUt";
            btnLoggUt.Size = new Size(128, 31);
            btnLoggUt.TabIndex = 10;
            btnLoggUt.Text = "Logg Ut";
            btnLoggUt.UseVisualStyleBackColor = true;
            btnLoggUt.Click += btnLoggUt_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(617, 209);
            Controls.Add(btnLoggUt);
            Controls.Add(btnTaUt);
            Controls.Add(btnSettInn);
            Controls.Add(lblSaldo);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtBeløp);
            Name = "Form2";
            Text = "Bankapplikasjon";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtBeløp;
        private Label label2;
        private Label lblSaldo;
        private Button btnSettInn;
        private Button btnTaUt;
        private Button btnLoggUt;
    }
}