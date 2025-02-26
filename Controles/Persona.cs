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
    public partial class Persona : Form
    {
        Crud c = new Crud();
        public Persona()
        {
            InitializeComponent();
        }

        private void registrarDatos(object sender, EventArgs e)
        {
            string nombre = txt_nombre.Text.Trim();
            string apellido = txt_apellido.Text.Trim();
            string direccion = txt_direccion.Text.Trim();
            string telefono = txt_telefono.Text.Trim();
            int edad = int.Parse(txt_edad.Text.Trim());

            Registro nuevo = new Registro(nombre, apellido, direccion, telefono,edad); 
            
            c.agregarObjeto(nuevo);
            MessageBox.Show("Registro Correcto");
        }

        private void mostrarLista(object sender, EventArgs e)
        {
            foreach(var p in c.listRegistro)
            {
                MessageBox.Show("Nombre: "+p.Nombre +"\nApellido: "+p.Apellido+"\nDirección: "+p.Direccion+"\nTelefono: "+p.Telefono+"\nEdad: "+p.Edad);
            }
        }
    }
}
