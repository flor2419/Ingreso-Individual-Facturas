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
                MessageBox.Show("Solo Puede Ingresar Numeros", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La factura ha sido ingresada correctamente\nNumero: " + txtFactura.Text + "\nProveedor: " +txtProveedor.Text + "\nReceptor : " + txtRazonSocial.Text + "\nTotales: " + txtGiro.Text );
        
        }

       
            private void limpiarTextBoxes(Control parent)
            {
                //Limpiar de manera rapida
                foreach (Control c in parent.Controls)
                {
                    if (c is TextBox)
                    {
                        c.Text = "";
                    }
                    if (c.Controls.Count > 0)
                    {
                        limpiarTextBoxes(c);
                    }
                }

            }

        public void GuardarFactura()
        {

            string[] codigo = new string[5] { txtcod1.Text, txtcod2.Text, txtcod3.Text, txtcod4.Text, txtcod5.Text };



            string[] descripcion = new string[5] { txtDesc1.Text, txtDesc2.Text, txtDesc3.Text, txtDesc4.Text, txtDesc5.Text };


            int[] cantidad = new int[5] { int.Parse(txtCant1.Text), int.Parse(txtCant2.Text), int.Parse(txtCant3.Text), int.Parse(txtCant4.Text), int.Parse(txtCant5.Text) };


            int[] precio = new int[5] { int.Parse(txtPrecio1.Text), int.Parse(txtPrecio2.Text), int.Parse(txtPrecio3.Text), int.Parse(txtPrecio4.Text), int.Parse(txtPrecio5.Text) };

            int totalProducto1 = cantidad[0] * precio[0];
            int totalProducto2 = cantidad[1] * precio[1];
            int totalProducto3 = cantidad[2] * precio[2];
            int totalProducto4 = cantidad[3] * precio[3];
            int totalProducto5 = cantidad[4] * precio[4];

            double totalProducto = totalProducto1 + totalProducto2 + totalProducto3 + totalProducto4 + totalProducto5;
            double iva = totalProducto * 0.19;
            double montoNeto = totalProducto - iva;
            txtMontoN.Text = montoNeto.ToString();
            txtMontoT.Text = totalProducto.ToString();
            txtIva.Text = iva.ToString();

            ClsFactura factura = new ClsFactura (int.Parse(txtFactura.Text), txtProveedor.Text, txtRazonSocial.Text, txtGiro.Text, txtDireccion.Text,
                                                 codigo, descripcion, cantidad, precio, double.Parse(txtMontoN.Text),
                                                 double.Parse(txtMontoT.Text), double.Parse(txtIva.Text));


            
        }


        private void txtFactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }


        public void SoloNumeros(KeyPressEventArgs e)
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
                MessageBox.Show("Solo Puede ingresar Numeros", "Modulo Factura", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }




        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtFactura.Clear();
            txtRazonSocial.Clear();
            txtProveedor.Clear();
            txtGiro.Clear();
        }

       

        private void txtCod1_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtCod2_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtCod3_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtCod4_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtCod5_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtCant1_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtCant2_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtCant3_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtCant4_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtCant5_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtPrecio1_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtPrecio2_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtPrecio3_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtPrecio4_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtPrecio5_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtFechaEmi_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtFechaVen_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }


    }
}