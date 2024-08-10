using System.ComponentModel;
using System.Runtime.CompilerServices;
using Aula_02___Fundamentos.Models;

//classes
// Pessoa p = new Pessoa();

// p.Nome = "Buta";
// p.Idade = 26;
// p.Apresentar();

//metodos
// Calculadora c = new Calculadora();
// c.Somar(2, 2);


//arrays
// int [] arrayInt = new int[3];

// arrayInt[0] = 72;
// arrayInt[1] = 64;
// arrayInt[2] = 50;

// for(int count = 0; count < arrayInt.Length; count++){
//     Console.WriteLine($"Posição N {count} - {arrayInt[count]}");
// }

//foreach com array
// Console.WriteLine("\n");

// int count2 = 0;
// foreach(int valor in arrayInt){
//     Console.WriteLine($"Posição N {count2} - {valor}");
//     count2++;
// }

// //redimencionar Array
// Array.Resize(ref arrayInt, 10);

//copiar um array para outro
// int[] arrayInt2 = new int[arrayInt.Length * 2];
// Array.Copy(arrayInt, arrayInt2, arrayInt.Length);


//listas

// List<string> listaString = new List<string>();

// listaString.Add("SP");
// listaString.Add("BA");
// listaString.Add("MG");
//ou
// listaString.AddRange(new string[] { "SP", "BA", "MG" });
//ou
// listaString.AddRange(new List<string> { "SP", "BA", "MG" });

// foreach(string estado in listaString){
//     Console.WriteLine(estado);
// }

//fila
Queue<int> fila = new Queue<int>();

//add elemento
fila.Enqueue(2);
fila.Enqueue(5);
fila.Enqueue(3);

foreach(int item in fila){
    Console.WriteLine(item);
}

//Removendo o primeiro elemento, sempre é o primeiro
Console.WriteLine($"Removendo o primeiro elemento da fila {fila.Dequeue()}");


//Pilha (contrario da fila)
Stack<int> pilha = new Stack<int>();

//add elemento
pilha.Push(1);
pilha.Push(6);
pilha.Push(23);

foreach(int item in pilha){
    Console.WriteLine(item);
}

//removendo o ultimo elemento da pilha, sempre o ultimo
pilha.Pop();
