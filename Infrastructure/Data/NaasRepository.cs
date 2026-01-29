using Core_.Entities;
using Core_.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class NaasRepository : INaasRepository
    {
        private string recentNaasData;
        private IGetNaasDataProvider _dataProvider;

        public NaasRepository(IGetNaasDataProvider dataProvider) 
        {
            _dataProvider = dataProvider;
            UpdateNaasData();
        }

        public string GetNaasData() { return recentNaasData; }
        public void UpdateNaasData()
        {
            recentNaasData = _dataProvider.GetNewNaasdata().Text;
        }
    }
}
