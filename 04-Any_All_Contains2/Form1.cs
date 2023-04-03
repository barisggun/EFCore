using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace _04_Any_All_Contains2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        string[] iller = new string[] { "Ankara", "Istanbul", "Izmir", "Antalya", "Konya", "Hatay", "Kahramanmaras", "Mugla" };

        List<Personel> personeller = new List<Personel>()
        {
            new Personel(){PersonelId=1, Adi="Baris",Yas=24},
            new Personel(){PersonelId=2, Adi="Irem",Yas=24},
            new Personel(){PersonelId=3, Adi="Muhammed",Yas=35},
            new Personel(){PersonelId=4, Adi="Aykut",Yas=23},
            new Personel(){PersonelId=5, Adi="Umut",Yas=22},
        };


        private void Form1_Load(object sender, EventArgs e)
        {
            // Any() = listenin içerisindeki verdiðimiz koþullara uyan herhangi bir kayýt varsa true, yoksa false deðer döndürür.

            // All() = elimizdeki listenin içerisinde belirlediðimizþarta tüm kayýtlar uyuyor mu? Uyarsa true, uymazsa false

            //Contains() = elimizdeki listenin içerisinde belli þarta uyan kayýt var mý diye bakýyor. True ya da false deðer döndürür.
        }

        private void btn18buyuk30kucuk_Click(object sender, EventArgs e)
        {
            MessageBox.Show(personeller.All(x => x.Yas > 18 && x.Yas < 30).ToString());
        }

        private void btn18buyuk40kucuk_Click(object sender, EventArgs e)
        {
            MessageBox.Show(personeller.All(x => x.Yas > 18 && x.Yas < 40).ToString());
        }

        private void btn18buyuk20denkucuk_Click(object sender, EventArgs e)
        {
            MessageBox.Show(personeller.Any(x => x.Yas > 18 && x.Yas < 20).ToString());
        }

        private void btn18denbuyuk30dankucuk_Click(object sender, EventArgs e)
        {
            MessageBox.Show(personeller.Any(x => x.Yas > 18 && x.Yas < 30).ToString());
        }

        private void btnIsmiAnkara_Click(object sender, EventArgs e)
        {
            MessageBox.Show(iller.Contains("Ankara").ToString());

        }

        private void btnIsmiAykutOlan_Click(object sender, EventArgs e)
        {
            //CONTAINS kullanýlsaydý: Düzgün çalýþmaz her zaman false döner. Not: Contains metodu sadece basit veri tipleri için kullanýlýr. 

            MessageBox.Show(personeller.Any(x => x.Adi == "Aykut").ToString());
        }
    }
}

public class Personel
{
    public int PersonelId { get; set; }
    public string Adi { get; set; }
    public int Yas { get; set; }
}