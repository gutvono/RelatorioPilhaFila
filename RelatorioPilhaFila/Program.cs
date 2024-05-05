using RelatorioPilhaFila;

namespace RelatorioPilhaFila;

internal class Program
{
    private static void Main(string[] args)
    {
        //VARIAVEIS
        int[] vetorDaPilha = CriaVetor();
        int[] vetorDaFila = CriaVetor();
        FilaNumeros fila = new();
        PilhaNumero pilha = new();

        //FUNCOES
        int[] CriaVetor()
        {
            int[] vetorInteiros = new int[10];
            for (int i = 0; i < 10; i++)
            {
                vetorInteiros[i] = new Random().Next(1, 21);
            }
            return vetorInteiros;
        }

        void PopularEstruturas()
        {
            for (int i = 0; i < 10; i++)
            {
                bool repete = false;
                for (int j = 0; j < 10; j++)
                {
                    if (vetorDaFila[i] == vetorDaPilha[j])
                    {
                        repete = true;
                        break;
                    }
                }
                fila.Push(new Numero(vetorDaFila[i], repete));
            }

            for (int i = 0; i < 10; i++)
            {
                bool repete = false;
                for (int j = 0; j < 10; j++)
                {
                    if (vetorDaPilha[i] == vetorDaFila[j])
                    {
                        repete = true;
                        break;
                    }
                }
                pilha.Push(new Numero(vetorDaPilha[i], repete));
            }
        }

        //PROGRAMA
        PopularEstruturas();
        Console.WriteLine("Numeros da PILHA que NÃO repetem NA FILA:");
        pilha.Print(false);

        Console.WriteLine("\nNumeros da FILA que NÃO repetem na PILHA:");
        fila.Print(false);

        Console.WriteLine("\n\nNumeros repetidos:");
        fila.Print(true);
        Console.ReadKey();
    }
}