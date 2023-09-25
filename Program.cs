using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Hóspede 1");
Pessoa p2 = new Pessoa(nome: "Hóspede 2");
Pessoa p3 = new Pessoa(nome: "Hóspede 3");
Pessoa p4 = new Pessoa(nome: "Hóspede 4");
Pessoa p5 = new Pessoa(nome: "Hóspede 5");
Pessoa p6 = new Pessoa(nome: "Hóspede 6");
Pessoa p7 = new Pessoa(nome: "Hóspede 7");
Pessoa p8 = new Pessoa(nome: "Hóspede 8");
Pessoa p9 = new Pessoa(nome: "Hóspede 9");
Pessoa p10 = new Pessoa(nome: "Hóspede 10");

hospedes.Add(p1);
hospedes.Add(p2);
hospedes.Add(p3);
hospedes.Add(p4);
hospedes.Add(p5);
hospedes.Add(p6);
hospedes.Add(p7);
hospedes.Add(p8);
hospedes.Add(p9);
hospedes.Add(p10);

// Cria a suíte
Suite suite = new Suite(tipoSuite: "Premium", capacidade: 15, valorDiaria: 30);

// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva = new Reserva(diasReservados: 10);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");