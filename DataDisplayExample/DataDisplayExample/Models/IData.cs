using System;
using System.Collections.Generic;
using System.Text;

namespace DataDisplayExample.Models
{
    public interface IData
    {
        User GetUser(int userId);
    }
}
