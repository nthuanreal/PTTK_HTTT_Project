using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_winform.Utils
{
    public class NavigationControl
    {
        List <UserControl> controls = new List<UserControl>();
        Panel panel;

        public NavigationControl(List<UserControl> controls, Panel panel) {
            this.panel = panel;
            this.controls = controls;
            AddUserControls();
        }

        private void AddUserControls()
        {
            for (int i = 0; i < controls.Count; i++)
            {
                controls[i].Dock = DockStyle.Fill;
                panel.Controls.Add(controls[i]);
            }
        }

        public void Display(int index)
        {
            if (index < controls.Count())
            {
                controls[index].BringToFront();
            }
        }
    }
}
