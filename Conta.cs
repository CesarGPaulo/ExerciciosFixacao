using System.Globalization;

namespace ExerciciosFixacao
{
    internal class Conta
    {
        public int Numero { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }

        public Conta(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }
        public Conta (int numero, string titular, double depositoInicial) : this (numero, titular) 
        {
            Deposito(depositoInicial); 
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }
        public void Saque (double valorSaque)
        {
            Saldo -= (valorSaque + 5.00);
        }

        public override string ToString()
        {
            return "Conta " + Numero + ", Titular: " + Titular + ", Saldo: $ " + Saldo.ToString("F2", CultureInfo.InvariantCulture); 
        }
    }
}
