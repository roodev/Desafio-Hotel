namespace DesafioProjetoHospedagem.Models
{
	public class Reserva
	{
		public List<Pessoa> Hospedes { get; set; }
		public Suite Suite { get; set; }
		public int DiasReservados { get; set; }

		public Reserva() { }

		public Reserva(int diasReservados)
		{
			DiasReservados = diasReservados;
		}

		public void CadastrarHospedes(List<Pessoa> hospedes)
		{
			// TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
			if (Suite.Capacidade >= hospedes.Count)
			{
				Hospedes = hospedes;
			}
			else
			{
				// TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
				throw new Exception($"Não foi possível efetuar a reserva. Você deseja acomodar {hospedes.Count} hóspedes e a suíte selecionada comporta apenas {Suite.Capacidade} hóspedes");
			}
		}

		public void CadastrarSuite(Suite suite)
		{
			Suite = suite;
		}

		public int ObterQuantidadeHospedes()
		{
			// TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
			return Hospedes.Count;
		}

		public decimal CalcularValorDiaria()
		{
			// TODO: Retorna o valor da diária
			decimal valorIntegral = DiasReservados * Suite.ValorDiaria;
			decimal valor = valorIntegral;

			// Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
			if (DiasReservados >= 10)
			{
				decimal desconto = valorIntegral * 10 / 100;
				valor = valorIntegral - desconto;
			}

			return valor;
		}
	}
}