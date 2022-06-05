using BusinessLayer.Interface;
using CommanLayer.Model;
using RepositoryLayer.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Service
{
    public class ToDoListBL : IToDoListBL
    {

        private readonly IToDoListRL toDoListRL;
        public ToDoListBL(IToDoListRL toDoListRL)
        {
            this.toDoListRL = toDoListRL;
        }
        public string AddItem(ToDoListModel add)
        {
            try
            {
                return this.toDoListRL.AddItem(add);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public List<ToDoListModel> GetList()
        {
            try
            {
                return this.toDoListRL.GetList();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
