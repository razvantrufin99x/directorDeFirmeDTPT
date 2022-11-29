using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace directorDeFirmeDTPT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        directoruldefirme dtpt = new directoruldefirme();
        int counter = -1;
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        void clearTextBoxes()
        {
                textBox1.Text = "";
                textBox2.Text= ""; 
                textBox3.Text= ""; 
                textBox4.Text= ""; 
                textBox5.Text= ""; 
                textBox6.Text= "";
                textBox7.Text= "";
                textBox8.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {

            dtpt.listaFirmelor.Add(new firma(
                textBox1.Text, 
                textBox2.Text, 
                textBox3.Text, 
                textBox4.Text, 
                textBox5.Text, 
                textBox6.Text,
                textBox7.Text, 
                textBox8.Text
                ));
            
            counter++;
            string br = " , ";

            textBox9.Text += dtpt.listaFirmelor[counter].adresa + br +
                dtpt.listaFirmelor[counter].categoria + br +
                dtpt.listaFirmelor[counter].denumire + br +
                dtpt.listaFirmelor[counter].domeniul + br +
                dtpt.listaFirmelor[counter].email + br +

                //dtpt.listaFirmelor[counter].id + br +
                 counter.ToString() + br +
                
                 dtpt.listaFirmelor[counter].subdomeniul + br +
                dtpt.listaFirmelor[counter].telefon + " ; \r\n";
            clearTextBoxes();
        }
    }
}
