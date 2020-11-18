
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace KartaOcenFilmow
{
    class karta
    {

        public karta()
        {
            oceny =new List<float>();
        }

        

        //stan (zmienne - pola)

        private List<float> oceny;


        //zachowania (metody)

        internal KartaStatystyki ObliczStatystyki()
        {

            KartaStatystyki stat = new KartaStatystyki();


            float suma = 0;
            
            foreach (var ocena in oceny)
            {
                suma += ocena;
            }

            stat.sredniaOcena = suma / oceny.Count();
            
            return stat;
        }


        /// <summary>
        /// dodaje nową ocene do listy ocen 
        /// </summary>
        /// <param name="ocena">nowa ocena</param>
        public void DodajOcene(float ocena)
        {
            oceny.Add(ocena);
        }


        /// <summary>
        /// obliczamy srednią z listy ocen
        /// </summary>
        /// <returns>srednia ocena</returns>
        public float ObliczSrednia()
        {
            float suma = 0;
            float srednia = 0;
            foreach (var ocena in oceny)
            {
                suma += ocena;
            }

            srednia = suma / oceny.Count(); 

            return srednia;
        }


        /// <summary>
        /// obliczamy najwyzsza ocene
        /// </summary>
        /// <returns>zwraca najwyzsza ocene</returns>
        public float NajnizszaOcena()
        {
            float min=float.MaxValue; 
            foreach (var ocena in oceny)
            {
                if (min > ocena)
                {
                    min = ocena;
                }
            }

            return min;
        }

        /// <summary>
        /// obliczamy najnizsza ocene
        /// </summary>
        /// <returns>zwraca najnizsza ocene</returns>
        public float NajwyzszaOcena ()
        {
            return oceny.Max();
        }
    }
}
