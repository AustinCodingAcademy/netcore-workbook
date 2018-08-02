using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BaseProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace BaseProject.Controllers
{
    public class CardViewComponent : ViewComponent
    {

        public IViewComponentResult Invoke(CardModel cardModel)
        {
            return View<CardModel>(cardModel);
        }


    }

//    public abstract class BaseViewComponent : ViewComponent
//    {
//        public abstract IViewComponentResult Invoke();

//    }
}
