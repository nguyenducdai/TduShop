using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItShop.Models.Models;
using ItShop.Data.Repositories;
using ItShop.Data.Infrastrusture;

namespace ItShop.Services
{
    public interface IErrorService
    {
        Error Add(Error error);

        void Save();

    }
    public class ErrorService: IErrorService
    {

        private ErrorRepository _errorRepository;
        private IUnitOfWork _unitOfWork;

        public ErrorService(ErrorRepository errorRepository , IUnitOfWork unitOfWork)
        {
            this._errorRepository = errorRepository;
            this._unitOfWork = unitOfWork;
        }

        public Error Add(Error error)
        {
            return this._errorRepository.Add(error);
        }

        public void Save()
        {
            this._unitOfWork.Commit();
        }
    }
}
