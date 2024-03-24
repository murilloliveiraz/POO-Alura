﻿namespace ScreenSound_POO.Exercicios.modulo4
{
    internal class Dono
    {
        public string Nome { get; set; }
        public string Contato { get; set; }
        public Veiculo Veiculo { get; set; }

        public Dono(string nome, string contato)
        {
            Nome = nome;
            Contato = contato;
        }

        public void setVeiculo(Veiculo veiculo)
        {
            Veiculo = veiculo;
        }
    }
}
