using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            // var id = Guid.NewGuid();
            // id.ToString();

            // id = new Guid("bfb7e1cd-d615-4b36-bbb0-c2e55f9fc529");
            // if (id == Guid.NewGuid())

            // Console.WriteLine(id.ToString().Substring(0, 8));

            double preco = 10.2;
            double precoPromocao = 8.5;
            string texto = $"O preço do produto é R${preco} \n agora na promoção custa R${precoPromocao}";
            //string texto = string.Format("O preço do produto é R${0} agora na promoção é R${1}.", preco, precoPromocao);
            Console.WriteLine(texto);
        }
    }
}
