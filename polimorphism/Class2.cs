using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace polimorphism
{
    public class SquareMatrix : Matrix
    {
        public SquareMatrix(int rows, int columns) : base(rows, columns)
        {

            RandomMatrix(5, 7);

        }

        public override int Row { get; set ; }
        public override int Column { get ; set ; }
        public override int[,] Data { get; set; }

        public override Matrix Add(Matrix other)
        {

            Matrix res=new SquareMatrix(Row, Column);
            if (other.Row == this.Row && other.Column == this.Column)
            {
                for(int i=0;i<Row;i++)
                {
                    for (int j = 0; j < Column; j++)
                    {
                        res.Data[i, j] = Data[i, j] + other.Data[i, j];


                    }

                }

            }
            else
            {
                return null;
            }

            return res;    
                


        }

        public override Matrix Divide(Matrix other)
        {
            throw new NotImplementedException();
        }

        public override Matrix Multiply(Matrix other)
        {
            throw new NotImplementedException();
        }

        public override void PrintMatrix()
        {
            for(int i = 0; i < Row; i++)
            {
                for(int j = 0; j < Column; j++)
                {
                    Console.Write(Data[i, j]);
                    Console.Write(' ');
                }
                Console.WriteLine();

            }

        }

        public override Matrix Subtract(Matrix other)
        {
            throw new NotImplementedException();
        }
    }
}
