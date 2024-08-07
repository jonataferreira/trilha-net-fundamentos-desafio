namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void LimparTela ()
        {
            Console.Clear();
        }

        public void AdicionarVeiculo()
        {
            LimparTela();
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();
            
            //Verifica se há duplicidade de placas;
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine($"Veículo {placa} já foi cadastrado, Confira se digitou a placa corretamente.");
            }
            else
            {
                veiculos.Add(placa);
                LimparTela();
                Console.WriteLine($"Veículo {placa} cadastrado com sucesso!");
            }
        }

        public void RemoverVeiculo()
        {
            LimparTela();
            //Verifica se há placas registradas usando count
            if (veiculos.Count != 0)
            {
                
                Console.WriteLine("Digite a placa do veículo para remover:");
                string placa = "";
                placa = Console.ReadLine();


                // Verifica se o veículo existe
                if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
                {
                    
                    Console.WriteLine("Digite a quantidade de horas completas que o veículo permaneceu estacionado:");
                    int horas = 0;
                    horas = Convert.ToInt32(Console.ReadLine());

                    decimal valorTotal = 0;
                    valorTotal = precoInicial + (precoPorHora * horas);

                    LimparTela();
                    Console.WriteLine($"O veículo {placa} Permaneceu por {horas} horas, o preço total foi de: R$ {valorTotal}");
                    Console.WriteLine("Veículo removido do sistema com sucesso! ");
                    veiculos.Remove(placa);
                }

                else
                {
                    Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
                }
            }

            else
            {
                Console.WriteLine("Não há placas cadastradas. Por favor, adicione uma placa usando o menu principal");
            }
        }

        public void ListarVeiculos()
        {
            LimparTela();
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                
                //Laço feito por ForEach
                veiculos.ForEach(x => Console.WriteLine(x));
                
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
