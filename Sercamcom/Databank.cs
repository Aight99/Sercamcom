using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sercamcom
{
    static class Databank
    {
        public static HashTableOA HashTable;
        public static ListOfSales SalesTable;
        static Databank()
        {
            HashTable = new HashTableOA();
            SalesTable = new ListOfSales(HashTable);
        }
    }
}
