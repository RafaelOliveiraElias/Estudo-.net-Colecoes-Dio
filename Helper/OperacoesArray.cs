using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Colecoes.Helper
{
    public class OperacoesArray
    {
        public void OrdenarBubbleSort(ref int[] array)
        {  
            int temp = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if(array[j] > array[j + 1])
                    {
                        temp = array[ j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }
        public void ImprimirArray(int[] array)
        {
            var linha = string.Join(", ", array);
            System.Console.WriteLine(linha);
        }

        public void Ordenar(ref int[] array)
        {
            Array.Sort(array);
        }

        public void Copiar(ref int[] array, ref int [] arrayDestino)
        {
            Array.Copy(array, arrayDestino, array.Length);
        }

        public bool Existe(int[] array, int valor)
        {
            // mesmo que o .includes do JS
            return Array.Exists(array, element => element == valor);
        }
        public bool TodosMaiorQue(int[] array, int valor)
        {
            //mesmo que o .every do JS
            return Array.TrueForAll(array, each => each > valor);
        }

        public int ObterValor(int[] array, int valor)
        {
            //mesmo que o .every do JS Array.FindAll = filter no JS
            return Array.Find(array, each => each == valor);
        }

        public int ObterIndice(int[] array, int valor)
        {
            //mesmo que o .every do JS Array.FindAll = filter no JS
            return Array.IndexOf(array, valor);
        }
    }
}