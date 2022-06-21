// See https://aka.ms/new-console-template for more information
using Colecoes.Helper;

OperacoesArray op = new OperacoesArray();
int[] array = new int[5] { 6, 3, 8, 1, 9 };
int[] arrayCopia = new int[10];

System.Console.WriteLine("array original");
op.ImprimirArray(array);

System.Console.WriteLine("array ordenado");

// op.OrdenarBubbleSort(ref array);

op.Ordenar(ref array);
op.ImprimirArray(array);

System.Console.WriteLine("array antes da copia");
op.ImprimirArray(arrayCopia);

op.Copiar(ref array, ref arrayCopia);
System.Console.WriteLine("array após da copia");
op.ImprimirArray(arrayCopia);


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
