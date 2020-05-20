using System;

namespace files2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Libreta
            //Notas (linea)

            //Agregar nota
            //Consultar notas

            Libreta libreta = new Libreta("notas.txt");

            int opcion = 0;
            while (opcion != 9) {
                System.Console.WriteLine("");
                System.Console.WriteLine("1) Agregar nota");
                System.Console.WriteLine("2) Consultar notas");
                System.Console.WriteLine("3) Borrar notas");
                System.Console.WriteLine("9) Salir");
                System.Console.WriteLine("Selecciona una opción");

                opcion = Convert.ToInt32(Console.ReadLine());

                switch(opcion) {
                    case 1:
                        libreta.AgregarNota();
                        break;
                    case 2:
                        libreta.ConsultarNotas();
                        break;
                    case 3:
                        libreta.BorrarNotas();
                        break;
                    //9 no es necesario; el while se encarga de salir
                }
            }
        }
    }
}
