using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Controles
{
    public class Crud
    {
        public List<Registro> listRegistro = new List<Registro>();
        public Crud() 
        {
            
        }

        public void agregarObjeto(Registro nuevo)
        {
            listRegistro.Add(nuevo);
        }
    }
}
