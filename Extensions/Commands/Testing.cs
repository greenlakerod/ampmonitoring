using Avanade.Amp.Common;
using Microsoft.VisualStudio;
using Microsoft.VisualStudio.Shell.Interop;
using System;

namespace Avanade.Amp.Extensions.Commands
{
    static class Testing
    {
        public static string[] Accounts = { Resources.Apples, Resources.Blueberries, Resources.Pears, Resources.Strawberries };

        public static void ShowMessage(string title, string message)
        {
            IVsUIShell uiShell = (IVsUIShell)CommandsPackage.GetGlobalService(typeof(SVsUIShell));
            Guid clsid = Guid.Empty;
            int result = VSConstants.S_OK;
            int hr = uiShell.ShowMessageBox(0,
                                ref clsid,
                                title,
                                message,
                                null,
                                0,
                                OLEMSGBUTTON.OLEMSGBUTTON_OK,
                                OLEMSGDEFBUTTON.OLEMSGDEFBUTTON_FIRST,
                                OLEMSGICON.OLEMSGICON_INFO,
                                0,        // false = application modal; true would make it system modal
                                out result);
            ErrorHandler.ThrowOnFailure(hr);
        }
    }
}
