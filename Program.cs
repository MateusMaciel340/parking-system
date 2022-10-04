using parking_system.Models;

Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal initialPrice = 0;
decimal pricePerHour = 0;

Console.WriteLine("Seja bem vindo ao estacionamento!\n" +
    "Digite o preço inicial: ");
initialPrice = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Agora digite o preço por hora: ");
pricePerHour = Convert.ToDecimal(Console.ReadLine());

Parking parking = new Parking(initialPrice, pricePerHour);

string option = string.Empty;
bool displayMenu = true;

while (displayMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");

    switch (Console.ReadLine())
    {
        case "1":
            Console.WriteLine("Adicionando!");
            break;
        
        case "2":
            Console.WriteLine("Removendo!");
            break;

        case "3":
            Console.WriteLine("Listando!");
            break;

        case "4":
            displayMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida!");
            break;
    }

    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
}

Console.WriteLine("O programa se encerrou");