using Kata.SearchingAlgorithms.Models;
using System.Collections.Generic;

namespace Kata.SearchingAlgorithms.Tests.Mocks
{
    public static class SearchingAlgorithmRequestMockFactory
    {
        public static SearchingAlgorithmRequest RomaniaCities()
        {
            #region Initialize nodes

            var oradea = new Node("Oradea");
            var zerind = new Node("Zerind");
            var arad = new Node("Arad");
            var timisoara = new Node("Timisoara");
            var lugoj = new Node("Lugoj");
            var mehadia = new Node("Mehadia");
            var dobreta = new Node("Dobreta");
            var craiova = new Node("Craiova");
            var rimnicuVilcea = new Node("Rimnicu Vilcea");
            var sibiu = new Node("Sibiu");
            var fagaras = new Node("Fagaras");
            var bucharest = new Node("Bucharest");
            var pitesti = new Node("Pitesti");
            var giurgiu = new Node("Giurgiu");
            var urziceni = new Node("Urziceni");
            var hirsova = new Node("Hirsova");
            var eforie = new Node("Eforie");
            var vaslui = new Node("Vaslui");
            var iasi = new Node("Iasi");
            var neamt = new Node("Neamt");

            #endregion

            #region Add edges to nodes

            oradea.Edges = new List<Edge> { new Edge(zerind, 71), new Edge(sibiu, 151) };
            zerind.Edges = new List<Edge> { new Edge(oradea, 71), new Edge(arad, 75) };
            arad.Edges = new List<Edge> { new Edge(zerind, 75), new Edge(sibiu, 140), new Edge(timisoara, 118) };
            timisoara.Edges = new List<Edge> { new Edge(arad, 118), new Edge(lugoj, 111) };
            lugoj.Edges = new List<Edge> { new Edge(timisoara, 111), new Edge(mehadia, 70) };
            mehadia.Edges = new List<Edge> { new Edge(lugoj, 70), new Edge(dobreta, 75) };
            dobreta.Edges = new List<Edge> { new Edge(mehadia, 75), new Edge(craiova, 120) };
            craiova.Edges = new List<Edge> { new Edge(rimnicuVilcea, 146), new Edge(pitesti, 138) };
            rimnicuVilcea.Edges = new List<Edge> { new Edge(craiova, 146), new Edge(sibiu, 80), new Edge(pitesti, 97) };
            sibiu.Edges = new List<Edge> { new Edge(oradea, 151), new Edge(arad, 140), new Edge(rimnicuVilcea, 80), new Edge(fagaras, 99) };
            fagaras.Edges = new List<Edge> { new Edge(sibiu, 99), new Edge(bucharest, 211) };
            bucharest.Edges = new List<Edge> { new Edge(fagaras, 211), new Edge(pitesti, 101), new Edge(giurgiu, 90), new Edge(urziceni, 85) };
            pitesti.Edges = new List<Edge> { new Edge(craiova, 138), new Edge(rimnicuVilcea, 97), new Edge(bucharest, 101) };
            giurgiu.Edges = new List<Edge> { new Edge(bucharest, 90) };
            urziceni.Edges = new List<Edge> { new Edge(bucharest, 85), new Edge(hirsova, 98), new Edge(vaslui, 142) };
            hirsova.Edges = new List<Edge> { new Edge(urziceni, 98), new Edge(eforie, 86) };
            eforie.Edges = new List<Edge> { new Edge(hirsova, 86) };
            vaslui.Edges = new List<Edge> { new Edge(urziceni, 142), new Edge(iasi, 92) };
            iasi.Edges = new List<Edge> { new Edge(vaslui, 92), new Edge(neamt, 87) };
            neamt.Edges = new List<Edge> { new Edge(iasi, 87) };

            #endregion

            return new SearchingAlgorithmRequest
            {
                StartNode = timisoara,
                TargetNode = bucharest
            };
        }

        public static SearchingAlgorithmRequest RomaniaCitiesUnlinked()
        {
            var oradea = new Node("Oradea");
            var zerind = new Node("Zerind");
            var arad = new Node("Arad");

            oradea.Edges = new List<Edge> { new Edge(zerind, 71) };
            zerind.Edges = new List<Edge> { new Edge(oradea, 71) };
            arad.Edges = new List<Edge> { new Edge(zerind, 75) };

            return new SearchingAlgorithmRequest
            {
                StartNode = oradea,
                TargetNode = arad
            };
        }
    }
}
