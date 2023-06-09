namespace _03_ExtensionMethodIleLinq
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] iller = new string[] { "Ankara", "Istanbul", "Izmir", "Antalya", "Konya", "Hatay", "Kahramanmaras", "Mugla" };

        private void btnTumunuListele_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.DataSource = iller;
        }

        private void btnAltidanFazlaOlanlar_Click(object sender, EventArgs e)
        {
            List<string> list = iller.Where(il => il.Length>6).ToList();

            listBox1.DataSource = null;
            listBox1.DataSource = list;
        }

        private void btnAdanZyeSirala_Click(object sender, EventArgs e)
        {
            List<string> list = iller
                                     .OrderBy(il => il)
                                     .Select(x=> x)
                                     .ToList();

            listBox1.DataSource = null;
            listBox1.DataSource = list;
        }

        private void btnZdenAyaSirala_Click(object sender, EventArgs e)
        {
            List<string> list = iller
                                     .OrderByDescending(il => il)
                                     .Select(x => x)
                                     .ToList();

            listBox1.DataSource = null;
            listBox1.DataSource = list;
        }

        private void btnAileBaslayanlar_Click(object sender, EventArgs e)
        {
            List<string> list = iller.Where(il => il.StartsWith("A")).ToList();

            listBox1.DataSource = null;
            listBox1.DataSource = list;
        }

        private void btnYaileBitenler_Click(object sender, EventArgs e)
        {
            //List<string> list = iller.Where(il => il.EndsWith("ya")).ToList();

            //listBox1.DataSource = null;
            //listBox1.DataSource = list;
            List<string> list = new List<string>();

            foreach (var il in iller)
            {
                 if( il.EndsWith("ya") )
                {
                    list.Add(il);   
                }
            }

            listBox1.DataSource = null;
            listBox1.DataSource = list;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }




    }
}