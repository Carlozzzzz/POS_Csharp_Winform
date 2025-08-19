using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_V1.Views
{
    public interface IMainView
    {
        event EventHandler ShowDashboardView;
        event EventHandler ShowProductView;
        event EventHandler ShowUserView;

    }
}
