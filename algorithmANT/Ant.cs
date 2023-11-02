using System;

namespace algorithmANT
{
    internal class Ant
    {
        public int[] Cycle { get; private set; }
        public double CycleDistance { get; private set; }

        public Ant(int numCities)
        {
            Cycle = new int[numCities];
        }

        public void ConstructSolution(double[,] pheromoneMatrix, AdjacencyMatrix distanceMatrix, double alpha, double beta, Random random)
        {
            CycleDistance = 0.0;
            int numCities = Cycle.Length; // Number of cities
            bool[] visited = new bool[numCities]; // Visited cities  

            // Starting from a random city
            int startCity = random.Next(numCities);
            Cycle[0] = startCity;
            visited[startCity] = true;

            for (int step = 1; step < numCities; step++)
            {
                int currentCity = Cycle[step - 1];
                double[] probabilities = new double[numCities];
                double totalWish = 0.0;

                for (int nextCity = 0; nextCity < numCities; nextCity++)
                {
                    if (!visited[nextCity])
                    {
                        double pheromone = pheromoneMatrix[currentCity, nextCity];
                        double inverseDistance = 1.0 / distanceMatrix.Get(currentCity, nextCity);
                        double wish = Math.Pow(pheromone, alpha) * Math.Pow(inverseDistance, beta);
                        totalWish += wish;
                    }
                }

                for (int nextCity = 0; nextCity < numCities; nextCity++)
                {
                    if (!visited[nextCity])
                    {
                        double pheromone = pheromoneMatrix[currentCity, nextCity];
                        double inverseDistance = 1.0 / distanceMatrix.Get(currentCity, nextCity);
                        double probability = (Math.Pow(pheromone, alpha) * Math.Pow(inverseDistance, beta)) / totalWish;
                        probabilities[nextCity] = probability;
                    }
                }

                // Random selection of the next city
                double randomValue = random.NextDouble();
                double cumulativeProbability = 0;
                int selectedCity = -1;
                for (int nextCity = 0; nextCity < numCities; nextCity++)
                {
                    if (!visited[nextCity])
                    {
                        if (randomValue - probabilities[nextCity] - cumulativeProbability <= 0.0)
                        {
                            selectedCity = nextCity;
                            break;
                        }
                        else
                        {
                            cumulativeProbability += probabilities[nextCity];
                        }
                    }
                }

                Cycle[step] = selectedCity;
                visited[selectedCity] = true;

                CycleDistance += distanceMatrix.Get(currentCity, selectedCity);
            }
            CycleDistance += distanceMatrix.Get(Cycle[numCities - 1], Cycle[0]);
        }

        public void UpdatePheromone(double[,] pheromoneMatrix, double k, double e)
        {
            int numCities = Cycle.Length;
            double pheromoneDelta = k / CycleDistance;

            for (int i = 0; i < numCities; i++)
            {
                int fromCity = Cycle[i];
                int toCity = (i == numCities - 1) ? Cycle[0] : Cycle[i + 1];
                pheromoneMatrix[fromCity, toCity] += pheromoneDelta;
                pheromoneMatrix[toCity, fromCity] += pheromoneDelta;
            }
        }
    }
}