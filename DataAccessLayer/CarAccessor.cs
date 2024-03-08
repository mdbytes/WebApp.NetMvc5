using System.Data.SqlClient;
using System.Data;
using MVCWebApp.Models;
using System;
using System.Collections.Generic;

namespace MVCWebApp.Data
{
    public class CarAccessor : ICarAccessor
    {
        public Car createCar(Car car)
        {
            var conn = Database.GetConnection();

            var cmdText = "sp_create_car";

            var cmd = new SqlCommand(cmdText, conn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@make", SqlDbType.VarChar, 100);
            cmd.Parameters.Add("@model", SqlDbType.VarChar, 100);
            cmd.Parameters.Add("@year", SqlDbType.Int);

            cmd.Parameters["@make"].Value = car.Make;
            cmd.Parameters["@model"].Value = car.Model;
            cmd.Parameters["@year"].Value = car.Year;

            var id = 0;

            try
            {
                conn.Open();

                id = (int)cmd.ExecuteScalar();

                if (id == 0)
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            Car newCar = getCarById(id);

            return newCar;
        }

        public void deleteCar(int carId)
        {
            var conn = Database.GetConnection();

            var cmdText = "sp_delete_car";

            var cmd = new SqlCommand(cmdText, conn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@carId", SqlDbType.Int);

            cmd.Parameters["@carId"].Value = carId;

            var rows = 0;

            try
            {
                conn.Open();

                rows = cmd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }

        }

        public List<Car> getAllCars()
        {
            // Make return variable if appropriate
            List<Car> cars = new List<Car>();

            // connection
            var conn = Database.GetConnection();

            // command text
            var cmdText = "sp_select_all_cars";

            // command
            var cmd = new SqlCommand(cmdText, conn);

            // command type
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                conn.Open();

                var reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Car car = new Car();
                        car.CarId = reader.GetInt32(0);
                        car.Make = reader.GetString(1);
                        car.Model = reader.GetString(2);
                        car.Year = reader.GetInt32(3);
                        cars.Add(car);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return cars;
        }

        public Car getCarById(int carId)
        {
            // Make return variable if appropriate
            Car car = null;

            // connection
            var conn = Database.GetConnection();

            // command text
            var cmdText = "sp_select_car_by_id";

            // command
            var cmd = new SqlCommand(cmdText, conn);

            // command type
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@id", SqlDbType.Int);

            cmd.Parameters["@id"].Value = carId;

            try
            {
                conn.Open();

                var reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        car = new Car();
                        car.CarId = reader.GetInt32(0);
                        car.Make = reader.GetString(1);
                        car.Model = reader.GetString(2);
                        car.Year = reader.GetInt32(3);
                        
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return car;
        }

        public Car updateCar(Car car)
        {
            var conn = Database.GetConnection();

            var cmdText = "sp_update_car";

            var cmd = new SqlCommand(cmdText, conn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@carId", SqlDbType.Int);
            cmd.Parameters.Add("@make", SqlDbType.VarChar, 100);
            cmd.Parameters.Add("@model", SqlDbType.VarChar, 100);
            cmd.Parameters.Add("@year", SqlDbType.Int);

            cmd.Parameters["@carId"].Value = car.CarId;
            cmd.Parameters["@make"].Value = car.Make;
            cmd.Parameters["@model"].Value = car.Model;
            cmd.Parameters["@year"].Value = car.Year;

            var rows = 0;

            try
            {
                conn.Open();

                rows = (int)cmd.ExecuteNonQuery();

                if (rows == 0)
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            
            return car;
        }
    }
}
