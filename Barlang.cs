namespace CSHARP25010801;

public class Barlang
{
    public int Azon { get; set; }
    public string Nev { get; set; }
    public int Hossz { get; set; }
    public int Melyseg { get; set; }
    public string Telepules { get; set; }
    public string Vedettseg { get; set; }

    public Barlang(string sor)
    {
        string[] tmp = sor.Split(';');

        Azon = int.Parse(tmp[0]);
        Nev = tmp[1];
        Hossz = int.Parse(tmp[2]);
        Melyseg = int.Parse(tmp[3]);
        Telepules = tmp[4];
        Vedettseg = tmp[5];
    }
}
