using System;
using System.Drawing;
using System.Windows.Forms;

namespace Listenansicht
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LView.View = View.Details;
            LView.FullRowSelect = true;

            ListViewItem eintrag1 = new ListViewItem("Berlin.txt", 0);
            eintrag1.SubItems.Add("120 KB");
            eintrag1.SubItems.Add("13.07.2017");
            LView.Items.Add(eintrag1);

            ListViewItem eintrag2 = new ListViewItem("Paris.txt", 1);
            eintrag2.SubItems.Add("130 KB");
            eintrag2.SubItems.Add("05.07.2017");
            LView.Items.Add(eintrag2);

            ListViewItem eintrag3 = new ListViewItem("Rom.txt", 2);
            eintrag3.SubItems.Add("100 KB");
            eintrag3.SubItems.Add("24.07.2017");
            LView.Items.Add(eintrag3);

            LView.Columns.Add("Name", 100);
            LView.Columns.Add("Größe", 100);
            LView.Columns.Add("Datum", 100);

            ImageList bildklein = new ImageList();
            bildklein.Images.Add(Image.FromFile("bild0.bmp"));
            bildklein.Images.Add(Image.FromFile("bild1.bmp"));
            bildklein.Images.Add(Image.FromFile("bild2.bmp"));
            LView.SmallImageList = bildklein;
            LView.LargeImageList = bildklein;
        }

        private void OptView_CheckedChanged(object sender, EventArgs e)
        {
            if (OptDetails.Checked)
                LView.View = View.Details;
            else if (OptLargeIcon.Checked)
                LView.View = View.LargeIcon;
            else if (OptList.Checked)
                LView.View = View.List;
            else if (OptSmallIcon.Checked)
                LView.View = View.SmallIcon;
            else if (OptTile.Checked)
                LView.View = View.Tile;
        }
    }
}
