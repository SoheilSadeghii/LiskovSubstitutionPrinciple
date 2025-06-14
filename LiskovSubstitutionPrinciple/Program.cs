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
            CollectionBase array = new Array();
            CollectionBase list =new List();

            array.Add(2); // Throw Exeption
            list.Add(3); // Work
        }
    }

    public class CollectionBase
    {
        public int Count { get; set; }
        public virtual void Add(object item)
        {

        }

    }

    public class Array : CollectionBase
    {
        public override void Add(object item) 
        {

        }
    }

    public class List : CollectionBase
    {
        public override void Add(object item) 
        {

        }
    }
}
