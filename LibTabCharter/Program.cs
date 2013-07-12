using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibTabCharter
{
    class Program
    {
        static void Main(string[] args)
        {
            /*TabCharter ltc = new TabCharter("C:\\Users\\el\\Desktop\\dashes.txt");
            List<String> header = new List<string>();
            header.Add("汉字");
            header.Add("憨子");
            header.Add("汉子");
            header.Add("汗渍");
            ltc.Create(header);
            ltc.Append(header);*/

            TabFetcher tf = new TabFetcher("C:\\Users\\el\\Desktop\\projects\\HRV\\HRV.txt", "\\s");
            tf.Open();
            List<String> line;
            while((line = tf.GetLineBy()).Count != 0)
            {
                for(int i = 0 ; i < line.Count; i++)
                {
                    Console.WriteLine(line[i]);
                }

                Console.ReadLine();
            }

            tf.Close();
        }
    }
}
