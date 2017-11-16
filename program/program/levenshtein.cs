using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace WindowsFormsApp2
{
    class levenshtein
    {
        private List<string> data;
        private List<string> originaldata;
        private List<int> l;
        private string input;
        public bool run = true;


        public levenshtein(string[] arr)
        {
            
            data = new List<string>();
            originaldata = new List<string>(arr);
            l = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                int times = 30 - arr[i].Length;
                for (int j = 0; j < times; j++)
                {
                    arr[i] += "_";
                }
                data.Add(arr[i]);
                l.Add(int.MaxValue);
            }
        }
        public void add(string str)
        {
            data.Add(str);
        }
        public string compute(string str)
        {
            input = str;
            Parallel.ForEach(data, distance);
            int n = l.IndexOf(l.Min());
            
            return originaldata[n];
        }
        


        private void distance(string val)
        {
            string a = input;
            string b = val;

            Int32 cost;
            Int32[,] d = new int[a.Length + 1, b.Length + 1];
            Int32 min1;
            Int32 min2;
            Int32 min3;

            for (Int32 i = 0; i <= d.GetUpperBound(0); i += 1)
            {
                d[i, 0] = i;
            }

            for (Int32 i = 0; i <= d.GetUpperBound(1); i += 1)
            {
                d[0, i] = i;
            }

            for (Int32 i = 1; i <= d.GetUpperBound(0); i += 1)
            {
                for (Int32 j = 1; j <= d.GetUpperBound(1); j += 1)
                {
                    cost = Convert.ToInt32(!(a[i - 1] == b[j - 1]));

                    min1 = d[i - 1, j] + 1;
                    min2 = d[i, j - 1] + 1;
                    min3 = d[i - 1, j - 1] + cost;
                    d[i, j] = Math.Min(Math.Min(min1, min2), min3);
                }
            }
            int distance = d[d.GetUpperBound(0), d.GetUpperBound(1)]*100;
            try
            {
                if (val[0] == input[0])
                {
                    distance /= 8;
                }
            }
            catch (Exception)
            {
            }
            int n = data.IndexOf(val);
            l[n] = distance;
        }
    }
}
