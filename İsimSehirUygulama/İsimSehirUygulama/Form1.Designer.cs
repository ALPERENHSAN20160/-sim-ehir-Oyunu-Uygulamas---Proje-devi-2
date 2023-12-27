namespace İsimSehirUygulama
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
            components = new System.ComponentModel.Container();
            BtnHarfAl = new Button();
            BtnBasla = new Button();
            BtnKontrolEt = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            PnlBolum = new Panel();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            TxtEsya = new TextBox();
            TxtBitki = new TextBox();
            TxtHayvan = new TextBox();
            TxtSehir = new TextBox();
            TxtIsım = new TextBox();
            label1 = new Label();
            LblHarf = new Label();
            label3 = new Label();
            LblZaman = new Label();
            label5 = new Label();
            LblPuan = new Label();
            PnlBolum.SuspendLayout();
            SuspendLayout();
            // 
            // BtnHarfAl
            // 
            BtnHarfAl.BackColor = Color.Gainsboro;
            BtnHarfAl.Location = new Point(20, 61);
            BtnHarfAl.Name = "BtnHarfAl";
            BtnHarfAl.Size = new Size(145, 53);
            BtnHarfAl.TabIndex = 0;
            BtnHarfAl.Text = "Harf Ver";
            BtnHarfAl.UseVisualStyleBackColor = false;
            BtnHarfAl.Click += BtnHarfAl_Click;
            // 
            // BtnBasla
            // 
            BtnBasla.BackColor = Color.Gainsboro;
            BtnBasla.Location = new Point(352, 61);
            BtnBasla.Name = "BtnBasla";
            BtnBasla.Size = new Size(152, 53);
            BtnBasla.TabIndex = 1;
            BtnBasla.Text = "Başla";
            BtnBasla.UseVisualStyleBackColor = false;
            BtnBasla.Click += BtnBasla_Click;
            // 
            // BtnKontrolEt
            // 
            BtnKontrolEt.BackColor = Color.Gainsboro;
            BtnKontrolEt.Location = new Point(825, 324);
            BtnKontrolEt.Name = "BtnKontrolEt";
            BtnKontrolEt.Size = new Size(176, 100);
            BtnKontrolEt.TabIndex = 2;
            BtnKontrolEt.Text = "Kontrol Et";
            BtnKontrolEt.UseVisualStyleBackColor = false;
            BtnKontrolEt.Click += BtnKontrolEt_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // PnlBolum
            // 
            PnlBolum.Controls.Add(label11);
            PnlBolum.Controls.Add(label10);
            PnlBolum.Controls.Add(label9);
            PnlBolum.Controls.Add(label8);
            PnlBolum.Controls.Add(label7);
            PnlBolum.Controls.Add(TxtEsya);
            PnlBolum.Controls.Add(TxtBitki);
            PnlBolum.Controls.Add(TxtHayvan);
            PnlBolum.Controls.Add(TxtSehir);
            PnlBolum.Controls.Add(TxtIsım);
            PnlBolum.Location = new Point(20, 188);
            PnlBolum.Name = "PnlBolum";
            PnlBolum.Size = new Size(781, 236);
            PnlBolum.TabIndex = 3;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(622, 66);
            label11.Name = "label11";
            label11.Size = new Size(93, 30);
            label11.TabIndex = 11;
            label11.Text = "Eşya(10)";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(470, 66);
            label10.Name = "label10";
            label10.Size = new Size(92, 30);
            label10.TabIndex = 10;
            label10.Text = "Bitki(10)";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(318, 66);
            label9.Name = "label9";
            label9.Size = new Size(123, 30);
            label9.TabIndex = 9;
            label9.Text = "Hayvan(10)";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(166, 66);
            label8.Name = "label8";
            label8.Size = new Size(100, 30);
            label8.TabIndex = 8;
            label8.Text = "Şehir(10)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(14, 66);
            label7.Name = "label7";
            label7.Size = new Size(90, 30);
            label7.TabIndex = 7;
            label7.Text = "İsim(10)";
            // 
            // TxtEsya
            // 
            TxtEsya.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TxtEsya.Location = new Point(623, 111);
            TxtEsya.Name = "TxtEsya";
            TxtEsya.Size = new Size(146, 31);
            TxtEsya.TabIndex = 4;
            // 
            // TxtBitki
            // 
            TxtBitki.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TxtBitki.Location = new Point(471, 111);
            TxtBitki.Name = "TxtBitki";
            TxtBitki.Size = new Size(146, 31);
            TxtBitki.TabIndex = 3;
            // 
            // TxtHayvan
            // 
            TxtHayvan.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TxtHayvan.Location = new Point(319, 111);
            TxtHayvan.Name = "TxtHayvan";
            TxtHayvan.Size = new Size(146, 31);
            TxtHayvan.TabIndex = 2;
            // 
            // TxtSehir
            // 
            TxtSehir.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TxtSehir.Location = new Point(167, 111);
            TxtSehir.Name = "TxtSehir";
            TxtSehir.Size = new Size(146, 31);
            TxtSehir.TabIndex = 1;
            // 
            // TxtIsım
            // 
            TxtIsım.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TxtIsım.Location = new Point(14, 111);
            TxtIsım.Name = "TxtIsım";
            TxtIsım.Size = new Size(146, 31);
            TxtIsım.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(185, 71);
            label1.Name = "label1";
            label1.Size = new Size(64, 32);
            label1.TabIndex = 4;
            label1.Text = "Harf:";
            // 
            // LblHarf
            // 
            LblHarf.AutoSize = true;
            LblHarf.Location = new Point(255, 71);
            LblHarf.Name = "LblHarf";
            LblHarf.Size = new Size(29, 32);
            LblHarf.TabIndex = 5;
            LblHarf.Text = "A";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(516, 71);
            label3.Name = "label3";
            label3.Size = new Size(92, 32);
            label3.TabIndex = 6;
            label3.Text = "Zaman:";
            // 
            // LblZaman
            // 
            LblZaman.AutoSize = true;
            LblZaman.Location = new Point(609, 71);
            LblZaman.Name = "LblZaman";
            LblZaman.Size = new Size(27, 32);
            LblZaman.TabIndex = 7;
            LblZaman.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(825, 71);
            label5.Name = "label5";
            label5.Size = new Size(72, 32);
            label5.TabIndex = 5;
            label5.Text = "Puan:";
            // 
            // LblPuan
            // 
            LblPuan.AutoSize = true;
            LblPuan.Location = new Point(892, 71);
            LblPuan.Name = "LblPuan";
            LblPuan.Size = new Size(27, 32);
            LblPuan.TabIndex = 6;
            LblPuan.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(1013, 554);
            Controls.Add(LblZaman);
            Controls.Add(label3);
            Controls.Add(LblHarf);
            Controls.Add(LblPuan);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(PnlBolum);
            Controls.Add(BtnKontrolEt);
            Controls.Add(BtnBasla);
            Controls.Add(BtnHarfAl);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "İsim Şehir Uygulaması";
            Load += Form1_Load;
            PnlBolum.ResumeLayout(false);
            PnlBolum.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnHarfAl;
        private Button BtnBasla;
        private Button BtnKontrolEt;
        private System.Windows.Forms.Timer timer1;
        private Panel PnlBolum;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label LblPuan;
        private Label label5;
        private TextBox TxtEsya;
        private TextBox TxtBitki;
        private TextBox TxtHayvan;
        private TextBox TxtSehir;
        private TextBox TxtIsım;
        private Label label1;
        private Label LblHarf;
        private Label label3;
        private Label LblZaman;
        private Label label11;
        private Label label10;
    }
}