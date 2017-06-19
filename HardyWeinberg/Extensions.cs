using System.Windows.Forms;

namespace HardyWeinberg {

    static class Extensions {

        public static void InvokeIfRequired(this Control control, MethodInvoker action) {
            // While the form (and thus the control) aren't visible yet, InvokeRequired returns false
            // So wait until the Contol is visible first before getting that property
            while (!control.Visible)
                System.Threading.Thread.Sleep(50);

            // Then do the Invoke, if required
            if (control.InvokeRequired)
                control.Invoke(action);
            else
                action();
        }

    }

}
