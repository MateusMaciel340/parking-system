using parking_system.Models;

Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal initialPrice = 0;
decimal pricePerHour = 0;

Console.WriteLine("Seja bem vindo ao estacionamento!\n" +
    "Digite o preço inicial: ");
initialPrice = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Agora digite o preço por hora: ");
pricePerHour = Convert.ToDecimal(Console.ReadLine());