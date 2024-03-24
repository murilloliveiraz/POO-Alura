namespace ScreenSound_POO.Exercicios.modulo4
{
    internal class Oficina
    {
        public Mecanico Mecanico { get; set; }
        public string Nome { get; set; }
        public List<Veiculo> VeiculosNaOficina { get; set; }

        public Oficina(Mecanico mecanico, string nome)
        {
            Mecanico = mecanico;
            Nome = nome;
            VeiculosNaOficina = new List<Veiculo>();
        }

        public void MarcarManutencao(Veiculo veiculo, string data, string servico)
        {
            VeiculosNaOficina.Add(veiculo);
            Console.WriteLine($"Manutencão agendada para o veiculo {veiculo.Nome}, placa: {veiculo.Placa}");
            Console.WriteLine($"Detalhes: {Mecanico.Nome} \n Serviço: {servico} \n Data: {data}");
        }

        public void RealizarManutencao(Veiculo veiculo)
        {
            if (VeiculosNaOficina.Contains(veiculo))
            {

                Console.WriteLine($"Serviço realizado em {veiculo.Placa} pelo mecânico {Mecanico.Nome}.");
                VeiculosNaOficina.Remove(veiculo);
            }
            else
            {
                Console.WriteLine($"O veículo {veiculo.Placa} não está na oficina para realizar o serviço.");
            }
        }
    }
}

/** // Criar instâncias de Veiculo, Cliente, Mecanico e Oficina
using ScreenSound_POO.Exercicios.modulo4;

Veiculo meuCarro = new Veiculo("Chevrolet Cruze", "ABC1234");
Dono cliente = new Dono("Carlos", "987654321");
Mecanico mecanico = new Mecanico("Mário", "Mecânica Geral");
Oficina oficina = new Oficina(mecanico, "Oficina 2 irmaos");

// Agendar e realizar um serviço na oficina
oficina.MarcarManutencao(meuCarro,"2023-12-18", "Trocar Pneu");
oficina.RealizarManutencao(meuCarro);**/