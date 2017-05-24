using Nancy;
using Tamagotchi.Objects;
using System.Collections.Generic;

namespace Tamagotchi
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };

      Get["/tamagotchi"] = _ => {
        List<Tamagotchi> allTamagotchi = Tamagotchi.GetAll();
        return View["index.cshtml"];
      };

      Post["/tamagotchi"] = _ => {
        Tamagotchi newTamagotchi = new Tamagotchi(Request.Form["image"], Request.Form["name"]);
        List<Tamagotchi> allTamagotchi = Tamagotchi.GetAll();
        return View["tamagotchi.cshtml", allTamagotchi];
      };


      Get["/action/{id}"] = parameters => {
        Tamagotchi tamagotchi = Tamagotchi.Find(parameters.id);
        return View["action.cshtml", tamagotchi];
      };
    }
  }
}
