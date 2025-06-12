 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple
{
    public class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class CollectionBase
    {
        public int Count { get; set; }

    }

    public class Array : CollectionBase 
    {

    }
}
