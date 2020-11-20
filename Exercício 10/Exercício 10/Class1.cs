using System;
using System.Collections.Generic;
using System.Text;

namespace Exercício_10
{
    class Terreno
    {
        double @base;
        double altura;
        double area;

        public void SetBase(double p)
        {
            @base = p;
        }

        public void SetAltura(double p)
        {
            altura = p;
        }

        public double GetBase()
        {
            return @base;
        }

        public double GetAltura()
        {
            return altura;
        }

        public double GetArea()
        {
            return area;
        }

        public double CalcularArea()
        {
            area = @base * altura;
            return area;
        }

        public string DimensionarTerreno()
        {
            string k;

            if(CalcularArea() > 100)
            {
                k = "grande";
            }
            else
            {
                k = "pequeno";
            }
            return k;
        }
    }
}
