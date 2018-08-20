using System;
using SPA.Controllers;

namespace SPA.Data
{
    public class DataProvider
    {
        public void Save()
        {
            var controller = new SpaController();
            controller.Create();
            
        }

    }
}
