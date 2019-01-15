using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoApp.Models;
using System.Linq;
using Microsoft.AspNetCore.Http;

namespace ToDoApp.Services
{
    public class Repository
    {

        public static Dictionary<int, Status> status = new Dictionary<int, Status>
        {
            { 1, new Status { Id = 1, Value = "Not Started" } },
            { 2, new Status { Id = 2, Value = "In Progress" } },
            { 3, new Status { Id = 3, Value = "Done" } }
        };

        public static List<ToDo> list = new List<ToDo>
        {
            new ToDo { Id = 1, Title = "My First ToDo", Description = "Get the app working", Status = status[2] }
        };

        public static ToDo GetTodoById(int id)
        {
            var todo = list.SingleOrDefault( t => t.Id == id);
            return todo;
        }

        public static ToDo SaveToDo(int id, IFormCollection collection)
        {
            var todo = GetTodoById(id);
            todo.Id = Convert.ToInt32(collection["Id"]);
            todo.Title = collection["Title"];
            todo.Description = collection["Description"];

            return todo;
            
            // get the current todo based on id
            //overwrite each property with vales from collection
            //return saved todo
        }

        public static void CreateToDo(IFormCollection collection)
        {
            var todo = new ToDo { Id = Convert.ToInt32(collection["Id"]), Title = collection["Title"], Description = collection["Description"], Status = status[2] };
            list.Add(todo);
           
            // no need to get anything from list
            //create a new object of type todo and append values from collection
            //add new todo to list 
        }

        public static void DeleteToDo(int id)
        {
            // find todo 
            var todo = GetTodoById(id);
            // delete from  list
            list.Remove(todo);

        }
    }
}
