using SistemaVentas.Data.ClienteData;
using SistemaVentas.Domain.Entities;

namespace SistemaVentas.Services.ClienteService
{
    public class ClienteService
    {
        public void InputCliente(string nombre, string apellido)
        { 
            var Cliente = new Domain.Entities.Cliente(nombre, apellido, 0);
            var cliente = ClienteRepository.Obtener();
            cliente.Add(cliente);
            ClienteRepository.Guardar(Cliente);



        }

    }
}
