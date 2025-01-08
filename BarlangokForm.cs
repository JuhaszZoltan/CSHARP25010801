using System.Text;

namespace CSHARP25010801
{
    public partial class BarlangokForm : Form
    {
        public List<Barlang> barlangok = [];

        public BarlangokForm()
        {
            InitializeComponent();
            this.Load += BarlangokFormLoad;
            btnKereses.Click += BtnKeresesClick;
        }

        private void BtnKeresesClick(object? sender, EventArgs e)
        {
            Barlang barlang = barlangok
                .Single(b => b.Azon == int.Parse(tbAzonosito.Text));

            lblBarlangNeve.Text = barlang.Nev;
            tbHosszusag.Text = $"{barlang.Hossz}";
            tbMelyseg.Text = $"{barlang.Melyseg}";
        }

        private void BarlangokFormLoad(object? sender, EventArgs e)
        {
            using StreamReader sr = new("C:\\Users\\juhaszz\\source\\repos\\CSHARP25010801\\src\\barlangok.txt", Encoding.UTF8);
            _ = sr.ReadLine();
            while (!sr.EndOfStream) barlangok.Add(new(sr.ReadLine()));
        }
    }
}
