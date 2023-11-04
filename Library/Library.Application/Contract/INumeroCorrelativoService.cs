using Library.Application.Core;
using Library.Application.Dtos.DtoNumeroCorrelativo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Application.Contract
{
    public interface INumeroCorrelativoService : IBaseService<NumeroCorrelativoDtoAdd, NumeroCorrelativoDtoUpdate, NumeroCorrelativoDtoRemove>
    {
       
    }
}
