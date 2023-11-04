using Library.Application.Contract;
using Library.Application.Core;
using Library.Application.Core.Library.Application.Core;
using Library.Application.Dtos.DtoNumeroCorrelativo;
using Library.Domain.Entities;
using Library.Infrastructure.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Application.Service
{

    public class NumeroCorrelativoService : INumeroCorrelativoService
    {
        private readonly INumeroCorrelativoRepository numeroCorrelativoRepository;
        private readonly ILogger<NumeroCorrelativoService> logger;

        public NumeroCorrelativoService(INumeroCorrelativoRepository numeroCorrelativoRepository,
                                        ILogger<NumeroCorrelativoService> logger)
        {
            this.numeroCorrelativoRepository = numeroCorrelativoRepository;
            this.logger = logger;
        }

        public ServiceResult GetAll()
        {
            try
            {
                var result = new ServiceResult
                {
                    Data = this.numeroCorrelativoRepository.GetNumeroCorrelativos()
                };
                return result;
            }
            catch (Exception ex)
            {
                var result = new ServiceResult
                {
                    Success = false,
                    Message = "Error obteniendo los números correlativos."
                };
                this.logger.LogError(result.Message, ex.ToString());
                return result;
            }
        }

        public ServiceResult GetById(int id)
        {
            try
            {
                var result = new ServiceResult
                {
                    Data = this.numeroCorrelativoRepository.GetNumeroCorrelativo(id)
                };
                return result;
            }
            catch (Exception ex)
            {
                var result = new ServiceResult
                {
                    Success = false,
                    Message = "Error obteniendo el número correlativo."
                };
                this.logger.LogError(result.Message, ex.ToString());
                return result;
            }
        }

        public ServiceResult Remove(NumeroCorrelativoDtoRemove dtoRemove)
        {
            try
            {
                var numeroCorrelativo = new NumeroCorrelativo
                {
                   
                };

                this.numeroCorrelativoRepository.Remove(numeroCorrelativo);

                var result = new ServiceResult
                {
                    Message = "El número correlativo fue removido correctamente."
                };
                return result;
            }
            catch (Exception ex)
            {
                var result = new ServiceResult
                {
                    Success = false,
                    Message = "Error removiendo el número correlativo."
                };
                this.logger.LogError(result.Message, ex.ToString());
                return result;
            }
        }

        public ServiceResult Save(NumeroCorrelativoDtoAdd dtoAdd)
        {
            try
            {
                var numeroCorrelativo = new NumeroCorrelativo
                {
                   
                };

                this.numeroCorrelativoRepository.Save(numeroCorrelativo);

                var result = new ServiceResult
                {
                    Message = "El número correlativo fue guardado correctamente."
                };
                return result;
            }
            catch (Exception ex)
            {
                var result = new ServiceResult
                {
                    Success = false,
                    Message = "Error guardando el número correlativo."
                };
                this.logger.LogError(result.Message, ex.ToString());
                return result;
            }
        }

        public ServiceResult Update(NumeroCorrelativoDtoUpdate dtoUpdate)
        {
            try
            {
                var numeroCorrelativo = new NumeroCorrelativo
                {
                   
                };

                this.numeroCorrelativoRepository.Update(numeroCorrelativo);

                var result = new ServiceResult
                {
                    Message = "El número correlativo fue actualizado correctamente."
                };
                return result;
            }
            catch (Exception ex)
            {
                var result = new ServiceResult
                {
                    Success = false,
                    Message = "Error actualizando el número correlativo."
                };
                this.logger.LogError(result.Message, ex.ToString());
                return result;
            }
        }

        Microsoft.Exchange.WebServices.Data.ServiceResult IBaseService<NumeroCorrelativoDtoAdd, NumeroCorrelativoDtoUpdate, NumeroCorrelativoDtoRemove>.GetAll()
        {
            throw new NotImplementedException();
        }

        Microsoft.Exchange.WebServices.Data.ServiceResult IBaseService<NumeroCorrelativoDtoAdd, NumeroCorrelativoDtoUpdate, NumeroCorrelativoDtoRemove>.GetById(int id)
        {
            throw new NotImplementedException();
        }

        Microsoft.Exchange.WebServices.Data.ServiceResult IBaseService<NumeroCorrelativoDtoAdd, NumeroCorrelativoDtoUpdate, NumeroCorrelativoDtoRemove>.Remove(NumeroCorrelativoDtoRemove dtoRemove)
        {
            throw new NotImplementedException();
        }

        Microsoft.Exchange.WebServices.Data.ServiceResult IBaseService<NumeroCorrelativoDtoAdd, NumeroCorrelativoDtoUpdate, NumeroCorrelativoDtoRemove>.Save(NumeroCorrelativoDtoAdd dtoAdd)
        {
            throw new NotImplementedException();
        }

        Microsoft.Exchange.WebServices.Data.ServiceResult IBaseService<NumeroCorrelativoDtoAdd, NumeroCorrelativoDtoUpdate, NumeroCorrelativoDtoRemove>.Update(NumeroCorrelativoDtoUpdate dtoUpdate)
        {
            throw new NotImplementedException();
        }
    }




}
