namespace GUISensorer
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
            this.NyTemp_btn = new System.Windows.Forms.Button();
            this.NyTrykk_btn = new System.Windows.Forms.Button();
            this.NyMåling_btn = new System.Windows.Forms.Button();
            this.Slett_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.handling_list = new System.Windows.Forms.ListBox();
            this.btnLagre = new System.Windows.Forms.Button();
            this.btnLesFraFil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NyTemp_btn
            // 
            this.NyTemp_btn.Location = new System.Drawing.Point(26, 245);
            this.NyTemp_btn.Name = "NyTemp_btn";
            this.NyTemp_btn.Size = new System.Drawing.Size(183, 31);
            this.NyTemp_btn.TabIndex = 0;
            this.NyTemp_btn.Text = "Ny Temperaturmåler";
            this.NyTemp_btn.UseVisualStyleBackColor = true;
            this.NyTemp_btn.Click += new System.EventHandler(this.NyTemp_btn_Click);
            // 
            // NyTrykk_btn
            // 
            this.NyTrykk_btn.Location = new System.Drawing.Point(214, 245);
            this.NyTrykk_btn.Name = "NyTrykk_btn";
            this.NyTrykk_btn.Size = new System.Drawing.Size(159, 31);
            this.NyTrykk_btn.TabIndex = 1;
            this.NyTrykk_btn.Text = "Ny Trykkmåler";
            this.NyTrykk_btn.UseVisualStyleBackColor = true;
            this.NyTrykk_btn.Click += new System.EventHandler(this.NyTrykk_btn_Click);
            // 
            // NyMåling_btn
            // 
            this.NyMåling_btn.Location = new System.Drawing.Point(380, 245);
            this.NyMåling_btn.Name = "NyMåling_btn";
            this.NyMåling_btn.Size = new System.Drawing.Size(152, 31);
            this.NyMåling_btn.TabIndex = 2;
            this.NyMåling_btn.Text = "Ny Måling";
            this.NyMåling_btn.UseVisualStyleBackColor = true;
            this.NyMåling_btn.Click += new System.EventHandler(this.NyMåling_btn_Click);
            // 
            // Slett_btn
            // 
            this.Slett_btn.Location = new System.Drawing.Point(546, 245);
            this.Slett_btn.Name = "Slett_btn";
            this.Slett_btn.Size = new System.Drawing.Size(152, 31);
            this.Slett_btn.TabIndex = 3;
            this.Slett_btn.Text = "Slett sensor";
            this.Slett_btn.UseVisualStyleBackColor = true;
            this.Slett_btn.Click += new System.EventHandler(this.Slett_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Handling";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(26, 297);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(672, 28);
            this.comboBox1.TabIndex = 7;
            // 
            // handling_list
            // 
            this.handling_list.FormattingEnabled = true;
            this.handling_list.ItemHeight = 20;
            this.handling_list.Location = new System.Drawing.Point(28, 65);
            this.handling_list.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.handling_list.Name = "handling_list";
            this.handling_list.Size = new System.Drawing.Size(667, 144);
            this.handling_list.TabIndex = 8;
            // 
            // btnLagre
            // 
            this.btnLagre.Location = new System.Drawing.Point(241, 17);
            this.btnLagre.Name = "btnLagre";
            this.btnLagre.Size = new System.Drawing.Size(183, 31);
            this.btnLagre.TabIndex = 9;
            this.btnLagre.Text = "Lagre";
            this.btnLagre.UseVisualStyleBackColor = true;
            this.btnLagre.Click += new System.EventHandler(this.btnLagre_Click);
            // 
            // btnLesFraFil
            // 
            this.btnLesFraFil.Location = new System.Drawing.Point(458, 17);
            this.btnLesFraFil.Name = "btnLesFraFil";
            this.btnLesFraFil.Size = new System.Drawing.Size(159, 31);
            this.btnLesFraFil.TabIndex = 10;
            this.btnLesFraFil.Text = "Les frå fil";
            this.btnLesFraFil.UseVisualStyleBackColor = true;
            this.btnLesFraFil.Click += new System.EventHandler(this.btnLesFraFil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 405);
            this.Controls.Add(this.btnLesFraFil);
            this.Controls.Add(this.btnLagre);
            this.Controls.Add(this.handling_list);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Slett_btn);
            this.Controls.Add(this.NyMåling_btn);
            this.Controls.Add(this.NyTrykk_btn);
            this.Controls.Add(this.NyTemp_btn);
            this.Name = "Form1";
            this.Text = "GUI Sensorer";
            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NyTemp_btn;
        private System.Windows.Forms.Button NyTrykk_btn;
        private System.Windows.Forms.Button NyMåling_btn;
        private System.Windows.Forms.Button Slett_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox handling_list;
        private System.Windows.Forms.Button btnLagre;
        private System.Windows.Forms.Button btnLesFraFil;
    }
}

