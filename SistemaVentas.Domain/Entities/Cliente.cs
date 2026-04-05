namespace SistemaVentas.Domain.Entities
{
    public class Cliente
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Id { get; set; }

        public Cliente(string nombre, string apellido, int id)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                throw new Exception("El nombre no puede estar vacío");

            Nombre = nombre;
            Apellido = apellido;
            Id = id;
        }
    }
}
