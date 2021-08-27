using MeDo.Shared;
using System;
using System.Collections.Generic;

namespace MeDo.Client.State
{
    public class StateContainer
    {
        // In reality, better to split these out to separate classes, as it seems to re-render if ANY of this class changes instead of just what you are using.
        private bool collapseNav = false;
        private List<TodoList> todoLists = null;
        private int? showListId = null;
        
        public bool CollapseNavMenuState
        {
            get => collapseNav;
            set
            {
                collapseNav = value;
                NotifyStateChanged();
            }
        }

        public List<TodoList> TodoListsState
        {
            get => todoLists;
            set
            {
                todoLists = value;
                NotifyStateChanged();
            }
        }

        public int? ShowListIdState
        {
            get => showListId;
            set
            {
                showListId = value;
                NotifyStateChanged();
            }
        }

        public event Action OnChange;

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
