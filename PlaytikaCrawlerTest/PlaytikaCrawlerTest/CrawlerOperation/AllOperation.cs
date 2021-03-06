﻿using PlaytikaCrawlerTest.Helpers;
using PlaytikaCrawlerTest.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PlaytikaCrawlerTest.CrawlerOperation
{
    public class AllOperation : IOperation
    {

        public AllOperation(string originalStartFolder, string resultFile)
        {
            OriginalStartFolder = originalStartFolder;
            ResultFile = resultFile;
        }

        public async Task Process(string path)
        {
            await ProcessFolder(path);
            if (Result.Count > 0)
            {
                WriteFile wf = new WriteFile(ResultFile);
                wf.WriteResult(Result);
            }
            Console.WriteLine(string.Format(SharedConstants.SucessMessage.ProgramCompleted, ResultFile));
        }

        public async Task ProcessFolder(string path)
        {
            string[] subdirectoryEntries = Directory.GetDirectories(path);
            foreach (string subdirectory in subdirectoryEntries)
            {
                ProcessFolder(subdirectory);
            }

            string[] fileEntries = Directory.GetFiles(path);
            foreach (string fileName in fileEntries)
                await ProcessFile(fileName);

        }

        public async Task ProcessFile(string path)
        {
            Uri file = new Uri(path);

            Uri folder = new Uri(OriginalStartFolder);
            string relativePath =
            Uri.UnescapeDataString(
                folder.MakeRelativeUri(file)
                    .ToString()
                    .Replace('/', Path.DirectorySeparatorChar)
                );
            Result.Add(relativePath);
            Console.WriteLine(path);
        }

        public string OriginalStartFolder { get; set; }
        public string ResultFile { get; set; }
        public List<string> Result = new List<string>();

    }
}
