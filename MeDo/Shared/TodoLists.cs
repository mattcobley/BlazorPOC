using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeDo.Shared
{
    public class TodoLists
    {
        public TodoLists()
        {
        }

        public TodoLists(int id, List<TodoList> lists)
        {
            Id = id;
            Lists = lists;
        }

        public int Id { get; set; }

        public List<TodoList> Lists { get; set; }

    }
}
