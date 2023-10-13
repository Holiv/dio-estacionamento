using System;
namespace DIOEstacionamento.Models
{
	public class Estacionamento
	{
        private readonly decimal precoInicial;
        private readonly decimal precoPorHora;
        private List<string> veiculos = new();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
		{
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do Veículo");
            try
            {
                veiculos.Add(Console.ReadLine().ToUpper());
                Console.WriteLine("Veículo adicionado com sucesso");
            }
            catch
            {
                Console.WriteLine("Placa inválida");
            }
            
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do carro a ser removido: ");
            var placa = Console.ReadLine().ToUpper();

            if(veiculos.Contains(placa))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado");
                int horas = int.Parse(Console.ReadLine());
                decimal valorTotal = precoInicial + (horas * precoPorHora);

                veiculos.Remove(placa);

                Console.WriteLine($"O veículo de placa {placa} foi removido e o valor total foi de {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, este veículo não está estacionado aqui. Verifique se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados aqui são:");
                foreach (var veiculo in veiculos)
                {
                    Console.WriteLine($"{veiculo}");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }

    }
}

