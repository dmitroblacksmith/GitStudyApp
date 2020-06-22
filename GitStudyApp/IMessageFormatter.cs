using System;
using System.Collections.Generic;
using System.Text;

namespace GitStudyApp
{
    public interface IMessageFormatter
    {
        string FormatMessage(string message);
    }
}
