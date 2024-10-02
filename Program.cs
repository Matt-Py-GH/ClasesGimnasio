using ejercicio2deunTP;

class Program
{
    static void Main()
    {
        //HARDCODEANDO OBJETOS---------------------------------------------------------------------------------------------------
        Clase claseFitnessPro = new Clase(15, 150, "Clase Fitness pro", new Instructor("Pablo", "1", 2));
        Clase claseFitnessStandar = new Clase(15, 100, "Clase Fitness standar", new Instructor("Jorge", "2", 3));
        Miembro miembroUno = new Miembro("Mateo","1");
        List<Clase> clases = new List<Clase>();
        clases.Add(claseFitnessStandar);
        clases.Add(claseFitnessPro);
        //HARDCODEANDO OBJETOS---------------------------------------------------------------------------------------------------

        //MENU-------------------------------------------------------------------------------------------------------------------
        int opc = 0;
        Console.WriteLine("Bienvenido al gimnasio TermineAntesQueJor");
        while (opc != 3)
        {
            Console.WriteLine("Seleccione una opcion: \n1.Registrarse a una clase\n2.Anular registro\n3.Salir");
            opc = int.Parse(Console.ReadLine());
            switch (opc)
            {
                case 1:
                    Console.Clear();
                    Console.Beep();
                    ServicioInscripcion service = new ServicioInscripcion();
                    service.InscripcionClase(clases, miembroUno);
                break;

                case 2:
                    Console.Clear();
                    Console.Beep();
                    ServicioInscripcion servicio = new ServicioInscripcion();
                    servicio.AnularInscripcion(miembroUno);
                    break;
                case 3:
                    Console.Clear();
                    Console.Beep();
                    Console.WriteLine("Saliendo...\n");
                    break;

                default:
                    Console.WriteLine("Opcion invalida...\n");
                    break;

            }
        }
    }
}