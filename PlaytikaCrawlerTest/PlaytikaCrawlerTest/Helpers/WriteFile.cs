using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaytikaCrawlerTest.Helpers
{
    public class WriteFile
    {

        public WriteFile(string resultFile)
        {
            ResultFile = resultFile;
        }

        public void WriteResult(List<string> results)
        {
            using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(ResultFile))
            {
                foreach (string result in results)
                {
                    file.WriteLine(result);
                }
            }
        }

        public string ResultFile { get; set; }

    }
}
