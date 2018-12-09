using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Moq;
using ToDoApp.Data;
using ToDoApp.Models;
using Xunit;

namespace ToDoApp.Test
{

    public class ToDoControllerTests
    {
        private void SetupMockDbSet(Mock<DbSet<ToDo>> mock, List<ToDo> toDos)
        {
            var data = toDos.AsQueryable();
            mock.As<IQueryable<ToDo>>().Setup(m => m.Provider).Returns(data.Provider);
            mock.As<IQueryable<ToDo>>().Setup(m => m.Expression).Returns(data.Expression);
            mock.As<IQueryable<ToDo>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mock.As<IQueryable<ToDo>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());
        }

        [Fact]
        public void TestMethod()
        {
            //var data = new List<ToDo>();

            //var todos = new Mock<DbSet<ToDo>>();
            //SetupMockDbSet(todos, data);

            

            //todos.Setup(c => c.Add(somthing));
            //var dbContext = new Mock<ToDoContext>(new DbContextOptionsBuilder().Options);
            //dbContext.Setup(c => c.ToDos).Returns(todos.Object);

            //dbContext.Object.ToDos.First(x => x.Id == 1);
        }
    }
}
