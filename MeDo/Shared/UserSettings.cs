using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeDo.Shared
{
    public class UserSettings
    {
        public int Id { get; set; }

        public TodoLists UserLists { get; set; }
    }
}
