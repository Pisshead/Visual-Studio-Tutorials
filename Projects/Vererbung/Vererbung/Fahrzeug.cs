namespace Vererbung
{
    class Fahrzeug
    {
        private int geschwindigkeit;

        public void Beschleunigen(int wert)
        {
            geschwindigkeit += wert;
        }

        public override string ToString()
        {
            return "Geschwindigkeit: " + geschwindigkeit + "\n";
        }
    }
}
