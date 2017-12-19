namespace Vererbung
{
    class PKW : Fahrzeug
    {
        private int insassen;

        public void Einsteigen(int anzahl)
        {
            insassen += anzahl;
        }

        public override string ToString()
        {
            return "Insassen: " + insassen + "\n" + base.ToString();
        }
    }
}
