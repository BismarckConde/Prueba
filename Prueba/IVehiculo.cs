using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    public interface IVehiculo
    {
        public int gasolina { get; set; }

        public void Conducir()
        {

        }

        public bool LlenarTan()
        {
            return true;
        }
    }
}
