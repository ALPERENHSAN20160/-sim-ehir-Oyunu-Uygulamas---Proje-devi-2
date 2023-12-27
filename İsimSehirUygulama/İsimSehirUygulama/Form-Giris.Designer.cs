namespace İsimSehirUygulama
{
    partial class Form_Giris
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
            BtnGiris = new Button();
            SuspendLayout();
            // 
            // BtnGiris
            // 
            BtnGiris.BackColor = Color.Gainsboro;
            BtnGiris.Location = new Point(107, 89);
            BtnGiris.Margin = new Padding(4);
            BtnGiris.Name = "BtnGiris";
            BtnGiris.Size = new Size(276, 69);
            BtnGiris.TabIndex = 0;
            BtnGiris.Text = "Lütfen Oyuna Giriş Yapın.";
            BtnGiris.UseVisualStyleBackColor = false;
            BtnGiris.Click += BtnGiris_Click;
            // 
            // Form_Giris
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(508, 263);
            Controls.Add(BtnGiris);
            Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form_Giris";
            Text = "Giriş";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnGiris;
    }
}