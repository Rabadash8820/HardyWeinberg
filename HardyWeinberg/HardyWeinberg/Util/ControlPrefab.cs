using System.Windows.Forms;

namespace HardyWeinberg.Util {

    public abstract class ControlPrefab : IControlPrefab {
        // INTERFACE FUNCTIONS
        public void AddToContainer(Control container) {
            container.SuspendLayout();

            AddControlsToContainer(container);

            container.ResumeLayout(false);
            container.PerformLayout();
        }

        // HELPER FUNCTIONS
        protected abstract void AddControlsToContainer(Control container);
    }

}
