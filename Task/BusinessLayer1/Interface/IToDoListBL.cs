using CommanLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Interface
{
    public interface IToDoListBL
    {
        public string AddItem(ToDoListModel add);
        public List<ToDoListModel> GetList();

    }
}
