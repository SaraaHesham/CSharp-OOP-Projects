using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileAnalyzer
{
    public static class FileInfoExtenstions
    {
        public static bool IsTxtFile(this FileInfo fileInfo)
        {
            if (fileInfo.Extension == ".txt")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool IsCsvFile(this FileInfo fileInfo)
        {
            if (fileInfo.Extension == ".csv")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
