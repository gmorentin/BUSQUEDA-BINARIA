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
        public int comp;

        public Vector()
        {
            vector = new int[500];
            alea = new Random();
            llenaryOrdenar();
        }

        public void llenaryOrdenar()
        {
            for (int i = 0; i < 500; i++)
            {
                vector[i] = alea.Next(0, 10000);
            }
            Array.Sort(vector);
        }


        public int busquedaBin(int num)
        {
            int limiteInferior=0;
            int limiteSuperior=500;
            comp=0;
            int mitad;
            bool encontrado = false;

            mitad = limiteSuperior / 2;
            if (vector[mitad] == num)
            {
                comp++;
                return mitad;
            }
            else
            {
                while (limiteInferior <= limiteSuperior && encontrado==false)
                {
                    mitad = (limiteInferior + limiteSuperior) / 2;
                    if (vector[mitad] == num)
                    {
                        comp++;
                        encontrado = true;
                    }
                    else
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
                return mitad;
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
