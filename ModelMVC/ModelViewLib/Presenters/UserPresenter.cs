using ModelViewLib.Models;
using ModelViewLib.ModelViews;
using ModelViewLib.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ModelViewLib.Presenters
{
    public class UserPresenter
    {
        private IusersModel usersModel_;
        private IusersView usersView_;

        public UserPresenter(IusersModel usersModel, IusersView usersView)
        {
            usersModel_ = usersModel; ;
            usersView_ = usersView;
            
            List<User> model = usersModel_.LoadUsers();
            usersView_.ShowUsers(model);
        }
    }
}
