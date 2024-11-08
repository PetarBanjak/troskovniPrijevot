namespace Troškovnik_prijevoza
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
            cBx_Zaposlenik = new ComboBox();
            mC_Kalendar = new MonthCalendar();
            Izracunaj = new Button();
            txb_Udaljenost = new TextBox();
            txb_Troskovnik = new TextBox();
            txb_CijenaKm = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // cBx_Zaposlenik
            // 
            cBx_Zaposlenik.FormattingEnabled = true;
            cBx_Zaposlenik.Location = new Point(62, 43);
            cBx_Zaposlenik.Margin = new Padding(3, 2, 3, 2);
            cBx_Zaposlenik.Name = "cBx_Zaposlenik";
            cBx_Zaposlenik.Size = new Size(133, 23);
            cBx_Zaposlenik.TabIndex = 0;
            cBx_Zaposlenik.SelectedIndexChanged += cBx_Zaposlenik_SelectedIndexChanged;
            cBx_Zaposlenik.Format += Full_Name;
            // 
            // mC_Kalendar
            // 
            mC_Kalendar.Location = new Point(62, 118);
            mC_Kalendar.Margin = new Padding(8, 7, 8, 7);
            mC_Kalendar.MaxSelectionCount = 1000;
            mC_Kalendar.Name = "mC_Kalendar";
            mC_Kalendar.TabIndex = 1;
            mC_Kalendar.DateSelected += mC_Kalendar_DateSelected;
            // 
            // Izracunaj
            // 
            Izracunaj.Location = new Point(81, 316);
            Izracunaj.Margin = new Padding(3, 2, 3, 2);
            Izracunaj.Name = "Izracunaj";
            Izracunaj.Size = new Size(186, 38);
            Izracunaj.TabIndex = 2;
            Izracunaj.Text = "Izračunaj";
            Izracunaj.UseVisualStyleBackColor = true;
            Izracunaj.Click += Izracunaj_Click;
            // 
            // txb_Udaljenost
            // 
            txb_Udaljenost.Location = new Point(408, 44);
            txb_Udaljenost.Margin = new Padding(3, 2, 3, 2);
            txb_Udaljenost.Name = "txb_Udaljenost";
            txb_Udaljenost.Size = new Size(154, 23);
            txb_Udaljenost.TabIndex = 3;
            // 
            // txb_Troskovnik
            // 
            txb_Troskovnik.Location = new Point(408, 219);
            txb_Troskovnik.Margin = new Padding(3, 2, 3, 2);
            txb_Troskovnik.Multiline = true;
            txb_Troskovnik.Name = "txb_Troskovnik";
            txb_Troskovnik.Size = new Size(211, 143);
            txb_Troskovnik.TabIndex = 4;
            // 
            // txb_CijenaKm
            // 
            txb_CijenaKm.Location = new Point(408, 144);
            txb_CijenaKm.Margin = new Padding(3, 2, 3, 2);
            txb_CijenaKm.Name = "txb_CijenaKm";
            txb_CijenaKm.Size = new Size(154, 23);
            txb_CijenaKm.TabIndex = 5;
            txb_CijenaKm.Text = "1€ ";
            txb_CijenaKm.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 15);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 6;
            label1.Text = "Zaposlenik:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 87);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 7;
            label2.Text = "Radni dani:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(408, 15);
            label3.Name = "label3";
            label3.Size = new Size(138, 15);
            label3.TabIndex = 8;
            label3.Text = "Udaljenost (jedan smjer):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(408, 118);
            label4.Name = "label4";
            label4.Size = new Size(80, 15);
            label4.TabIndex = 9;
            label4.Text = "Cijena po km:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(408, 202);
            label5.Name = "label5";
            label5.Size = new Size(66, 15);
            label5.TabIndex = 10;
            label5.Text = "Troškovnik:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(816, 415);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txb_CijenaKm);
            Controls.Add(txb_Troskovnik);
            Controls.Add(txb_Udaljenost);
            Controls.Add(Izracunaj);
            Controls.Add(mC_Kalendar);
            Controls.Add(cBx_Zaposlenik);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cBx_Zaposlenik;
        private MonthCalendar mC_Kalendar;
        private Button Izracunaj;
        private TextBox txb_Udaljenost;
        private TextBox txb_Troskovnik;
        private TextBox txb_CijenaKm;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}