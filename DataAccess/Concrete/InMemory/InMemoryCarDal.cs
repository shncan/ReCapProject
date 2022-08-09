using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.Inmemory
{

    


    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;


        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1, BrandId=1, ColorId=1, ModelYear=2006, DailyPrice=15000, Description=("Spor Araba")},
                new Car{Id=2, BrandId=2, ColorId=3, ModelYear=2012, DailyPrice=35000, Description=("Lüx Araba")},
                new Car{Id=3, BrandId=2, ColorId=4, ModelYear=2019, DailyPrice=75000, Description=("Rahat Araba")},
                new Car{Id=4, BrandId=3, ColorId=5, ModelYear=2022, DailyPrice=115000, Description=("En iyi Araba")},

            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carDelete = _cars.SingleOrDefault(p => p.Id == car.Id);

            _cars.Remove(carDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetByID(int id)
        {
            return _cars.Where(p => p.Id == id).ToList();
        }

        public void Update(Car car)
        {
            Car carUpdate = _cars.SingleOrDefault(p => p.Id == car.Id);
            carUpdate.BrandId = car.BrandId;
            carUpdate.ColorId = car.ColorId;
            carUpdate.ModelYear = car.ModelYear;
            carUpdate.DailyPrice = car.DailyPrice;
            carUpdate.Description = car.Description;
        }
    }
}
