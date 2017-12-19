using System.ComponentModel;

namespace DllErstellen
{
    public partial class Fahrzeug : Component
    {
        public Fahrzeug()
        {
            InitializeComponent();
        }

        public Fahrzeug(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        private int geschwindigkeit;

        public void Beschleunigen(int wert)
        {
            geschwindigkeit += wert;

        }
        public override string ToString()
        {
            return "Geschwindigkeit: " + geschwindigkeit;
        }
    }
}
