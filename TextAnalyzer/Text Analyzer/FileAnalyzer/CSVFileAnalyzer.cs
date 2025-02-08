using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileAnalyzer
{
    internal class CSVFileAnalyzer : FileAnalyzer, IFileAnalysis
    {
        public void AnalyzeFile(FileInfo fileInfo)
        {
            string[] filestring = File.ReadAllLines(fileInfo.FullName);

            var rowElements = filestring[0].Split(',');

            AnalysisResult result = new AnalysisResult();

            result.FieldCount = rowElements.Length; 

            SetResults(result);
        }
    }
}
