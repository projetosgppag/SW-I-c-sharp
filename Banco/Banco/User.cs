using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    internal class User : Banco
    {
        private string _Name { get; set; }
        private string _Password { get; set; }
        private string _Cpf { get; set; }
        private double _Saldo { get; set; }
        private double _Limite { get; set; }

        public User(string name, string password, string cpf, double saldo, double limite)
        {
            _Name = name;
            _Password = password;
            _Cpf = cpf;
            _Saldo = saldo;
            _Limite = limite;
        }

        public void Register()
        {
            Console.WriteLine("----- Cadastro de User -----");
            Console.Write("Nome: ");
            _Name = Console.ReadLine();
            Console.Write("Senha: ");
            _Password = Console.ReadLine();
            Console.Write("CPF: ");
            _Cpf = Console.ReadLine();
            Console.Write("Saldo: ");
            _Saldo = Convert.ToDouble(Console.ReadLine());
            Console.Write("Limite: ");
            _Limite = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Usuário registrado com sucesso!");
            Console.WriteLine();
        }

        public bool Login()
        {
            Console.WriteLine("----- Login -----");
            Console.Write("CPF: ");
            string cpf = Console.ReadLine();
            Console.Write("Senha: ");
            string password = Console.ReadLine();

            if (_Cpf == cpf && _Password == password)
            {
                Console.WriteLine("Login realizado com sucesso");
                Console.WriteLine();
                return true;
            }
            else
            {
                Console.WriteLine("CPF ou senha incorretos.");
                Console.WriteLine();
                return false;
            }
        }

        public void Saque()
        {
            Console.WriteLine("----- Realizar Saque -----");
            Console.Write("Valor do saque: ");
            double valor = Convert.ToDouble(Console.ReadLine());

            double saldoLimite = _Saldo + _Limite;
            if (valor > saldoLimite)
            {
                Console.WriteLine("Saldo insuficiente.");
            }
            else if (valor > _Saldo)
            {
                double limiteUtilizado = valor - _Saldo;
                Console.WriteLine("Saque realizado com sucesso, mas ultrapassou o limite.");
                Console.WriteLine("O limite ficou: " + (_Limite - limiteUtilizado) + " e o saldo: 0");
                _Limite -= limiteUtilizado;
                _Saldo = 0;
            }
            else
            {
                _Saldo -= valor;
                Console.WriteLine("Saque realizado com sucesso");
                Console.WriteLine("Saldo restante: " + _Saldo);
            }
            Console.WriteLine();
        }

        public void Deposito()
        {
            Console.WriteLine("---- RealizarDeposito ----");
            Console.Write("Valor do depósito: ");
            double valor = Convert.ToDouble(Console.ReadLine());

            _Saldo += valor;
            Console.WriteLine("Deposito realizado com sucesso");
            Console.WriteLine("Saldo atual: R$ " + _Saldo.ToString("0.00"));
        }

        public void Emprestimo()
        {
            Console.WriteLine("----- Solicitar Emprestimo -----");
            Console.Write("Valor do emprestimo: ");
            double valor = Convert.ToDouble(Console.ReadLine());

            Console.Write("Prazo (em meses): ");
            int prazo = Convert.ToInt32(Console.ReadLine());

            double juros = 0.06;
            double parcelaComJuros = (valor * juros) + (valor / prazo);
            double totalPagar = parcelaComJuros * prazo;

            Console.WriteLine("Empréstimo realizado com sucesso");
            Console.WriteLine("Valor a pagar: " + totalPagar.ToString("0.00"));
            Console.WriteLine("Prazo: " + prazo + " meses");
        }
    }
}