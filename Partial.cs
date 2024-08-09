using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    public partial class PartialDemo
    {
        private int companyid;
        private string item;
        public PartialDemo(string a, int id)
        {
            this.item = a;
            this.companyid = id;
        }
    }
}