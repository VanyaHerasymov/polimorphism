using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace polimorphism
{
    public abstract class Matrix
    {


        public abstract int Row { get; set; }
            public abstract int Column { get; set; }
    
            public abstract int[,] Data { get; set; }
        
        public Matrix(int rows,int columns)
        {
            Row = rows;
            Column = columns;
            Data = new int[rows, columns];
        }
        public abstract Matrix Add(Matrix other);
        public abstract Matrix Subtract(Matrix other);  
        public abstract Matrix Multiply(Matrix other);  
        public abstract Matrix Divide(Matrix other);
        protected virtual void RandomMatrix(int min=0,int max=9)
        {
            for(int i = 0; i < Row; i++)
            {
                for (global::System.Int32 j = 0; j < Column; j++)
                {
                    Data[i, j] = new Random().Next(min, max);
                }

            }
        }
        public abstract void PrintMatrix();

    }
}

