namespace Personaje
{
    public class personaje
    {
        public string Nombre { get; set; }
        public string Camino { get; set; }
        public personaje(string nombre, string camino)
        {
            Nombre = nombre;
            Camino = camino;

        }

    }
}
