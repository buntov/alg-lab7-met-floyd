using System;
using System.Collections.Generic;
using static System.Console;

namespace alg_lab7
{
      class Program
      {



          static void Main(string[] args)
          {
              int inf = 9999999;

              int[,] array = new int[3, 3] // Создание двумерного массива 6x6
                                           //Матрица смежности для применения Алгоритма Флойда
                                    {{ 0, 13, 10 },
                                    { 1, 0, inf },
                                    { inf, 2, 0 }
                                   };

              int i, j, k; // Создание локальных переменных для вычисления

              // Применение алгоритма Флойда с использованием матрицы смежности
              for (k = 0; k < 3; k++)
                  for (i = 0; i < 3; i++)
                      for (j = 0; j < 3; j++)
                          if (array[i, j] > array[i, k] + array[k, j])
                              array[i, j] = array[i, k] + array[k, j];
              ;
               // Вывод измененной матрицы смежности на экран
              Console.WriteLine("Floyd alg : ");
              for (i = 0; i < 3; i++)
              {
                  for (j = 0; j < 3; j++)
                      Console.Write(array[i, j] + "\t");
                  Console.WriteLine();
              }

            /*  for (i = 0;  i < 6; i++)
              {
                  for (j = 0;j < 6; j++)
                  {
                      if (j != i && array[i, j] != -1)
                      {
                          int[] route=new int[19];
                          route.SetValue(i, i);
                          int weight = 0;

                          for (k = 0; k < route.Length-1; k++)
                          {
                              weight += array[route[i], route[j+1]];
                          }
                          Console.WriteLine("Shorter way from {0} to {1} is {2}", i, j, route[i]);
                          Console.WriteLine("Weight: {0}", weight);
                      }
                  }
              }
            */
              Console.ReadLine();
          }
      }





  }
  
   /* enum Graph
    {
        a,
        b,
        c,
        d,
        f,
        g
    }
    class Program
    {
        static int Graph(string value)
        {
            switch (value)
            {
                case "a":
                    return 0;
                case "b":
                    return 1;
                case "c":
                    return 2;
                case "d":
                    return 3;
                case "f":
                    return 4;
                case "g":
                    return 5;
                default:
                    Console.WriteLine("Not found vertex");
                    break;
            }
            return 0;
        }
        static void Floyd(int[,] mainGraph, int from, int to)
        {
            int numberVertex = mainGraph.GetLength(0);
            int[,] vertex = new int[numberVertex, numberVertex];
            int[,] graph = new int[numberVertex, numberVertex]; ;
            for (int i = 0; i < numberVertex; i++)
            {
                for (int j = 0; j < numberVertex; j++)
                {
                    graph[i, j] = mainGraph[i, j];
                }
            }
            for (int k = 0; k < numberVertex; k++)
            {
                for (int i = 0; i < numberVertex; i++)
                {
                    for (int j = 0; j < numberVertex; j++)
                    {
                        if (graph[i, k] + graph[k, j] < graph[i, j] && graph[i, k] !=
                       int.MaxValue && graph[k, j] != int.MaxValue)
                        {
                            graph[i, j] = graph[i, k] + graph[k, j];
                            vertex[i, j] = k;
                        }
                    }
                }
            }
            if (graph[from, to] != int.MaxValue)
            {
                Console.WriteLine($"Самый короткий путь от вершины {(Graph)from} в вершину {(Graph)to}: {graph[from, to]} ");
                string shortWay = "";
                shortWay += (Graph)to;
                int value = to;
                while (value != 0)
                {
                    if (vertex[from, value] != 0)
                    {
                        shortWay += (Graph)vertex[from, value];
                        value = vertex[from, value];
                    }
                    else
                    {
                        shortWay += (Graph)from;
                        break;
                    }
                }
                for (int i = shortWay.Length - 1; i >= 0; i--)
                    Console.Write($"{shortWay[i]} ");
            }
            else
            {
                Console.WriteLine($"Пути от вершины {(Graph)from} в вершину {(Graph)to}не существует ");
            }
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            //Матрица смежности графа данного в задании
            int[,] graph = new int[6, 6] {
 {0, 5, 3, int.MaxValue, int.MaxValue, int.MaxValue},
 {int.MaxValue, 0, int.MaxValue, 6, int.MaxValue, int.MaxValue},
 {int.MaxValue, int.MaxValue, 0, int.MaxValue, 2, 5},
 {int.MaxValue, int.MaxValue, int.MaxValue, 0, 7, 2},
 {int.MaxValue, int.MaxValue, int.MaxValue, int.MaxValue, 0, 1},
 {int.MaxValue, int.MaxValue, int.MaxValue, int.MaxValue, int.MaxValue, 0}
 };
            Console.Write("Введите начальную вершину графа: ");
            int FromVertex = Graph(ReadLine()); // Номер вершины, из которой ищем пути
            Console.Write("Введите конечную вершину графа: ");
            int ToVertex = Graph(ReadLine()); // Номер вершины, в которую ищем пути
            Floyd(graph, FromVertex, ToVertex);
        }
    }
}*/