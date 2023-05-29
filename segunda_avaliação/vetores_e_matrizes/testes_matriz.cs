using System;
using System.Collections;
class Program{
    static void Main(string[] args){
    /*
    int[] v = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    for (int i = 0; i < v.Length; i++)
        Console.WriteLine(v[i]);
    Console.ReadKey();
    */
    //================================================
    /*
    int[] v = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    foreach (int i in v) //--> vê elemento por elemento
    if (i % 2 == 0) Console.WriteLine(i);
    Console.ReadKey(); 
    //================================================
    int[] v = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    for (int i = 0; i < v.Length; i++) //Analisa indices pares
    if (i % 2 == 0) Console.WriteLine(v[i]);
    Console.ReadKey();
    //================================================
    int[] v = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    IEnumerator x = v.GetEnumerator();
    while (x.MoveNext())
    Console.WriteLine(x.Current);
    Console.ReadKey(); 
    //================================================
    int[] v = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    int[] w = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
    for (int i = 0; i < v.Length; i++)
    Console.WriteLine(v[i] + w[w.Length-1-i]);
    Console.ReadKey();
    //================================================
    int[] v = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    int[] w = new int[10];
    Array.Copy(v, w, 5); //Copia os primeiros elementos do array v para o array w
    foreach (int i in w) //{1, 2, 3, 4, 5, 0,0,0,0,0}
        Console.WriteLine(i);
    Console.ReadKey(); 
    //================================================
    int[] v = { 10, 8, 6, 4, 2, 1, 3, 5, 7, 9 };
    Array.Sort(v);
    foreach (int i in v)
    Console.WriteLine(i);
    Console.ReadKey();
    //================================================
     int[] v = { 10, 8, 6, 4, 2, 1, 3, 5, 7, 9 };
    Array.Reverse(v);
    foreach (int i in v)
        Console.WriteLine(i);
    Console.ReadKey(); 
    //================================================
    int[] v = { 10, 8, 6, 4, 2, 1, 3, 5, 7, 9 };
    int p1 = Array.IndexOf(v, 5); // retorna o índice do elemento 5
    int p2 = Array.IndexOf(v, 10); // retorna o índice do elemento 10
    int p3 = Array.IndexOf(v, 15); // retorna -1 para indicar que o índice não foi encontrado
    Console.WriteLine(p1);
    Console.WriteLine(p2);
    Console.WriteLine(p3);
    Console.ReadKey();
    //================================================
    int[] v = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    Array.ForEach(v, i => Console.WriteLine(i * i)); // => é o operador de seta que separa o parâmetro da expressão lambda do corpo da função. 
    Console.ReadKey();  // recebe como parâmetros o array a ser percorrido e uma expressão lambda
    //================================================
    int[,] m = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };
    Console.WriteLine(m.Length); //Retorna o número total de elementos da matriz
    Console.WriteLine(m.GetLength(0)); // Retorna o tamanho da primeira dimensão da matriz (linhas)
    Console.WriteLine(m.GetLength(1)); // Retorna o tamanho da segunda dimensão da matriz (colunas)
    Console.ReadKey();
    //================================================
    int[,] m = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, {13, 14, 15, 16 } };
    for (int i = 0; i < m.GetLength(0); i++)
    {
    for (int j = 0; j < m.GetLength(1); j++)
    Console.Write("{0,5}", m[i, j]);
    Console.WriteLine();
    }
    Console.ReadKey(); 
    //================================================ 
    int[,] m = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 },
    { 9, 10, 11, 12 }, {13, 14, 15, 16 } };
    foreach (int i in m)
    Console.WriteLine(i);
    Console.ReadKey();
    */ 
 }
}
