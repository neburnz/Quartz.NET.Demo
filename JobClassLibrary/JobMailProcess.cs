using MailClassLibrary;
using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobClassLibrary
{
    public class JobMailProcess : IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            MailProcess process = new MailProcess();

            process.DoWork();
        }
    }
}
