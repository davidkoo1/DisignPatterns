﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reporter
{
    public class EmployeeReport
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public string Footer { get; set; }
        //!можно попробовать еще что-то добавить

        public override string ToString() => new StringBuilder().Append(Header).Append(Body).Append(Footer).ToString();
    }
}
