using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nandm = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(nandm[1]);
            int m = Convert.ToInt32(nandm[0]);
            char[,] matrix = new char[m,n];
            for(int i = 0; i<m;i++)
            {
                string line = Console.ReadLine();
                line = line.Replace(" ", string.Empty);
                for(int j = 0; j<n; j++)
                {
                    matrix[i, j] = line[j];
                }
            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if(j!=n-1&&matrix[i,j]==matrix[i,j+1])
                    {
                        if(j==0||matrix[i, j] != matrix[i, j - 1])
                        {
                            int _j = j;
                            int count = 1;
                            do
                            {
                                count++;
                                _j++;
                            } while (_j != n - 1 && matrix[i, _j] == matrix[i, _j + 1]);
                            Console.WriteLine($"- [{i + 1} {j + 1}] {matrix[i,j]} {count}");
                        }
                    }
                    if(j != n - 1&& i != m - 1&&matrix[i,j]==matrix[i+1,j+1])
                    {
                        if (j==0||i==0 || matrix[i, j] != matrix[i - 1, j - 1])
                        {
                            int _j = j;
                            int _i = i;
                            int count = 1;
                            do
                            {
                                count++;
                                _j++;
                                _i++;
                            } while (_j != n - 1 && _i != m - 1 && matrix[_i, _j] == matrix[_i+1, _j + 1]);
                            Console.WriteLine($"\\ [{i + 1} {j + 1}] {matrix[i, j]} {count}");
                        }
                    }
                    if(i != m - 1 && matrix[i,j]==matrix[i+1,j])
                    {
                        if (i == 0 || matrix[i, j] != matrix[i - 1, j])
                        {
                            int _i = i;
                            int count = 1;
                            do
                            {
                                count++;
                                _i++;
                            } while (_i != m - 1 && matrix[_i, j] == matrix[_i, j + 1]);
                            Console.WriteLine($"| [{i + 1} {j + 1}] {matrix[i, j]} {count}");
                        }
                    }
                    if (j!=0&& i != m - 1 && matrix[i, j] == matrix[i + 1, j - 1])
                    {
                        if (i == 0 || j == n-1|| matrix[i, j] != matrix[i - 1, j + 1])
                        {
                            int _j = j;
                            int _i = i;
                            int count = 1;
                            do
                            {
                                count++;
                                _j--;
                                _i++;
                            } while (_j != 0 && _i != m - 1 && matrix[_i, _j] == matrix[_i + 1, _j - 1]);
                            Console.WriteLine($"/ [{i + 1} {j + 1}] {matrix[i, j]} {count}");
                        }
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
