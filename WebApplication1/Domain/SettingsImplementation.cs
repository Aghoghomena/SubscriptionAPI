using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Entity;

namespace WebApplication1.Domain
{
    public class SettingsImplementation : ISettings
    {

        private SubContext _subContext;
        public SettingsImplementation(SubContext subContext)
        {

            _subContext = subContext;
        }
        public Setting GetSingleSetting(string type)
        {
            var existing = _subContext.Settings.Where(c => c.type == type).FirstOrDefault();
            return existing;
        }
    }
}
