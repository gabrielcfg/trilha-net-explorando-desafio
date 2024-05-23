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
            // DONE 
            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
                //DONE
                Console.WriteLine("Você inseriu uma quantidade de hospedes maior do que a comportada nesta suíte.");
                return;
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // DONE
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            // DONE
            decimal valor = (DiasReservados * Suite.ValorDiaria);

            // DONE
            if (DiasReservados >= 10)
            {
                valor = (valor - (valor / 10));
            }

            return valor;
        }
    }
}