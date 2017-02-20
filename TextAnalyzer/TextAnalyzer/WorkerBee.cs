using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextAnalyzer
{
    public static class WorkerBee
    {
        public static Dictionary<char, int> AnalyzeText(string text)
        {
            Dictionary<char, int> result = getAlphaDict();
            var chararray = text.ToLower().ToCharArray();
            if (chararray.Length > 0)
            {                
                var g = chararray.GroupBy(i => i);
                foreach (var grp in g)
                    result[grp.Key] = grp.Count();
            }
            return result
                .Where(x => Char.IsLetter(x.Key))
                .OrderBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value); ;
        }

        public static Dictionary<char, int> getAlphaDict()
        {
            Dictionary<char, int> alpha = new Dictionary<char, int>();
            for (char c = 'a'; c <= 'z'; c++)
                alpha.Add(c,0);
            return alpha;
        }
    }
}
