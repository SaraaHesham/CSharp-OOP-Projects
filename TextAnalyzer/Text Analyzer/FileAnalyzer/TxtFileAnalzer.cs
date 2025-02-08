using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileAnalyzer
{
    internal class TxtFileAnalzer : FileAnalyzer , IFileAnalysis  
    {
        public void AnalyzeFile(FileInfo fileInfo)
        {
            string fileString = File.ReadAllText(fileInfo.FullName);

            AnalysisResult result = new AnalysisResult();

            var words = fileString.Split(new char[] {' ','\n','\r' });
            result.WordCount = words.Length;
            result.CharacterCount = fileString.Length;
            result.LineCount = fileString.Split('\n').Length;

            SetResults(result);
        }
    }
}
