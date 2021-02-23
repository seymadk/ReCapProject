using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        [ValidationAspect(typeof(CarValidator))]
        public IResult Insert(Car car)
        {
            _carDal.Insert(car);

            if (car.CarName.Length < 3)
            {
                return new ErrorResult(Messages.CarNameInvalid);
            }
            return new SuccessResult(Messages.CarInserted);
        }

        public IDataResult<List<Car>> GetAll()
        {
            if (DateTime.Now.Hour == 3)
            {
                return new ErrorDataResult<List<Car>>
                    (Messages.MaintennanceTime);
            }
            return new SuccessDataResult<List<Car>>
                (_carDal.GetAll(), Messages.CarListed);
        }


        public IDataResult<List<Car>> GetAllByBrand(int Id)
        {
            return new SuccessDataResult<List<Car>>
                (_carDal.GetAll(c => c.BrandId == Id));
        }

        public IDataResult<List<Car>> GetAllByColor(int Id)
        {
            return new SuccessDataResult<List<Car>>
                (_carDal.GetAll(c => c.ColorId == Id));
        }
        public IDataResult<Car> GetById(int carId)
        {
            return new SuccessDataResult<Car>
                (_carDal.Get(c => c.CarId == carId));
        }

        public IDataResult<List<Car>> GetByDailyPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Car>>
                (_carDal.GetAll(c => c.DailyPrice >= min && c.DailyPrice <= max));
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            if (DateTime.Now.Hour == 4)
            {
                return new ErrorDataResult<List<CarDetailDto>>
                    (Messages.MaintennanceTime);
            }
            return new SuccessDataResult<List<CarDetailDto>>
                (_carDal.GetCarDetails());
        }
    }
}
