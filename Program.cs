using System;
using System.Linq;
using System.Text;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            /*GUIDS*/
            // var id = Guid.NewGuid();
            // id.ToString();

            // id = new Guid("bfb7e1cd-d615-4b36-bbb0-c2e55f9fc529");
            // if (id == Guid.NewGuid())

            // Console.WriteLine(id.ToString().Substring(0, 8));
            

            /*INTERPOLAÇÃO DE STRINGS*/
            // double preco = 10.2;
            // double precoPromocao = 8.5;
            // string texto = $"O preço do produto é R${preco} \n agora na promoção custa R${precoPromocao}";
            // //string texto = string.Format("O preço do produto é R${0} agora na promoção é R${1}.", preco, precoPromocao);
            // Console.WriteLine(texto);
            

            /*COMPARAÇÃO DE STRINGS*/
            // var texto = "Esse texto é um mero teste";
            // Console.WriteLine(texto.Contains("teste"));
            // Console.WriteLine(texto.Contains("Mero"));
            // Console.WriteLine(texto.Contains("@"));
            // Console.WriteLine(texto.Contains("esse", StringComparison.OrdinalIgnoreCase)); //faz ignorar se tiver letra maiuscula ou minuscula
            // Console.WriteLine(texto.Contains(null)); 

            /*STARTS WITH/ ENDS WITH*/
            // string texto = "Isso é um teste boy";
            // Console.WriteLine(texto.StartsWith("Isto"));
            // Console.WriteLine(texto.StartsWith("Isso"));
            // Console.WriteLine(texto.StartsWith("Este"));
            // Console.WriteLine(texto.EndsWith("boi"));
            // Console.WriteLine(texto.EndsWith("Boy" , StringComparison.OrdinalIgnoreCase));
            // Console.WriteLine(texto.EndsWith("boy"));

            /*EQUALS*/
            // string texto = "Isso é um teste boy";
            // Console.WriteLine(texto.Equals("Isso é um teste boy"));//EQUALS analisa se é exatamente igual ao objeto
            // Console.WriteLine(texto.Equals("isso e um teste bóy"));
            // Console.WriteLine(texto.Equals("Isso e um texte"));

            /*ÍNDICES*/
            // string texto = "Esse texto é um teste";
            // Console.WriteLine(texto.IndexOf("é"));
            // Console.WriteLine(texto.LastIndexOf("s"));
            // Console.WriteLine(texto.IndexOf("e"));
            // Console.WriteLine(texto.Insert(5,"Funcionasse?"));
            // Console.WriteLine(texto.Remove(6,8));
            // Console.WriteLine(texto.Length);

            /*MANIPULANDO STRINGS*/
            
            // string texto = " Esse texto é um teste boy ";
            // Console.WriteLine(texto.Replace("Esse", "isto")); //substitui o 1º valor pelo 2º inserido no Replace
            // Console.WriteLine(texto.Replace("e", "a"));

            // var dividir = texto.Split(" ");
            // Console.WriteLine(dividir[0]);
            // Console.WriteLine(dividir[1]);
            // Console.WriteLine(dividir[2]);
            // Console.WriteLine(dividir[3]);
            // Console.WriteLine(dividir[4]);
            // Console.WriteLine(dividir[5]);

            // var resultado = texto.Substring(5, 10);//começa a partir do 5º caracter e em seguida pega os próximos 5 caracteres
            // Console.WriteLine(resultado);

            // Console.WriteLine(texto.Trim());

            /*STRING BUILDER*/

            var texto = new StringBuilder();
            texto.Append(" Sem abuso ");
            texto.Append(" Se eu estou com você ");
            texto.Append("Não sou de ninguem ");
            texto.Append("Eu sou o Seu bem ");

            texto.ToString();
            Console.WriteLine(texto);
        }
    }
}
