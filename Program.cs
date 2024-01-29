namespace Ejercicio1DateTime
{
    /// <summary>
    /// Clase principal de la aplicacion
    /// JL - 29/01/2024
    /// </summary>
    class Program
    {
        /// <summary>
        /// Metodo principal de la aplicacion
        /// JL - 29/01/2024
        /// </summary>
        static void Main(string[] args)
        {
            
            DateTime fechaActual = DateTime.Now;
            fechaActual.ToString("yy - MM - ddThh:mm: ss.ms");
            Console.WriteLine("Fecha formato-tiempo: " + fechaActual.ToString());

        }
    }
}