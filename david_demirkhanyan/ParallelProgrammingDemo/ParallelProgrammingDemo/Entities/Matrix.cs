﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParallelProgrammingDemo.Entities
{
    public class Matrix<T>
    {
        private List<List<T>> matrixValues;
        private int height;
        private int width;

        /// <summary>
        /// Initializes a matrix of type T
        /// </summary>
        /// <param name="height">default value is 1024</param>
        /// <param name="width">default value is 512</param>
        public Matrix(int height = 1024, int width = 512)
        {
            this.InitializeMatrix(height, width);
            this.height = height;
            this.width = width;
        }


        private void InitializeMatrix(int height, int width)
        {
            this.matrixValues = new List<List<T>>(height);

            for (int i = 0; i < height; i++)
            {
                matrixValues.Add(new List<T>(new T[width]));
            }
        }

        /// <summary>
        /// Adds an element at this position 
        /// </summary>
        /// <param name="element">element</param>
        /// <param name="verticalIndex">vertical index of the element</param>
        /// <param name="horizontalIndex">horizontal index of the element</param>
        public void AddElement(T element, int verticalIndex,int horizontalIndex)
        {
            if(verticalIndex < this.height && horizontalIndex < this.width)
            {
                matrixValues[verticalIndex][horizontalIndex] = element;
            }
        }

        /// <summary>
        /// Attempts to add an element at this position
        /// </summary>
        /// <param name="element">element</param>
        /// <param name="verticalIndex">vertical index of the element</param>
        /// <param name="horizontalIndex">horizontal index of the element</param>
        /// <returns>returns true if addition successfull</returns>
        public bool TryAddElement(T element, int verticalIndex, int horizontalIndex)
        {
            if (verticalIndex < this.height && horizontalIndex < this.width)
            {
                matrixValues[verticalIndex][horizontalIndex] = element;
                return true;
            }

            else
            {
                return false;
            }
        }

    }
}
