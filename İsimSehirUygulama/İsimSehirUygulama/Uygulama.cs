using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İsimSehirUygulama
{
    public class Uygulama
    {

        string[] harfler = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "İ", "Ç", "J", "K", "L", "M", "N", "O", "Ö", "P", "R", "S", "Ş", "T", "U", "Ü", "V", "Y", "Z" };
        string[] isimler = new string[] { "Ali", "Ahmet", "Ayhan", "Ayşe", "Aynur", "Ayşenur", "Abdullah", "Açelya", "Adalet", "Adile", "Ahsen", "Ajda","Alev","Anıl","Arife","arzu","asena","asiye","aslı","aslıhan","asu","asude","asya","asuman","ayben","ayfer","aybike"
        ,"ayça","aydoğan","aygün","ayla","ayperi","aysel","aysu","aysun","ayşegül","ayten","azize","azra","abbas","abulaziz","abdulhamit"
        ,"abdulkerim","Abdurrahman","Abidin","Abuzer","adal","adil","ayhan","adnan","alp","alper","akif","akman","aktan","alaaddin","aladdin"
        ,"alican","alişan","alperen","altay","anıl","arda","arif","akif" };
        string[] bitkiler = new string[] { "Aynısefa", "Anason", "Aslan Pençesi", "Avokado", "Ayrık Otu", "Altın Otu", "Adaçayı", "Akdiken", "At Kuyruğu", "Ayçiçeği", "Ağaç Mantarı", "Arum", "Alman Süseni", "Avrupa Kayını", "Arı Otu", "Ayva", "Alıç" };
        string[] sehirler = new string[] { "Adıyaman", "Adana", "Afyonkarahisar", "Ankara", "Antalya", "Ağrı", "Aksaray", "Aydın", "Artvin", "Ardahan", "Amasya" };
        string[] hayvanlar = new string[] { "Aslan", "At", "Akrep", "Ayı", "Akbaba", "Arı", "Atmaca", "Ahtapot", "Ağaçkakan", "Ağustos Böceği", "Ateş Böceği", "Albartros", "Anakonda", "Antilop", "Ayı Balığı", "Alageyik", "Afgan Tazısı", "Alabalık", "Armadillo", "Anadolu Parsı" };
        string[] esyalar = new string[] { "Abajur", "Ampul", "Anten", "Ayakkabı", "Aspiratör", "Atkı", "Ayna", "Askı", "Ataç", "Abaküs" };


        İsim ism = new İsim();
        Sehirler shr = new Sehirler();
        Bitkiler btk = new Bitkiler();
        Esyalar esy = new Esyalar();
        Hayvanlar hyv = new Hayvanlar();
        IsimSehirOyun ıso = new IsimSehirOyun();
        
        
        public string Isim
        {
            get { return Isim; }
            set { Isim = value; }
        }
        public string Sehir
        {
            get { return Sehir; }
            set { Sehir = value; }
        }
        public string Hayvan
        {
            get { return Hayvan; }
            set { Hayvan = value; }
        }
        public string Esya
        {
            get { return Esya; }
            set { Esya = value; }
        }
        public string Bitki
        {
            get { return Bitki; }
            set { Bitki = value; }
        }
    }
}
