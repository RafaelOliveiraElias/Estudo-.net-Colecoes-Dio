// See https://aka.ms/new-console-template for more information
using System.Linq;
using Colecoes.Helper;

int[] arrayNumeros = new int[9] {1, 4, 4, 8, 0, 18, 100, 19, 100};

var numerosPares =
  from num in arrayNumeros
  where num % 2 == 0
  orderby num
  select num;


var numerosParesMetodo = arrayNumeros.Where(x => x % 2 == 0).OrderBy(x => x).ToList();

System.Console.WriteLine("Numeros pares query: " + string.Join(", ", numerosPares));

System.Console.WriteLine("Numeros pares Método: " + string.Join(", ", numerosParesMetodo));




var minimo = arrayNumeros.Min();
var maximo = arrayNumeros.Max();
var medio = arrayNumeros.Average();
var soma = arrayNumeros.Sum();
var arrayUnico = arrayNumeros.Distinct().ToArray();

System.Console.WriteLine($"valor máximo: {maximo}, valor mínimo: {minimo}, média : {medio}");

System.Console.WriteLine($"Soma: {soma}");
System.Console.WriteLine($"Array original: {string.Join(", ", arrayNumeros)}");
System.Console.WriteLine($"Array novo: {string.Join(", ", arrayUnico.OrderBy(x=> x))}");



///////////////////////////////////////////////////////////////////////////


//DICTIONARY

// Dictionary<string, string> estados = new Dictionary<string, string>();

// estados.Add("SP","São Paulo");
// estados.Add("MG","Minas Gerais");
// estados.Add("BA","Bahia");

// estados["sp".ToUpper()] = "Sãooo Paulo";


// foreach (KeyValuePair<string, string> item in estados)
// {
//   System.Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }
// System.Console.WriteLine(estados["sp".ToUpper()]); 


// estados.Remove("SP");

// foreach (KeyValuePair<string, string> item in estados)
// {
//   System.Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }


// if (estados.TryGetValue("SC", out var estadoEncontrado))
// {
//   System.Console.WriteLine(estadoEncontrado);
// } else 
// {
//     System.Console.WriteLine("BA Não existe");
//}

///////////////////////////////////////////////////////////////////////////

//FILA LIFO

// Stack<string> pilhaLivros = new Stack<string>();
// pilhaLivros.Push(".NET");
// pilhaLivros.Push("DDD");
// pilhaLivros.Push("Código Limpo");


// System.Console.WriteLine($"Livros para a leitura {pilhaLivros.Count}");
// while (pilhaLivros.Count() > 0)
// {
//   System.Console.WriteLine($"Próximo livro para ler: {pilhaLivros.Peek()}");
//   System.Console.WriteLine($"{pilhaLivros.Pop()} lido com sucesso");
// }

// System.Console.WriteLine($"Livros para a leitura {pilhaLivros.Count}");


///////////////////////////////////////////////////////////////////////////

//FILA TIPO FIFO:

// Queue<string> fila = new Queue<string>();

// fila.Enqueue("Leonardo");
// fila.Enqueue("Eduardo");
// fila.Enqueue("André");

// while (fila.Count() > 0)
// {
//   System.Console.WriteLine($"Pessoas na fila: {fila.Count}");
//   System.Console.WriteLine($"Vez de: {fila.Peek()}");
//   System.Console.WriteLine($"{fila.Dequeue()} atendido");
// }

// System.Console.WriteLine($"Pessoas na fila: {fila.Count}");


///////////////////////////////////////////////////////////////////////////

//LISTAS ABAIXOOOO

// OperacoesLista opLista = new OperacoesLista();
// List<string> estados =  new List<string>() {"SP", "MG", "BA"};
// string[] estadosArray = new string[2] {"SC", "MT"};

// System.Console.WriteLine($"quantidade de elementos na lista {estados.Count()}");


// estados.Insert(1, "RJ");

// opLista.ImprimirLista(estados);

// System.Console.WriteLine($"Removendo o elemento MG");

// estados.Remove("MG");

// estados.AddRange(estadosArray);


// opLista.ImprimirLista(estados);


// foreach (var item in estados)
// {
//   System.Console.WriteLine($"Elemento: {item}");
// }



///////////////////////////////////////////////////////////////////////////


// ABAIXO OPERAÇÔES COM ARRAY:



// OperacoesArray op = new OperacoesArray();
// int[] array = new int[5] { 6, 3, 8, 1, 9 };
// int[] arrayCopia = new int[10];


// System.Console.WriteLine($"capacidade atual do array: {array.Length}");

// op.RedimensionarArray(ref array, array.Length * 2 );


// System.Console.WriteLine($"capacidade atual do array após redimensionar: {array.Length}");
// //convertall = map no js
// string[] teste = Array.ConvertAll(array, each => each.ToString());

// System.Console.WriteLine(Array.ConvertAll(array, each => each.ToString())[1]);

// teste[2] = "3";
// int valorProcurado = 3;

// int valorAchado = op.ObterValor(array, valorProcurado);
// int indice = op.ObterIndice(array, valorProcurado);

// if(indice > -1 && valorAchado > 0)
// {
//   System.Console.WriteLine("Indice do elemento {0} é: {1}", valorAchado, indice);
// } else {
//   System.Console.WriteLine("não achou");
// }

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
