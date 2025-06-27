using System;
using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

//Adicionando os Hóspedes
Pessoa p1 = new Pessoa(nome: "Hóspede 1");
Pessoa p2 = new Pessoa(nome: "Hóspede 2");
Pessoa p3 = new Pessoa(nome: "Hóspede 3");

bool menu = true;

while (menu)
{

    Console.Clear();
    Console.WriteLine("Seja bem-vindos ao Hotel Dev!");

    hospedes.Add(p1);
    hospedes.Add(p2);
    hospedes.Add(p3);

    // Cria a suíte
    Suite suite = new Suite(tipoSuite: "Master", capacidade: 3, valorDiaria: 45);

    // Cria uma nova reserva, passando a suíte e os hóspedes
    Reserva reserva = new Reserva(diasReservados: 12);
    reserva.CadastrarSuite(suite);
    reserva.CadastrarHospedes(hospedes);

    // Exibe a quantidade de hóspedes e o valor da diária
    Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
    Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");

    Console.WriteLine("\nPressione qualquer tecla para continuar ou 'S' para sair.");
    var opcao = Console.ReadKey().Key;
    if (opcao == ConsoleKey.S)
    {
        menu = false;
    }
}
