﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaGabriela = new ContaCorrente();

            contaGabriela.titular = "Gabriela";
            contaGabriela.agencia = 863;
            contaGabriela.conta = 863452;
            contaGabriela.saldo = 100;

            Console.WriteLine(contaGabriela.titular);
            Console.WriteLine("Agência: " + contaGabriela.agencia);
            Console.WriteLine("Conta: " + contaGabriela.conta);
            Console.WriteLine("Saldo: R$" + contaGabriela.saldo);

            contaGabriela.saldo += 200;
            Console.WriteLine("Saldo: R$" + contaGabriela.saldo);

            Console.ReadLine();
        }
    }
}
