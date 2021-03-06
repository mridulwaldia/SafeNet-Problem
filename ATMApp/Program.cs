﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ATMapp
{
    class ATMTest
    {
        static void Main(string[] args)
        {
            ATM machine = new ATM();
            bool quit = false;
            while (!quit)
            {
                String order = Console.ReadLine();
                String[] breakdown = order.Split();
                Char command;
                if (breakdown[0].Equals(""))
                    command = 'F';
                else
                    //command = breakdown[0].ToUpper().charAt(0);
                    command = Convert.ToChar(breakdown[0].ToUpper().Substring(0, 1));
                //System.out.println(command);
                switch (command)
                {
                    case 'R':
                        {
                            machine.reset();
                            Console.WriteLine("Restocked ATM!");
                            Console.WriteLine(machine.DisplayAmounts());
                        }
                        break;
                    case 'W':
                        {
                            if (machine.Withdraw(int.Parse(breakdown[1].Substring(1))))
                            {
                                Console.WriteLine("Success: Dispensed " + breakdown[1]);
                                Console.WriteLine(machine.DisplayAmounts());
                            }
                            else
                                Console.WriteLine("Failure: insufficient funds");
                            break;
                        }
                    case 'I':
                        List<string> denom = new List<string>();
                        String s = "";
                        for(int i = 0; i < breakdown.Length; i++)
                        {
                            s = breakdown[1].Substring(1);
                            Console.WriteLine(s);
                        }
                        while (!machine.denominations(int.Parse(breakdown[1].Substring(1))))
                        {
                            Console.WriteLine(machine.denominations(int.Parse(breakdown[1].Substring(1))));
                        }
                        break;
                    case 'Q':
                        {
                            Console.WriteLine("Thank you.");
                            quit = true;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Failure: Invalid Command");
                            break;
                        }
                }
            }
        }
        }
    }