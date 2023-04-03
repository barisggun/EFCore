using System.Windows.Forms;

namespace _06_Take_Skip_Distinct
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


        private void Form1_Load(object sender, EventArgs e)
        {
            //Take() : SQLdeki top keyword�ne kar��l�k gelir. Yani elimizdeki listenin i�erisindeki ilk n kayd� geriye d�ner. (ilk 5 ilk 10 vb)

            //Skip() :Elimizdeki listenin i�indeki ilk n kayd� atlar ve sonrakileri geriye d�ner.

            //Distinct() : Yinelenen sat�rlar� kald�rarak tekil olarak liste halinde geriye d�ner.

            //
        }

        private void btnTumunuGetir_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = personeller;

        }

        private void btnIlkIk�KaydiGetir_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = personeller.Take(2).ToList();
        }

        private void btnIlkIk�KaydiAtlaSonrakiIkiKaydiGetir_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = personeller.Skip(2).Take(2).ToList();    
        }

        private void btnPersonelIsimleriniTekilOlarakGetir_Click(object sender, EventArgs e)
        {
            List<string> list = personeller.Select(x => x.Adi).Distinct().ToList();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = list;

            string isimler = string.Join(" , ", list);
            MessageBox.Show(isimler);


        }
    }

}


public class Personel
{
    public int PersonelId { get; set; }
    public string Adi { get; set; }
    public int Yas { get; set; }
}