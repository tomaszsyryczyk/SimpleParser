using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SimpleParser
{
    class Program
    {
        private static ICollection<Category> _categories;
        private static List<Product> _products;

        static void Main(string[] args)
        {
            _categories = GetCategories();
            _products = GetProducts();

            Console.WriteLine("Hello World!");
        }

        private static List<Product> GetProducts()
        {
            var productsUrl = "./InputFiles/products.csv";
            var lines = File.ReadAllLines(productsUrl);
            var data = lines.Skip(1);
            return data.Select(ParseProduct).ToList();
        }

        private static Product ParseProduct(string row)
        {
            var values = row.Split(';', StringSplitOptions.None);
            return new Product(_categories, values[0], values[1], values[2], values[3], values[4], values[5], values[6], values[7], values[8], values[9], values[10], values[11], values[12],values[13],
                values[14], values[15], values[16], values[17], values[18], values[19], values[20], values[21], values[22], values[23], values[24], values[25], values[26], values[27],
                values[28], values[29], values[30], values[31], values[32], values[33], values[34], values[35], values[36], values[37], values[38], values[39], values[40], values[41],
                values[42], values[43], values[44], values[45], values[46], values[47], values[48], values[49], values[50], values[51], values[52], values[53], values[54], values[55]);
        }

        private static ICollection<Category> GetCategories()
        {
            var categoriesUrl = "./InputFiles/categories.csv";
            var lines = File.ReadAllLines(categoriesUrl);
            var data = lines.Skip(1);
            return data.Select(ParseCategory).ToList();
        }

        private static Category ParseCategory(string row)
        {
            var values = row.Split(';', StringSplitOptions.None);
            return new Category(values[0], values[1], values[2], values[3], values[4], values[5], values[6], values[7], values[8], values[9], values[10], values[11], values[12]);
        }
    }
}
