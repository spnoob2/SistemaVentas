namespace SistemaVentas.Data.ClienteData;
using System.Text.Json;
using System.IO;
using System.Collections.Generic;
using SistemaVentas.Domain.Entities;

public class ClienteRepository
{
    private string path = Path.Combine("DataFiles", "clientes.json");

    public ClienteRepository() { }

    public void Guardar(List<Cliente> clientes)
    {
        var opciones = new JsonSerializerOptions
        {
            WriteIndented = true
        };

        string json = JsonSerializer.Serialize(clientes, opciones);

        var directory = Path.GetDirectoryName(path);

        if (!Directory.Exists(directory))
        {
            Directory.CreateDirectory(directory);
        }

        File.WriteAllText(path, json);
    }


    public List<Cliente> Obtener()
    {
        if (!File.Exists(path))
            return new List<Cliente>();

        string json = File.ReadAllText(path);

        return JsonSerializer.Deserialize<List<Cliente>>(json);
    }
}
//V8873899200AGEEE2WWE112-IIIOOOSPP


