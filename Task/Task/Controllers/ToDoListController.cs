using BusinessLayer.Interface;
using CommanLayer.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoListController : ControllerBase
    {
        private readonly IToDoListBL toDoListBL;
        public ToDoListController(IToDoListBL addressBL)
        {
            this.toDoListBL = addressBL;
        }
        [HttpPost("AddItem")]
        public IActionResult AddItem(ToDoListModel list)
        {
            try
            {
                var addData = this.toDoListBL.AddItem(list);
                if (addData.Equals("Task Added Successfully"))
                {
                    return this.Ok(new { Status = true, Response = addData });
                }
                else
                {
                    return this.BadRequest(new { Status = false, Response = addData });
                }
            }
            catch (Exception ex)
            {
                return this.BadRequest(new { status = false, Response = ex.Message });
            }
        }
        [HttpGet("GetList")]
        public IActionResult GetList()
        {
            try
            {
                var updatedBookDetail = this.toDoListBL.GetList();
                if (updatedBookDetail != null)
                {
                    return this.Ok(new { Success = true, message = "List Fetched Sucessfully", Response = updatedBookDetail });
                }
                else
                {
                    return this.BadRequest(new { Success = false, message = "Enter Valid Priority Id" });
                }
            }
            catch (Exception ex)
            {
                return this.BadRequest(new { Success = false, message = ex.Message });
            }
        }
    }
}
