namespace PlaytikaCrawlerTest
{
    public static class SharedConstants
    {
        public static class InputAction
        {
            public const string All = "all";
            public const string Cs = "cs";
            public const string Reversed1 = "reversed1";
            public const string Reversed2 = "reversed2";
        }

        public static class ErrorMessage
        {
            public static string ParametresNotSupplied = "Not all required parametres specified. Please provide: Start directory and Action name";
            public static string StartDirectoryNotValid = "Path provided for Start directory parameter is not valid";
            public static string ResultPathDirectoryNotValid = "Path provided for Result file is not valid";
            public static string InvalidAction = "Action specified is not valid. Valid actions are: {0}, {1}, {2} and {3}";
            public static string BadFileExtension = "File has to be of {} format";
        }

        public static class SucessMessage
        {
            public static string ProgramCompleted = "Program completed sucessfully. File containing results can be found at this location: {0}";
        }

        public static class Result
        {
            public static string ResultFilename = "results.txt";
            public static string AcceptedFileFormat = ".txt";
        }

        public static class FileExtension
        {
            public static string CSFileExtension = ".cs";
        }

    }
}
