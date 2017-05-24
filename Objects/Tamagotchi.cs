using System.Collections.Generic;

namespace Tamagotchi.Objects
{
  public class Tamagotchi
  {
    private string _image;
    private string _name;
    private int _hunger;
    private int _play;
    private int _sleep;
    private int _id;
    // private string _status;
    private static List<Tamagotchi> _creatures = List<Tamagotchi>();

    public Tamagotchi (string image, string name)
    {
      _image = image;
      _name = name;
      _hunger = 10;
      _play = 10;
      _sleep = 10;
      _id = _creatures.Count;
      // _status = "alive";
    }

    public string GetImage()
    {
      return _image;
    }
    public void SetImage(string newImage)
    {
      _image = newImage;
    }

    public string GetName()
    {
      return _name;
    }
    public void SetName(string newName)
    {
      _name = newName;
    }

    public int GetHunger()
    {
      return _hunger;
    }

    public int GetPlay()
    {
      return _play;
    }

    public int GetSleep()
    {
      return _sleep;
    }

    public static List<Tamagotchi> GetAll()
   {
     return _creatures;
   }

    public int GetId()
   {
     return _id;
   }

   public static Tamagotchi Find(int searchId)
   {
     return _creatures[searchId-1];
   }


    if (action == feed)
    {
      return _hunger -=;
    }
    else if (action == play)
    {
        return _play -=;
    }
    else if (action == sleep)
    {
      return _sleep -=;
    }
  }
}
