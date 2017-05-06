using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySQL
{
    class Model
    {
        private string valueToSearch;

        public void setValueToSearch(string value)
        {
            valueToSearch = value;
        }
        public string getValueToSearch()
        {
            return valueToSearch;

        }
    }
}
