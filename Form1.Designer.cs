namespace treinotabela
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart_equacao = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.lbl_x = new System.Windows.Forms.Label();
            this.txt_a = new System.Windows.Forms.TextBox();
            this.txt_b = new System.Windows.Forms.TextBox();
            this.lbl_n0 = new System.Windows.Forms.Label();
            this.lbl_result = new System.Windows.Forms.Label();
            this.btn_limpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart_equacao)).BeginInit();
            this.SuspendLayout();
            // 
            // chart_equacao
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_equacao.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_equacao.Legends.Add(legend1);
            this.chart_equacao.Location = new System.Drawing.Point(12, 97);
            this.chart_equacao.Name = "chart_equacao";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "CandidatoMarley";
            series1.YValuesPerPoint = 2;
            this.chart_equacao.Series.Add(series1);
            this.chart_equacao.Size = new System.Drawing.Size(764, 325);
            this.chart_equacao.TabIndex = 0;
            this.chart_equacao.Text = "tabela";
            // 
            // btn_calcular
            // 
            this.btn_calcular.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calcular.Location = new System.Drawing.Point(424, 37);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(124, 38);
            this.btn_calcular.TabIndex = 1;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // lbl_x
            // 
            this.lbl_x.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_x.Location = new System.Drawing.Point(137, 37);
            this.lbl_x.Name = "lbl_x";
            this.lbl_x.Size = new System.Drawing.Size(62, 38);
            this.lbl_x.TabIndex = 2;
            this.lbl_x.Text = "X +";
            this.lbl_x.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_a
            // 
            this.txt_a.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_a.Location = new System.Drawing.Point(33, 34);
            this.txt_a.Multiline = true;
            this.txt_a.Name = "txt_a";
            this.txt_a.Size = new System.Drawing.Size(86, 41);
            this.txt_a.TabIndex = 3;
            this.txt_a.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_b
            // 
            this.txt_b.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_b.Location = new System.Drawing.Point(205, 34);
            this.txt_b.Multiline = true;
            this.txt_b.Name = "txt_b";
            this.txt_b.Size = new System.Drawing.Size(86, 41);
            this.txt_b.TabIndex = 4;
            this.txt_b.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_n0
            // 
            this.lbl_n0.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n0.Location = new System.Drawing.Point(297, 37);
            this.lbl_n0.Name = "lbl_n0";
            this.lbl_n0.Size = new System.Drawing.Size(62, 38);
            this.lbl_n0.TabIndex = 5;
            this.lbl_n0.Text = "=";
            this.lbl_n0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_result
            // 
            this.lbl_result.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_result.Location = new System.Drawing.Point(345, 37);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(62, 38);
            this.lbl_result.TabIndex = 6;
            this.lbl_result.Text = "0";
            this.lbl_result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_limpar
            // 
            this.btn_limpar.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpar.Location = new System.Drawing.Point(580, 37);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(124, 38);
            this.btn_limpar.TabIndex = 7;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 434);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.lbl_n0);
            this.Controls.Add(this.txt_b);
            this.Controls.Add(this.txt_a);
            this.Controls.Add(this.lbl_x);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.chart_equacao);
            this.Name = "Form1";
            this.Text = "Equacao";
            ((System.ComponentModel.ISupportInitialize)(this.chart_equacao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_equacao;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Label lbl_x;
        private System.Windows.Forms.TextBox txt_a;
        private System.Windows.Forms.TextBox txt_b;
        private System.Windows.Forms.Label lbl_n0;
        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.Button btn_limpar;
    }
}

