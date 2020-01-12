using System;
using System.Runtime.CompilerServices;

namespace CanIBuildIt
{
    internal class Program
    {
        
        

        private static void Main(string[] args)
        {
            var argsLength = args.Length;
            
            if ( argsLength < 3 || argsLength > 4)
            {
                Console.WriteLine(WhatCanIBuild.Unrecognised);
                return;
            }
            var sides = new float[argsLength];

            for (var i = 0; i < args.Length; i++){
                try
                {
                    sides[i] = float.Parse(args[i]);
                    if (sides[i] <= 0) throw new Exception("wrong arg");
                }
                catch (Exception)
                {
                    Console.WriteLine(WhatCanIBuild.Unrecognised);
                    return;
                }
            }
            var whatCanIBuild = new WhatCanIBuild(sides);
            Console.WriteLine(whatCanIBuild.GetAnswer());
        }
    }
}