using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileAnalyzer
{
    public interface IFileAnalysis
    {
        void AnalyzeFile(FileInfo fileInfo);
    }
}
