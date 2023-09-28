
using MauiAppEjemplo.Modelo;

namespace MauiAppEjemplo.Servicios
{
    public interface IGetUsuarios
    {
        public Task<List<UsuariosResponse>> Obtener();

    }
}
