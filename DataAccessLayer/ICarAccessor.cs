using MVCWebApp.Models;
using System.Collections.Generic;

namespace MVCWebApp.Data
{
    public interface ICarAccessor
    {

        Car createCar(Car car);

        List<Car> getAllCars();

        Car getCarById(int carId);

        Car updateCar(Car car);

        void deleteCar(int carId);

    }
}
