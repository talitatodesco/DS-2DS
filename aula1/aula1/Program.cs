using System; // import de um namespace
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace aula1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declarando variáveis
            // int num1;
            // num1 = 2;
            // int num1 = 2;



            // declaração por Inferência de Dados
            // var num1 = 2.1;



            // double num1 = 2020.12;
            // int num2 = (int)num1; // cast



            // string texto = "12";
            // int num2 = int.Parse(texto);



            // concatenação
            // string primeira = "Wagner"; // W = 0, a = 1...
            // string segunda = "Barth";
            // string unidos = "O nome é: " + primeira + " " + segunda + ".";
            //string unidos = $"O nome é: {primeira} {segunda}."; // interpolação de strings



            // DateTime



            // DateTime dia = DateTime.Today;
            // DateTime agora = DateTime.Now;



            // criar um objeto data
            // DateTime data = DateTime.Now;
            // DateTime novaData = data.AddDays(5);



            // Console.WriteLine(data);
            // Console.WriteLine(novaData.ToLongTimeString());



            // aula dia 26/08/2022



            // array
            int[] numeros = new int[3]; // inicia na posição 0

            numeros[0] = 1;
            numeros[1] = 12;
            numeros[2] = 21;

            Console.WriteLine(numeros[2] + numeros[0]);

            numeros[2] = 30;
            Console.WriteLine(numeros[2] + numeros[0]);


            var nomes = new string[] { "Wagner", "Antonio", "Todesco" };
            Console.WriteLine(nomes[2]);

            Console.ReadKey();

        }
    }
}