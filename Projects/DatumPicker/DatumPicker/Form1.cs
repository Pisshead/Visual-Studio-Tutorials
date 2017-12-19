using System;
using System.Windows.Forms;

namespace DatumPicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DatPicker1.MinDate = new DateTime(2016, 12, 15);
            DatPicker1.MaxDate = new DateTime(2017, 2, 15);
            DatPicker1.Value = new DateTime(2017, 1, 15);

            DatPicker2.CustomFormat = "dd.MM.yy";
            DatPicker2.Format = DateTimePickerFormat.Custom;

            DatPicker3.ShowUpDown = true;
            DatPicker3.Format = DateTimePickerFormat.Short;

            DatPicker4.ShowUpDown = true;
            DatPicker4.Format = DateTimePickerFormat.Time;
        }

        private void DatPicker_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker datPicker = sender as DateTimePicker;
            LblDatum.Text = datPicker.Value + "";

            DateTime plusTag;
            plusTag = datPicker.Value;
            plusTag = plusTag.AddDays(1);
            LblPlusTag.Text = plusTag + "";
        }
    }
}
