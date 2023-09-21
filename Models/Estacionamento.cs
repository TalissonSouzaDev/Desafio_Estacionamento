using System.Globalization;
namespace DesafioFundamentos.Models
{

    public class Estacionamento
    {
        public double preco_inical { get; private set; }
        public double preco_hora { get; private set; }
        public int estacionado_horas { get; private set; }
        private List<string> _Veiculos = new List<string>();

        public string? Placa { get; private set; }
        public string? opcao { get; private set; }




        public void PrecoIn_Preco_hr()
        {
            // pegando preço inicial
            Console.WriteLine("Digite o preço Inicial");
            this.preco_inical = double.Parse(Console.ReadLine());
            // pegando preço por horas
            Console.WriteLine("Agora Digite Preço por hora");
            this.preco_hora = double.Parse(Console.ReadLine());

        }

        // Mensagem de esoclha do usuario

        public void MsgOpcao()
        {

            Console.WriteLine("********** Digite uma Opção ************");
            Console.WriteLine("1- Cadastrar Veiculo");
            Console.WriteLine("2- Remover Veiculo");
            Console.WriteLine("3- Lista Veiculo");
            Console.WriteLine("4- Encerrar!");
            this.opcao = Console.ReadLine();

            // para mostra a mensagem para digita a placa precisa ser diferente de 3 e 4
            if (this.opcao != "3")
            {
                if (this.opcao != "4")
                {
                    Console.WriteLine("Digite a placa do veiculo");
                    this.Placa = Console.ReadLine();
                }

            }

        }



        // Lista todos os veiculos
        public void ListaVeiculo()
        {

            Console.Clear();
            Console.WriteLine("********* Veiculo no estacionamento ***********");
            int indice = 1;
            foreach (string veiculo in this._Veiculos)
            {
                Console.WriteLine($" {indice++}  - {veiculo}");

            }
        }


        public void AdicionarVeiculo()
        {

            // limpa a tela

            if (!_Veiculos.Contains(this.Placa.ToUpper()))
            {
                Console.Clear();
                // adicionar o veiculo
                this._Veiculos?.Add(this?.Placa.ToUpper());
                Console.WriteLine("Veiculo Adicionado no estacionamento com sucesso! 😀");
                Console.ReadKey();
            }

            else
            {
                Console.WriteLine("Humm .. ja existir Veiculo Adicionado no estacionamento com essa placa! 🙁");
                Console.ReadKey();
            }



        }



        public void RemoveVeiculo()
        {
            Console.Clear();
            // verifica se existe
            if (_Veiculos.Any(x => x.ToUpper() == this.Placa.ToUpper()))
            {

                // pegando quantidade de horas
                Console.WriteLine("Quantidade de horas que o veiculo ficou estacionado:");
                this.estacionado_horas = int.Parse(Console.ReadLine());
                // se o usuario digita 0 volta para a pergunta
                if (this.estacionado_horas <= 0)
                {
                    RemoveVeiculo();

                }
                // calculando o valores 
                double Valor = this.preco_inical + (this.preco_hora * this.estacionado_horas);
                // removendo
                this._Veiculos?.Remove(this?.Placa);
                Console.WriteLine($"Veiculo Removido do estacionamento com sucesso! 😀 o valor a ser pago foi de: {Valor:C}");
                Console.ReadKey();


            }
        }


    }
}