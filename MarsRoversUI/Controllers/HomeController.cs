using System.Collections.Generic;
using System.Web.Mvc;
using MarsRovers;
using MarsRovers.Exceptions;
using MarsRoversUI.Models;

namespace MarsRoversUI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            MarsRoversTestModel model = new MarsRoversTestModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult Test(MarsRoversTestModel model) {

            RoverRegion region = new RoverRegion(model.RegionWidth, model.RegionHeight);

            foreach (MarsRoverModel roverModel in model.MarsRoverList) {
                try
                {
                    MarsRover marsRover = new MarsRover(region, new RoverPosition(roverModel.X, roverModel.Y, roverModel.Heading[0]), roverModel.Instructions);
                    
                    marsRover.Displace();

                    roverModel.X = marsRover.Position.X;
                    roverModel.Y = marsRover.Position.Y;

                    roverModel.Heading = marsRover.Position.Heading.ToString();

                    roverModel.Information = marsRover.Status + (marsRover.ErrorMessage.Length > 0 ? " - " + marsRover.ErrorMessage : "");
                }
                catch (RoverStartPositionBadInitializationException ex) {
                    roverModel.Information = "Failed" + " - " + ex.Message;
                }

                
            }

            return PartialView("_MarsRoversList", model.MarsRoverList);
        }

    }
}