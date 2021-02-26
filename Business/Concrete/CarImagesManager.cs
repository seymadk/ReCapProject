using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class CarImagesManager : ICarImagesService
    {
        ICarImagesDal _carImagesDal;
        public CarImagesManager(ICarImagesDal carImagesDal)
        {
            _carImagesDal = carImagesDal;
        }

        public IResult Insert(CarImages carImages)
        {
            _carImagesDal.Insert(carImages);

            if (carImages.CarImagesId > 5)
            {
                return new ErrorResult(Messages.CarImagesLimitedExceded);
            }
            return new SuccessResult(Messages.CarImagesInserted);
        }

        public IResult Delete(CarImages carImages)
        {
            _carImagesDal.Delete(carImages);
            return new SuccessResult(Messages.CarImagesDeleted);
        }

        public IDataResult<List<CarImages>> GetAll()
        {
            if (DateTime.Now.Hour == 3)
            {
                return new ErrorDataResult<List<CarImages>>
                    (Messages.CarImagesNotLoaded);
            }
            return new SuccessDataResult<List<CarImages>>
                (_carImagesDal.GetAll(), Messages.CarImagesListed);
        }

        public IDataResult<CarImages> GetById(int carImagesId)
        {
            return new SuccessDataResult<CarImages>
                (_carImagesDal.Get(ci => ci.CarImagesId == carImagesId));
        }

        public IResult Update(CarImages carImages)
        {
            var result = _carImagesDal.GetAll(ci => ci.CarImagesId == carImages.CarImagesId).Count;
            if (result > 6)
            {
                return new ErrorResult(Messages.CarImagesLimitedExceded);
            }
            return new SuccessResult(Messages.CarImagesUpdated);
        }
    }
}
