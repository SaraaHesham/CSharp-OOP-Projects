using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileAnalyzer
{
    public class FileAnalyzer
    {
        private AnalysisResult _results;
        public AnalysisResult GetResults()
        {
            return _results;
        }   
        public void SetResults(AnalysisResult results)
        {
            _results = results;
        }
    }
}
