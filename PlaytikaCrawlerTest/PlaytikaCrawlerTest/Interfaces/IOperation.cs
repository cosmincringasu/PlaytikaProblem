using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaytikaCrawlerTest.Interfaces
{
    interface IOperation
    {
        Task Process(string path);
        Task ProcessFolder(string path);
        Task ProcessFile(string path);

    }
}
