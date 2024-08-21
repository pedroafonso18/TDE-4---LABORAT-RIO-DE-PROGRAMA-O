int menu = 0;
int menu2 = 0;
double pedidoTotal = 0.0;

while (true){
Console.WriteLine("Escolha a sua opção! : 1 = Adicionar Item ao pedido, 2 = Exibir Total do Pedido, 3 = Finalizar Pedido e Sair!");
menu = Convert.ToInt32(Console.ReadLine());

switch (menu){
    case 1: {
        Console.WriteLine("Qual item você deseja adicionar? 1- Pizza(R$ 30,00), 2 - Hamburguer(R$ 15,00), 3 - Refrigerante (R$ 5,00)");
        menu2 = Convert.ToInt32(Console.ReadLine());
        switch (menu2){
            case 1: {
                Console.WriteLine("Pedido Adicionado!");
                pedidoTotal += 30.00;
                continue;
            }
            case 2: {
                Console.WriteLine("Pedido Adicionado!");
                pedidoTotal += 15.00;
                continue;
            }
            case 3: {
                Console.WriteLine("Pedido Adicionado!");
                pedidoTotal += 5.00;
                continue;
            }
            default:
            {
                Console.WriteLine("Não encontrei seu pedido, pode tentar novamente?");
                continue;
            }
        }

    }

    case 2: {
        Console.WriteLine($"Claro! O pedido está no total de R${pedidoTotal}");
        continue;
    }

    case 3: {
        Console.WriteLine($"Ok, o pedido no valor de R${pedidoTotal} está à caminho! Muito obrigado!");
        break;
    }
    }
if (menu == 3){
    break;
}
}
