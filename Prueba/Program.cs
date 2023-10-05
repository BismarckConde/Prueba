using Prueba;


Automovil Automovil = new Automovil(0);

Console.WriteLine(" ¿que cantidad de gasolina desea introducir?");
int CaGa =int.Parse(Console.ReadLine());

bool Lleno=Automovil.LlenarTan(CaGa);
if(Lleno)
{
    Console.WriteLine("Tanque Lleno");
}
else
{
    Console.WriteLine("Tanque en 0");
}
Automovil.Conducir();


