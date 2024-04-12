﻿using AccommodationManagerApp.Model;
using AccommodationManagerApp.Repository;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccommodationManagerApp.Service {
    public class VehicleService {
        private readonly VehicleRepository _vehicleRepository;

        public VehicleService(VehicleRepository vehicleRepository) {
            _vehicleRepository = vehicleRepository;
        }

        public List<Vehicle> GetAll() {
            return _vehicleRepository.GetAll().ToList();
        }

        public List<Vehicle> GetAllWithRoom() {
            return _vehicleRepository.GetAllWithRoom().ToList();
        }

        public void Add(Vehicle vehicle) {
            _vehicleRepository.Add(vehicle);
        }

        public void Update(int id, Vehicle vehicle) {
            _vehicleRepository.Update(id, vehicle);
        }

        public bool Delete(int id) {
            try {
                _vehicleRepository.Delete(id);
                return true;
            }
            catch (Exception e) {
                Console.WriteLine(e);
                return false;
            }
        }

        public Vehicle GetByNumber(string number) {
            return _vehicleRepository.GetByNumber(number);
        }

        public Vehicle GetByIdWithRoom(int id) {
            return _vehicleRepository.GetByIdWithRoom(id);
        }

        public List<Vehicle> GetAllByRoomId(int roomId) {
            return _vehicleRepository.GetAllByRoomId(roomId).ToList();
        }

        public bool IsVehicleNumberExists(string vehicleNumber) {
            return _vehicleRepository.GetByNumber(vehicleNumber) != null;
        }

        public int GenerateVehicleFeeByRoomId(int? roomId) {
            var totalFee = 0;

            if (roomId != null) {
                var vehicles = GetAllByRoomId(roomId.Value);

                foreach (var vehicle in vehicles) {
                    totalFee += vehicle.Price;
                }
            }

            return totalFee;
        }

        public List<Vehicle> GetByCustomizeQuery(List<Vehicle> vehicles, VehicleCategory type, List<string> text)
        {
            var filteredVehicles = vehicles.Where(vehicle =>
                (vehicle.Category == type || type == VehicleCategory.Null) &&
                (text[0] == null || text[0].Equals(vehicle.Name, StringComparison.OrdinalIgnoreCase)) &&
                (text[1] == null || text[1].Equals(vehicle.Room.RoomNumber, StringComparison.OrdinalIgnoreCase)) &&
                (text[2] == null || text[2].Equals(vehicle.Number, StringComparison.OrdinalIgnoreCase)) 
            );
            return filteredVehicles.ToList();
        }
    }
}