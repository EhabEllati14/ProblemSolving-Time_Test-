//using System;
//using System.Collections.Generic;

//namespace ProblemSolving_Time_Test_
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {

//            int[][] originalMatrix = new int[][]
//            {
//                new int[] { 0, 0, 9 },
//                new int[] { 0, 0, 0 },
//                new int[] { 8, 0, 0 }
//            };

//            SparseMatrixCompress compressor = new SparseMatrixCompress();

//            int rows = originalMatrix.Length;
//            int cols = originalMatrix[0].Length;

//            var compressed = compressor.compress(originalMatrix);

//            Console.WriteLine("Compressed Dictionary:");
//            if (compressed != null)
//            {
//                foreach (var item in compressed)
//                {
//                    Console.WriteLine($"({item.Key.Item1}, {item.Key.Item2}) => {item.Value}");
//                }

//                int[][] decompressed = compressor.decompress2DArray(compressed, rows, cols);
//                Console.WriteLine("\n Decompressed Matrix:");
//                for (int i = 0; i < decompressed.Length; i++)
//                {
//                    for (int j = 0; j < decompressed[i].Length; j++)
//                    {
//                        Console.Write(decompressed[i][j] + " ");
//                    }
//                    Console.WriteLine();
//                }
//            }
//            else
//            {
//                Console.WriteLine("Compression failed due to invalid input.");
//            }

//            Console.WriteLine("\nProgram finished.");
//        }
//    }
//}

//Test2
//using System;

//namespace ProblemSolving_Time_Test_
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine(" Password Pattern Generator");
//            Console.Write("Enter pattern (e.g., A#x*): ");
//            string pattern = Console.ReadLine();

//            // Validate input
//            if (string.IsNullOrWhiteSpace(pattern))
//            {
//                Console.WriteLine(" Pattern cannot be empty.");
//                return;
//            }

//            // Create generator and run
//            PasswordGenerator generator = new PasswordGenerator();
//            generator.GeneratePasswords(pattern);

//            Console.WriteLine("\n✅ Done generating passwords (limited to 150).");
//        }
//    }
//}
//Test3

