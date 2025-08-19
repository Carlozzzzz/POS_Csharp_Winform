using POS_V1.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_V1.Presenters
{
    public class MainPresenter
    {
        private IMainView mainView;
        private readonly string connectionStringl;

        public MainPresenter(IMainView mainView, string connectionString)
        {
            this.mainView = mainView;
            this.connectionStringl = connectionString;

            // Subscribe to the event here
        }

        // Create the operations for your events here
    }
}
