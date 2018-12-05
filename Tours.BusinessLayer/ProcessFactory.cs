using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tours.BusinessLayer
{
    public class ProcessFactory
    {
        public static IClientProcess GetClientProcess()
        {
            return new ClientProcess();
        }
    }
}
