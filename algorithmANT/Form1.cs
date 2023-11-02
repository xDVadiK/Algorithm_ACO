using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace algorithmANT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            NumAnts.Text = "10";
            MaxIterations.Text = "100";
            PheromoneEvaporationRate.Text = "0,1";
            Alpha.Text = "1,0"; 
            Beta.Text = "2,0"; 
            K.Text = "1,0";
            Result.Text = "Результат";
            GraphSelection.SelectedIndex = 0;
        }

        internal AСO AСO
        {
            get => default;
            set
            {
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int numAnts = int.Parse(NumAnts.Text);
                if (numAnts <= 0)
                {
                    throw new Exception("Отрицательное или нулевое значение количества муравьев");
                }
                int maxIterations = int.Parse(MaxIterations.Text);
                if (maxIterations <= 0)
                {
                    throw new Exception("Отрицательное или нулевое значение количества итераций");
                }
                double pheromoneEvaporationRate = double.Parse(PheromoneEvaporationRate.Text);
                if (1.0 <= pheromoneEvaporationRate || pheromoneEvaporationRate <= 0.0)
                {
                    throw new Exception("Коэффициент испарения феромона должен лежать в диапазоне (0; 1)");
                }
                double alpha = double.Parse(Alpha.Text);
                if (alpha < 0)
                {
                    throw new Exception("Отрицательное значение коэффициента alpha");
                }
                double beta = double.Parse(Beta.Text);
                if (beta < 0)
                {
                    throw new Exception("Отрицательное значение коэффициента beta");
                }
                double k = double.Parse(K.Text);
                if (k < 0)
                {
                    throw new Exception("Отрицательное значение коэффициента k");
                }

                int[,] graph = ParseGraph(Graph.Text);
                AСO aco = new AСO(numAnts, maxIterations, pheromoneEvaporationRate, alpha, beta, k, graph);
                aco.FindShortestHamiltonianСycle();

                String path = "Путь: " + aco.GetShortestHamiltonianCycle();
                String distance = "Длина: " + aco.GetShortestCycleDistance();
                Result.Text = distance + "\r\n" + path;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Исключительная ситуация");
            }
        }

        private int[,] ParseGraph(string graph)
        {
            char[] chars = { '\r', '\n' };
            string[] rows = graph.Trim().Split(chars);

            List<string> list = new List<string>(rows);
            list.RemoveAll(string.IsNullOrEmpty);
            rows = list.ToArray();

            int rowCount = rows.Length;

            int[,] matrix = new int[rowCount, rowCount];

            for (int i = 0; i < rowCount; i++)
            {
                string[] values = rows[i].Split(' ');

                if (values.Length != rowCount)
                {
                    throw new Exception("Несимметричный двумерный массив");
                }

                for (int j = 0; j < rowCount; j++)
                {
                    if (!int.TryParse(values[j], out int element))
                    {
                        throw new Exception("Некорректное значение элемента графа");
                    }
                    matrix[i, j] = element;
                }
            }

            return matrix;
        }

        private void GraphSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (GraphSelection.SelectedIndex)
            {
                case 0: Graph.Text = "0 5 2 3\r\n5 0 1 1\r\n2 1 0 1\r\n3 1 1 0\r\n"; break;
                case 1: Graph.Text = "0 1 4 5 6 8 5\r\n1 0 5 9 7 3 4\r\n4 5 0 1 4 2 4\r\n5 9 1 0 4 2 2\r\n6 7 4 4 0 1 3\r\n8 3 2 2 1 0 9\r\n5 4 4 2 3 9 0\r\n"; break;
                case 2: Graph.Text = ""; break;
            }
        }
    }
}