using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileAnalyzer
{
    public struct AnalysisResult
    {
        public int WordCount { get; set; }
        public int CharacterCount { get; set; }
        public int LineCount { get; set; }
        public int FieldCount { get; set; }
    }
}
