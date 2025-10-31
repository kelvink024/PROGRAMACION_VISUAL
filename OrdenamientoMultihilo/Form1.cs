using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Word = Microsoft.Office.Interop.Word;

namespace OrdenamientoMultihilo
{
    public partial class Form1 : Form
    {
        private List<int> listaOriginal;
        private List<int> listaBurbuja;
        private List<int> listaQuik;
        private List<int> listaMerge;
        private List<int> listaSelection;

        private Thread hiloBurbuja;
        private Thread hiloSelection;

        private Stopwatch relojBurbuja = new Stopwatch();
        private Stopwatch relojQuik = new Stopwatch();
        private Stopwatch relojMerge = new Stopwatch();
        private Stopwatch relojSelection = new Stopwatch();

        private bool cancelarBurbuja = false;
        private bool cancelarSelection = false;
        private bool cancelarMerge = false;
        private bool cancelarQuick = false;

        private Word.Application wordApp;
        private Word.Document wordDoc;
        private object missing = Type.Missing;

        private bool pausarBurbuja = false;
        private bool pausarQuicksor = false;
        private bool pausarMergesort = false;
        private bool pausarSelectionsort = false;

        private readonly object bloqueoBurbuja = new object();
        private readonly object bloqueoSelection = new object();
        private readonly object bloqueoMerge = new object();
        private readonly object bloqueoQuick = new object();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                if (chartResultados.Series.FindByName("Tiempos") == null)
                {
                    chartResultados.Series.Add("Tiempos");
                    chartResultados.Series["Tiempos"].IsValueShownAsLabel = true;
                    chartResultados.Series["Tiempos"].ChartType = SeriesChartType.Column;
                }
                backgroundWorkerQuickSort.WorkerReportsProgress = true;
                backgroundWorkerQuickSort.WorkerSupportsCancellation = true;
                
                backgroundWorker2Merge.WorkerReportsProgress = true;
                backgroundWorker2Merge.WorkerSupportsCancellation = true;
            }
            catch(Exception ex) 
            {
                MessageBox.Show("error al iniciar los tiempos");
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                if(!int.TryParse(txtCantidad.Text, out int cantidad) || cantidad <= 0)
                {
                    MessageBox.Show("ingrese un numero valido de elementos");
                    return;
                }
                listaOriginal = new List<int>();
                Random rnd = new Random();

                for (int i = 0; i< cantidad; i++)
                {
                    listaOriginal.Add(rnd.Next(0, 100000));
                }

                
                //IniciarWord();
                AgregarLineaWord("LISTA ORIGINAL GENERADA:");
                AgregarLineaWord(Preview(listaOriginal));
                AgregarLineaWord(""); 


                MessageBox.Show($"cantidad generada con {cantidad} de numeros ");
            } catch (Exception ex)
            {
                MessageBox.Show("ERROR AL GENERAR LA LISTA DE LOS NUMEROS ALEATOREOS");
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
           if(listaOriginal == null || listaOriginal.Count == 0)
           {
                MessageBox.Show("primero genera los datos");
                return;
           }
           
           listaBurbuja = new List<int>(listaOriginal);
           listaQuik = new List<int>(listaOriginal);
           listaMerge = new List<int>(listaOriginal);
           listaSelection = new List<int>(listaOriginal);

            cancelarBurbuja = false;
            cancelarSelection = false;

            button2.Enabled = false;

            //burbuja
            try
            {
                hiloBurbuja = new Thread(OrdenarBurbuja);
                hiloBurbuja.Start();
            }
            catch (Exception ex) 
            {
                MessageBox.Show("ERROR AL INICIAR EL ALGORITMO DE BURBUJA");
            }

            // QuickSort
            try
            {
                if (!backgroundWorkerQuickSort.IsBusy)
                {
                    backgroundWorkerQuickSort.RunWorkerAsync(listaQuik);
                }

            }catch(Exception ex)
            {
                MessageBox.Show("ERROR AL INICIAR EL ALGORITMO DE QUICKSORT");
            }

            // MergeSort
            try
            {
                if (!backgroundWorker2Merge.IsBusy)
                {
                    backgroundWorker2Merge.RunWorkerAsync(listaMerge);
                }
            }catch( Exception ex)
            {
                MessageBox.Show("ERROR AL INICAR EL ALGORITMO DE MERGESORT");
            }

            // SelectionSort
            try
            {
                hiloSelection = new Thread(OrdenarSelection);
                hiloSelection.Start();
            } catch( Exception ex)
            {
                MessageBox.Show("ERROR AL COMENZAR EL ALGORITMO DE SELECTIO SORT");
            }
        }




        // ALGORITMO DE  BURBUJA
        private void OrdenarBurbuja()
        {
            try
            {
                relojBurbuja.Restart();
                int n = listaBurbuja.Count;

                for (int i = 0; i < n - 1 && !cancelarBurbuja; i++)
                {
                    for (int j = 0; j < n - i - 1 && !cancelarBurbuja; j++)
                    {
                        EsperarSiPausado(ref pausarBurbuja, bloqueoBurbuja);
                        if (listaBurbuja[j] > listaBurbuja[j + 1])
                        {
                            int temp = listaBurbuja[j];
                            listaBurbuja[j] = listaBurbuja[j + 1];
                            listaBurbuja[j + 1] = temp;
                        }
                    }

                    if (i % 500 == 0)
                    {
                        int progreso = (int)((i / (float)n) * 100);
                        this.Invoke(new Action(() =>
                        {
                            if (!this.IsDisposed)
                            {
                                progressBurbuja.Value = Math.Min(progreso, 100);
                                lblBurbuja.Text = $"Burbuja: {progreso}%";
                            }
                        }));

                    }
                }

                relojBurbuja.Stop();

                if (!cancelarBurbuja)
                {
                    this.Invoke(new Action(() =>
                    {
                        progressBurbuja.Value = 100;
                        lblBurbuja.Text = $"Burbuja: Completado en {relojBurbuja.ElapsedMilliseconds} ms";
                        AgregarResultado("Burbuja", relojBurbuja.ElapsedMilliseconds);
                        button2.Enabled = true;

                        AgregarLineaWord("ALGORITMO: BURBUJA");
                        AgregarLineaWord($"Tiempo: {relojBurbuja.ElapsedMilliseconds} ms");
                        AgregarLineaWord($"Resultado: {Preview(listaBurbuja)}");
                        AgregarLineaWord(""); // línea en blanco

                    }));
                }
            }
            catch (Exception ex)
            {
                this.Invoke(new Action(() =>
                {
                    MessageBox.Show("Error en hilo Burbuja: " + ex.Message);
                }));
            }   
        }

            

        // ALGORITMO QUICK SORT
        private void QuickSort(List<int> lista, int izquierda, int derecha, BackgroundWorker worker)
        {
            EsperarSiPausado(ref pausarQuicksor, bloqueoQuick);
            if (worker.CancellationPending)
                return;

            if (izquierda < derecha)
            {
                int pivot = Particionar(lista, izquierda, derecha);
                QuickSort(lista, izquierda, pivot - 1, worker);
                QuickSort(lista, pivot + 1, derecha, worker);
            }

            if (derecha % 1000 == 0)
            {
                int progreso = (int)((derecha / (float)lista.Count) * 100);
                worker.ReportProgress(Math.Min(progreso, 100));
                
            }
            

        }


        private int Particionar(List<int> lista, int izquierda, int derecha)
        {
            int pivote = lista[derecha];
            int i = izquierda - 1;

            for (int j = izquierda; j < derecha; j++)
            {
                if (lista[j] <= pivote)
                {
                    i++;
                    int temp = lista[i];
                    lista[i] = lista[j];
                    lista[j] = temp;
                }
            }
            int temp2 = lista[i + 1];
            lista[i + 1] = lista[derecha];
            lista[derecha] = temp2;
            return i + 1;
        }
        
        private void backgroundWorkerQuickSort_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                relojQuik.Restart();
                List<int> lista = (List<int>)e.Argument;
                QuickSort(lista, 0, lista.Count - 1, backgroundWorkerQuickSort);
                if (backgroundWorkerQuickSort.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en QuickSort: " + ex.Message);
            }
        }

        private void backgroundWorkerQuickSort_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressQuickSort.Value = e.ProgressPercentage;
            lblQuickSort.Text = $"QuickSort: {e.ProgressPercentage}%";
        }

        private void backgroundWorkerQuickSort_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            relojQuik.Stop();
            lblQuickSort.Text = $"QuickSort: Completado en {relojQuik.ElapsedMilliseconds} ms";
            progressQuickSort.Value = 100;
            AgregarResultado("QuickSort", relojQuik.ElapsedMilliseconds);
            button2.Enabled = true;


            AgregarLineaWord("ALGORITMO: QUICK SORT");
            AgregarLineaWord($"Tiempo: {relojQuik.ElapsedMilliseconds} ms");
            AgregarLineaWord($"Resultado: {Preview(listaQuik)}");
            AgregarLineaWord(""); // línea en blanco

        }




        // ALGORITMO DE SELECTION SORT

        private void OrdenarSelection()
        {
            try
            {
                relojSelection.Restart();
                int n = listaSelection.Count;
                for (int i = 0; i < n - 1 && !cancelarSelection; i++)
                {
                    EsperarSiPausado(ref pausarSelectionsort, bloqueoSelection);
                    int minIndex = i;
                    for (int j = i + 1; j < n && !cancelarSelection; j++)
                    {
                        EsperarSiPausado(ref pausarSelectionsort, bloqueoSelection);
                        if (listaSelection[j] < listaSelection[minIndex])
                            minIndex = j;
                    }

                    int temp = listaSelection[minIndex];
                    listaSelection[minIndex] = listaSelection[i];
                    listaSelection[i] = temp;

                    if (i % 500 == 0)
                    {
                        int progreso = (int)((i / (float)n) * 100);
                        this.Invoke(new Action(() =>
                        {
                            if (!this.IsDisposed)
                            {
                               progressSelectionSort.Value = Math.Min(progreso, 100);
                                lblSelectionSort.Text = $"SelectionSort: {progreso}%";
                            }
                        }));
                        
                    }
                }

                relojSelection.Stop();

                if (!cancelarSelection)
                {
                    this.Invoke(new Action(() =>
                    {
                        progressSelectionSort.Value = 100;
                        lblSelectionSort.Text = $"SelectionSort: Completado en {relojSelection.ElapsedMilliseconds} ms";
                        AgregarResultado("SelectionSort", relojSelection.ElapsedMilliseconds);
                        button2.Enabled = true;

                        AgregarLineaWord("ALGORITMO: SELECTION SORT");
                        AgregarLineaWord($"Tiempo: {relojSelection.ElapsedMilliseconds} ms");
                        AgregarLineaWord($"Resultado: {Preview(listaSelection)}");
                        AgregarLineaWord(""); // línea en blanco

                    }));
                }
            } catch (Exception ex)
            {
                this.Invoke(new Action(() =>
                {
                    MessageBox.Show("Error en hilo SelectionSort: " + ex.Message);
                }));
            }
        }



        // ALGORITMO MERGE SORT
        private void backgroundWorker2Merge_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                relojMerge.Restart();
                List<int> lista = (List<int>)e.Argument;
                MergeSort(lista, 0, lista.Count - 1, backgroundWorker2Merge);
                if (backgroundWorker2Merge.CancellationPending || cancelarMerge)
                    return;

            } catch (Exception ex)
            {
                MessageBox.Show("Error en MergeSort: " + ex.Message);
            }
        }

        private void MergeSort(List<int> lista, int izquierda, int derecha, BackgroundWorker worker)
        {
            EsperarSiPausado(ref pausarMergesort, bloqueoMerge);
            if (worker.CancellationPending)
                return;

            if (izquierda < derecha)
            {
                int medio = (izquierda + derecha) / 2;
                MergeSort(lista, izquierda, medio, worker);
                MergeSort(lista, medio + 1, derecha, worker);
                Merge(lista, izquierda, medio, derecha);
                
            }
            this.Invoke(new Action(() =>
            {
               
            }));

        }

        private void Merge(List<int> lista, int izquierda, int medio, int derecha)
        {
            int n1 = medio - izquierda + 1;
            int n2 = derecha - medio;
            int[] L = new int[n1];
            int[] R = new int[n2];

            for (int i = 0; i < n1; i++)
                L[i] = lista[izquierda + i];
            for (int j = 0; j < n2; j++)
                R[j] = lista[medio + 1 + j];

            int k = izquierda, a = 0, b = 0;
            while (a < n1 && b < n2)
            {
                EsperarSiPausado(ref pausarMergesort, bloqueoMerge);
                if (L[a] <= R[b])
                    lista[k++] = L[a++];
                else
                    lista[k++] = R[b++];
            }

            while (a < n1)
                lista[k++] = L[a++];
            while (b < n2)
                lista[k++] = R[b++];
        }

        private void backgroundWorker2Merge_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
           
        }

        private void backgroundWorker2Merge_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            relojMerge.Stop();
            lblMergeSort.Text = $"MergeSort: Completado en {relojMerge.ElapsedMilliseconds} ms";
            progressMergeSort.Value = 100;
            AgregarResultado("MergeSort", relojMerge.ElapsedMilliseconds);
            button2.Enabled = true;

            AgregarLineaWord("ALGORITMO: MERGE SORT");
            AgregarLineaWord($"Tiempo: {relojMerge.ElapsedMilliseconds} ms");
            AgregarLineaWord($"Resultado: {Preview(listaMerge)}");
            AgregarLineaWord(""); // línea en blanco

        }


        private void btnDetener_Click(object sender, EventArgs e)
        {
            pausarBurbuja = true;
            pausarQuicksor = true;
            pausarMergesort = true;
            pausarSelectionsort = true;

            MessageBox.Show("Ejecución pausada. Usa 'Reanudar' para continuar.");
        }
        private void chartResultados_Click(object sender, EventArgs e)
        {
        }

        private void AgregarResultado(string algoritmo, long tiempoMs)
        {
            if (chartResultados.Series["Tiempos"] == null)
                chartResultados.Series.Add("Tiempos");

            chartResultados.Series["Tiempos"].Points.AddXY(algoritmo, tiempoMs);
        }

        private void limpiar_datos()
        {
            listaOriginal = null;
            listaBurbuja = null;
            listaQuik = null;
            listaMerge = null;
            listaSelection = null;

            lblBurbuja.Text = "Burbuja: ";
            lblQuickSort.Text = "QuickSort: ";
            lblMergeSort.Text = "MergeSort: ";
            lblSelectionSort.Text = "SelectionSort: ";

            progressBurbuja.Value = 0;
            progressQuickSort.Value = 0;
            progressMergeSort.Value = 0;
            progressSelectionSort.Value = 0;

            if (chartResultados.Series.FindByName("Tiempos") != null)
                chartResultados.Series["Tiempos"].Points.Clear();

            txtCantidad.Clear(); listaOriginal = null;
            listaBurbuja = null;
            listaQuik = null;
            listaMerge = null;
            listaSelection = null;

            lblBurbuja.Text = "Burbuja: ";
            lblQuickSort.Text = "QuickSort: ";
            lblMergeSort.Text = "MergeSort: ";
            lblSelectionSort.Text = "SelectionSort: ";

            progressBurbuja.Value = 0;
            progressQuickSort.Value = 0;
            progressMergeSort.Value = 0;
            progressSelectionSort.Value = 0;

            if (chartResultados.Series.FindByName("Tiempos") != null)
                chartResultados.Series["Tiempos"].Points.Clear();

            txtCantidad.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            limpiar_datos();
            MessageBox.Show("Datos limpiados correctamente.");
        }

        private string Preview(List<int> lista)
        {
            if (lista == null || lista.Count == 0)
                return "Lista vacía";
            return string.Join(", ", lista.Take(20)) + (lista.Count > 20 ? ", ..." : "");
        }

        #region Guardar en Word
        private void btnGuardarWord_Click(object sender, EventArgs e)
        {
            try
            {
                if (wordDoc != null)
                {
                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.Filter = "Documentos de Word|*.docx";
                    sfd.FileName = "Resultados_Ordenamiento.docx";

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        wordDoc.SaveAs2(sfd.FileName);
                        MessageBox.Show("Documento guardado correctamente en Word.");
                    }
                }
                else
                {
                    MessageBox.Show("Primero genera la lista para iniciar el documento Word.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar Word: " + ex.Message);
            }

        }
        #endregion

        // atajos menu -> botones (si existen en menú)
        private void toolStripMenuItem1_Click(object sender, EventArgs e) => btnGenerar.PerformClick();
        private void toolStripMenuItem2_Click(object sender, EventArgs e) => button2.PerformClick();
        private void toolStripMenuItem3_Click(object sender, EventArgs e) => btnDetener.PerformClick();
        private void toolStripMenuItem4_Click(object sender, EventArgs e) => btnClear.PerformClick();

        private void progressSelectionSort_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardarWord_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (wordDoc != null)
                {
                    SaveFileDialog sfd = new SaveFileDialog
                    {
                        Filter = "Documentos de Word|*.docx",
                        FileName = "Iteraciones_Ordenamiento.docx"
                    };

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        wordDoc.SaveAs2(sfd.FileName);
                        MessageBox.Show("Documento guardado correctamente en: " + sfd.FileName);
                    }
                }
                else
                {
                    MessageBox.Show("Primero inicia Word con el botón IniciarWord.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar Word: " + ex.Message);
            }
        }

        private void AgregarLineaWord(string texto)
        {
            try
            {
                if (wordDoc != null)
                {
                    Word.Paragraph parrafo = wordDoc.Content.Paragraphs.Add();
                    parrafo.Range.Text = texto;
                    parrafo.Range.InsertParagraphAfter();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error agregando línea a Word: " + ex.Message);
            }
        }


        private void IniciarWord()
        {
            wordApp = new Word.Application();
            wordApp.Visible = true;
            wordDoc = wordApp.Documents.Add(ref missing, ref missing, ref missing, ref missing);
            Word.Paragraph parrafo = wordDoc.Content.Paragraphs.Add(ref missing);
            parrafo.Range.Text = $"Registro de iteraciones - {DateTime.Now}";
            parrafo.Range.InsertParagraphAfter();
        }

        private void btnIniciarWord_Click(object sender, EventArgs e)
        {
            IniciarWord();
            MessageBox.Show("Word iniciado. Las iteraciones se registrarán aquí.");
        }

        private void btnReanudar_Click(object sender, EventArgs e)
        {
            ReanudarHilo(ref pausarBurbuja, bloqueoBurbuja);
            ReanudarHilo(ref pausarQuicksor, bloqueoQuick);
            ReanudarHilo(ref pausarMergesort, bloqueoMerge);
            ReanudarHilo(ref pausarSelectionsort, bloqueoSelection);

            MessageBox.Show("Ejecución reanudada.");
        }
        private void EsperarSiPausado(ref bool pausaFlag, object bloqueo)
        {
            lock (bloqueo)
            {
                while (pausaFlag)
                {
                    Monitor.Wait(bloqueo); // Suspende hasta que se reanude
                }
            }
        }

        private void ReanudarHilo(ref bool pausaFlag, object bloqueo)
        {
            lock (bloqueo)
            {
                pausaFlag = false;
                Monitor.PulseAll(bloqueo); // Despierta los hilos pausados
            }
        }

    }
}
