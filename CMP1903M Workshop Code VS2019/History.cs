using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Workshop_Code_VS2019
{
    class History
    {
        private Stack<Page> history;

        //constructor
        public History()
        {
            history = new Stack<Page>();
        }
    }
}
