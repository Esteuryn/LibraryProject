using Library.Domain.Entities;
using Library.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library.Infrastructure.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private List<Usuario> usuarios; 

        public UsuarioRepository()
        {
           
            usuarios = new List<Usuario>();
        }

        public List<Usuario> BuscarUsuariosPorNombre(string nombre)
        {
            
            return usuarios.Where(u => u.nombreApellidos != null && u.nombreApellidos.Contains(nombre)).ToList();
        }

        public void CambiarEstadoUsuario(int idUsuario, bool nuevoEstado)
        {
            Usuario usuario = usuarios.FirstOrDefault(u => u.idUsuario == idUsuario);
            if (usuario != null)
            {
                usuario.esActivo = nuevoEstado;
            }
        }


        public List<Usuario> GetEntities()
        {
            
            return usuarios;
        }

        public Usuario GetEntity(int id)
        {
            
            return usuarios.FirstOrDefault(u => u.idUsuario == id);
        }

        public Usuario GetUsuarioByEmail(string correo)
        {
            
            return usuarios.FirstOrDefault(u => u.correo == correo);
        }

        public List<Usuario> GetUsuariosActivos()
        {
            return usuarios.Where(u => u.esActivo).ToList();
        }


        public void Remove(Usuario entity)
        {
            
            usuarios.Remove(entity);
        }

        public void Save(Usuario entity)
        {
            
            usuarios.Add(entity);
        }

        public void Update(Usuario entity)
        {
            
            Usuario existingUser = usuarios.FirstOrDefault(u => u.idUsuario == entity.idUsuario);
            if (existingUser != null)
            {
                existingUser = entity;
            }
        }
    }


}
