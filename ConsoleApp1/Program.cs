using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string output;
            do
            {
                Console.WriteLine("\t************* Main Menu *************\t\n");
                Console.WriteLine("\tPress [1] to Add product!\t");
                Console.WriteLine("\tPress 2 to Read Product!\t");
                Console.WriteLine("\tPress 3 to update product Items!\t");
                Console.WriteLine("\tPress 4 to Delete product!\t");
                Console.WriteLine("\tPress enter to Exist!\t");
                Console.WriteLine("\t***************////*********************\t\n");

                int UserInput = int.Parse(Console.ReadLine());

                var ProductDetails = new ProductDetails();

                switch (UserInput)
                {
                    case 1:
                        // Add product details

                        Console.Write("\nEnter Product name: ");
                        var productname = Console.ReadLine();

                        Console.Write("Enter Product Quantity: ");
                        int productquantity = int.Parse(Console.ReadLine());

                        Console.Write("Enter Product Brand: ");
                        var productbrand = Console.ReadLine();

                        string filepath = @"D:\Items.txt";
                        StreamWriter sw;

                        if (File.Exists(filepath))
                            sw = new StreamWriter(filepath, true);
                        else
                            sw = new StreamWriter(@"D:\Items.txt");
                        sw.Write(productname + ":");
                        sw.Write(productquantity + ":");
                        sw.Write(productbrand);
                        sw.Close();

                        //sw.Write(string.Format("{0}", name));
                        //sw.WriteLine(string.Format("{0}", number));

                        break;

                    case 2:
                        /// read details from text file

                        String filePath = (@"D:\Items.txt");
                        List<string> lines = File.ReadAllLines(filePath).ToList();

                        foreach (string linee in lines)
                        {
                            Console.WriteLine(linee);
                        }

                        break;

                    case 3:

                        //update details of product

                        string text = File.ReadAllText(@"D:\Items.txt");

                        Console.Write("Enter the last product name: ");
                        var oldName = Console.ReadLine();

                        Console.Write("Enter the old Brand: ");
                        var oldBrand = Console.ReadLine();


                        Console.Write("Enter product Name that you want to update: ");
                        var updatedProductName = Console.ReadLine();

                        Console.Write("Enter Product Brand that you want to update: ");
                        var updatedproductBrand = Console.ReadLine();

                        text = text.Replace(oldName, updatedProductName);
                        text = text.Replace(oldBrand, updatedproductBrand);
                        File.WriteAllText(@"D:\Items.txt", text);

                        break;

                    case 4:

                        //Delete details of product

                        var fileLocation = (@"D:\Items.txt");

                        Console.Write("Enter the ProductName that you want to delete: ");
                        var searchDigit = Console.ReadLine();

                        string strSearchText = searchDigit;
                        string strOldText;
                        string n = "";

                        StreamReader sr = File.OpenText(fileLocation);
                        while ((strOldText = sr.ReadLine()) != null)
                        {
                            if (!strOldText.Contains(strSearchText))
                            {
                                n += strOldText + Environment.NewLine;
                            }
                        }
                        sr.Close();
                        File.WriteAllText(fileLocation, n);

                        break;

                    //case E:
                    //    return;



                    default:
                        Console.WriteLine("Select valid operation");
                        break;
                }

                Console.Write("\nPress [ok] to continue further OR Press [E] to exit the program : ");
                output = Console.ReadLine();


            } while (output != "No");
        }
    }
}
