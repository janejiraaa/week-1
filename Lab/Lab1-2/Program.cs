﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_2
{
    class BubbleSortFunction
    {
        static void Main(string[] args)
        {
            

            // input
            program x = new program();
            x.input();

            // process
            

            // output
            
            Console.ReadKey();
        }

        class program {
            public void input()
            {
                string y;
                Console.WriteLine("Input number: ");
                y = Console.ReadLine();
                int[] input;
                input = y.Split(' ').Select(a => Convert.ToInt32(a)).ToArray();
                process(input);
                output(input);
            }
            public void process(int[] input) {
                bool flag = true;
                while (flag)
                {
                    flag = false;
                    for (int i = 0; i != input.Length - 1; i++)
                    {
                        if (input[i] > input[i + 1])
                        {
                            int temp = input[i];
                            input[i] = input[i + 1];
                            input[i + 1] = temp;
                            flag = true;
                        }
                    }
                }
            }

            public void output(int[] input) {
                Console.WriteLine("Output number: ");
                for (int i = 0; i != input.Length; i++)
                {
                    Console.Write(input[i]);
                    Console.Write(" ");
                }
            }
        }
    }
}
