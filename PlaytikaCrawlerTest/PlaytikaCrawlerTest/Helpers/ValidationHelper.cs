using System;
using System.IO;

namespace PlaytikaCrawlerTest.Helpers
{
    public class ValidationHelper
    {

        public static bool ValidateInput(string[] args, out string startDirectory, out string actionName, out string resultFilePath)
        {
            bool errorsFound = false;
            startDirectory = string.Empty;
            actionName = string.Empty;
            resultFilePath = string.Empty;

            if (args.Length < 2 || args.Length > 3)
            {
                Console.WriteLine(SharedConstants.ErrorMessage.ParametresNotSupplied);
                errorsFound = true;
            }

            if (!Directory.Exists(args[0]))
            {
                Console.WriteLine(SharedConstants.ErrorMessage.StartDirectoryNotValid);
                errorsFound = true;
            }
            else
                startDirectory = args[0];

            actionName = args[1].ToLower();

            if (args.Length == 3)
            {
                try
                {
                    string pathofDirectory = Path.GetDirectoryName(args[2]);
                    if (!Directory.Exists(pathofDirectory))
                    {
                        Console.WriteLine(SharedConstants.ErrorMessage.ResultPathDirectoryNotValid);
                        errorsFound = true;
                    }
                    else if(Path.GetExtension(args[2]) != SharedConstants.Result.AcceptedFileFormat)
                    {
                        Console.WriteLine(string.Format(SharedConstants.ErrorMessage.BadFileExtension, SharedConstants.Result.AcceptedFileFormat));
                        errorsFound = true;
                    }

                    resultFilePath = args[2];
                }
                catch(Exception e)
                {
                    Console.WriteLine(SharedConstants.ErrorMessage.ResultPathDirectoryNotValid);
                    errorsFound = true;
                }
            }
            else
                resultFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, SharedConstants.Result.ResultFilename);

            return !errorsFound;
        }

    }
}
