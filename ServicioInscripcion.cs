namespace ejercicio2deunTP
{
    internal class ServicioInscripcion
    {

        public void MuestraClases(List<Clase> clases)
        {
            foreach (var clase in clases)
            {
                clase.InfoClase();
            }
        }

        public void AnularInscripcion(Miembro miembro)
        {
            Console.WriteLine("Seleccione la clase a la cual desinscribirse: ");
            foreach (var claseMiembro in miembro.ClasesInscripto)
            {
                Console.WriteLine($"{claseMiembro.Nombre}");
            }
            Console.WriteLine("Escriba el nombre de la clase: ");
            string nombre = Console.ReadLine();
            bool encontrado = false;
            Clase claseAnulada = new Clase();
            foreach (var clase in miembro.ClasesInscripto)
            {
                if (nombre.Trim().ToLower() == clase.Nombre.Trim().ToLower())
                {
                    encontrado = true;
                    claseAnulada = clase;
                    clase.LugaresDisponibles += 1;
                    Console.WriteLine("Registro anulado exitosamente!\n");
                }
            }
            if (!encontrado) { Console.WriteLine("Clase no encontrada..."); }
            else { miembro.ClasesInscripto.Remove(claseAnulada); }
            Console.ReadLine();
        }

        public void InscripcionClase(List<Clase> clases, Miembro miembro)
        {
            Console.WriteLine("Seleccione la clase a la cual anotarse: ");
            MuestraClases(clases);
            Console.WriteLine("Escriba el nombre de la clase que desea: ");
            string nombre = Console.ReadLine();
            bool encontrado = false;
            foreach (var clase in clases)
            {
                if (nombre.Trim().ToLower() == clase.Nombre.Trim().ToLower())
                {
                    encontrado = true;
                    if (clase.LugaresDisponibles >= 1)
                    {
                        miembro.ClasesInscripto.Add(clase);
                        clase.LugaresDisponibles -= 1;
                        Console.WriteLine("Inscripto exitosamente!");
                    }
                    else
                    {
                        Console.WriteLine("Lo siento, no tenemos lugares suficientes para esa clase");
                    }

                }
            }
            if (!encontrado) { Console.WriteLine("Clase no encontrada..."); }

        }
    }
}
