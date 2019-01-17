using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace LuckySpin.Controllers
{
    public class SpinnerController : Controller
    {
        Random random = new Random();

        public IActionResult Index(int Luck)
        {
            Models.Spin NewSpin = new Models.Spin();
            //Models.TextTransformService NewText = new Models.TextTransformService(Luck);
            NewSpin.a = random.Next(1, 10);
            NewSpin.b = random.Next(1, 10);
            NewSpin.c = random.Next(1, 10);

            if (NewSpin.a == Luck || NewSpin.b == Luck || NewSpin.c == Luck)
                NewSpin.Display = "block";
            else
                NewSpin.Display = "none";

            NewSpin.Luck = Luck;

            return View(NewSpin);
        }
    }
}