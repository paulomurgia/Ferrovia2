using Ferrovia.Domain;
using NUnit.Framework;

namespace NUnitTestFerrovia
{
    public class DistanciaRotaTest
    {
        private Rota _rota;

        [SetUp]
        public void Setup()
        {
            _rota = new Rota();
            _rota.AddRota("AB", 5);
            _rota.AddRota("BC", 4);
            _rota.AddRota("CD", 8);
            _rota.AddRota("DC", 8);
            _rota.AddRota("DE", 6);
            _rota.AddRota("AD", 5);
            _rota.AddRota("CE", 2);
            _rota.AddRota("EB", 3);
            _rota.AddRota("AE", 7);
        }

        [Test]
        public void ObterDistanciaRota_ABC()
        {
            Rota rota = new Rota();
            var iDistancia = _rota.ObterDistancia("A-B-C");
            
            Assert.AreEqual(iDistancia, 9);
        }

        [Test]
        public void ObterDistanciaRota_AEBCD()
        {            
            Rota rota = new Rota();
            var iDistancia = _rota.ObterDistancia("A-E-B-C-D");

            Assert.AreEqual(iDistancia, 22);
        }

        [Test]
        public void ObterDistanciaRotaInexistente()
        {
            Rota rota = new Rota();
            var iDistancia = _rota.ObterDistancia("A-E-D");

            Assert.AreEqual(iDistancia, -1);
        }
    }
}