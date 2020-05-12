using DataModelLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System
{
    public static class DBCommon
    {
        private static AutomationNewEntities _context = new AutomationNewEntities();

        public static AutomationNewEntities Context
        {
            get { return DBCommon._context; }

        }

    }
}
