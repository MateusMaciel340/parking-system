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

        public void removeVehicles()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            string? board = Console.ReadLine();

            if(vehicles.Any(x => x.ToUpper() == board?.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");


                int hours = 0;
                decimal totalValue = 0;

                hours = Convert.ToInt32(Console.ReadLine());
                totalValue = (initialPrice) + pricePerHour * hours;

                Console.WriteLine($"O veículo {board} foi removido e o preço total foi de: R$ {totalValue}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente.");
            }
        }

        public void listingVehicles()
        {
            if (vehicles.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");

                    foreach (string item in vehicles)
                    {
                        Console.WriteLine(item.ToString());
                    }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados!");
            }
        }
    }
}