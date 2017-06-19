using System.Windows.Forms;

namespace HardyWeinberg {

    public abstract class ControlPrefab : IControlPrefab {
        // INTERFACE FUNCTIONS
        public void AddToContainer(Control container) {
            container.SuspendLayout();

            addControlsToContainer(container);

            container.ResumeLayout(false);
            container.PerformLayout();
        }

        // HELPER FUNCTIONS
        protected abstract void addControlsToContainer(Control container);
    }

}
