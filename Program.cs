using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Stack<string> pedidos = new Stack<string>();

        pedidos.Push("Tacos");
        pedidos.Push("Torta");
        pedidos.Push("Agua");

        Console.WriteLine(pedidos.Count);
    }
}
