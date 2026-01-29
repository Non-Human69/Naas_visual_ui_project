using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_.Interfaces
{
    public interface IHistoryService
    {
        void AddEntry(string entry);
        IEnumerable<string> GetHistory();
    }
}
