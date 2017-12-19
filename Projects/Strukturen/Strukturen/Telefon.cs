namespace Strukturen
{
    struct Telefon
    {
        public string vorwahl;
        public int nummer;

        public Telefon(string v, int n)
        {
            vorwahl = v;
            nummer = n;
        }

        public override string ToString()
        {
            return vorwahl + "-" + nummer;
        }
    }
}
