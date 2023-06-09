namespace _02_LinqSorgu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] iller = new string[] {"Ankara","Istanbul","Izmir","Antalya","Konya","Hatay","Kahramanmaras","Mugla" };

        private void btnTumunuListele_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.DataSource = iller;

        }

        private void btnAltidanFazlaOlanlar_Click(object sender, EventArgs e)
        {
            IEnumerable<string> list = from il in iller
                                       where il.Length > 6
                                       select il;

            listBox1.DataSource = null;
            listBox1.DataSource = list.ToList();

        }

        private void btnAdanZyeSirala_Click(object sender, EventArgs e)
        {
            IEnumerable<string> list = from il in iller
                                       orderby il ascending
                                       select il;

            listBox1.DataSource = null;
            listBox1.DataSource = list.ToList();
        }

        private void btnZdenAyaSirala_Click(object sender, EventArgs e)
        {
            IEnumerable<string> list = from il in iller
                                       orderby il descending
                                       select il;

            listBox1.DataSource = null;
            listBox1.DataSource = list.ToList();
        }

        private void btnAileBaslayanlar_Click(object sender, EventArgs e)
        {
            IEnumerable<string> list = from il in iller
                                       where il.StartsWith("A")
                                       select il;


            listBox1.DataSource = null;
            listBox1.DataSource = list.ToList();
        }

        private void btnYaileBitenler_Click(object sender, EventArgs e)
        {
            IEnumerable<string> list = from il in iller
                                       where il.EndsWith("ya")
                                       select il;


            listBox1.DataSource = null;
            listBox1.DataSource = list.ToList();
        }
    }
}