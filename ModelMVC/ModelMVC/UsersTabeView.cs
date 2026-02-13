using ModelViewLib.ModelViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ModelViewLib.Views;

namespace ModelMVC
{
    class UsersTabeView : DataGridView, IusersView
    {
        public void ShowUsers(List<User> users)
        {
            DataSource = users;
        }
    }
}
