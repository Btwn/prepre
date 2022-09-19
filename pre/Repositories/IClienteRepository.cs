using pre.Modelos;

namespace pre.Repositories
{
    public interface IClienteRepository
    {
        IEnumerable<ClienteInfo> BuscarClienteXCuenta(string cuenta);
        IEnumerable<DoctosPadres> BuscarDoctosPadresXCuenta(string cuenta);
    }
}