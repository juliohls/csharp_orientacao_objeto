﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();

            conta.titular = "Gabriela";

            Console.WriteLine(conta.titular);
            Console.WriteLine(conta.agencia);
            Console.WriteLine(conta.saldo); // Mesmo não atribuindo nenhum valor nas classes, já possuem um valor padrão

            conta.saldo = 200; // Mas se definirmos o valor, altera o padrão, não adiciona
            Console.WriteLine(conta.saldo);

            Console.ReadLine();
        }
    }
}
