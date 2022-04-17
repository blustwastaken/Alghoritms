﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alghoritms.Sort
{
    
    public class SelectionSorter<T>
    {
        /// <summary>
        /// Выполняет сортировку слиянием.
        /// </summary>
        public T[] Sort(T[] array, IComparer<T> comparer)
        {
            for (int i = 0; i < array.Length; i++)
            {
                var min = array[i];
                for (int j = 0; j < array.Length; j++)
                {
                    if(comparer.Compare(array[i],array[j]) > 0)
                        min = array[i];
                }

                array[i] = min;
            }

            return array;
        }
    }
}
