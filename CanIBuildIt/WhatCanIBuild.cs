using System;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;

namespace CanIBuildIt
{
    public class WhatCanIBuild
    {
        public const string Unrecognised = "nierozpoznano";
        
        private const string equilateral = "trojkat rownoboczny";
        private const string isosceles = "trojkat rownoramienny";
        private const string scalene = "trojkat roznoboczny";

        private const string quadrangle = "czworobok";
        private const string square = "kwadrat";
        private const string reptangle = "prostokat";
        
        
        private readonly float[] sides;

        public WhatCanIBuild(float[] sides)
        {
            this.sides = sides;
            Console.WriteLine("tere");
        }

        public string GetAnswer()
        {
            if (CanBuild())
            {
                return this.sides.Length == 3 ? WhatTriangle() : WhatQuadrangle();
            }
            
            return Unrecognised;
        }

        private bool CanBuild()
        {
            return sides.Sum() - 2 * sides.Max() > 0;
        }

        private string WhatTriangle()
        {
            if (sides[0].Equals(sides[1]))
            {
                return sides[0].Equals(sides[2]) ? equilateral : isosceles;
            }

            if (sides[0].Equals(sides[2]))
            {
                return isosceles;
            }
            
            return sides[1].Equals(sides[2]) ? isosceles : scalene;
        }

        private string WhatQuadrangle()
        {
            if (sides[0].Equals(sides[2]) && sides[1].Equals(sides[3]))
            {
                return sides[0].Equals(sides[1]) ? square : reptangle;
            }
            return quadrangle;
        }
    }
}