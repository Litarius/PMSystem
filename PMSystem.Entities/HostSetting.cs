using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMSystem.Entities
{
    public class HostSetting
    {
        public HostSetting(string settingName, string settingValue)
        {
            SettingName = settingName;
            SettingValue = settingValue;
        }

        public HostSetting()
        {
            SettingName = string.Empty;
            SettingValue = string.Empty;
        }

        public string SettingName { get; set; }

        public string SettingValue { get; set; }
    }
}
