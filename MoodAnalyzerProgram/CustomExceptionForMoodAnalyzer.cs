using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerProgram
{
    public class CustomExceptionForMoodAnalyzer : Exception
    {
        public enum ExceptionType
        {
            EMPTY_MOOD,
            NULL_MOOD,
        }
        public ExceptionType exceptiontype;
        public CustomExceptionForMoodAnalyzer(ExceptionType exceptionType, string message) : base(message)
        {
            this.exceptiontype = exceptionType;
        }
    }
}
