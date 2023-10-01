using Library.Domain.Entities;
using Library.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Infrastructure.Interfaces
{
    public interface IUsuarioRepository : IBaseRepository<Usuario>
    {
        Usuario GetUsuarioByEmail(string correo);
        List<Usuario> GetUsuariosActivos();
        void CambiarEstadoUsuario(int idUsuario, bool nuevoEstado);
        List<Usuario> BuscarUsuariosPorNombre(string nombre);
    }
}
