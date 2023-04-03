namespace _05_First_Single_Last
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Personel> personeller = new List<Personel>()
        {
            new Personel(){PersonelId=1, Adi="Baris",Yas=24},
            new Personel(){PersonelId=2, Adi="Irem",Yas=24},
            new Personel(){PersonelId=3, Adi="Muhammed",Yas=35},
            new Personel(){PersonelId=4, Adi="Aykut",Yas=23},
            new Personel(){PersonelId=5, Adi="Umut",Yas=22},
        };

        List<Personel> personelBos = new List<Personel>();


        List<Personel> personelTek = new List<Personel>()
        {
            new Personel(){PersonelId=1, Adi="�zg�r",Yas=38},
        };

        private void Form1_Load(object sender, EventArgs e)
        {
            //First() : Elimizdeki listenin i�inideki ilk eleman� d�ner. E�er eleman yoksa hata f�rlat�r.

            //FirstOrDefault() : Elimizdeki listenin i�indeki ilk eleman� d�ner. Ama eleman yoksa hata f�rlatmaz eleman�n varsay�lan de�erleriyle bir nesne d�ner.

            //Single() : Elimizdeki listenin i�erisinde 1 tane eleman var m� yok mu diye bakar, bir tane varsa o eleman� geriye d�ner. Yoksa veya birden fazlaysa  hata verir. 

            //SingleOrDefault() : Elimizdeki listenin i�erisinde 1 tane eleman var m� yok mu diye bakar, bir tane varsa o eleman� geriye d�ner yoksa hata vermez. varsay�lan de�eri d�ner. ama birden fazla kay�t varsa yine hata f�rlat�r.

            //Last() : Elimizdeki listenin i�inideki son eleman� d�ner. E�er eleman yoksa hata f�rlat�r.

            //LastOrDefault() : Elimizdeki listenin i�indeki son eleman� d�ner. Ama eleman yoksa hata f�rlatmaz eleman�n varsay�lan de�erleriyle bir nesne d�ner.

        }

        


        //FIRST
        private void btnFirst_Click(object sender, EventArgs e)
        {
            Personel personel = personeller.First(x=> x.Yas>25 && x.Adi=="Ahmet"); //hata d�necek
            MessageBox.Show(personel.Adi);
        }

        private void btnFirstOrDefault_Click(object sender, EventArgs e)
        {
            Personel personel = personeller.FirstOrDefault();
            MessageBox.Show(personel.Adi);
        }

        private void btnFirstBos_Click(object sender, EventArgs e)
        {
            Personel personel = personelBos.First();
            MessageBox.Show(personel.Adi);
        }

        private void btnFirstOrDefaultBos_Click(object sender, EventArgs e)
        {
            Personel personel = personelBos.FirstOrDefault();
            MessageBox.Show(personel.Adi);
        }

        //LAST
        private void btnLast_Click(object sender, EventArgs e)
        {
            Personel personel = personeller.Last();

        }

        private void btnLastOrDefault_Click(object sender, EventArgs e)
        {
            Personel personel = personeller.LastOrDefault();

        }

        private void btnLastBos_Click(object sender, EventArgs e)
        {
            Personel personel = personelBos.Last();
        }

        private void btnLastOrDefaultBos_Click(object sender, EventArgs e)
        {
            Personel personel = personelBos.LastOrDefault();
        }


        //SINGLE
        private void btnSingle_Click(object sender, EventArgs e)
        {
            Personel personel = personeller.Single();
        }

        private void btnSingleOrDefault_Click(object sender, EventArgs e)
        {
            Personel personel = personeller.SingleOrDefault();
        }


        private void btnSingleBos_Click(object sender, EventArgs e)
        {

        }

        private void btnSingleOrDefault_Click(object sender, EventArgs e)
        {

        }

       
    }

      


}


public class Personel
{
    public int PersonelId { get; set; }
    public string Adi { get; set; }
    public int Yas { get; set; }
}