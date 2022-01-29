using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            // Aprendendo metodos e funções
            ContaCorrente contaBruno = new ContaCorrente();

            contaBruno.titular = "Bruno";

            Console.WriteLine("Saldo: R$" + contaBruno.saldo);
            Console.WriteLine("Sacando..");
            contaBruno.Sacar(50);
            Console.WriteLine("Saque feito!");
            Console.WriteLine("Saldo restante: R$" + contaBruno.saldo);


            contaBruno.Depositar(500);
            Console.WriteLine(contaBruno.saldo);


            ContaCorrente contaGabriela = new ContaCorrente();

            contaGabriela.titular = "Gabriela";

            Console.WriteLine("Saldo Bruno: R$" + contaBruno.saldo);
            Console.WriteLine("Saldo Gabriela: R$" + contaGabriela.saldo);
            contaBruno.Transferir(200, contaGabriela);
            Console.WriteLine("Saldo Bruno: R$" + contaBruno.saldo);
            Console.WriteLine("Saldo Gabriela: R$" + contaGabriela.saldo);

            Console.ReadLine();
        }
    }
}
