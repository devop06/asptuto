using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using appWeb.fonctions;

namespace appWebTests
{
    [TestClass]
    public class MathTests
    {
        [TestMethod]
        public void Factorielle_AvecValeur0_Retourne1()
        {
            double resultat = MathHelper.Factorielle(0);
            Assert.AreEqual(1, resultat);
        }

        [TestMethod]
        public void Factorielle_AvecValeur3_Retourne6()
        {
            double resultat = MathHelper.Factorielle(3);
            Assert.AreEqual(6, resultat);
        }

        [TestMethod]
        public void Factorielle_AvecValeur15_Retourne1307674368000()
        {
            double resultat = MathHelper.Factorielle(15);
            Assert.AreEqual(6, resultat); // retourne une erreur
        }

        [TestMethod]
        public void Factorielle_AvecValeur15v2_Retourne1307674368000()
        {
            double resultat = MathHelper.Factorielle(15);
            Assert.AreEqual(1307674368000, resultat); // ici ok
        }

        [TestMethod]
        public void Addition_AvecValeur5et5_Retourne10()
        {
            int resultat = MathHelper.Addition(5,5);
            Assert.AreEqual(10, resultat); 
        }
    }
}
