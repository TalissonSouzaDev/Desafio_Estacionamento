// See https://aka.ms/new-console-template for more information
using DesafioFundamentos.Models;
bool Rep = true;
Estacionamento estacionamento = new Estacionamento();


estacionamento.PrecoIn_Preco_hr();


while (Rep)
{
    estacionamento.MsgOpcao();
    switch (estacionamento.opcao)
    {
        case "1":
            estacionamento.AdicionarVeiculo();
            break;

        case "2":
            estacionamento.RemoveVeiculo();
            break;

        case "3":
            estacionamento.ListaVeiculo();
            Console.WriteLine("Pressione uma tecla para continuar");
            Console.ReadKey();
            break;

        default:
            Console.Clear();
            Console.WriteLine("Programa Encerrado");
            Rep = false;

            break;
    }
}

