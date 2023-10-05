using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    public class Automovil : IVehiculo
    {

        public int gasolina { get; set; }
        public int CanGa { get; private set; }

        public Automovil(int CaGa)
        {
            gasolina = CaGa;
        }


        public void Conducir()
        {
            if (gasolina > 0)
            {
                Console.WriteLine("no esta conduciendo");
            }
            else
            {
                Console.WriteLine("  conduciendo");
            }
        }
        public bool LlenarTan(int gasolina)
        {
            if (gasolina < 0)
            {
                Console.WriteLine(" no lleno");
                return false;
            }
            gasolina += CanGa;
            return true;
        }
    }
}
