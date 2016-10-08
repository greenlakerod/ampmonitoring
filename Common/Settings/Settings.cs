using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avanade.Amp.Common.Settings
{
    public static class Settings
    {
        private static IEnumerable<ISettingsEntity> _accounts;
        private static IEnumerable<ISettingsEntity> _sites;
        private static IEnumerable<Api.Target.Target> _targets;
        private static ISettingsEntity _account;
        private static ISettingsEntity _site;
        private static Api.Target.Target _target;

        public static ISettingsEntity Account
        {
            get
            {
                ReadSettingsFile();
                return _account;
            }
        }

        public static ISettingsEntity Site
        {
            get
            {
                ReadSettingsFile();
                return _site;
            }
        }

        public static Api.Target.Target Target
        {
            get
            {
                ReadSettingsFile();
                return _target;
            }
        }

        public static void SetAccount()
        {
        }

        public static void SetSite()
        {
        }

        public static void SetTarget()
        {
        }

        private static void ReadSettingsFile()
        {

        }
    }
}
