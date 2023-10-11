namespace algorithmANT
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.Graph = new System.Windows.Forms.TextBox();
            this.NumAnts = new System.Windows.Forms.TextBox();
            this.MaxIterations = new System.Windows.Forms.TextBox();
            this.PheromoneEvaporationRate = new System.Windows.Forms.TextBox();
            this.Alpha = new System.Windows.Forms.TextBox();
            this.Beta = new System.Windows.Forms.TextBox();
            this.GraphSelection = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.Label();
            this.K = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(867, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(246, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "Запуск алгоритма";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Graph
            // 
            this.Graph.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Graph.Location = new System.Drawing.Point(830, 52);
            this.Graph.Multiline = true;
            this.Graph.Name = "Graph";
            this.Graph.Size = new System.Drawing.Size(325, 288);
            this.Graph.TabIndex = 1;
            // 
            // NumAnts
            // 
            this.NumAnts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumAnts.Location = new System.Drawing.Point(305, 48);
            this.NumAnts.Name = "NumAnts";
            this.NumAnts.Size = new System.Drawing.Size(186, 28);
            this.NumAnts.TabIndex = 2;
            // 
            // MaxIterations
            // 
            this.MaxIterations.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaxIterations.Location = new System.Drawing.Point(305, 99);
            this.MaxIterations.Name = "MaxIterations";
            this.MaxIterations.Size = new System.Drawing.Size(100, 28);
            this.MaxIterations.TabIndex = 3;
            // 
            // PheromoneEvaporationRate
            // 
            this.PheromoneEvaporationRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PheromoneEvaporationRate.Location = new System.Drawing.Point(305, 161);
            this.PheromoneEvaporationRate.Name = "PheromoneEvaporationRate";
            this.PheromoneEvaporationRate.Size = new System.Drawing.Size(100, 28);
            this.PheromoneEvaporationRate.TabIndex = 4;
            // 
            // Alpha
            // 
            this.Alpha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Alpha.Location = new System.Drawing.Point(441, 226);
            this.Alpha.Name = "Alpha";
            this.Alpha.Size = new System.Drawing.Size(100, 28);
            this.Alpha.TabIndex = 5;
            // 
            // Beta
            // 
            this.Beta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Beta.Location = new System.Drawing.Point(365, 278);
            this.Beta.Name = "Beta";
            this.Beta.Size = new System.Drawing.Size(191, 28);
            this.Beta.TabIndex = 6;
            // 
            // GraphSelection
            // 
            this.GraphSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GraphSelection.FormattingEnabled = true;
            this.GraphSelection.Items.AddRange(new object[] {
            "По умолчанию (1)",
            "По умолчанию (2)",
            "Вручную"});
            this.GraphSelection.Location = new System.Drawing.Point(261, 387);
            this.GraphSelection.Name = "GraphSelection";
            this.GraphSelection.Size = new System.Drawing.Size(121, 30);
            this.GraphSelection.TabIndex = 7;
            this.GraphSelection.SelectedIndexChanged += new System.EventHandler(this.GraphSelection_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(32, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Количество муравьёв";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(33, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Количество итераций";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(33, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 48);
            this.label3.TabIndex = 10;
            this.label3.Text = "Коэффициент испарения\r\nферомона";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(32, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(378, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Alpha (приоритет количества феромона)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(42, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(269, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "Beta (приоритет длины пути)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(90, 387);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "Выбор графа";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(33, 333);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(291, 24);
            this.label7.TabIndex = 14;
            this.label7.Text = "Коэффициент следа феромона";
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Result.Location = new System.Drawing.Point(481, 400);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(60, 24);
            this.Result.TabIndex = 15;
            this.Result.Text = "label8";
            // 
            // K
            // 
            this.K.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.K.Location = new System.Drawing.Point(440, 337);
            this.K.Name = "K";
            this.K.Size = new System.Drawing.Size(244, 28);
            this.K.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 475);
            this.Controls.Add(this.K);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GraphSelection);
            this.Controls.Add(this.Beta);
            this.Controls.Add(this.Alpha);
            this.Controls.Add(this.PheromoneEvaporationRate);
            this.Controls.Add(this.MaxIterations);
            this.Controls.Add(this.NumAnts);
            this.Controls.Add(this.Graph);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Graph;
        private System.Windows.Forms.TextBox NumAnts;
        private System.Windows.Forms.TextBox MaxIterations;
        private System.Windows.Forms.TextBox PheromoneEvaporationRate;
        private System.Windows.Forms.TextBox Alpha;
        private System.Windows.Forms.TextBox Beta;
        private System.Windows.Forms.ComboBox GraphSelection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.TextBox K;
    }
}

