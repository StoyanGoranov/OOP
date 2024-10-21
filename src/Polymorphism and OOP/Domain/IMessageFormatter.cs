using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toni.Messages.Domain
{
    public interface IMessageFormatter
    {
        void FormatMessage(string[] args);
        string GetMessage();
    }
}
