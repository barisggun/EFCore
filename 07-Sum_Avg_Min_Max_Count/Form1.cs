namespace _07_Sum_Avg_Min_Max_Count
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

        }
    }
}

public class Personel
{
    public int PersonelId { get; set; }
    public string Adi { get; set; }
    public int Yas { get; set; }
}