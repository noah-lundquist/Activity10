﻿//Corrected By Noah Lundquist
using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace CST117_IC08_console

{

    class Program

    {

        static void Main(string[] args)

        {

            //make some sets

            Set A = new Set();

            Set B = new Set();

            //put some stuff in the sets

            Random r = new Random();

            for (int i = 0; i < 10; i++)

            {

                A.addElement(r.Next(4));

                B.addElement(r.Next(12));

            }

            //display each set and the union

            Console.WriteLine("A: " + A);

            Console.WriteLine("B: " + B);

            Console.WriteLine("A union B: " + A.union(B));

            //display original sets (should be unchanged)

            Console.WriteLine("After union operation");

            Console.WriteLine("A: " + A);

            Console.WriteLine("B: " + B);



        }

    }

}
//duplicated at the top, not sure if it was an error,or my error however using which ever library needs to 
// be called only once at the top 
//using System;

//using System.Collections.Generic;

//using System.Linq;

//using System.Text;

//using System.Threading.Tasks;



//Lydia's code - find the errors!

namespace CST117_IC08_console
{
    class Set
    {
        private List<int> elements;

        public Set()
        {
            elements = new List<int>();
        }

        public bool addElement(int val)
        {
            if (containsElement(val)) return false;
            else
            {
                elements.Add(val);
                return true;
            }
        }

        private bool containsElement(int val)
        {
            /*
            removed else statement, if 1st number is not equal to given then 
            it will return false
            */
            
            for (int i = 0; i < elements.Count; i++)
            {
                if (val == elements[i]) return true;
                // else return false;
            }
            return false;
        }

        public override string ToString()
        {
            string str = "";
            foreach (int i in elements)
            {
                str += i + " ";
            }
            return str;
        }


        public void clearSet()
        {
            elements.Clear();
        }

        public Set union(Set rhs)
        {
            /*Originally adds all elements to first set, hwoever do not want to disrupt 
             * first set, added another set. 
             * 
             * 
             */ 
            
            Set C = new Set();
            for (int i = 0; i < rhs.elements.Count; i++)
            {
                C.addElement(rhs.elements[i]);
                // this.addElement (rhs.elements[i]);
            }
            for (int i = 0; i < this.elements.Count; i++)
            {
                C.addElement(this.elements[i]);
                // this.addElement (rhs.elements[i]);
            }
            return C;
        }


    }


}
