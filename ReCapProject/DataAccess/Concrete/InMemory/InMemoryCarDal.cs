using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _car;
        public InMemoryCarDal()
        {
            _car = new List<Car>
            {
                new Car{ID=1,BrandID=1,ColorID=2,DailyPrice=100,ModelYear=2020,Description="Otomatik,Benzinli"},
                new Car{ID=2,BrandID=3,ColorID=1,DailyPrice=1500,ModelYear=2021,Description="Otomatik,Dizel"},
                new Car{ID=3,BrandID=2,ColorID=5,DailyPrice=200,ModelYear=2020,Description="Otomatik,Dizel"},
                new Car{ID=4,BrandID=5,ColorID=3,DailyPrice=150,ModelYear=2019,Description="Manuel,Dizel"},
                new Car{ID=5,BrandID=4,ColorID=2,DailyPrice=90,ModelYear=2018,Description="Manuel,Benzinli"},
            };
        }

        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            Car deleteCar = _car.SingleOrDefault(x => x.ID == car.ID);
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetAllByBrand(int brandId)
        {
            return _car.Where(x => x.BrandID == brandId).ToList();
        }

        public List<Car> GetAllByColor(int colorId)
        {
            return _car.Where(x => x.ColorID == colorId).ToList();
        }

        public void Update(Car car)
        {
            Car updateCar = _car.SingleOrDefault(x => x.ID == car.ID);
            updateCar.ModelYear = car.ModelYear;
            updateCar.Description = car.Description;
            updateCar.BrandID = car.BrandID;
            updateCar.ColorID = car.ColorID;
            updateCar.DailyPrice = car.DailyPrice;

        }
    }
}
