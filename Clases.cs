namespace ejercicio2deunTP
{
    internal class Clase
    {
        private int _lugaresDisponibles;
        private float _costo;
        private string _nombre;
        private Instructor _instructorClase;
        
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public int LugaresDisponibles
        {
            get { return _lugaresDisponibles; }
            set { _lugaresDisponibles = value; }
        }

        public Clase(int lugaresDisponibles, float costo, string nombre, Instructor instructorClase)
        {
            _lugaresDisponibles = lugaresDisponibles;
            _costo = costo;
            _nombre = nombre;
            _instructorClase = instructorClase;
        }
        public Clase()
        {

        }


        public void InfoClase()
        {
            Console.WriteLine(this._nombre, this._costo, this._lugaresDisponibles);
        }

    }
}
