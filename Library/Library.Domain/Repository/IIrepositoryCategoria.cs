using Library.Domain.Entities;
using System.Collections.Generic;

namespace Library.Domain.Repository
{
    internal interface IIrepositoryCategoria
    {

        void Save(Categoria categoria);

        void Update(Categoria categoria);
        void Delete(Categoria categoria);

        List<Categoria> GetCategoria();
        Categoria GetCategoria(int id);
        
    }
}
