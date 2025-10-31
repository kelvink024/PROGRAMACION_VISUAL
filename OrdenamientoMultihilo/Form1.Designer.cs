namespace OrdenamientoMultihilo
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.progressBurbuja = new System.Windows.Forms.ProgressBar();
            this.progressQuickSort = new System.Windows.Forms.ProgressBar();
            this.lblBurbuja = new System.Windows.Forms.Label();
            this.lblQuickSort = new System.Windows.Forms.Label();
            this.btnDetener = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.chartResultados = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnClear = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorkerQuickSort = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2Merge = new System.ComponentModel.BackgroundWorker();
            this.progressMergeSort = new System.Windows.Forms.ProgressBar();
            this.lblMergeSort = new System.Windows.Forms.Label();
            this.progressSelectionSort = new System.Windows.Forms.ProgressBar();
            this.lblSelectionSort = new System.Windows.Forms.Label();
            this.btnGuardarWord = new System.Windows.Forms.Button();
            this.btnIniciarWord = new System.Windows.Forms.Button();
            this.btnReanudar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartResultados)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenerar
            // 
            this.btnGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.Location = new System.Drawing.Point(189, 398);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(71, 40);
            this.btnGenerar.TabIndex = 18;
            this.btnGenerar.Text = "Generar Datos";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(289, 398);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "Iniciar Ordenamiento";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // progressBurbuja
            // 
            this.progressBurbuja.Location = new System.Drawing.Point(12, 161);
            this.progressBurbuja.Name = "progressBurbuja";
            this.progressBurbuja.Size = new System.Drawing.Size(280, 40);
            this.progressBurbuja.TabIndex = 2;
            // 
            // progressQuickSort
            // 
            this.progressQuickSort.Location = new System.Drawing.Point(12, 220);
            this.progressQuickSort.Name = "progressQuickSort";
            this.progressQuickSort.Size = new System.Drawing.Size(280, 40);
            this.progressQuickSort.TabIndex = 3;
            // 
            // lblBurbuja
            // 
            this.lblBurbuja.AutoSize = true;
            this.lblBurbuja.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBurbuja.Location = new System.Drawing.Point(12, 145);
            this.lblBurbuja.Name = "lblBurbuja";
            this.lblBurbuja.Size = new System.Drawing.Size(74, 13);
            this.lblBurbuja.TabIndex = 4;
            this.lblBurbuja.Text = "Burbuja: 0%";
            // 
            // lblQuickSort
            // 
            this.lblQuickSort.AutoSize = true;
            this.lblQuickSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuickSort.Location = new System.Drawing.Point(10, 204);
            this.lblQuickSort.Name = "lblQuickSort";
            this.lblQuickSort.Size = new System.Drawing.Size(87, 13);
            this.lblQuickSort.TabIndex = 5;
            this.lblQuickSort.Text = "QuickSort: 0%";
            // 
            // btnDetener
            // 
            this.btnDetener.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetener.Location = new System.Drawing.Point(374, 398);
            this.btnDetener.Name = "btnDetener";
            this.btnDetener.Size = new System.Drawing.Size(72, 40);
            this.btnDetener.TabIndex = 6;
            this.btnDetener.Text = "Detener";
            this.btnDetener.UseVisualStyleBackColor = true;
            this.btnDetener.Click += new System.EventHandler(this.btnDetener_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(216, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "EJECUCION MULTIHILOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Agregar Datos para la simulacion:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(12, 92);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(162, 20);
            this.txtCantidad.TabIndex = 9;
            // 
            // chartResultados
            // 
            chartArea2.Name = "ChartArea1";
            this.chartResultados.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartResultados.Legends.Add(legend2);
            this.chartResultados.Location = new System.Drawing.Point(299, 78);
            this.chartResultados.Name = "chartResultados";
            this.chartResultados.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartResultados.Series.Add(series2);
            this.chartResultados.Size = new System.Drawing.Size(347, 300);
            this.chartResultados.TabIndex = 10;
            this.chartResultados.Text = "chart1";
            this.chartResultados.Click += new System.EventHandler(this.chartResultados_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(555, 398);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(82, 40);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Limpiar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(658, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(93, 20);
            this.toolStripMenuItem1.Text = "Generar Datos";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(131, 20);
            this.toolStripMenuItem2.Text = "Iniciar Ordenamiento";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(60, 20);
            this.toolStripMenuItem3.Text = "Detener";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(92, 20);
            this.toolStripMenuItem4.Text = "Limpiar Datos";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // backgroundWorkerQuickSort
            // 
            this.backgroundWorkerQuickSort.WorkerReportsProgress = true;
            this.backgroundWorkerQuickSort.WorkerSupportsCancellation = true;
            this.backgroundWorkerQuickSort.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerQuickSort_DoWork);
            this.backgroundWorkerQuickSort.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerQuickSort_ProgressChanged);
            this.backgroundWorkerQuickSort.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerQuickSort_RunWorkerCompleted);
            // 
            // backgroundWorker2Merge
            // 
            this.backgroundWorker2Merge.WorkerReportsProgress = true;
            this.backgroundWorker2Merge.WorkerSupportsCancellation = true;
            this.backgroundWorker2Merge.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2Merge_DoWork);
            this.backgroundWorker2Merge.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker2Merge_ProgressChanged);
            this.backgroundWorker2Merge.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker2Merge_RunWorkerCompleted);
            // 
            // progressMergeSort
            // 
            this.progressMergeSort.Location = new System.Drawing.Point(15, 338);
            this.progressMergeSort.Name = "progressMergeSort";
            this.progressMergeSort.Size = new System.Drawing.Size(280, 40);
            this.progressMergeSort.TabIndex = 13;
            // 
            // lblMergeSort
            // 
            this.lblMergeSort.AutoSize = true;
            this.lblMergeSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMergeSort.Location = new System.Drawing.Point(12, 322);
            this.lblMergeSort.Name = "lblMergeSort";
            this.lblMergeSort.Size = new System.Drawing.Size(89, 13);
            this.lblMergeSort.TabIndex = 14;
            this.lblMergeSort.Text = "MergeSort: 0%";
            // 
            // progressSelectionSort
            // 
            this.progressSelectionSort.Location = new System.Drawing.Point(13, 279);
            this.progressSelectionSort.Name = "progressSelectionSort";
            this.progressSelectionSort.Size = new System.Drawing.Size(280, 40);
            this.progressSelectionSort.TabIndex = 15;
            this.progressSelectionSort.Click += new System.EventHandler(this.progressSelectionSort_Click);
            // 
            // lblSelectionSort
            // 
            this.lblSelectionSort.AutoSize = true;
            this.lblSelectionSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectionSort.Location = new System.Drawing.Point(12, 263);
            this.lblSelectionSort.Name = "lblSelectionSort";
            this.lblSelectionSort.Size = new System.Drawing.Size(107, 13);
            this.lblSelectionSort.TabIndex = 16;
            this.lblSelectionSort.Text = "SelectionSort: 0%";
            // 
            // btnGuardarWord
            // 
            this.btnGuardarWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnGuardarWord.Location = new System.Drawing.Point(101, 398);
            this.btnGuardarWord.Name = "btnGuardarWord";
            this.btnGuardarWord.Size = new System.Drawing.Size(73, 40);
            this.btnGuardarWord.TabIndex = 18;
            this.btnGuardarWord.Text = "Guardar Word";
            this.btnGuardarWord.UseVisualStyleBackColor = true;
            this.btnGuardarWord.Click += new System.EventHandler(this.btnGuardarWord_Click_1);
            // 
            // btnIniciarWord
            // 
            this.btnIniciarWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnIniciarWord.Location = new System.Drawing.Point(15, 398);
            this.btnIniciarWord.Name = "btnIniciarWord";
            this.btnIniciarWord.Size = new System.Drawing.Size(71, 40);
            this.btnIniciarWord.TabIndex = 18;
            this.btnIniciarWord.Text = "Init Word";
            this.btnIniciarWord.UseVisualStyleBackColor = true;
            this.btnIniciarWord.Click += new System.EventHandler(this.btnIniciarWord_Click);
            // 
            // btnReanudar
            // 
            this.btnReanudar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnReanudar.Location = new System.Drawing.Point(464, 398);
            this.btnReanudar.Name = "btnReanudar";
            this.btnReanudar.Size = new System.Drawing.Size(72, 40);
            this.btnReanudar.TabIndex = 19;
            this.btnReanudar.Text = "Reanudar";
            this.btnReanudar.UseVisualStyleBackColor = true;
            this.btnReanudar.Click += new System.EventHandler(this.btnReanudar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 450);
            this.Controls.Add(this.btnReanudar);
            this.Controls.Add(this.btnIniciarWord);
            this.Controls.Add(this.btnGuardarWord);
            this.Controls.Add(this.lblSelectionSort);
            this.Controls.Add(this.progressSelectionSort);
            this.Controls.Add(this.lblMergeSort);
            this.Controls.Add(this.progressMergeSort);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.chartResultados);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDetener);
            this.Controls.Add(this.lblQuickSort);
            this.Controls.Add(this.lblBurbuja);
            this.Controls.Add(this.progressQuickSort);
            this.Controls.Add(this.progressBurbuja);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartResultados)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ProgressBar progressBurbuja;
        private System.Windows.Forms.ProgressBar progressQuickSort;
        private System.Windows.Forms.Label lblBurbuja;
        private System.Windows.Forms.Label lblQuickSort;
        private System.Windows.Forms.Button btnDetener;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResultados;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.ComponentModel.BackgroundWorker backgroundWorkerQuickSort;
        private System.ComponentModel.BackgroundWorker backgroundWorker2Merge;
        private System.Windows.Forms.ProgressBar progressMergeSort;
        private System.Windows.Forms.Label lblMergeSort;
        private System.Windows.Forms.ProgressBar progressSelectionSort;
        private System.Windows.Forms.Label lblSelectionSort;
        private System.Windows.Forms.Button btnGuardarWord;
        private System.Windows.Forms.Button btnIniciarWord;
        private System.Windows.Forms.Button btnReanudar;
    }
}

