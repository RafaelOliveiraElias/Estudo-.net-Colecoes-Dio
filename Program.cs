// See https://aka.ms/new-console-template for more information
using Colecoes.Helper;

OperacoesArray op = new OperacoesArray();
int[] array = new int[5] { 6, 3, 8, 1, 9 };
int[] arrayCopia = new int[10];

int valorProcurado = 3;

int valorAchado = op.ObterValor(array, valorProcurado);
int indice = op.ObterIndice(array, valorProcurado);

if(indice > -1 && valorAchado > 0)
{
  System.Console.WriteLine("Indice do elemento {0} é: {1}", valorAchado, indice);
} else {
  System.Console.WriteLine("não achou");
}

// bool TodosMaiorQue = op.TodosMaiorQue(array, valorProcurado);

// if(TodosMaiorQue)
// {
//   System.Console.WriteLine("Todos maiores que: {0}", valorProcurado);
// } else {
//   System.Console.WriteLine("Pelo menos um valor é maior que: {0}", valorProcurado);
// }

// bool existe = op.Existe(array, valorProcurado);

// tb pode : if(Array.Exists(array, element => element == valorProcurado)) {...
// if(existe)
// {
//   System.Console.WriteLine("encontrei o valor: {0}", valorProcurado);
// } else {
//   System.Console.WriteLine("NÃO encontrei o valor: {0}", valorProcurado);
// }
// System.Console.WriteLine("array original");
// op.ImprimirArray(array);

// System.Console.WriteLine("array ordenado");

// op.OrdenarBubbleSort(ref array);

// op.Ordenar(ref array);
// op.ImprimirArray(array);

// System.Console.WriteLine("array antes da copia");
// op.ImprimirArray(arrayCopia);

// op.Copiar(ref array, ref arrayCopia);
// System.Console.WriteLine("array após da copia");
// op.ImprimirArray(arrayCopia);




// int [] arrayInteiros = new int[3];

// arrayInteiros[0] = 10;
// arrayInteiros[1] = 20;
// arrayInteiros[2] = int.Parse("30");


// System.Console.WriteLine("array pelo for");
// for (int i = 0; i < arrayInteiros.Length; i++)
// {
//   System.Console.WriteLine(arrayInteiros[i]);
// }


// System.Console.WriteLine("array pelo forEach");
// foreach (int valor in arrayInteiros)
// {
//   System.Console.WriteLine(valor);
// }

// int[,] matriz = new int[4, 2]
// {
//   { 8, 8 },
//   { 10, 20 },
//   { 50, 100 },
//   { 90, 200 }
// };

// for (int i = 0; i < matriz.GetLength(0); i++)
// {
//   for (int j = 0; j < matriz.GetLength(1) ; j++)
//   {
//     System.Console.WriteLine(matriz[i, j]);
//   }
// }
