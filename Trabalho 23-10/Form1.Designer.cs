namespace Trabalho_23_10
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxBaseDeTreinamento = new System.Windows.Forms.GroupBox();
            this.buttonTreinar = new System.Windows.Forms.Button();
            this.labelciclos = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelLETRA = new System.Windows.Forms.Label();
            this.labelFONTE = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxTesteDaRedeNeural = new System.Windows.Forms.GroupBox();
            this.buttonTestar = new System.Windows.Forms.Button();
            this.labelRespostaRede = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelDesenheALetraNogridabaixo = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxBaseDeTreinamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBoxTesteDaRedeNeural.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxBaseDeTreinamento
            // 
            this.groupBoxBaseDeTreinamento.Controls.Add(this.buttonTreinar);
            this.groupBoxBaseDeTreinamento.Controls.Add(this.labelciclos);
            this.groupBoxBaseDeTreinamento.Controls.Add(this.label3);
            this.groupBoxBaseDeTreinamento.Controls.Add(this.labelLETRA);
            this.groupBoxBaseDeTreinamento.Controls.Add(this.labelFONTE);
            this.groupBoxBaseDeTreinamento.Controls.Add(this.comboBox2);
            this.groupBoxBaseDeTreinamento.Controls.Add(this.comboBox1);
            this.groupBoxBaseDeTreinamento.Controls.Add(this.dataGridView1);
            this.groupBoxBaseDeTreinamento.Controls.Add(this.chart1);
            this.groupBoxBaseDeTreinamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxBaseDeTreinamento.Location = new System.Drawing.Point(12, 12);
            this.groupBoxBaseDeTreinamento.Name = "groupBoxBaseDeTreinamento";
            this.groupBoxBaseDeTreinamento.Size = new System.Drawing.Size(531, 586);
            this.groupBoxBaseDeTreinamento.TabIndex = 0;
            this.groupBoxBaseDeTreinamento.TabStop = false;
            this.groupBoxBaseDeTreinamento.Text = "Base de Treinamento ";
            // 
            // buttonTreinar
            // 
            this.buttonTreinar.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.buttonTreinar.Location = new System.Drawing.Point(376, 548);
            this.buttonTreinar.Name = "buttonTreinar";
            this.buttonTreinar.Size = new System.Drawing.Size(75, 23);
            this.buttonTreinar.TabIndex = 8;
            this.buttonTreinar.Text = "Treinar";
            this.buttonTreinar.UseVisualStyleBackColor = true;
            this.buttonTreinar.Click += new System.EventHandler(this.buttonTreinar_Click);
            // 
            // labelciclos
            // 
            this.labelciclos.AutoSize = true;
            this.labelciclos.Location = new System.Drawing.Point(68, 553);
            this.labelciclos.Name = "labelciclos";
            this.labelciclos.Size = new System.Drawing.Size(62, 17);
            this.labelciclos.TabIndex = 7;
            this.labelciclos.Text = "______";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 553);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ciclos:";
            // 
            // labelLETRA
            // 
            this.labelLETRA.AutoSize = true;
            this.labelLETRA.Location = new System.Drawing.Point(18, 112);
            this.labelLETRA.Name = "labelLETRA";
            this.labelLETRA.Size = new System.Drawing.Size(58, 17);
            this.labelLETRA.TabIndex = 5;
            this.labelLETRA.Text = "LETRA";
            // 
            // labelFONTE
            // 
            this.labelFONTE.AutoSize = true;
            this.labelFONTE.Location = new System.Drawing.Point(16, 29);
            this.labelFONTE.Name = "labelFONTE";
            this.labelFONTE.Size = new System.Drawing.Size(60, 17);
            this.labelFONTE.TabIndex = 4;
            this.labelFONTE.Text = "FONTE";
            // 
            // comboBox2
            // 
            this.comboBox2.AutoCompleteCustomSource.AddRange(new string[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "J",
            "K"});
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "J",
            "K"});
            this.comboBox2.Location = new System.Drawing.Point(19, 132);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(85, 24);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3"});
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboBox1.Location = new System.Drawing.Point(19, 49);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(85, 24);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView1.Location = new System.Drawing.Point(136, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(389, 279);
            this.dataGridView1.TabIndex = 1;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(86, 334);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(445, 185);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // groupBoxTesteDaRedeNeural
            // 
            this.groupBoxTesteDaRedeNeural.Controls.Add(this.buttonTestar);
            this.groupBoxTesteDaRedeNeural.Controls.Add(this.labelRespostaRede);
            this.groupBoxTesteDaRedeNeural.Controls.Add(this.label4);
            this.groupBoxTesteDaRedeNeural.Controls.Add(this.labelDesenheALetraNogridabaixo);
            this.groupBoxTesteDaRedeNeural.Controls.Add(this.dataGridView2);
            this.groupBoxTesteDaRedeNeural.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTesteDaRedeNeural.Location = new System.Drawing.Point(559, 12);
            this.groupBoxTesteDaRedeNeural.Name = "groupBoxTesteDaRedeNeural";
            this.groupBoxTesteDaRedeNeural.Size = new System.Drawing.Size(480, 586);
            this.groupBoxTesteDaRedeNeural.TabIndex = 1;
            this.groupBoxTesteDaRedeNeural.TabStop = false;
            this.groupBoxTesteDaRedeNeural.Text = "Teste da Rede Neural";
            // 
            // buttonTestar
            // 
            this.buttonTestar.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.buttonTestar.Location = new System.Drawing.Point(328, 553);
            this.buttonTestar.Name = "buttonTestar";
            this.buttonTestar.Size = new System.Drawing.Size(75, 23);
            this.buttonTestar.TabIndex = 11;
            this.buttonTestar.Text = "Testar";
            this.buttonTestar.UseVisualStyleBackColor = true;
            this.buttonTestar.Click += new System.EventHandler(this.buttonTestar_Click);
            // 
            // labelRespostaRede
            // 
            this.labelRespostaRede.AutoSize = true;
            this.labelRespostaRede.ForeColor = System.Drawing.Color.Crimson;
            this.labelRespostaRede.Location = new System.Drawing.Point(197, 385);
            this.labelRespostaRede.Name = "labelRespostaRede";
            this.labelRespostaRede.Size = new System.Drawing.Size(98, 17);
            this.labelRespostaRede.TabIndex = 10;
            this.labelRespostaRede.Text = "__________";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(151, 348);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Resposta da Rede Neural:";
            // 
            // labelDesenheALetraNogridabaixo
            // 
            this.labelDesenheALetraNogridabaixo.AutoSize = true;
            this.labelDesenheALetraNogridabaixo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDesenheALetraNogridabaixo.ForeColor = System.Drawing.Color.Blue;
            this.labelDesenheALetraNogridabaixo.Location = new System.Drawing.Point(136, 25);
            this.labelDesenheALetraNogridabaixo.Name = "labelDesenheALetraNogridabaixo";
            this.labelDesenheALetraNogridabaixo.Size = new System.Drawing.Size(237, 17);
            this.labelDesenheALetraNogridabaixo.TabIndex = 8;
            this.labelDesenheALetraNogridabaixo.Text = "Desenhe a Letra no grid abaixo";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14});
            this.dataGridView2.Location = new System.Drawing.Point(88, 45);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(315, 279);
            this.dataGridView2.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "1";
            this.Column1.Name = "Column1";
            this.Column1.Width = 20;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "2";
            this.Column2.Name = "Column2";
            this.Column2.Width = 20;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "3";
            this.Column3.Name = "Column3";
            this.Column3.Width = 20;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "4";
            this.Column4.Name = "Column4";
            this.Column4.Width = 20;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "5";
            this.Column5.Name = "Column5";
            this.Column5.Width = 20;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "6";
            this.Column6.Name = "Column6";
            this.Column6.Width = 20;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "7";
            this.Column7.Name = "Column7";
            this.Column7.Width = 20;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "1";
            this.Column8.Name = "Column8";
            this.Column8.Width = 20;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "2";
            this.Column9.Name = "Column9";
            this.Column9.Width = 20;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "3";
            this.Column10.Name = "Column10";
            this.Column10.Width = 20;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "4";
            this.Column11.Name = "Column11";
            this.Column11.Width = 20;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "5";
            this.Column12.Name = "Column12";
            this.Column12.Width = 20;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "6";
            this.Column13.Name = "Column13";
            this.Column13.Width = 20;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "7";
            this.Column14.Name = "Column14";
            this.Column14.Width = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 615);
            this.Controls.Add(this.groupBoxTesteDaRedeNeural);
            this.Controls.Add(this.groupBoxBaseDeTreinamento);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxBaseDeTreinamento.ResumeLayout(false);
            this.groupBoxBaseDeTreinamento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBoxTesteDaRedeNeural.ResumeLayout(false);
            this.groupBoxTesteDaRedeNeural.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxBaseDeTreinamento;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox groupBoxTesteDaRedeNeural;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonTreinar;
        private System.Windows.Forms.Label labelciclos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelLETRA;
        private System.Windows.Forms.Label labelFONTE;
        private System.Windows.Forms.Button buttonTestar;
        private System.Windows.Forms.Label labelRespostaRede;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelDesenheALetraNogridabaixo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
    }
}

