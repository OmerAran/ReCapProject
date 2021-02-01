using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace DataAccess.Concrete
{
   public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> 
            {
                new Car{CarId=1,CarName="Mercedes - Benz",BrandId=1,ColorId=1,DailyPrice=350,ModelYear=2021,Description="her şey dahil 350 tl"} ,
                 new Car{CarId=2,CarName="BMW",BrandId=1,ColorId=1,DailyPrice=270,ModelYear=2020,Description="her şey dahil 270 tl"} ,
                  new Car{CarId=3,CarName="Renault",BrandId=2,ColorId=2,DailyPrice=230,ModelYear=2019,Description="her şey dahil 230 tl"} ,
                   new Car{CarId=4,CarName="Peugeot",BrandId=2,ColorId=2,DailyPrice=190,ModelYear=2018,Description="her şey dahil 190 tl"} ,
                    new Car{CarId=5,CarName="Dacia",BrandId=3,ColorId=2,DailyPrice=160,ModelYear=2017,Description="her şey dahil 160 tl"} ,
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p=>p.CarId==car.CarId);
            
            
            _cars.Remove(carToDelete);
        }
            
        public  List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById()
        {
            return _cars;
        }

        public List<Car> GetById(int brandId)
        {
           return  _cars.Where(p=>p.BrandId == brandId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.CarId == car.CarId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.CarName = car.CarName;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;


        }
    }
}
