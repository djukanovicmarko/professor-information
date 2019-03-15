namespace WindowsFormsApplication1
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
            this.Imelabela = new System.Windows.Forms.Label();
            this.Prezimelabela = new System.Windows.Forms.Label();
            this.Zvanjelabela = new System.Windows.Forms.Label();
            this.Datumlabela = new System.Windows.Forms.Label();
            this.Pollabela = new System.Windows.Forms.Label();
            this.Imetxt = new System.Windows.Forms.TextBox();
            this.Prezimetxt = new System.Windows.Forms.TextBox();
            this.Zvanjetxt = new System.Windows.Forms.ComboBox();
            this.Datum = new System.Windows.Forms.DateTimePicker();
            this.Potvrdibtn = new System.Windows.Forms.Button();
            this.RbMuski = new System.Windows.Forms.RadioButton();
            this.RbZenski = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // Imelabela
            // 
            this.Imelabela.AutoSize = true;
            this.Imelabela.Location = new System.Drawing.Point(30, 22);
            this.Imelabela.Name = "Imelabela";
            this.Imelabela.Size = new System.Drawing.Size(24, 13);
            this.Imelabela.TabIndex = 0;
            this.Imelabela.Text = "Ime";
            // 
            // Prezimelabela
            // 
            this.Prezimelabela.AutoSize = true;
            this.Prezimelabela.Location = new System.Drawing.Point(30, 60);
            this.Prezimelabela.Name = "Prezimelabela";
            this.Prezimelabela.Size = new System.Drawing.Size(44, 13);
            this.Prezimelabela.TabIndex = 1;
            this.Prezimelabela.Text = "Prezime";
            // 
            // Zvanjelabela
            // 
            this.Zvanjelabela.AutoSize = true;
            this.Zvanjelabela.Location = new System.Drawing.Point(30, 98);
            this.Zvanjelabela.Name = "Zvanjelabela";
            this.Zvanjelabela.Size = new System.Drawing.Size(40, 13);
            this.Zvanjelabela.TabIndex = 2;
            this.Zvanjelabela.Text = "Zvanje";
            // 
            // Datumlabela
            // 
            this.Datumlabela.AutoSize = true;
            this.Datumlabela.Location = new System.Drawing.Point(30, 137);
            this.Datumlabela.Name = "Datumlabela";
            this.Datumlabela.Size = new System.Drawing.Size(78, 13);
            this.Datumlabela.TabIndex = 3;
            this.Datumlabela.Text = "Datum rodjenja";
            // 
            // Pollabela
            // 
            this.Pollabela.AutoSize = true;
            this.Pollabela.Location = new System.Drawing.Point(30, 175);
            this.Pollabela.Name = "Pollabela";
            this.Pollabela.Size = new System.Drawing.Size(22, 13);
            this.Pollabela.TabIndex = 4;
            this.Pollabela.Text = "Pol";
            // 
            // Imetxt
            // 
            this.Imetxt.Location = new System.Drawing.Point(129, 19);
            this.Imetxt.Name = "Imetxt";
            this.Imetxt.Size = new System.Drawing.Size(121, 20);
            this.Imetxt.TabIndex = 5;
            // 
            // Prezimetxt
            // 
            this.Prezimetxt.Location = new System.Drawing.Point(129, 57);
            this.Prezimetxt.Name = "Prezimetxt";
            this.Prezimetxt.Size = new System.Drawing.Size(121, 20);
            this.Prezimetxt.TabIndex = 6;
            // 
            // Zvanjetxt
            // 
            this.Zvanjetxt.FormattingEnabled = true;
            this.Zvanjetxt.Location = new System.Drawing.Point(129, 90);
            this.Zvanjetxt.Name = "Zvanjetxt";
            this.Zvanjetxt.Size = new System.Drawing.Size(121, 21);
            this.Zvanjetxt.TabIndex = 7;
            // 
            // Datum
            // 
            this.Datum.CustomFormat = "dd/MM/yyyy";
            this.Datum.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Datum.Location = new System.Drawing.Point(129, 130);
            this.Datum.Name = "Datum";
            this.Datum.Size = new System.Drawing.Size(121, 20);
            this.Datum.TabIndex = 8;
            // 
            // Potvrdibtn
            // 
            this.Potvrdibtn.Location = new System.Drawing.Point(108, 227);
            this.Potvrdibtn.Name = "Potvrdibtn";
            this.Potvrdibtn.Size = new System.Drawing.Size(75, 23);
            this.Potvrdibtn.TabIndex = 11;
            this.Potvrdibtn.Text = "Potvrdi";
            this.Potvrdibtn.UseVisualStyleBackColor = true;
            this.Potvrdibtn.Click += new System.EventHandler(this.Potvrdibtn_Click);
            // 
            // RbMuski
            // 
            this.RbMuski.AutoSize = true;
            this.RbMuski.Checked = true;
            this.RbMuski.Location = new System.Drawing.Point(129, 171);
            this.RbMuski.Name = "RbMuski";
            this.RbMuski.Size = new System.Drawing.Size(53, 17);
            this.RbMuski.TabIndex = 12;
            this.RbMuski.TabStop = true;
            this.RbMuski.Text = "Muski";
            this.RbMuski.UseVisualStyleBackColor = true;
            // 
            // RbZenski
            // 
            this.RbZenski.AutoSize = true;
            this.RbZenski.Location = new System.Drawing.Point(129, 195);
            this.RbZenski.Name = "RbZenski";
            this.RbZenski.Size = new System.Drawing.Size(57, 17);
            this.RbZenski.TabIndex = 13;
            this.RbZenski.Text = "Zenski";
            this.RbZenski.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.RbZenski);
            this.Controls.Add(this.RbMuski);
            this.Controls.Add(this.Potvrdibtn);
            this.Controls.Add(this.Datum);
            this.Controls.Add(this.Zvanjetxt);
            this.Controls.Add(this.Prezimetxt);
            this.Controls.Add(this.Imetxt);
            this.Controls.Add(this.Pollabela);
            this.Controls.Add(this.Datumlabela);
            this.Controls.Add(this.Zvanjelabela);
            this.Controls.Add(this.Prezimelabela);
            this.Controls.Add(this.Imelabela);
            this.Name = "Form1";
            this.Text = "Podaci o profesoru";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Imelabela;
        private System.Windows.Forms.Label Prezimelabela;
        private System.Windows.Forms.Label Zvanjelabela;
        private System.Windows.Forms.Label Datumlabela;
        private System.Windows.Forms.Label Pollabela;
        private System.Windows.Forms.TextBox Imetxt;
        private System.Windows.Forms.TextBox Prezimetxt;
        private System.Windows.Forms.ComboBox Zvanjetxt;
        private System.Windows.Forms.DateTimePicker Datum;
        private System.Windows.Forms.Button Potvrdibtn;
        private System.Windows.Forms.RadioButton RbMuski;
        private System.Windows.Forms.RadioButton RbZenski;
    }
}

