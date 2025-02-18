using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controles
{
    class Matematica : Operacion
    {
        private int num1;
        private int num2;

        public Matematica(int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }

        public int Num1 { get => num1; set => num1 = value; }
        public int Num2 { get => num2; set => num2 = value; }

        /************************************************************/
        public int dividir()
        {
            if (num2 == 0)
            {
                MessageBox.Show("No existe división para cero");
                return 0;
            }
            else
                return num1 / num2;
        }

        /************************************************************/
        public int modulo()
        {
            if (num2 == 0)
            {
                MessageBox.Show("No existe división para cero");
                return 0;
            }
            else
                return num1 % num2;
        }

        /************************************************************/
        public int multiplicar()
        {
            return num1 * num2;
        }

        /************************************************************/
        public int restar()
        {
            return num1 - num2;
        }

        /************************************************************/
        public int sumar()
        {
            return num1 + num2;
        }
    }
}
