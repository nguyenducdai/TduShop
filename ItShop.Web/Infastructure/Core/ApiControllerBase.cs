using ItShop.Models.Models;
using ItShop.Services;
using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ItShop.Web.Infastructure.Core
{
    public class ApiControllerBase : ApiController
    {
        private IErrorService _errorService;

        public ApiControllerBase(IErrorService errorService)
        {
            this._errorService = errorService;
        }

        protected HttpResponseMessage CreateResponse(HttpRequestMessage requestMessage, Func<HttpResponseMessage> function)
        {
            HttpResponseMessage messageRespose = null;
            try
            {
                messageRespose = function.Invoke();
            }
            catch (DbEntityValidationException dbVEx)
            {

                foreach (var item in dbVEx.EntityValidationErrors)
                {
                        Trace.WriteLine($"entity of type \"{item.Entry.Entity.GetType().Name} \" in state\"{item.Entry.State}\" has the following validation errors");

                    foreach (var ex in item.ValidationErrors)
                    {
                        Trace.WriteLine($"-Property \"{ex.PropertyName} \" Error \"{ex.ErrorMessage}\"");
                    }

                }
                this.LogErr(dbVEx);

                // su ly ben trong len phải view inner
                messageRespose = requestMessage.CreateResponse(HttpStatusCode.BadRequest, dbVEx.InnerException.Message);

            }
            catch (DbUpdateException dbEx)
            {
                this.LogErr(dbEx);

                // su ly ben trong len phải view inner
                messageRespose = requestMessage.CreateResponse(HttpStatusCode.BadRequest, dbEx.InnerException.Message);
            }
            catch (Exception ex)
            {
                this.LogErr(ex);

                // trả về lỗi 404
                messageRespose = requestMessage.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }

            return messageRespose;
        }

        //add error
        private void LogErr(Exception ex)
        {
            try
            {
                Error error = new Error();
                error.Message = ex.Message;
                error.StackTrace = ex.StackTrace;
                error.CreateAt = DateTime.Now;
                this._errorService.Add(error);
            }
            catch (System.Exception)
            {
            }
        }
    }
}