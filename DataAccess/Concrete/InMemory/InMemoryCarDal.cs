﻿using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car
                {
                    CarId = 1,
                    BrandId = 1,
                    ColorId = 1,
                    ModelYear = "2000",
                    DailyPrice = 95,
                    Description = "3 Gün"
                },
                new Car
                {
                    CarId = 2,
                    BrandId = 2,
                    ColorId = 2,
                    ModelYear = "2001",
                    DailyPrice = 100,
                    Description = "4 Gün"
                },
                new Car
                {
                    CarId = 3,
                    BrandId = 3,
                    ColorId = 3,
                    ModelYear = "2002",
                    DailyPrice = 105,
                    Description = "5 Gün"
                },
                new Car
                {
                    CarId = 4,
                    BrandId = 4,
                    ColorId = 4,
                    ModelYear = "2003",
                    DailyPrice = 110,
                    Description = "6 Gün"
                },
                new Car
                {
                    CarId = 5,
                    BrandId = 5,
                    ColorId = 5,
                    ModelYear = "2004",
                    DailyPrice = 115,
                    Description = "7 gün"
                }
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = null;
            foreach (var c in _cars)
            {
                if (car.CarId == c.CarId)
                {
                    carToDelete = c;
                }
            }
            carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public List<Car> GetCarsByBrandId(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetCarsByColorId(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Insert(Car entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
