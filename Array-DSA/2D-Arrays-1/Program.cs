using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_Arrays_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of rows of 1st matrix: ");
            int mRow1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number of columnss of 1st matrix: ");
            int mCol1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number of rows of 2nd matrix: ");
            int mRow2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number of columns of 2nd matrix: ");
            int mCol2 = Convert.ToInt32(Console.ReadLine());

            int[,] matrix1 = new int[mRow1, mCol1];
            int[,] matrix2 = new int[mRow2, mCol2];
            int[,] addedMatrix = new int[mRow1, mCol1];

            char exit;

            //VALUES OF MATRIX 1
            for(int i = 0;  i < mRow1; i++)
            {
                for(int j = 0; j < mCol1; j++)
                {
                    Console.Write("Enter the value at row {0} and column {1} of matrix 1 :", i + 1, j + 1);
                    matrix1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("\n");

            //VALUES OF MATRIX 2
            for (int i = 0; i < mRow2; i++)
            {
                for (int j = 0; j < mCol2; j++)
                {
                    Console.Write("Enter the value at row {0} and column {1} of matrix 2 :", i + 1, j + 1);
                    matrix2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            do
            {
                Console.WriteLine("\n");
                Console.Write("Action list: \n 1. Display Matrix \n 2. Addition of matrix \n 3. Subtraction of Matrix \n 4. Matrix multiplication \n 5. Determinant \n 6. Inverse \n Select action: ");
                int action = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\n");
                switch (action)
                {
                    case 1:
                        //DISPLAY OF MATRIX
                        Console.Write("Select the matrix you want to display (1/2): ");
                        int select = Convert.ToInt32(Console.ReadLine());
                        if (select == 1)
                        {
                            Console.WriteLine("Matrix 1 :");
                            for (int i = 0; i < mRow1; i++)
                            {
                                for (int j = 0; j < mCol1; j++)
                                {
                                    Console.Write(matrix1[i, j] + "\t");
                                }
                                Console.WriteLine();
                            }
                        }
                        else if (select == 2)
                        {
                            Console.WriteLine("Matrix 2 :");
                            for (int i = 0; i < mRow2; i++)
                            {
                                for (int j = 0; j < mCol2; j++)
                                {
                                    Console.Write(matrix2[i, j] + "\t");
                                }
                                Console.WriteLine();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Matrix does not exist");
                        }
                        break;

                    case 2:
                        //ADDITION OF MATRIX
                        if (mRow1 == mRow2 && mCol1 == mCol2)
                        {
                            for (int i = 0; i < mRow1; i++)
                            {
                                for (int j = 0; j < mCol1; j++)
                                {
                                    addedMatrix[i, j] = matrix1[i, j] + matrix2[i, j];
                                    Console.Write(addedMatrix[i, j] + "\t");
                                }
                                Console.WriteLine();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Only the matrix with same number of rows and colcumns can be added");
                        }
                        break;

                    case 3:
                        //SUBTRACTION OF MATRIX
                        if (mRow1 == mRow2 && mCol1 == mCol2)
                        {
                            for (int i = 0; i < mRow1; i++)
                            {
                                for (int j = 0; j < mCol1; j++)
                                {
                                    addedMatrix[i, j] = matrix1[i, j] - matrix2[i, j];
                                    Console.Write(addedMatrix[i, j] + "\t");
                                }
                                Console.WriteLine();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Only the matrix with same number of rows and colcumns can be added");
                        }
                        break;

                    case 4:
                        //MULTIPLICATION OF MATRIX
                        if (mCol1 == mRow2)
                        {
                            int[,] multiply = new int[mRow1, mCol2];
                            for (int i = 0; i < mRow1; i++)
                            {
                                for (int j = 0; j < mCol2; j++)
                                {
                                    multiply[i, j] = 0;
                                    for (int k = 0; k < mCol1; k++)
                                    {
                                        multiply[i, j] += matrix1[i, k] * matrix2[k, j];
                                    }
                                    Console.Write(multiply[i, j] + "\t");
                                }
                                Console.WriteLine();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Matrix multiplication not possible");
                        }
                        break;

                    case 5:
                        //DETERMINANT OF MATRIX
                        Console.Write("Select the matrix you want to take determinant of (1/2): ");
                        select = Convert.ToInt32(Console.ReadLine());
                        int det;
                        if (select == 1)
                        {
                            det = (matrix1[0, 0] * matrix1[1, 1]) - (matrix1[0, 1] * matrix1[1, 0]);
                            Console.WriteLine("The determinant is {0}", det);
                        }
                        else if (select == 2)
                        {
                            det = (matrix2[0, 0] * matrix2[1, 1]) - (matrix2[0, 1] * matrix2[1, 0]);
                            Console.WriteLine("The determinant is {0}", det);
                        }
                        else
                        {
                            Console.WriteLine("Matrix does not exist");
                        }
                        break;

                    case 6:
                        //INVERSE OF MATRIX
                        Console.Write("Select the matrix you want to take inverse of (1/2): ");
                        select = Convert.ToInt32(Console.ReadLine());
                        if (select == 1 && mRow1 == 2 && mCol1 == 2)
                        {
                            det = (matrix1[0, 0] * matrix1[1, 1]) - (matrix1[0, 1] * matrix1[1, 0]);
                            if (det == 0)
                            {
                                Console.WriteLine("Inverse not possible as determinant is 0");
                            }
                            else
                            {
                                double[,] inverse = new double[2, 2];
                                inverse[0, 0] = matrix1[1, 1] / (double)det;
                                inverse[0, 1] = -matrix1[0, 1] / (double)det;
                                inverse[1, 0] = -matrix1[1, 0] / (double)det;
                                inverse[1, 1] = matrix1[0, 0] / (double)det;

                                Console.WriteLine("Inverse of matrix 1: ");
                                for (int i = 0; i < 2; i++)
                                {
                                    for (int j = 0; j < 2; j++)
                                    {
                                        Console.Write(inverse[i, j] + "\t");
                                    }
                                    Console.WriteLine();
                                }
                            }
                        }
                        else if (select == 2 && mRow2 == 2 && mCol2 == 2)
                        {
                            det = (matrix2[0, 0] * matrix2[1, 1]) - (matrix2[0, 1] * matrix2[1, 0]);
                            if (det == 0)
                            {
                                Console.WriteLine("Inverse not possible (determinant is 0).");
                            }
                            else
                            {
                                double[,] inverse = new double[2, 2];
                                inverse[0, 0] = matrix2[1, 1] / (double)det;
                                inverse[0, 1] = -matrix2[0, 1] / (double)det;
                                inverse[1, 0] = -matrix2[1, 0] / (double)det;
                                inverse[1, 1] = matrix2[0, 0] / (double)det;

                                Console.WriteLine("Inverse of matrix 2:");
                                for (int i = 0; i < 2; i++)
                                {
                                    for (int j = 0; j < 2; j++)
                                    {
                                        Console.Write(inverse[i, j] + "\t");
                                    }
                                    Console.WriteLine();
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Matrix does not exist.");
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid action");
                        break;
                }

                Console.Write("do you want to perform any other action? (y/n): ");
                exit = Convert.ToChar(Console.ReadLine());
            }
            while(exit == 'n' || exit == 'N');
        }
    }
}
