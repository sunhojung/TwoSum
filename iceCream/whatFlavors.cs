using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;


namespace IceCream
{
    /*search problem from hackerrank.com
     input: total money available and an array of ice cream costs,
     this function finds 2 distinct ice cream flavours that spends the total amount of money available.
     
     output: indices for the flavors chosen(the indexes are 1-based index numbers -> index starts at 1)

     the inputs for this function will always have a unique solution
     */
    public class WhatFlavors
    {
        public static int[] GetFlavors(int[] cost, int money)
        {
            int[] flavors = new int[2];
            Hashtable firstInstance = new Hashtable();
            Hashtable secondInstance = new Hashtable();
            int moneyAvailable;

            for(int i=0; i<cost.Length; i++) //key = cost of ice cream, value = index
            {
                if (firstInstance.ContainsKey(cost[i])){ //if there are duplicates only the first 2 will be checked
                    if (!secondInstance.ContainsKey(cost[i]))
                    {
                        secondInstance.Add(cost[i], i);
                    }
                    
                } else
                {
                    firstInstance.Add(cost[i], i);
                }
            }

            for (int i = 0; i < cost.Length; i++)

            {
                if (firstInstance.ContainsKey(cost[i]))
                {
                    firstInstance.Remove(cost[i]);
                    moneyAvailable = money - cost[i];
                    if (firstInstance.ContainsKey(moneyAvailable))
                    {
                        flavors[0] = i + 1;
                        flavors[1] = Convert.ToInt32(firstInstance[moneyAvailable]) + 1;
                        /*
                        Console.WriteLine("{0}, {1}", flavors[0], flavors[1]);
                        Console.ReadLine();
                        */
                        return flavors;
                    }
                    else if (secondInstance.ContainsKey(moneyAvailable))
                    {
                        flavors[0] = i + 1;
                        flavors[1] = Convert.ToInt32(secondInstance[moneyAvailable]) + 1;
                        /*
                        Console.WriteLine("{0}, {1}", flavors[0], flavors[1]);
                        Console.ReadLine();*/
                        return flavors;
                    }
                }

            }
            return flavors;
        }
    }
}
