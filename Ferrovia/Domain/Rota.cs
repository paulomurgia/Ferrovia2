using System;
using System.Collections.Generic;
using System.Text;

namespace Ferrovia.Domain
{
    public class Rota
    {
        private Dictionary<string, int> _grafo;

        public Rota()
        {
            _grafo = new Dictionary<string, int>();
        }

        public void AddRota(string nome, int distancia)
        {
            _grafo.Add(nome, distancia);
        }

        public int ObterDistancia(string rota)
        {
            var trecho = "";
            var distanciaRota = 0;
            var distanciaTrecho = 0;

            trecho = rota.Replace("-", "");

            if (_grafo.ContainsKey(trecho))
                return _grafo[trecho];

            var vtTrechos = rota.Split("-");

            for (int i = 0; i < vtTrechos.Length - 1; i++)
            {
                distanciaTrecho = ObterDistanciaViagem(vtTrechos[i], vtTrechos[i + 1]);

                if (distanciaTrecho == -1)
                    return distanciaTrecho;

                distanciaRota += distanciaTrecho;
            }

            return distanciaRota;
        }

        private int ObterDistanciaViagem(string origem, string destino)
        {
            int peso = -1;
            string trecho = origem + destino;

            if (_grafo.ContainsKey(trecho))
                return _grafo[trecho];

            return peso;
        }
    }
}
