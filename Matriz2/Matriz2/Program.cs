﻿using System;

namespace Matriz2 {
    class Program {
        static void Main(string[] args) {

            string[] line = Console.ReadLine().Split(' ');
            int l = int.Parse(line[0]);
            int c = int.Parse(line[1]);

            int[,] mat = new int[l, c];

            for (int i = 0; i < l; i++) {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < c; j++) {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < l; i++) {
                for (int j = 0; j < c; j++) {

                    if (mat[i, j] == x) {
                        Console.WriteLine($"Position {i},{j}:");
                        if (j > 0) {
                            Console.WriteLine("Left: " + mat[i, j - 1]);
                        }
                        if (i > 0) {
                            Console.WriteLine("Up: " + mat[i - 1, j]);
                        }
                        if (j < c - 1) {
                            Console.WriteLine("Right: " + mat[i, j + 1]);
                        }
                        if (i < l - 1) {
                            Console.WriteLine("Down: " + mat[i + 1, j]);
                        }
                    }
                }
            }
        }
    }
}