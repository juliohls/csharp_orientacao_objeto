using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            // Aprendendo Endereço de referência no objeto
            ContaCorrente contaGabriela = new ContaCorrente();
            contaGabriela.titular = "Gabriela";
            contaGabriela.agencia = 863;
            contaGabriela.conta = 863452;

            ContaCorrente contaGabrielaCosta = new ContaCorrente();
            contaGabrielaCosta.titular = "Gabriela";
            contaGabrielaCosta.agencia = 863;
            contaGabrielaCosta.conta = 863452;

            Console.WriteLine(contaGabriela == contaGabrielaCosta); // Igualdade de tipo de referência -  False

            int idade = 27;
            int idade2 = 27;

            Console.WriteLine(idade == idade2); // Igualdade de tipo de valor - True

            contaGabriela = contaGabrielaCosta; // Deixando a referência na memoria igual

            contaGabriela.saldo = 300;
            Console.WriteLine(contaGabriela.saldo);
            Console.WriteLine(contaGabrielaCosta.saldo); // O valor muda nas duas contas porque estão referênciando o mesmo objeto

            Console.ReadLine();
        }
    }
}
