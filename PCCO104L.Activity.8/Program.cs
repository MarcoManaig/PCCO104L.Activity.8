using System.Net;
using System.Security.Principal;

namespace PCCO104L.Encapsulation.MANAIG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What role would you like to play?");
            Console.WriteLine("");

            Champ mid = new Champ(6.8, "Mid Laner", "Solo");
            mid.champname = "Lux";
            mid.role = "Enchanter";
            mid.scndrole = "Secondary: Support";
            mid.first_item();
            mid.taunt();
            mid.Announcement();
            mid.second();



            Champ top = new Champ(8.5, "Top Lane", "Solo");
            top.champname = "Darius";
            top.role = "Bruiser";
            top.scndrole = "Secondary: Jungler";
            top.first_item();
            top.taunt();
            top.Announcement();
            top.second();



            Champ bot = new Champ(7.3, "Bottom Lane", "Needs Support");
            bot.champname = "Zeri";
            bot.role = "Marksman, Caster";
            bot.scndrole = "Secondary: Mid";
            bot.first_item();
            bot.taunt();
            bot.Announcement();
            bot.second();
            bot.Closing();


            Hero pos_one = new Hero(4.1, "Jungle", "Solo");
            pos_one.champname = "Kunkka";
            pos_one.role = "Jungler";
            pos_one.scndrole = "Hard Carry";
            pos_one.Announce();
            pos_one.first_item();
            pos_one.taunt();
            pos_one.nashor();

            Hero pos_three = new Hero(31.0, "Mid Lane", "Solo");
            pos_three.champname = "Pugna";
            pos_three.role = "Mid Laner";
            pos_three.scndrole = "Soft Support";
            pos_three.Announce();
            pos_three.first_item();
            pos_three.taunt();
            pos_three.nashor();

            Hero pos_five = new Hero(32.5, "Duo/Trio Lane", "Hard Support");
            pos_five.champname = "Pudge";
            pos_five.role = "Soft/Hard Support";
            pos_five.scndrole = "Mid Laner";
            pos_five.Announce();
            pos_five.first_item();
            pos_five.taunt();
            pos_five.nashor();

            God ares = new God(1.41, "Solo Lane", "Carry");
            ares.champname = "Ares";
            ares.role = "Guardian, Bruiser";
            ares.scndrole = "Jungler";
            ares.Announce();
            ares.first_item();
            ares.taunt();
            ares.nashor();


        }
    }
}

public class God : Hero
{
    private string _Lane { get; set; }

    private double _PickRate { get; set; }

    private string _Laning { get; set; }

    public string champname { get; set; }

    public string role { get; set; }

    public void Method1() { }

    public void Method2() { }

    public God() { }

    public God(double pickrate)
    {
        _PickRate = pickrate;
    }
    public God(double pickrate, string lane, string laning) : this(pickrate)
    {
        _Lane = lane;
        _Laning = laning;
    }

    public void Announce()
    {
        Console.WriteLine($"{_Lane} - Pickrate: {_PickRate} - {_Laning} - Champion: {champname} - {role} - Goodluck Summoner!");
    }
}
public class Hero : Int1, Int2
{

    private string _Lane { get; set; }

    private double _PickRate { get; set; }

    private string _Laning { get; set; }

    public string champname { get; set; }

    public string role { get; set; }

    public void taunt()
    {
        Console.WriteLine("Haha! First Blood!");

    }

    public void first_item()
    {
        Console.WriteLine("Boots of Speed");
    }

    public void nashor()
    {
        Console.WriteLine("Go to the Roshan pit!");
    }

    public string scndrole { get; set; }

    public void Method1() { }

    public void Method2() { }

    public Hero() { }

    public Hero(double pickrate)
    {
        _PickRate = pickrate;
    }
    public Hero(double pickrate, string lane, string laning) : this(pickrate)
    {
        _Lane = lane;
        _Laning = laning;
    }

    public void Announce()
    {
        Console.WriteLine($"{_Lane} - Pickrate: {_PickRate} - {_Laning} - Hero: {champname} - {role} - Goodluck Summoner!");
    }
}

interface Int1
{
    string scndrole { get; set; }
    void Method1();
}
interface Int2
{
    void Method2();
}
public class Champ : Hero, Int1, Int2
{
    private string _Lane { get; set; }

    private double _PickRate { get; set; }

    private string _Laning { get; set; }

    public string champname { get; set; }

    public string role { get; set; }

    public string scndrole { get; set; }

    public void Method1() { }
    public void Method2() { }

    public Champ() { }

    public Champ(double pickrate)
    {
        _PickRate = pickrate;
    }

    public Champ(double pickrate, string lane, string laning) : this(pickrate)
    {
        _Lane = lane;
        _Laning = laning;
    }

    public void Announcement()
    {
        Console.WriteLine($"{_Lane} - Pickrate: {_PickRate} - {_Laning} - Champion: {champname} - {role} - Goodluck Summoner!");
    }

    public void second()
    {
        Console.WriteLine($"{scndrole}");
    }

    public void Closing()
    {
        Console.WriteLine("Please consult the Summoner's Guild for more roles and chmapions. Goodluck Summoner!");
    }

}