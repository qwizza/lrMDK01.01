using ModelViewLib.ModelViews;
using System.Collections.Generic;
namespace ModelViewLib.Models
{
    public interface IusersModel
    {
        List<User> LoadUsers();
        bool Register(User user);
    }
}
