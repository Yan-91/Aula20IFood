using System;

namespace Aula20
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente("Kaua Deja");
            Console.WriteLine(cliente.MostrarDados());
            

            Restaurante restaurante = new Restaurante("Bela Vista", "Avenida Renata 560");
            Console.WriteLine(restaurante.MostrarDados());
            
            
            Pedido pedido = new Pedido("Pizza Mussarela","Kaua","Bela Vista","Cartão-Debito");
            
            
              
        }
    }
}
