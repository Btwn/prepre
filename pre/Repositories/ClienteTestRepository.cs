using pre.Modelos;

namespace pre.Repositories
{
    public class ClienteTestRepository : IClienteRepository
    {
        private string connectionString;

        public ClienteTestRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public IEnumerable<ClienteInfo> BuscarClienteXCuenta(string cuenta)
        {
            ClienteInfo cliente = new ClienteInfo();
            cliente.Nombre = "Ricardo de la Torre";
            cliente.Rfc = "XXAX000000ABC";
            cliente.Cliente = cuenta;
            cliente.Direccion = "Revolucion 1029";
            cliente.Delegacion = "Guadalajara";
            cliente.Estado = "Jalisco";
            var result = new List<ClienteInfo>();
            result.Add(cliente);
            return result;
        }

        public IEnumerable<DoctosPadres> BuscarDoctosPadresXCuenta(string cuenta)
        {
            DoctosPadres dto1 = new DoctosPadres();
            dto1.Empresa = "DEMO";
            dto1.Cliente = cuenta;
            dto1.PadreMAVI = "Factura";
            dto1.PadreIDMAVI = "ABC1";

            DoctosPadres dto2 = new DoctosPadres();
            dto2.Empresa = "DEMO";
            dto2.Cliente = cuenta;
            dto2.PadreMAVI = "Seguro";
            dto2.PadreIDMAVI = "XYZ2";

            var result = new List<DoctosPadres>();
            result.Add(dto1);
            result.Add(dto2);
            return result;
        }
    }
}
