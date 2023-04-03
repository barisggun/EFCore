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
            new Personel(){PersonelId=1, Adi="Özgür",Yas=38},
        };

        private void Form1_Load(object sender, EventArgs e)
        {
            //First() : Elimizdeki listenin içinideki ilk elemaný döner. Eðer eleman yoksa hata fýrlatýr.

            //FirstOrDefault() : Elimizdeki listenin içindeki ilk elemaný döner. Ama eleman yoksa hata fýrlatmaz elemanýn varsayýlan deðerleriyle bir nesne döner.

            //Single() : Elimizdeki listenin içerisinde 1 tane eleman var mý yok mu diye bakar, bir tane varsa o elemaný geriye döner. Yoksa veya birden fazlaysa  hata verir. 

            //SingleOrDefault() : Elimizdeki listenin içerisinde 1 tane eleman var mý yok mu diye bakar, bir tane varsa o elemaný geriye döner yoksa hata vermez. varsayýlan deðeri döner. ama birden fazla kayýt varsa yine hata fýrlatýr.

            //Last() : Elimizdeki listenin içinideki son elemaný döner. Eðer eleman yoksa hata fýrlatýr.

            //LastOrDefault() : Elimizdeki listenin içindeki son elemaný döner. Ama eleman yoksa hata fýrlatmaz elemanýn varsayýlan deðerleriyle bir nesne döner.

        }

        


        //FIRST
        private void btnFirst_Click(object sender, EventArgs e)
        {
            Personel personel = personeller.First(x=> x.Yas>25 && x.Adi=="Ahmet"); //hata dönecek
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