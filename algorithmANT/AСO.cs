using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace algorithmANT
{
    internal class AСO
    {
        private int numAnts; // Number of ants
        private int maxIterations; // Number of iterations
        private double pheromoneEvaporationRate; // Pheromone evaporation coefficient
        private double alpha; // Pheromone quantity priority
        private double beta; // Priority of the path length
        private double k; // Pheromone trace coefficient
        private double shortestCycleDistanse; // The length of the shortest Hamiltonian cycle
        private int[] shortestCycle; // The shortest Hamiltonian cycle
        AdjacencyMatrix matrix; // Adjacency matrix for graph storage

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

        // Adjacency matrix for graph storage
        internal AdjacencyMatrix AdjacencyMatrix
        {
            get => default;
            set
            {
            }
        }

        // Class Constructor
        internal Ant Ant
        {
            get => default;
            set
            {
            }
        }

        // Getting the shortest length of a Hamiltonian cycle
        public double GetShortestCycleDistance()
        {
            return shortestCycleDistanse;
        }

        // Formation of a visual representation of the Hamiltonian cycle in the form of a string
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

        // Finding the shortest Hamiltonian cycle using the ACO algorithm
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