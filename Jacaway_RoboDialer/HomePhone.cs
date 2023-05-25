using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jacaway_RoboDialer
{
    internal class HomePhone : Phone
    {
        public HomePhone(string company, string number, string phonetype) : base(company, number, phonetype)
        {

        }
        public override string Dial()
        {
            return Company + " is being dialed using " + Number + "...";
        }
    }
}
