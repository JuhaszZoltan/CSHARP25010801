using System.Text;

namespace CSHARP25010801
{
    public partial class BarlangokForm : Form
    {
        public List<Barlang> barlangok = [];
        private int sectedIndex = -1;

        public BarlangokForm()
        {
            InitializeComponent();
            this.Load += BarlangokFormLoad;
            btnKereses.Click += BtnKeresesClick;
            btnMentes.Click += BtnMentesClick;
        }

        private void BtnMentesClick(object sender, EventArgs e)
        {
            bool joHossz = barlangok[sectedIndex].Hossz <= int.Parse(tbHosszusag.Text);
            bool joMelyseg = barlangok[sectedIndex].Melyseg <= int.Parse(tbMelyseg.Text);
            bool joIndex = sectedIndex != -1;

            if (joIndex && joMelyseg && joHossz)
            {
                barlangok[sectedIndex].Hossz = int.Parse(tbHosszusag.Text);
                barlangok[sectedIndex].Melyseg = int.Parse(tbMelyseg.Text);
            }
            else if (barlangok[sectedIndex].Hossz > int.Parse(tbHosszusag.Text))
            {
                _ = MessageBox.Show(
                    "A hossz nem lehet kisebb a korábbi értéknél!");
            }
            else if (barlangok[sectedIndex].Melyseg > int.Parse(tbMelyseg.Text))
            {
                _ = MessageBox.Show(
                    "A mélység nem lehet kisebb a korábbi értéknél"!);
            }

            Visszaallitas();

        }

        private void BtnKeresesClick(object? sender, EventArgs e)
        {
            Barlang barlang = barlangok
                .SingleOrDefault(b => b.Azon == int.Parse(tbAzonosito.Text));
            if (barlang is null)
            {
                _ = MessageBox.Show(
                    "Ezzel az azonosítóval nem létezik barlang");

                Visszaallitas();
            }
            else
            {
                sectedIndex = barlangok.IndexOf(barlang);

                lblBarlangNeve.Text = barlang.Nev;
                tbHosszusag.Text = $"{barlang.Hossz}";
                tbMelyseg.Text = $"{barlang.Melyseg}";

                btnMentes.Enabled = true;
            }
        }

        private void BarlangokFormLoad(object? sender, EventArgs e)
        {
            using StreamReader sr = new("C:\\Users\\juhaszz\\source\\repos\\CSHARP25010801\\src\\barlangok.txt", Encoding.UTF8);
            _ = sr.ReadLine();
            while (!sr.EndOfStream) barlangok.Add(new(sr.ReadLine()));
        }

        private void Visszaallitas()
        {
            tbAzonosito.Text = string.Empty;
            lblBarlangNeve.Text = string.Empty;
            tbHosszusag.Text = string.Empty;
            tbMelyseg.Text = string.Empty;
            sectedIndex = -1;
            btnMentes.Enabled = false;
        }
    }
}
