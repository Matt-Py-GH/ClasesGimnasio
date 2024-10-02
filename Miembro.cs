namespace ejercicio2deunTP
{
    internal class Miembro
    {
        private string _nombre;
        private string _ID;
        private List<Clase> _clasesInscripto = new List<Clase>();
        
        public List<Clase> ClasesInscripto
        {
            get { return _clasesInscripto; }
            set {  _clasesInscripto = value;}
        }

        public Miembro(string nombre, string ID)
        {
            _nombre = nombre;
            _ID = ID;
        }
        public Miembro() { }
    }
}
