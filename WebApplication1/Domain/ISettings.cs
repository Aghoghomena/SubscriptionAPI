using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Entity;

namespace WebApplication1.Domain
{
    public interface ISettings
    {
        //get single employee
        Setting GetSingleSetting(string type);
    }
}
