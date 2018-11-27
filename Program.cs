using System;
using System.Diagnostics;

namespace MetodoOrdenar
{
    class Program
    {
        
        static int[] vetordecrescente(int x)
        {
            int[] vetor = new int[x];

            for (int y = 0; y < vetor.Length; y++)
            {
                
                vetor[y] = x;
                x = x - 1;
              
            }

            return vetor;
        }

        static int[] vetorcrescente(int x)
        {
            int[] vetor = new int[x];
            for (int i = 0; i < vetor.Length; i++)

            return vetor;
        }


        static int[] vetoraleatorio(int x)
        {
            int[] vetor = new int[x];
           
            Random aleatorio = new Random();
            for (int j = 0; j < vetor.Length; j++)
            {
                vetor[j] = aleatorio.Next(0, 100000); 
            }

            return vetor;
        }


        static int[] bubbleSort(int[] vetor)
        {

            int x = vetor.Length;
            int comparar = 0;
            int trocar = 0;

            for (int i = x - 1; i >= 1; i--)

            {

                for (int j = 0; j < i; j++)

                {

                    comparar++;

                    if (vetor[j] > vetor[j + 1])

                    {

                        int aux = vetor[j];

                        vetor[j] = vetor[j + 1];

                        vetor[j + 1] = aux;

                        trocar++;

                    }

                }

            }

            return vetor;

        }

        void insertion_sort(int[] vetor, int tamanhoVetor)
        {

            int selecionado, j;

            for (int i = 1; i < tamanhoVetor; i++)
            {
                selecionado = vetor[i];
                j = i - 1;

                while ((j >= 0) && (vetor[j] > selecionado))
                {
                    vetor[j + 1] = vetor[j];
                    j--;
                }

                vetor[j + 1] = selecionado;
            }


        }

        static int[] SelectionSort(int[] vetor)

        {

            int min, aux;

            for (int i = 0; i < vetor.Length - 1; i++)

            {

                min = i;



                for (int j = i + 1; j < vetor.Length; j++)

                    if (vetor[j] < vetor[min])

                        min = j;

                if (min != i)

                {

                    aux = vetor[min];

                    vetor[min] = vetor[i];

                    vetor[i] = aux;
                }
            }
            return vetor;
        }


        static int[] QuickSort(int[] vetor)

        {
            int inicio = 0;
            int fim = vetor.Length - 1;
            QuickSort(vetor, inicio, fim);
            return vetor;
        }
        static void QuickSort(int[] vetor, int comeco, int final)

        {
            if (comeco < final)
            {
                int p = vetor[comeco];
                int i = comeco + 1;
                int f = final;
                while (i <= f)
                {
                    if (vetor[i] <= p)
                    {
                        i++;
                    }
                    else if (p < vetor[f])
                    {
                        f--;
                    }
                    else
                    {
                        int troca = vetor[i];
                        vetor[i] = vetor[f];
                        vetor[f] = troca;
                        i++;
                        f--;
                    }
                }
                vetor[comeco] = vetor[f];
                vetor[f] = p;
                QuickSort(vetor, comeco, f - 1);
                QuickSort(vetor, f + 1, final);
            }
        }

        void Juntar(int[] vetor, int ini, int meio, int fim, int[] vetAux)
        {
            int esq = ini;
            int dir = meio;
            for (int i = ini; i < fim; ++i)
            {
                if ((esq < meio) && ((dir >= fim) || (vetor[esq] < vetor[dir])))
                {
                    vetAux[i] = vetor[esq];
                    ++esq;
                }
                else
                {
                    vetAux[i] = vetor[dir];
                    ++dir;
                }
            }

            for (int i = ini; i < fim; ++i)
           
        }

        void MergeSort(int[] vetor, int inicio, int fim, int[] vetorAux)
        {
            if ((fim - inicio) < 2) return;

            int meio = ((inicio + fim) / 2);
            MergeSort(vetor, inicio, meio, vetorAux);
            MergeSort(vetor, meio, fim, vetorAux);
            Juntar(vetor, inicio, meio, fim, vetorAux);
        }

        void MergeSort(int[] vetor, int x)
        {
            int[] vetorAux = new int[x];
            MergeSort(vetor, 0, x, vetorAux);
        }





        static void Main(string[] args)
        {
            
            {


                Stopwatch sw_desc_insertion = new Stopwatch();
                Stopwatch sw_orde_insertion = new Stopwatch();
                Stopwatch sw_aleatorio_insertion = new Stopwatch();

                Stopwatch sw_desc_selection = new Stopwatch();
                Stopwatch sw_orde_selection = new Stopwatch();
                Stopwatch sw_aleatorio_selection = new Stopwatch();

                Stopwatch sw_desc_bubble = new Stopwatch();
                Stopwatch sw_orde_bubble = new Stopwatch();
                Stopwatch sw_aleatorio_bubble = new Stopwatch();

                Stopwatch sw_desc_quick = new Stopwatch();
                Stopwatch sw_orde_quick = new Stopwatch();
                Stopwatch sw_aleatorio_quick = new Stopwatch();

                Stopwatch sw_desc_merge = new Stopwatch();
                Stopwatch sw_orde_merge = new Stopwatch();
                Stopwatch sw_aleatorio_merge = new Stopwatch();



                int[] vetor_desc_insertion = new int[10000]; 
                vetor_desc_insertion = vetordecrescente(10000); 

                sw_desc_insertion.Start();

                Program ordena_insertion = new Program(); 
                ordena_insertion.insertion_sort(vetor_desc_insertion, 10000);

      
                sw_desc_insertion.Stop();


                TimeSpan tempo_insertion = sw_desc_insertion.Elapsed;


                int[] vetor_orde_insertion = new int[10000]; 
                vetor_cres_insertion = vetorcrescente(10000); 

                Console.WriteLine( + "Vetor ordenardo pelo insertion sort" + "\n");


           
                sw_cres_insertion.Start();

                Program ordena_orde_insertion = new Program();
                ordena_cres_insertion.insertion_sort(vetor_orde_insertion, 10000);

                sw_orde_insertion.Stop();

                TimeSpan tempo_cres_insertion = sw_cres_insertion.Elapsed;


                int[] vetor_aleatorio_insertion = new int[10000]; 
                vetor_aleatorio_insertion = vetoraleatorio(10000);


                sw_aleatorio_insertion.Start();

                Program ordena_aleatorio_insertion = new Program(); 
                ordena_aleatorio_insertion.insertion_sort(vetor_aleatorio_insertion, 10000);

                sw_aleatorio_insertion.Stop();

                TimeSpan tempo_aleatorio_insertion = sw_aleatorio_insertion.Elapsed;




                Console.WriteLine();
                Console.WriteLine("\n" + "Tempo de execução do Insertion Sort vetor decrescente : " + tempo_insertion + "\n");
                Console.WriteLine("\n" + "Tempo de execução do Insertion Sort vetor crescente : " + tempo_orde_insertion + "\n");
                Console.WriteLine("\n" + "Tempo de execução do Insertion Sort vetor aleatorio : " + tempo_aleatorio_insertion + "\n");
                Console.WriteLine("Tecle ENTER para continuar");
                Console.ReadKey();
                Console.Clear();



                int[] vetor_desc_selection = new int[10000]; 
                vetor_desc_selection = vetordecrescente(10000);

                Console.WriteLine("\n \n" + "Vetor ordenardo pelo Selection sort" + "\n");

                sw_desc_selection.Start();

                SelectionSort(vetor_desc_selection);

                sw_desc_selection.Stop();

                TimeSpan tempo_selection = sw_desc_selection.Elapsed;


                int[] vetor_orde_selection = new int[10000]; 
                vetor_orde_selection = vetorcrescente(10000); 

                sw_orde_selection.Start();

                SelectionSort(vetor_orde_selection);

                sw_orde_selection.Stop();

                TimeSpan tempo_orde_selection = sw_orde_selection.Elapsed;

                int[] vetor_aleatorio_selection = new int[10000]; 
                vetor_aleatorio_selection = vetoraleatorio(10000); 

              
                sw_aleatorio_selection.Start();

                SelectionSort(vetor_aleatorio_selection);

                sw_aleatorio_selection.Stop();

        
                TimeSpan tempo_aleatorio_selection = sw_aleatorio_selection.Elapsed;


                Console.WriteLine();
                Console.WriteLine("\n" + "Tempo de execução do Selection Sort vetor decrescente : " + tempo_selection + "\n");
                Console.WriteLine("\n" + "Tempo de execução do Selection Sort vetor crescente : " + tempo_orde_selection + "\n");
                Console.WriteLine("\n" + "Tempo de execução do Selection Sort vetor aleatorio : " + tempo_aleatorio_selection + "\n");
                Console.WriteLine("Tecle ENTER para continuar");
                Console.ReadKey();
                Console.Clear();


                int[] vetor_desc_bubble = new int[10000];
                vetor_desc_bubble = vetordecrescente(10000); 

                Console.WriteLine( + "Vetor ordenardo pelo Bubble sort" + "\n");


                sw_desc_bubble.Start();

                bubbleSort(vetor_desc_bubble);

                sw_desc_bubble.Stop();

                TimeSpan tempo_bubble = sw_desc_bubble.Elapsed;


                int[] vetor_orde_bubble = new int[10000]; 
     
                sw_orde_bubble.Start();

                bubbleSort(vetor_orde_bubble);

                sw_orde_bubble.Stop();

                TimeSpan tempo_orde_bubble = sw_orde_bubble.Elapsed;


                int[] vetor_aleatorio_bubble = new int[10000]; 
                vetor_aleatorio_bubble = vetoraleatorio(10000); 

                sw_aleatorio_bubble.Start();

                bubbleSort(vetor_aleatorio_bubble);

                sw_alaeatorio_bubble.Stop();

             
                TimeSpan tempo_randon_bubble = sw_aleatorio_bubble.Elapsed;



                Console.WriteLine();
                Console.WriteLine("\n" + "Tempo de execução do Bubble Sort vetor decrescente : " + tempo_bubble + "\n");
                Console.WriteLine("\n" + "Tempo de execução do Bubble Sort vetor crescente : " + tempo_orde_bubble + "\n");
                Console.WriteLine("\n" + "Tempo de execução do Bubble Sort vetor aleatorio : " + tempo_alaeatorio_bubble + "\n");
                Console.WriteLine("Tecle ENTER para continuar");
                Console.ReadKey();
                Console.Clear();

                int[] vetor_desc_quick = new int[10000]; 
                vetor_desc_quick = vetordecrescente(10000); 

                Console.WriteLine(+ "Vetor ordenardo pelo Quick sort" + "\n");


      
                sw_desc_quick.Start();

                QuickSort(vetor_desc_quick);

                sw_desc_quick.Stop();

                TimeSpan tempo_quick = sw_desc_quick.Elapsed;


                int[] vetor_orde_quick = new int[10000];
                vetor_orde_quick = vetorcrescente(10000);

   
                sw_orde_quick.Start();

                QuickSort(vetor_orde_quick);

 
                sw_orde_quick.Stop();

 
                TimeSpan tempo_orde_quick = sw_orde_quick.Elapsed;


                int[] vetor_aleatorio_quick = new int[10000]; 
                vetor_aleatorio_quick = vetoraleatorio(10000); 


                sw_aleatorio_quick.Start();

                QuickSort(vetor_aleatorio_quick);

              
                sw_aleatorio_quick.Stop();

     
                TimeSpan tempo_aleatorio_quick = sw_aleatorio_quick.Elapsed;





                Console.WriteLine();
                Console.WriteLine("\n" + "Tempo de execução do Quick Sort vetor decrescente : " + tempo_quick + "\n");
                Console.WriteLine("\n" + "Tempo de execução do Quick Sort vetor crescente : " + tempo_orde_quick + "\n");
                Console.WriteLine("\n" + "Tempo de execução do Quick Sort vetor aleatorio : " + tempo_aleatorio_quick + "\n");
                Console.WriteLine("Tecle ENTER para continuar");
                Console.ReadKey();
                Console.Clear();

                int[] vetor_desc_merge = new int[10000]; 
                vetor_desc_merge = vetordecrescente(10000); 

                Console.WriteLine(+ "Vetor ordenardo pelo Merge sort" + "\n");


                sw_desc_merge.Start();

                Program ordena_merge = new Program();
                ordena_merge.MergeSort(vetor_desc_merge, 10000);

      
                sw_desc_merge.Stop();

                TimeSpan tempo_merge = sw_desc_merge.Elapsed;


                int[] vetor_orde_merge = new int[10000]; 
                vetor_orde_merge = vetorcrescente(10000); 

       
                sw_cres_merge.Start();

                Program ordena_orde_merge = new Program(); 
                ordena_orde_merge.MergeSort(vetor_orde_merge, 10000);

   
                sw_orde_merge.Stop();

                TimeSpan tempo_cres_merge = sw_cres_merge.Elapsed;

                int[] vetor_aleatorio_merge = new int[10000]; 
                vetor_aleatorio_merge = vetoraleatorio(10000); 


                sw_randon_merge.Start();

                Program ordena_aleatorio_merge = new Program(); 
                ordena_aleatorio_merge.MergeSort(vetor_aleatorio_merge, 10000);

              
                sw_aleatorio_merge.Stop();

  
                TimeSpan tempo_aleatorio_merge = sw_aleatorio_merge.Elapsed;


                Console.WriteLine();
                Console.WriteLine("\n" + "Tempo de execução do Merge Sort vetor decrescente: " + tempo_merge + "\n");
                Console.WriteLine("\n" + "Tempo de execução do Merge Sort vetor crescente: " + tempo_orde_merge + "\n");
                Console.WriteLine("\n" + "Tempo de execução do Merge Sort vetor aleatorio: " + tempo_aleatorio_merge + "\n");
                Console.WriteLine("Tecle ENTER para continuar");
                Console.ReadKey();
                Console.Clear();



            }

        }
    }
}

