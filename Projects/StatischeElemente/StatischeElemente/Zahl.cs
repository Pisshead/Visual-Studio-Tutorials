namespace StatischeElemente
{
    class Zahl
    {
        private double wert;
        private int nummer;
        private static int anzahl = 0;
        public static double pi = 3.1415926;

        public Zahl(double x)
        {
            anzahl += 1;
            nummer = anzahl;
            wert = x;
        }

        public void MalDrei()
        {
            wert = wert * 3;
        }

        public static double Verdoppeln(double x)
        {
            return x * 2;
        }

        public override string ToString()
        {
            return "Objekt Nr. " + nummer + ", Wert: " + wert;
        }
    }
}
