using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace appWeb.fonctions
{
    public interface INombreRandom
    {
         int Valeur { get; }
    }

    public class NombreRandom : INombreRandom
    {
        private Random r;

        public NombreRandom()
        {
            this.r = new Random();
        }

        public int Valeur
        {
            get
            {
                return this.r.Next(0, 10);
            }
        }

    }
}