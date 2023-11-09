using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Math;

namespace Calculadora
{
    public class ParaRetangular
    {
        private const char S = 'P';
        public string polar;
        public string real;
        public string imag;
        public ParaRetangular(string formaPolar)
        { 
            polar = formaPolar;
        }
        public string Retangular()
        {
            string[] prenum;
            prenum = polar.Split(S);
            real = string.(float.Parse(prenum[0])) * (Math.Cos(float.Parse(prenum[1])));
            imag = string.(float.Parse(prenum[0]) * (Math.Sin(float.Parse(prenum[1])));
            return string.Concat(real, imag);
        }
    }
}
