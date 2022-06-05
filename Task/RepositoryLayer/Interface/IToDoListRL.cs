using CommanLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryLayer.Interface
{
    public interface IToDoListRL
    {
        public string AddItem(ToDoListModel add);
        public List<ToDoListModel> GetList();

    }
}
