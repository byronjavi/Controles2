using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controles
{
    public partial class Controles : Form
    {
        Matematica nuevo;
        public Controles()
        {
            InitializeComponent();
            
        }

        private void calcularSuma(object sender, EventArgs e)
        {
            if (validar() == 0)
            {
                MessageBox.Show("Debe llenar todos los campos");
            }
            else
            {
                int num1 = int.Parse(txtNumero1.Text.Trim());
                int num2 = int.Parse(txtNumero2.Text.Trim());
                nuevo = new Matematica(num1, num2);
                calcularOperacion();
            }
            
        }

        private void calcularOperacion()
        {
            if (sumar.Checked)
            {
                MessageBox.Show("La suma es: " + nuevo.sumar(), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblResultado.Text = "" + nuevo.sumar();
            }
            else if (restar.Checked)
            {
                MessageBox.Show("La resta es: " + nuevo.restar(), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblResultado.Text = "" + nuevo.restar();
            }
            else if (multiplicar.Checked)
            {
                MessageBox.Show("La multiplicación es: " + nuevo.multiplicar(), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblResultado.Text = "" + nuevo.multiplicar();
            }
            else if (dividir.Checked)
            {
                MessageBox.Show("La división es: " + nuevo.dividir(), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblResultado.Text = "" + nuevo.dividir();
            }
            else
            {
                MessageBox.Show("El módulo es: " + nuevo.modulo(), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblResultado.Text = "" + nuevo.modulo();
            }
        }

        private int validar()
        {
            if(txtNumero1.Text.Trim().Equals("") || txtNumero2.Text.Trim().Equals(""))
                return 0;
            else
                return 1;
        }

        private void validarNumero(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void nuevaPantalla(object sender, EventArgs e)
        {
            Persona nuevo = new Persona();
            nuevo.ShowDialog();
        }
    }
}
