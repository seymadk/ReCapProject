using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarImagesService
    {
        IDataResult<List<CarImages>> GetAll();
        IDataResult<CarImages> GetById(int carImagesId);
        IResult Insert(CarImages carImages);
        IResult Delete(CarImages carImages);
        IResult Update(CarImages carImages);
    }
}
