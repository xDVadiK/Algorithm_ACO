using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace algorithmANT
{
    internal class AСO
    {
        private int numAnts;
        private int maxIterations;
        private double pheromoneEvaporationRate;
        private double alpha;
        private double beta;
        private double k;
        private double shortestCycleDistanse;
        private int[] shortestCycle;
        AdjacencyMatrix matrix;

        public AСO(int numAnts, int maxIterations, double pheromoneEvaporationRate, double alpha, double beta, double k, int[,] matrix)
        {
            this.numAnts = numAnts;
            this.maxIterations = maxIterations;
            this.pheromoneEvaporationRate = pheromoneEvaporationRate;
            this.alpha = alpha;
            this.beta = beta;
            this.k = k;
            this.matrix = new AdjacencyMatrix(matrix);
        }

        internal AdjacencyMatrix AdjacencyMatrix
        {
            get => default;
            set
            {
            }
        }

        internal Ant Ant
        {
            get => default;
            set
            {
            }
        }

        public double GetShortestCycleDistance()
        {
            return shortestCycleDistanse;
        }

        public String GetShortestHamiltonianCycle()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < shortestCycle.Length; i++)
            {
                sb.Append(shortestCycle[i]).Append(" -> ");
            }
            sb.Append(shortestCycle[0]);
            return sb.ToString();
        }

        public void FindShortestHamiltonianСycle() 
        {
            // Initialization of the pheromone matrix
            double[,] pheromoneMatrix = new double[matrix.GetSize(), matrix.GetSize()];
            for (int i = 0; i < matrix.GetSize(); i++)
            {
                for (int j = 0; j < matrix.GetSize(); j++)
                {
                    pheromoneMatrix[i, j] = 1.0;
                }
            }

            Random random = new Random();
            List<Ant> ants = new List<Ant>();

            // Creating ants
            for (int i = 0; i < numAnts; i++)
            {
                ants.Add(new Ant(matrix.GetSize()));
            }

            // ACO algorithm
            for (int iteration = 0; iteration < maxIterations; iteration++)
            {
                // Ants construct solutions
                foreach (var ant in ants)
                {
                    ant.ConstructSolution(pheromoneMatrix, matrix, alpha, beta, random);
                }

                // Evaporate pheromone
                for (int i = 0; i < matrix.GetSize(); i++)
                {
                    for (int j = 0; j < matrix.GetSize(); j++)
                    {
                        pheromoneMatrix[i, j] *= 1 - pheromoneEvaporationRate;
                    }
                }

                // Update pheromone levels
                foreach (var ant in ants)
                {
                    ant.UpdatePheromone(pheromoneMatrix, k, pheromoneEvaporationRate);
                }

            }

            Ant bestAnt = ants.OrderBy(ant => ant.CycleDistance).First();
            shortestCycleDistanse = bestAnt.CycleDistance;
            shortestCycle = bestAnt.Cycle;
        } 
    }
}