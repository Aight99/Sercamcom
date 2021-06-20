using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Sercamcom
{
    class HashTableOA
    {
        private int size_h; // Размер таблицы
        private int number_of_nodes = 0;
        private ProductNode[] h_table;

        public HashTableOA()
        {
            size_h = 15;
            h_table = new ProductNode[size_h];
            InputFromFile();
        }

        public HashTableOA(int size)
        {
            size_h = size;
            h_table = new ProductNode[size_h];
            InputFromFile();
        }

        private int GetHashFromInt(int a) => ((int)(a * a % Math.Pow(10, Convert.ToString(a * a).Length - 1) / 10) % size_h); // Середина квадрата

        private int GetHashCode(ProductNode node)
        {
            int hash_code = 0;
            for (int i = 0; i < node.login.Length; i++)
            {
                hash_code += (int)node.login[i];
            }
            for (int i = 0; i < node.product.Length; i++)
            {
                hash_code += (int)node.product[i];
            }
            return GetHashFromInt(hash_code);
        }

        private int GetHashCode(string login, string product)
        {
            int hash_code = 0;
            for (int i = 0; i < login.Length; i++)
            {
                hash_code += (int)login[i];
            }
            for (int i = 0; i < product.Length; i++)
            {
                hash_code += (int)product[i];
            }
            return GetHashFromInt(hash_code);
        }

        private bool InputFromFile()
        {
            string path = @"InputProducts.txt";
            using (StreamReader reader = new StreamReader(path))
            {
                while (!reader.EndOfStream)
                {
                    string line;
                    if ((line = reader.ReadLine()) == null)
                    {
                        //MessageBox.Show("No data in file");
                        Console.WriteLine("No data in file");
                        return false;
                    }
                    string[] fields = line.Split(new[] { '|' });
                    if (!CheckingLogin(fields[0]))
                    {
                        //MessageBox.Show("Incorrect data from file");
                        Console.WriteLine("Incorrect data from file");

                        return false;
                    }
                    string login = fields[0];
                    if (!CheckingNameOfProduct(fields[1]))
                    {
                        //MessageBox.Show("Incorrect name of product from file");
                        Console.WriteLine("Incorrect name of product from file");
                        return false;
                    }
                    ProductNode saleNode = new ProductNode();
                    saleNode.login = login;
                    saleNode.product = fields[1];
                    AddWithoutSave(saleNode);
                }
                return true;
            }
        }
        private async void UpdateFile()
        {
            string path = @"InputProducts.txt";
            using (StreamWriter writer = new StreamWriter(path))
            {
                foreach (var a in h_table)
                {
                    if (a != null)
                    {
                        string temp = "";
                        temp += a.login + "|" + a.product + "\r\n"; ;
                        await writer.WriteAsync(temp);
                    }
                }
            }
        }

        public void AddWithoutSave(ProductNode node)
        {
            if (Search(node.login, node.product) == null)
            {
                if (CheckingLogin(node.login) && CheckingNameOfProduct(node.product))
                {
                    if (number_of_nodes > (size_h * 0.75))
                    {
                        Resize();
                    }
                    number_of_nodes++;

                    int j = GetHashCode(node);

                    while (h_table[j] != null)
                    {
                        j = (j + 1) % size_h;
                    }
                    h_table[j] = node;
                }
                else
                {
                    //MessageBox.Show("Incorrect data");
                    Console.WriteLine("Incorrect data to input in table");
                }
            }
            else
            {
                //MessageBox.Show($"{node.login} is already in table");
                Console.WriteLine($"{node.login} is already in table");
            }
        }

        public void Add(ProductNode node)
        {
            if (Search(node.login, node.product) == null)
            {
                if (CheckingLogin(node.login) && CheckingNameOfProduct(node.product))
                {
                    if (number_of_nodes > (size_h * 0.75))
                    {
                        Resize();
                    }
                    number_of_nodes++;

                    int j = GetHashCode(node);

                    while (h_table[j] != null)
                    {
                        j = (j + 1) % size_h;
                    }
                    h_table[j] = node;
                    UpdateFile();
                }
                else
                {
                    //MessageBox.Show("Incorrect data");
                    Console.WriteLine("Incorrect data to input in table");
                }
            }
            else
            {
                //MessageBox.Show($"{node.login} is already in table");
                Console.WriteLine($"{node.login} is already in table");
            }
        }

        public void Delete(ProductNode node)
        {
            int i = GetHashCode(node);
            bool need_to_delete = false;
            bool is_found = false;

            while (h_table[i] != null)
            {
                if (h_table[i].Equals(node))
                {
                    is_found = true;
                    Console.WriteLine("Deleted!");
                    need_to_delete = FixDeleted(i);

                    break;
                }
                i = (i + 1) % size_h;
            }
            if (is_found && need_to_delete)
            {
                h_table[i] = null;
            }
            UpdateFile();
        }

        private bool FixDeleted(int deleted)
        {
            int i = deleted + 1;
            bool is_fixed = false;

            while (h_table[i] != null)
            {
                if (GetHashCode(h_table[i]) <= deleted)
                {
                    h_table[deleted] = h_table[i];
                    h_table[i] = null;
                    is_fixed = true;
                    FixDeleted(i);
                }
                i = (i + 1) % size_h;
            }
            return !is_fixed;
        }

        private void Resize()
        {
            int new_size = (int)(size_h * 1.5);
            Console.WriteLine($"Resize from {size_h} to {new_size}");
            ProductNode[] new_table = new ProductNode[new_size];
            size_h = new_size;

            foreach (var node in h_table)
            {
                if (node != null)
                {
                    int j = GetHashCode(node);

                    while (new_table[j] != null)
                    {
                        j = (j + 1) % new_size;
                    }
                    new_table[j] = node;
                }
            }

            h_table = new_table;
        }

        public bool Search(ProductNode node)
        {
            int i = GetHashCode(node);

            while (h_table[i] != null)
            {
                if (h_table[i].Equals(node))
                {
                    Console.WriteLine($"Found! Hash-index: {i}; login: {h_table[i].login}; priduct: {h_table[i].product}");
                    return true;
                }
                i = (i + 1) % size_h;
            }
            Console.WriteLine($"Not found!");
            return false;
        }

        public ProductNode Search(string login, string product)
        {
            int i = GetHashCode(login, product);

            while (h_table[i] != null)
            {
                if (h_table[i].login == login && h_table[i].product == product)
                {
                    Console.WriteLine($"Found! Hash-index: {i}; login: {h_table[i].login}; priduct: {h_table[i].product}");
                    return h_table[i];
                }
                i = (i + 1) % size_h;
            }
            //Console.WriteLine($"Not found in table!");
            return null;
        }

        public void ClearTable()
        {
            for (int i = 0; i < size_h; i++) h_table[i] = null;
        }

        public void PrintTable()
        {
            Console.WriteLine(" ");
            for (int i = 0; i < size_h; i++)

            {
                if (h_table[i] != null)
                {
                    Console.WriteLine($"Hash-index: {i}; login: {h_table[i].login}; priduct: {h_table[i].product}; {GetHashCode(h_table[i])}");

                }
                else
                {
                    Console.WriteLine($"Hash-index: {i}; NULL");
                }
            }
            Console.WriteLine(" ");
        }

        static bool CheckingNameOfProduct(string s)
        {
            if (s.Length > 50) return false;
            if ((s[0] >= 'А' && s[0] <= 'Я') || (s[0] >= 'а' && s[0] <= 'я')) // » «
            {
                for (int i = 1; i < s.Length; i++)
                {
                    if (!((s[i] >= 'a' && s[i] <= 'z') || (s[i] >= 'A' && s[i] <= 'Z') || (s[i] >= 'А' && s[i] <= 'Я') || (s[i] >= 'а' && s[i] <= 'я') || s[i] == '.' || s[i] == ' ' || s[i] == '»' || s[i] == '«' || s[i] == '-' || (s[i] >= '0' && s[i] <= '9')))
                    {
                        return false;
                    }
                }
                return true;
            }
            else return false;
        }
        static bool CheckingLogin(string s)
        {
            if (s.Length > 30) return false;
            if (s == "" || s == null) return false;
            if ((s[0] >= 'A' && s[0] <= 'Z') || (s[0] >= 'a' && s[0] <= 'z'))
            {
                for (int i = 1; i < s.Length; i++)
                {
                    if (!((s[i] >= 'A' && s[i] <= 'Z') || (s[i] >= 'a' && s[i] <= 'z') || s[i] == '.' || s[i] == '_' || (s[i] >= '0' && s[i] <= '9')))
                    {
                        return false;
                    }
                }
                return true;
            }
            else return false;
        }
    }
}
