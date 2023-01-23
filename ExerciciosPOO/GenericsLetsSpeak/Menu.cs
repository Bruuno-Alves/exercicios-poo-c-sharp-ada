using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace GenericsLetsSpeak
{
    public class Menu
    {
        public static void Iniciar(Dicionario<string, string> colecao)
        {
            int valor;
            do
            {
                Console.WriteLine("Dicionário Ada\n");
                Console.WriteLine("[1]-Buscar Expressão | [2]-Adicionar Expressão");
                int.TryParse(Console.ReadLine(), out valor);
                if (valor == 1 || valor == 2)
                {
                    break;
                }
                Console.WriteLine("Valor Inválido. Por favor tente novamente...");
                System.Threading.Thread.Sleep(2000);
                Console.Clear();
            } while (true);

            if (valor == 1)
            {
                Busca(colecao);
            }
            else
            {
                NovoTermo(colecao);
            }
        }

        private static void NovoTermo(Dicionario<string, string> colecao)
        {
            string termo;
            string significado;
            do
            {
                Console.WriteLine("Qual termo deseja adicionar?");
                termo = Console.ReadLine();
                Console.WriteLine("Qual o significado dele?");
                significado = Console.ReadLine();

                if (termo == null || significado == null)
                {
                    Console.WriteLine("Tanto o termo quanto o significado devem ter seus valores preenchidos");
                }
                else
                {
                    break;
                }
            } while (true);
            colecao.Termos.Add(termo, significado);
            if (!File.Exists("termosDicionario.bin"))
            {
                using (Stream stream = File.Open("termosDicionario.bin", FileMode.Create))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, colecao.Termos);
                }
            }
            using (StreamWriter sw = new StreamWriter("termosDicionario.txt", true))
            {
                sw.WriteLine($"{termo}:{significado}");
            }
            Console.WriteLine("Termo e significado registrados com sucesso!");
        }

        public static void Busca(Dicionario<string, string> colecao)
        {
            string input;
            do
            {
                Console.WriteLine("Informe o termo que deseja buscar");
                input = Console.ReadLine().ToLower();
                if (input.Length <= 2)
                {
                    Console.WriteLine("O termo necessita ter 3 ou mais caracteres");
                    System.Threading.Thread.Sleep(2000);
                    Console.Clear();
                }
                else if (input.Contains("*") || input.Contains("?"))
                {
                    Console.WriteLine("* ou ? não são caracteres válidos para a consulta");
                }
                else
                {
                    break;
                }
            } while (true);
            List<string> Combinacoes = new();
            foreach (KeyValuePair<string, string> termo in colecao.Termos)
            {
                if (termo.Key.ToLower().Contains(input))
                {
                    Combinacoes.Add(termo.Key);
                }
            }
            if (Combinacoes.Count == 0)
            {
                Console.WriteLine("Nenhum termo encontrado");
            }
            else
            {
                foreach (string combinou in Combinacoes)
                {
                    Console.WriteLine($"{combinou} : {colecao.Termos[combinou]}");
                }
            }
        }
    }
}
