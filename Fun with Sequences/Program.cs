using System;
using System.Collections.Generic;
namespace Fun_with_Sequences
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstarray = Convert.ToInt32(Console.ReadLine());
            string firstarraynumbers = Console.ReadLine();
            int secondarray = Convert.ToInt32(Console.ReadLine());
            string secondarraynumbers = Console.ReadLine();
            string[] splittedfirst = firstarraynumbers.Split(' ');
            string[] splittedsecond = secondarraynumbers.Split(' ');
            int[] firstnumbers = new int[firstarray];
            int[] secondnumbers = new int[secondarray];
            int result=0;
            List<Int32> resultofnumbers = new List<Int32>();
            string of = null;
            for (int i=0;i<firstarray;++i)
            {
                firstnumbers[i] = Convert.ToInt32(splittedfirst[i]);
            }
            for (int i = 0; i < secondarray; ++i)
            {
                secondnumbers[i] = Convert.ToInt32(splittedsecond[i]);
            }
            for(int i=0; i<firstarray;++i)
            {
                for(int j=0; j<secondarray;++j)
                {
                    if (firstnumbers[i]!=secondnumbers[j])
                    {
                        result++;
                    }
                }
                if (result==secondarray)
                {
                    resultofnumbers.Add(firstnumbers[i]);
                }
                result = 0;
            }
            resultofnumbers.Sort();  
            foreach (int a in resultofnumbers)
            {
                of = of + ' ' + Convert.ToString(a);
            }
            Console.WriteLine(of);
        }
    }
}