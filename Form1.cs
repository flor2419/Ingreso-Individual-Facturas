using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ingreso_Individual_Facturas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public void SoloLetras(KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;

            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }

            else
            {
                e.Handled = true;
                MessageBox.Show("Ingrese Solo numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void Solo_Numeros(KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {

                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo Puede ingresar Numeros", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void textfactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            Solo_Numeros(e);
        }
       

        private void textprove_KeyPress(object sender, KeyPressEventArgs e)
        {
            Solo_Numeros(e);

        }

        private void rbpdf_KeyPress(object sender, KeyPressEventArgs e)
        {
            rbpdf.Checked = true;
        }

        private void textotales_KeyPress(object sender, KeyPressEventArgs e)
        {
            Solo_Numeros(e);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La factura ha sido ingresada correctamente\nNumero: " + textfactura.Text + "\nProveedor: " +textprove.Text + "\nReceptor : " + textreceptor.Text + "\nTotales: " + textotales.Text );
            textfactura.Clear();
            textprove.Clear();
            textotales.Clear();
            textreceptor.Clear();
        }

        
    }
}