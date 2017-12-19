using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace EingabeAusgabe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdInput_Click(object sender, EventArgs e)
        {
            string eingabe;
            eingabe = Interaction.InputBox(
                "Bitte Ihren Namen:", "Ihr Name", "Maier");
            LblAnzeige.Text = eingabe;
        }

        private void CmdLotto_Click(object sender, EventArgs e)
        {
            int zahl;
            int[] lotto = new int[6];
            bool gezogen;

            LblAnzeige.Text = "";
            for (int i = 0; i < lotto.Length; i++)
            {
                do
                {
                    gezogen = false;
                    zahl = 0;
                    try
                    {
                        zahl = Convert.ToInt32(Interaction.InputBox(
                            "Zahl " + (i + 1) + ": ", "Zahl " + (i + 1)));
                    }
                    catch
                    {
                        continue;
                    }

                    for (int k = 0; k < i; k++)
                        if (lotto[k] == zahl)
                        {
                            gezogen = true;
                            break;
                        }
                }
                while (gezogen || zahl < 1 || zahl > 49);

                lotto[i] = zahl;
                LblAnzeige.Text += zahl + " ";
            }
        }

        private void CmdMsgBoxOkOnly_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gelesen? Dann bitte Ok drücken",
                "Ok", MessageBoxButtons.OK);
        }

        private void CmdMsgBoxInformation_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Das ist eine Information", "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CmdMsgBoxYesNo_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(
                "Soll die Datei gesichert werden?", "Sicherung",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
                LblAnzeige.Text = "Sichern";
            else
                LblAnzeige.Text = "Nicht sichern";
        }

        private void CmdMsgBoxYesNoCancel_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(
                "Soll die Datei gesichert werden?", "Sicherung",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
                LblAnzeige.Text = "Sichern";
            else if (dr == DialogResult.No)
                LblAnzeige.Text = "Nicht sichern";
            else
                LblAnzeige.Text = "Abbrechen";
        }

        private void CmdMsgBoxRetryCancel_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(
                "Beim Sichern der Datei trat ein Fehler auf.\n" +
                "Wollen Sie es noch einmal probieren?\n" + "Wollen Sie " +
                "den Vorgang abbrechen?", "Fehler bei Sicherung",
                MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

            if (dr == DialogResult.Retry)
                LblAnzeige.Text = "Noch einmal";
            else
                LblAnzeige.Text = "Abbrechen";
        }

        private void CmdMsgBoxAbortRetryIgnore_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(
               "Beim Sichern der Datei trat ein Fehler auf.\n" +
               "Wollen Sie den Vorgang abbrechen?\n" + "Wollen Sie es " +
               "noch einmal probieren?\n" + "Wollen Sie diese " +
               "Nachricht ignorieren?", "Fehler bei Sicherung",
               MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Warning);

            if (dr == DialogResult.Abort)
                LblAnzeige.Text = "Abbrechen";
            else if (dr == DialogResult.Retry)
                LblAnzeige.Text = "Noch einmal";
            else
                LblAnzeige.Text = "Ignorieren";
        }
    }
}
