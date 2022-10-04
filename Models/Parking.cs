using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace parking_system.Models
{
    public class Parking
    {
        private decimal initialPrice = 0;
        private decimal pricePerHour = 0;
        private List<string> vehicles = new List<string>();

        public Parking(decimal initialPrice, decimal pricePerHour)
        {
            this.initialPrice = initialPrice;
            this.pricePerHour = pricePerHour;
        }

        public void addingVehicles()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");

            vehicles.Add(Console.ReadLine());
        }
    }
}