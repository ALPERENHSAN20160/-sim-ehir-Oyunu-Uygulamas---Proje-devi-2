namespace İsimSehirUygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] harfler = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "İ", "Ç", "J", "K", "L", "M", "N", "O", "Ö", "P", "R", "S", "Ş", "T", "U", "Ü", "V", "Y", "Z" };
        string[] isimler = new string[] { "Ali", "Ahmet", "Ayhan", "Ayşe", "Aynur", "Ayşenur", "Abdullah", "Açelya", "Adalet", "Adile", "Ahsen", "Ajda","Alev","Anıl","Arife","arzu","asena","asiye","aslı","aslıhan","asu","asude","asya","asuman","ayben","ayfer","aybike"
        ,"ayça","aydoğan","aygün","ayla","ayperi","aysel","aysu","aysun","ayşegül","ayten","azize","azra","abbas","abulaziz","abdulhamit"
        ,"abdulkerim","Abdurrahman","Abidin","Abuzer","adal","adil","ayhan","adnan","alp","alper","akif","akman","aktan","alaaddin","aladdin"
        ,"alican","alişan","alperen","altay","anıl","arda","arif","akif" };
        string[] bitkiler = new string[] { "Aynısefa", "Anason", "Aslan Pençesi", "Avokado", "Ayrık Otu", "Altın Otu", "Adaçayı", "Akdiken", "At Kuyruğu", "Ayçiçeği", "Ağaç Mantarı", "Arum", "Alman Süseni", "Avrupa Kayını", "Arı Otu", "Ayva", "Alıç" };
        string[] sehirler = new string[] { "Adıyaman", "Adana", "Afyonkarahisar", "Ankara", "Antalya", "Ağrı", "Aksaray", "Aydın", "Artvin", "Ardahan", "Amasya" };
        string[] hayvanlar = new string[] { "Aslan", "At", "Akrep", "Ayı", "Akbaba", "Arı", "Atmaca", "Ahtapot", "Ağaçkakan", "Ağustos Böceği", "Ateş Böceği", "Albartros", "Anakonda", "Antilop", "Ayı Balığı", "Alageyik", "Afgan Tazısı", "Alabalık", "Armadillo", "Anadolu Parsı" };
        string[] esyalar = new string[] { "Abajur", "Ampul", "Anten", "Ayakkabı", "Aspiratör", "Atkı", "Ayna", "Askı", "Ataç", "Abaküs" };
        int saniye = 0;

        Uygulama uyg = new Uygulama();
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnBasla_Click(object sender, EventArgs e)
        {
            if (LblHarf.Text.Length > 0)
            {
                timer1.Enabled = true;
                timer1.Start();
            }
            else
            {
                MessageBox.Show("Harf seçilmedi");
            }
        }

        private void BtnHarfAl_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int sayi = rnd.Next(harfler.Count());
            LblHarf.Text = harfler[sayi];
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye++;
            PnlBolum.Enabled = true;
            LblZaman.Text = "Zaman : " + saniye.ToString();
            if (saniye == 120)
            {
                timer1.Enabled = false;
                PnlBolum.Enabled = false;
                LblHarf.Text = "";
                saniye = 0;
                MessageBox.Show("Zaman Bitti!");
            }
        }

        private void BtnKontrolEt_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                if (LblHarf.Text.Length > 0)
                {
                    timer1.Enabled = false;
                    PnlBolum.Enabled = false;

                    string harf = LblHarf.Text;
                    int kontrol = 0;
                    int puan = 0;



                    if (harf == "A")
                    {
                        if (isimler.Contains(TxtIsım.Text)) { kontrol = 2; puan += 10; };
                    }
                    else
                    {
                        if (TxtIsım.Text.ToUpper().Substring(0, 1) == harf && TxtIsım.Text.Length >= 2) { kontrol = 1; puan += 10; }
                    }


                    if (TxtSehir.Text.ToUpper().Substring(0, 1) == harf && TxtSehir.Text.Length >= 3) { kontrol = 2; puan += 10; }
                    if (TxtHayvan.Text.ToUpper().Substring(0, 1) == harf && TxtHayvan.Text.Length >= 2) { kontrol = 3; puan += 10; }
                    if (TxtBitki.Text.ToUpper().Substring(0, 1) == harf && TxtBitki.Text.Length >= 3) { kontrol = 4; puan += 10; }
                    if (TxtEsya.Text.ToUpper().Substring(0, 1) == harf && TxtEsya.Text.Length >= 3) { kontrol = 5; puan += 10; }



                    if (kontrol == 5)
                    {
                        MessageBox.Show("Tebrikler!. :) Hepsi Doğru" + Environment.NewLine + "Puanınız: " + puan.ToString());
                    }
                    else
                    {
                        MessageBox.Show("Üzgünüm. :( Hepsi doğru değildi." + Environment.NewLine + "Puanınız: " + puan.ToString());
                    }
                    LblPuan.Text = "Puan : " + puan.ToString();
                }
                else
                {
                    MessageBox.Show("Harf seçilmedi");
                }
            }
            else
            {
                MessageBox.Show("Zamanı başlatmadınız.");
            }
        }
    }
}