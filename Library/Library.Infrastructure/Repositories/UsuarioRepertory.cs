using Library.Domain.Entities;
using Library.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Infrastructure.Repositories
{
    public class UsuarioRepertory : IUsuarioRepository
    {
        public List<Usuario> BuscarUsuariosPorNombre(string nombre)
        {
            throw new NotImplementedException();
        }

        public void CambiarEstadoUsuario(int idUsuario, bool nuevoEstado)
        {
            throw new NotImplementedException();
        }

        public List<Usuario> GetEntities()
        {
            throw new NotImplementedException();
        }

        public Usuario GetEntity(int id)
        {
            throw new NotImplementedException();
        }

        public Usuario GetUsuarioByEmail(string correo)
        {
            throw new NotImplementedException();
        }

        public List<Usuario> GetUsuariosActivos()
        {
            throw new NotImplementedException();
        }

        public void Remove(Usuario entity)
        {
            throw new NotImplementedException();
        }

        public void Save(Usuario entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Usuario entity)
        {
            throw new NotImplementedException();
        }
    }
}
