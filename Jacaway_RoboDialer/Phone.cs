using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Jacaway_RoboDialer
{
    internal class Phone

    {
        private string _company;
        private string _number;
        public Phone(string company, string number, string phonetype)
        {
            _company = company;
            _number = number;
        }
        public string Company
        {
            get { return _company; }
        }
        public string Number
        {
            get { return _number; }
        }
        public virtual string Dial()
        {
            return Company + " is being dialed using " + Number + "...";
        }
    }
}
