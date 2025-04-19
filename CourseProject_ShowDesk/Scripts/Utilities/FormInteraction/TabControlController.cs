using System.Windows.Forms;

namespace CourseProject_ShowDesk.Scripts.Utilities.FormInteraction
{
    public class TabControlController
    {
        private TabControl tabControlNav;

        public TabControlController(TabControl tabControlNav)
        {
            this.tabControlNav = tabControlNav;
        }

        public void TabControlNavigation(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                MoveToNextPage();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Left)
            {
                MoveToPrevPage();
                e.Handled = true;
            }
        }

        public void MoveToNextPage()
        {
            int nextIndex = (tabControlNav.SelectedIndex + 1) % tabControlNav.TabCount;
            tabControlNav.SelectedIndex = nextIndex;
        }

        public void MoveToPrevPage()
        {
            int prevIndex = (tabControlNav.SelectedIndex - 1 + tabControlNav.TabCount) % tabControlNav.TabCount;
            tabControlNav.SelectedIndex = prevIndex;
        }

    }
}
