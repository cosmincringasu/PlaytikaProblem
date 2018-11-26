using PlaytikaCrawlerTest.CrawlerOperation;
using PlaytikaCrawlerTest.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaytikaCrawlerTest
{
    class Program
    {
        static void Main(string[] args)
        {

            if (!ValidationHelper.ValidateInput(args, out string startDirectory, out string actionName, out string resultFilePath))
                return;

            switch (actionName)
            {
                case SharedConstants.InputAction.All:
                    AllOperation allOp = new AllOperation(startDirectory, resultFilePath);
                    allOp.Process(startDirectory);
                    break;
                case SharedConstants.InputAction.Cs:
                    CsOperation csOp = new CsOperation(startDirectory, resultFilePath);
                    csOp.Process(startDirectory); ;
                    break;
                case SharedConstants.InputAction.Reversed1:
                    Reversed1Operation rev1Op = new Reversed1Operation(startDirectory, resultFilePath);
                    rev1Op.Process(startDirectory);
                    break; 
                case SharedConstants.InputAction.Reversed2:
                    Reversed2Operation rev2Op = new Reversed2Operation(startDirectory, resultFilePath);
                    rev2Op.Process(startDirectory);
                    break;
                default: Console.WriteLine(string.Format(SharedConstants.ErrorMessage.InvalidAction, 
                    SharedConstants.InputAction.All, SharedConstants.InputAction.Cs, 
                    SharedConstants.InputAction.Reversed1, SharedConstants.InputAction.Reversed2)); break;
            }

        }

    }
}
