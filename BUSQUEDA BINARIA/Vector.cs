using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUSQUEDA_BINARIA
{
    class Vector
    {
        private int[] vector;

        private static Random alea;
        public int limiteInferior;
        public int limiteSuperior;
        public int comp;
        public int mitad;

        public Vector()
        {
            vector = new int[500];
            alea = new Random();
            limiteInferior = 0;
            limiteSuperior = 0;
            comp = 0;
            mitad = 0;
            llenar();
        }

        public void llenar()
        {
            for (int i = 0; i < 500; i++)
            {
                vector[i] = alea.Next(0, 10000);
            }
            Array.Sort(vector);
            limiteInferior = 0;
            limiteSuperior = 500;
        }

        public void busquedaBinaria(int numero)
        {
            mitad = limiteSuperior / 2;
            if (numero == vector[mitad])
            {
                comp++;
            }
            else BusquedaBinaria(numero, mitad, limiteInferior);
        }

        public void BusquedaBinaria(int numero, int lS, int lI)
        {
            if (numero < vector[mitad])
            {
                comp++;
                mitad = mitad / 2;
            }
            else
            {
                comp++;

            }
        }


        public void busquedaBin(int num)
        {
            mitad = limiteSuperior / 2;
            if (vector[mitad] == num)
                comp++;
            else
            {
                while (limiteInferior <= limiteSuperior)
                {
                    mitad = (limiteInferior + limiteSuperior) / 2;
                    if (vector[mitad] == num)
                    {
                        comp++;
                        break;
                    }
                    
                    if (vector[mitad] > num)
                    {
                        limiteSuperior = mitad - 1;
                        comp++;
                    }
                    else
                    {
                        limiteInferior = mitad + 1;
                        comp++;
                    }
                }
            }
        }

    }


}











        //public int busquedaBinaria1(int numero)
        //{
        //    mitad = limiteSuperior / 2;
        //    if (vector[mitad] == numero)
        //    {
        //        comp++;
        //        return mitad;
        //    }
        //    else
        //    {
        //        while (limiteInferior <= limiteSuperior)
        //        {
        //            mitad = (limiteSuperior + limiteInferior) / 2;
        //            if (vector[mitad] == numero)
        //            {
        //                comp++;
        //                return mitad;
        //            }
        //            else
        //            if (numero < vector[mitad])
        //            {
        //                comp++;
        //                limiteSuperior = mitad - 1;
        //            }
        //            else
        //            {
        //                comp++;
        //                limiteInferior = mitad + 1;
        //            }

        //        }
        //        return -1;
        //    }
        //}



    //if (numero == vector[buscar])
            //{
            //    comp++;
            //    encontrado = buscar;
            //}
            //else if (numero < vector[buscar])
            //{
            //    limiteSuperior = limiteSuperior / 2;
            //    buscar = limiteSuperior / 2;
            //    comp++;
            //}
            //else
            //{
            //    limiteInferior = buscar;
            //    buscar = (limiteSuperior-limiteInferior)/2;
            //    comp++;
            //}
