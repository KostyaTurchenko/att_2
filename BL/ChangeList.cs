﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class ChangeList
    {

        private int l;
        public int L { get; set; }

        public List<int> CreateNewList(IList<int> list1, IList<int> list2)
        {
            var outputlist = new List<int>();
            foreach (int value in list1)
            {
                if (Сheckforparity(value) && !list2.Contains(value))
                    outputlist.Add(value);
            }

            foreach (int value in list2)
            {
                if (!Сheckforparity(value) && !list1.Contains(value))
                    outputlist.Add(value);
            }
            outputlist.Sort();
            return outputlist;
        }
        
        public List<int> List1generation(int L)
        {
            var outlist = new List<int>();
            Random rand = new Random();
            for (int i = 0; i < L; i++)
            {
                outlist.Add(rand.Next(0, 100));
            }
            return outlist;
        }
        public List<int> List2generation(int L)
        {
            var outlist = new List<int>();
            Random rand = new Random();
            for (int i = 0; i < L; i++)
            {
                outlist.Add(rand.Next(0, 50));
            }
            return outlist;
        }


        private bool Сheckforparity (int count)
        {
            bool z = count % 2 == 0;
            return z;
                     
        }
        public ChangeList (int count)
        {
            count = L;
        }

        


        
            


        


    }
}
