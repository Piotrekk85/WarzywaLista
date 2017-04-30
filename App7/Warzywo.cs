namespace App7
{
    class Warzywo
    {
        public string Nazwa { get; set; }
        public double Waga { get; set; }
        public int IdObrazka { get; set; }

        public Warzywo(string nazwa, double waga, int id)
        {
            this.Nazwa = nazwa;
            this.Waga = waga;
            this.IdObrazka = id;
        }
    
    }
}