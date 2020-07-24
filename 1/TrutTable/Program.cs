using System;
using System.Collections.Generic;
using System.Linq;

namespace TrutTable
{
    class Program
    {
        static void Main(string[] args)
        {
            var lstInput = new List<string>();
            while (true)
            {
                Console.Write("Please input variables then Enter if enough input 'ok': ");
                var input = Console.ReadLine();
                if (input.Equals("ok")) break;
                lstInput.Add(input);
            }
            Console.Write("What Logical do u want to calulate 'AND' 'OR' 'XOR' input any word: ");
            var logical = Console.ReadLine().ToUpper();
            var NoPrint = (int)Math.Pow(2, lstInput.Count);

            for (int i = 0; i < lstInput.Count; i++)
            {
                if (i == 0) Console.Write($"{"No",10}");
                Console.Write($" {lstInput[i],10} ");
                if (i == lstInput.Count - 1) Console.WriteLine($"{logical,10}");
            }

            var noCal = NoPrint;
            var lstInputValue = new List<string[]>();
            var resultLogic = new string[NoPrint];

            for (int i = 0; i < lstInput.Count; i++)
            {
                noCal = noCal / 2;
                var newLst = NewMethod(NoPrint, noCal);
                lstInputValue.Add(newLst);
            }

            var calTrustLst = lstInputValue.ToList();

            if (logical == "AND")
            {
                for (int i = 0; i < NoPrint; i++)
                {
                    resultLogic[i] = calTrustLst.Any(it => it[i].Equals("true")) ? "true" : "false";
                }
            }

            if (logical == "OR")
            {
                for (int i = 0; i < NoPrint; i++)
                {
                    resultLogic[i] = calTrustLst.Any(it => it[i].Equals("false")) ? "false" : "true";
                }
            }

            if (logical == "XOR")
            {
                var n = 0;
                for (int i = 0; i < NoPrint; i++)
                {
                    var lst = calTrustLst.Select(it => it[i]).ToList();
                    var secondLogic = "";
                    resultLogic[i] = lst[0];
                    for (int j = 0; j < lst.Count - 1; j++)
                    {
                        secondLogic = lst[j + 1];
                        resultLogic[i] = calXOR(resultLogic[i], secondLogic);
                    }
                }
            }

            for (int i = 0; i < NoPrint; i++)
            {
                Console.Write($"{i,10}");
                for (int j = 0; j < lstInputValue.Count; j++)
                {
                    Console.Write($" {lstInputValue[j][i],10} ");
                }
                Console.WriteLine($"{resultLogic[i],10}");
            }
            Console.WriteLine("Thank you!!");
        }

        private static string calXOR(string input1, string input2)
        {
            return (input1.Equals(input2) ? "true" : "false");
        }

        private static string[] NewMethod(int NoPrint, int noCal)
        {
            var input = new string[NoPrint];
            for (int j = 0; j < NoPrint; j++)
            {
                input[j] = ((j / noCal) % 2 == 0) ? "true" : "false";
            }
            return input;
        }
    }
}
