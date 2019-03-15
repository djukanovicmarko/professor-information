using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Dodavanje stavki u comboBox
            Zvanjetxt.Items.Add("Profesor");
            Zvanjetxt.Items.Add("Asistent");
            Zvanjetxt.Items.Add("Strucno osoblje");
            Zvanjetxt.SelectedItem = Zvanjetxt.Items[0];

        }

        
        private void Potvrdibtn_Click(object sender, EventArgs e)
        {
            
            string Ime = Imetxt.Text;
            string Prezime = Prezimetxt.Text;
            string Zvanje = Zvanjetxt.SelectedItem.ToString();
            int Dan = Datum.Value.Day;
            int Mesec = Datum.Value.Month;
            int Godina = Datum.Value.Year;

            string Pol = "";

            /*U koliko je oznaceni RB muski, pol dobiti vrednost muski, odnosno pol ce biti muski,
            ukoliko je oznacen zenski, bice zenski*/
            if (RbMuski.Checked)
            {
                Pol = RbMuski.Text;
            }
            else
            {
                Pol = RbZenski.Text;
            }

            //Ukoliko je ime ili prezime ostavljeno prazno, Message box ce nam prikazati da moramo to da unesemo
            if (Ime == "")
                MessageBox.Show("Morate uneti ime profesora");
            else if (Prezime == "")
            {
                MessageBox.Show("Morate uneti prezime profesora");
            }
            else
            {
            MessageBox.Show("Profesor: " + Ime + " " + Prezime + "\n" +
                "Datum Rodjenja: " + Dan + "/" + Mesec + "/" + Godina + "\n" +
                "Pol: " + Pol + "\n" +
                "Zvanje: " + Zvanje);
            }
           

        }
    }
}