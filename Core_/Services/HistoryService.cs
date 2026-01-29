using Core_.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_.Services
{
    public class HistoryService : IHistoryService
    {
        private List<string> _history;
        public HistoryService()
        {
            _history = new List<string>();
        }
        public void AddEntry(string entry)
        {
            _history.Add(entry);
            CheckAndRemoveFirst();
        }
        public IEnumerable<string> GetHistory()
        {
            return _history.AsReadOnly();
        }

        private void CheckAndRemoveFirst()
        { 
            if (_history.Count > 3)
            {
                _history.RemoveAt(0);
            }
        }
    }
}
