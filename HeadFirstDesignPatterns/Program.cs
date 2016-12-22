using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPatternsDuckExample;
using ObserverPatternWeatherDataExample;
using DecoratorPatternStarbuzzExample;
using FactoryPatternPizzaStoreExample;
using FactoryPatternPizzaStoreExample.PizzaStore;
using FactoryPatternPizzaStoreExample.IngredientConcreteClasses;
using FactoryPatternPizzaStoreExample.PizzaTypes;
using SingletonPatternSingleClassExample;
using CommandPatternRemoteControlExample;
using CommandPatternRemoteControlExample.Widget;
using CommandPatternRemoteControlExample.Commands;
using AdapterPatternTurkeyDuckExample;
using AdapterPatternTurkeyDuckExample.Interfaces;
using FacadePatternHomeTheaterExample;
using FacadePatternHomeTheaterExample.HomeTheaterComponents;

namespace HeadFirstDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Strategy pattern
            //Duck ModelDuck = new ModelDuck();
            //ModelDuck.PerformFly();
            //ModelDuck.SetFlyBehavior(new FlyNoWay());
            //ModelDuck.PerformFly();
            //Console.Read();

            ////Observer pattern
            //WeatherData WD = new WeatherData();
            //CurrentConditions CurrentDisplay =
            //new CurrentConditions(WD);
            //WeatherStatistics StatisticsDisplay = new WeatherStatistics(WD);
            //WeatherForecast forecastDisplay = new WeatherForecast(WD);
            //HeatIndex HiDisplay = new HeatIndex(WD);
            //WD.SetMeasurements(80, 65, 30.4f);
            //WD.SetMeasurements(82, 70, 29.2f);
            //WD.SetMeasurements(78, 90, 29.2f);
            //Console.Read();


            ////Decorator Patterns
            ////Only house blend!
            //Beverage BB = new Houseblend();
            //Console.WriteLine(BB.GetDescription());
            //Console.WriteLine(BB.Cost());
            ////Now add mocha to the house blend - 
            ////the statment Beverage Mocha = new Mocha(BB); and BB = new Mocha(BB); are equivalent
            ////However, in the below one we are explicitly making a new Mocha object
            ////In the one further below, we are "adding" Mocha to the existing object BB
            ////Beverage Mocha = new Mocha(BB);
            //BB = new Mocha(BB);
            //Console.WriteLine(BB.GetDescription());
            //Console.WriteLine(BB.Cost());
            //Console.Read();

            ////Factory Pattern
            //PizzaStore KoronetsNYStore = new NYPizzaStore();
            //PizzaStore KoronetsChicagoStore = new ChicagoPizzaStore();
            ////Order Cheese pizzas at the 2 stores
            //KoronetsNYStore.OrderPizza("Cheese");
            //KoronetsChicagoStore.OrderPizza("Cheese");

            ////Order Cheese pizzas at the 2 stores
            //KoronetsNYStore.OrderPizza("Veggie");
            //KoronetsChicagoStore.OrderPizza("Veggie");
            //Console.Read();


            ////Singleton Pattern
            //ChocolateBoiler choc = ChocolateBoiler.GetUniqueBoiler();
            //choc.Fill();
            //choc.Boil();
            //choc.Drain();
            ////Cannot drain empty container
            //choc.Drain();
            //Console.Read();


            ////Command Pattern
            //SimpleRemoteControl SimpleRC = new SimpleRemoteControl();
            //Light light = new Light("Kitchen"); //Initialize the widgets - light, fan etc.
            //LightOnCommand LOC = new LightOnCommand(light); //Inititialize the command
            //SimpleRC.SetCommand(LOC); //Set the command to a given concrete command
            //SimpleRC.ButtonWasPressed(); //Press the button!

            //ComplexRemoteControl ComplexRC = new ComplexRemoteControl();
            //Light lightBathRoom = new Light("Bath room");
            //Light lightLounge = new Light("Lounge");
            //Fan fanKitchen = new Fan("Kitchen");
            //Stereo livingRoomStereo = new Stereo();
            //GarageDoor GD = new GarageDoor();

            ////Get the command objects for each of the widgets - get both on and off command objects!
            //LightOnCommand LOCBathroomON = new LightOnCommand(lightBathRoom);
            //LightOffCommand LOCBathroomOFF = new LightOffCommand(lightBathRoom);

            //LightOnCommand LOCLoungeON = new LightOnCommand(lightLounge);
            //LightOffCommand LOCLoungeOFF = new LightOffCommand(lightLounge);

            //FanOnCommand FOCFanKitchenON = new FanOnCommand(fanKitchen);
            //FanOffCommand FOCFanKitchenOFF = new FanOffCommand(fanKitchen);

            //StereoOnCommand SOCLivingRoomStereoON = new StereoOnCommand(livingRoomStereo);
            //StereoOffCommand SOCLivingRoomStereoOFF = new StereoOffCommand(livingRoomStereo);

            //GarageDoorOpenCommand GdocGdOPEN = new GarageDoorOpenCommand(GD);
            //GarageDoorClosedCommand GdocGdCLOSE = new GarageDoorClosedCommand(GD);

            ////You can combine many commands into one macro command!
            //ICommand[] MacroON = { LOCBathroomON, LOCLoungeON, FOCFanKitchenON, SOCLivingRoomStereoON, GdocGdOPEN };
            //ICommand[] MacroOFF = { LOCBathroomOFF, LOCLoungeOFF, FOCFanKitchenOFF, SOCLivingRoomStereoOFF, GdocGdCLOSE };

            //MacroCommands MacroCommandON = new MacroCommands(MacroON);
            //MacroCommands MacroCommandOFF = new MacroCommands(MacroOFF);

            ////Set the commands on the different slots of the remote control
            //ComplexRC.SetCommand(0, LOCBathroomON, LOCBathroomOFF);
            //ComplexRC.SetCommand(1, LOCLoungeON, LOCLoungeOFF);
            //ComplexRC.SetCommand(2, FOCFanKitchenON, FOCFanKitchenOFF);
            //ComplexRC.SetCommand(3, SOCLivingRoomStereoON, SOCLivingRoomStereoOFF);
            //ComplexRC.SetCommand(4, GdocGdOPEN, GdocGdCLOSE);
            //ComplexRC.SetCommand(5, MacroCommandON, MacroCommandOFF); //This will perform many commands! If any doubts, review Head first design patterns
            //ComplexRC.SetCommand(14, GdocGdOPEN, GdocGdCLOSE); //OUT OF BOUNDS!

            //ComplexRC.DisplayContentsOfRemoteControl();
            //var Prompt = true;
            //while (Prompt)
            //{
            //    Console.WriteLine("Enter valid slot number: ");
            //    int slot = -1;
            //    Int32.TryParse(Console.ReadLine(), out slot);
            //    Console.WriteLine("Enter 'off' or 'on' or 'undo': ");
            //    string action = "";
            //    action = Console.ReadLine().ToLower();

            //    if(action == "on")
            //    {
            //        ComplexRC.OnButtonWasPressed(slot);
            //    }
            //    else if (action == "off")
            //    {
            //        ComplexRC.OffButtonWasPressed(slot);
            //    }
            //    else if (action == "undo")
            //    {
            //        ComplexRC.UndoButtonWasPressed(slot);
            //    }

            //    Console.WriteLine("More actions? y/n: ");
            //    if (Console.ReadLine().ToLower().Trim().First() == 'y')
            //    {
            //        Prompt = true;
            //    }
            //    else
            //    {
            //        Prompt = false;
            //    }
            //}
            //Console.Read();

            ////Adapter Pattern
            //WildTurkey WTurkey = new WildTurkey();
            //AdapterPatternTurkeyDuckExample.MallardDuck MDuck = new AdapterPatternTurkeyDuckExample.MallardDuck();
            //AdapterPatternTurkeyDuckExample.Interfaces.Duck AdaptTurkey = new AdapterTurkey(WTurkey);
            ////Adapt turkey is actually a duck (look at LHS)

            //Console.WriteLine("The mallard duck says...");
            //MDuck.Fly();
            //MDuck.Quack();

            //Console.WriteLine("The wild turkey says...");
            //WTurkey.Fly();
            //WTurkey.Gobble();

            //Console.WriteLine("The Adapter object 'duck' says...");
            //AdaptTurkey.Fly();
            //AdaptTurkey.Quack();
            //Console.Read();


            ////Facade Pattern
            //Amplifier amp = new Amplifier();
            //DvdPlayer dvd = new DvdPlayer();
            //PopcornPopper pop = new PopcornPopper();
            //Projector proj = new Projector();
            //Screen screen = new Screen();
            //TheaterLights lights = new TheaterLights();

            //HomeTheaterFacade facade = new HomeTheaterFacade(amp, dvd, pop, screen, lights, proj);
            //facade.WatchMovie("The office");
            //facade.EndMovie();
            //Console.Read();

            Console.Read();
        }
    }

   
}
