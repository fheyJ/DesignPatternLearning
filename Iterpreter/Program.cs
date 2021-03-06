﻿using Iterpreter.demo1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterpreter
{
    class Program
    {
        /// <summary>
        /// 解释器模式
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Context context=new Context();
            //IList<AbstractExpression> list=new List<AbstractExpression>();
            //list.Add(new TerminalExpression());
            //list.Add(new TerminalExpression());
            //list.Add(new NonterminalExpression());
            //list.Add(new NonterminalExpression());
            //foreach (var var in list)
            //{
            //    var.Interpret(context);
            //}

            PlayContext context=new PlayContext();
            //音乐-上海滩
            Console.WriteLine("上海滩：");
            context.PlayText = "T 500 O 2 E 0.5 A 3 E 0.5 G 0.5 D 3 E 0.5 G 0.5 A 0.5 O 3 C 1 O 2 A 0.5 G 1 C 0.5 E 0.5 D 3 ";
            Expression expression = null;
            try
            {
                while (context.PlayText.Length > 0)
                {
                    string str = context.PlayText.Substring(0, 1);
                    switch (str)
                    {
                        case "O":
                            expression=new Scale();
                            break;
                        case "T":
                            expression=new Speed();
                            break;
                        case "C":
                        case "D":
                        case "E":
                        case "F":
                        case "G":
                        case "A":
                        case "B":
                            expression=new Note();
                            break;
                    }
                    expression.Interpret(context);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            Console.Read();
        }
    }
}
