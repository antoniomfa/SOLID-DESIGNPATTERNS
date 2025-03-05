using SOLID_DESIGNPATTERNS.Abstraction;
using SOLID_DESIGNPATTERNS.Commnad;
using SOLID_DESIGNPATTERNS.Commnad.GoodExample;
using SOLID_DESIGNPATTERNS.Coupling;
using SOLID_DESIGNPATTERNS.Encapsulation;
using SOLID_DESIGNPATTERNS.Iterator;
using SOLID_DESIGNPATTERNS.Iterator.GoodExample;
using SOLID_DESIGNPATTERNS.Mediator;
using SOLID_DESIGNPATTERNS.Memento;
using SOLID_DESIGNPATTERNS.Observer.BadExample;
using SOLID_DESIGNPATTERNS.Observer.GoodExample;
using SOLID_DESIGNPATTERNS.Polymorphism;
using SOLID_DESIGNPATTERNS.SOLID.D;
using SOLID_DESIGNPATTERNS.SOLID.I;
using SOLID_DESIGNPATTERNS.SOLID.L;
using SOLID_DESIGNPATTERNS.SOLID.O;
using SOLID_DESIGNPATTERNS.State;
using SOLID_DESIGNPATTERNS.State.GoodSolution;
using SOLID_DESIGNPATTERNS.Strategy;
using SOLID_DESIGNPATTERNS.Strategy.GoodExample;
using SOLID_DESIGNPATTERNS.Template.BadExample;
using SOLID_DESIGNPATTERNS.Template.GoodExample;
using System.Net.Security;

// -------------- Encapsulation --------------
// hiding internal implementation only exposing necessary functionalities

BadBankAccount badBankAccount = new();
badBankAccount.Balance = -50; // PROBLEM

//Console.WriteLine(badBankAccount.Balance);

BankAccount bankAccount = new(100);
bankAccount.Deposit(50);
//Console.WriteLine(bankAccount.GetBalance());

bankAccount.Withdraw(100);
//Console.WriteLine(bankAccount.GetBalance());

// -------------- Abstraction --------------
// reduce complexity by hiding uneccesary details

EmailService emailService = new();
//emailService.Connect();
//emailService.Authenticate();
//emailService.SendEmail();
//emailService.Disconnect();
// Instead just call SendEmail, if seomthing changes in the other methods, dont worry 
emailService.SendEmail();

// -------------- Inheritance --------------
// creating new classes based on existing ones 

// -------------- Polymorphism --------------
// poly = many, morph = forms
// object can take many forms

List<object> vehicles = new();
List<Vehicle> vehicles2 = new();

vehicles.Add(new SOLID_DESIGNPATTERNS.Polymorphism.Car
{
    Brand = "Ford",
    Model = "Focus",
    Year = 1999,
    NumberOfDoors = 5
});


vehicles.Add(new Motorcycle
{
    Brand = "Harley",
    Model = "Camry",
    Year = 1999
});

vehicles2.Add(new SOLID_DESIGNPATTERNS.Polymorphism.Car
{
    Brand = "Ford",
    Model = "Focus",
    Year = 1999,
    NumberOfDoors = 5
});


vehicles2.Add(new Motorcycle
{
    Brand = "Harley",
    Model = "Camry",
    Year = 1999
});

foreach (var v in vehicles)
{
    // NOT OPTIMAL!!!
    if (v is SOLID_DESIGNPATTERNS.Polymorphism.Car)
    {
        var _car = (SOLID_DESIGNPATTERNS.Polymorphism.Car)v;
        _car.Start();
    }
    else if (v is Motorcycle)
    {
        var motorcycle = (Motorcycle)v;
        motorcycle.Start();
    }
}

foreach (var v in vehicles2)
{
    // GOOD
    v.Start();
}

// -------------- Coupling --------------
// the degree of dependency between different classes

var order = new Order(new EmailSender());
order.SendNotification();
var order2 = new Order(new SmsSender());
order2.SendNotification();

// -------------- Composition --------------
// creating complex obj by combining simpler ones

var car = new SOLID_DESIGNPATTERNS.Composition.Car();
car.StartCar();

// -------------- SOLID --------------

// -------------- S --------------
// a class should have only one reason to change

// -------------- O --------------
// entities should be open for extension but closed for modification

// -------------- L --------------
// obj of superclass should be replaceable with obj of its subclass without affecting the program

// OK
var rect = new SOLID_DESIGNPATTERNS.SOLID.L.Rectangle();
rect.Height = 10;
rect.Width = 5;
Console.WriteLine("Expected area = 10 * 10 = 50 ...\n");
Console.WriteLine("Calculated area = " + rect.Area + "\n");

// INVALID
var square = new Square();
square.Width = 10;
square.Height = 5;
Console.WriteLine("Expected area = 10 * 10 = 50 ...\n");
Console.WriteLine("Calculated area = " + square.Area + "\n");

// NOW IS OK
SOLID_DESIGNPATTERNS.SOLID.L.Shape rectangle = new SOLID_DESIGNPATTERNS.SOLID.L.Rectangle { Width = 5, Height = 4 };
SOLID_DESIGNPATTERNS.SOLID.L.Shape squareRefact = new SquareRefactored { SideLength = 5 };
Console.WriteLine($"Area of rectangle: {rectangle.Area}\n");
Console.WriteLine($"Area of square: {squareRefact.Area}\n");

// -------------- I --------------
// clients should not be force to depend on interfaces they do not use

var circ = new SOLID_DESIGNPATTERNS.SOLID.I.Circle();

circ.Radius = 10;
Console.WriteLine(circ.Area());
Console.WriteLine(circ.Volume()); // EXCEPTION THROWN

// now we can't call this
var circFixed = new CircleFixed();
//circFixed.Volume(); <-- does not exist

// -------------- D --------------
// high level modules should not depend on low level modules

// without IEngine injected into ctor of Car class
var carNOTOK = new SOLID_DESIGNPATTERNS.SOLID.D.Car();

// now we can create other sort of engines because car class does not depend only on Engine class but it's
// flexible with IEngine that can have any type of engine
var carOK = new SOLID_DESIGNPATTERNS.SOLID.D.Car(new Engine());

/* other engine for ex:
 * var carOtherEngine = SOLID_DESIGNPATTERNS.SOLID.D.Car(new ElectricEngine()); */


// DESIGN PATTERNS

// There are threee main groups of DP

// - Creational : different ways to create objects
// - Structural : the relationships between those objects
// - Behavioral : the interaction/communication between those obj


// Memento (WHEN TO USE: when u want to produce snapshots of an object's state to be able to restore to a previous state)
var editor = new Editor();
var history = new History(editor);

history.Backup();

editor.Title = "Test";

history.Backup();

editor.Content = "Hello there my name is TOM";

history.Backup();

editor.Title = "This life of a dev...";

Console.WriteLine("\nTitle: " + editor.Title);
Console.WriteLine("\nContent: " + editor.Content);

history.Undo();

Console.WriteLine("\nTitle after undo: " + editor.Title);
Console.WriteLine("\nContent after undo: " + editor.Content);

history.ShowHistory();

history.Undo();

Console.WriteLine("\nTitle after undo: " + editor.Title);
Console.WriteLine("\nContent after undo: " + editor.Content);


// State (WHEN TO USE: when we want an object to behave differently depending on the state that it is in)

// bad solution
var doc = new SOLID_DESIGNPATTERNS.State.Document();
doc.State = DocumentStates.Moderation;
doc.CurrentUserRole = UserRoles.Admin;

Console.WriteLine("\nCurrent state before publish: " + doc.State);

doc.Publish();

Console.WriteLine("\nCurrent state after publish: " + doc.State);

doc.CurrentUserRole = UserRoles.Admin;

doc.State = DocumentStates.Moderation;
doc.CurrentUserRole = UserRoles.Editor;

Console.WriteLine("\nCurrent state before publish: " + doc.State);

doc.Publish();

Console.WriteLine("\nCurrent state after publish: " + doc.State + "\n");

// good solution
var docOK = new SOLID_DESIGNPATTERNS.State.GoodSolution.Document(UserRoles.Admin);
Console.WriteLine(docOK.State);

docOK.Publish();
Console.WriteLine(docOK.State);

docOK.Publish();
Console.WriteLine(docOK.State);

docOK.State = new DraftState(docOK);
Console.WriteLine(docOK.State);


// Strategy (WHEN TO USE: when we want to pass diferent algorithms or behaviors to an object + when we have a class
// with a large number of conditional statements)
var videoStorage = new SOLID_DESIGNPATTERNS.Strategy.GoodExample.VideoStorage(
    new CompressorMP4(), new OverlayBlackAndWhite());

videoStorage.Store("/videos/some-movie/");

videoStorage.SetCompressor(new CompressorWEBM());
videoStorage.SetOverlay(new OverlayNone());
videoStorage.Store("/videos/some-series/");


// Iterator (WHEN TO USE: when our collection possesses a complex internal data structure, or it is likely to change,
// so that clients can iterate over it without any knowledge of the data structure behind)

// bad solution
SOLID_DESIGNPATTERNS.Iterator.ShoppingList shoppingList = new();
shoppingList.Push("Bread");
shoppingList.Push("Donuts");
shoppingList.Push("Juice");

for (int i = 0; i < shoppingList.GetList().Count; i++)
{
    var item = shoppingList.GetList()[i];
    Console.WriteLine(item);
}

// good solution
SOLID_DESIGNPATTERNS.Iterator.GoodExample.ShoppingList shoppingL = new();
shoppingL.Push("Pizza");
shoppingL.Push("Meat");
shoppingL.Push("Fish\n");
Console.WriteLine("\n");

var iterator = shoppingL.CreateIterator();

while(iterator.HasNext())
{
    Console.WriteLine(iterator.Current());

    iterator.Next();
}


// Command (WHEN TO USE: handling user interactions with buttons/menu items; each button/menu can be associated with a
// specific command obj, allowing the framwork to exec the appropriate action when requested; decouples the UI from the
// operations they perform, providing flexibility and maintainability in UI development; facilitates features such as
// undo/redo or event loggin in UI applications)

// bad solution
var light = new Light();
var remoteControl = new RemoteControl(light);

remoteControl.PressButton(true);
remoteControl.PressButton(false);

// good solution
var lightGood = new LightGood();
var remoteControlGood = new RemoteControlGood(new TurnOnCommand(lightGood));
remoteControlGood.PressButton(); // Light is on
remoteControlGood.SetCommand(new DimCommand(lightGood));
remoteControlGood.PressButton(); // Light is dim


// Template (WHEN TO USE: when we want to allow clients to implement only particular steps in an algorithm, and not the whole algorithm; it's
// a good pattern to use when there is a bunch of classes with the same logic but with differences in a few steps so if the algorithm changes
// it only has to be modified in one place, the base class)

// bad solution
//var tea = new Tea();
//tea.MakeBeverage();

// good solution
var beverageMaker = new BeverageMaker(new TeaGood());
beverageMaker.MakeBeverage();   

beverageMaker.SetBeverage(new CoffeeGood());
beverageMaker.MakeBeverage();



// Observer (implement Observer interface forcing all observers to implement it)

// bad solution
DataSource dataSource = new DataSource();
Sheet2 sheet = new Sheet2();
BarChart barChart = new BarChart();

dataSource.AddDependent(sheet);
dataSource.AddDependent(barChart);

dataSource.SetValues([5, 5, 1, 10]);

// good solution
DataSourceGood dataSourceGood = new();
Sheet2Good sheet2 = new Sheet2Good(dataSourceGood);
BarChartGood barChart2 = new BarChartGood(dataSourceGood);

dataSourceGood.AddObersver(sheet2);
dataSourceGood.AddObersver(barChart2);

dataSourceGood.SetValues([1, 2, 3]);



// Mediator ()

var postsDialogBox = new PostsDialogBox();
postsDialogBox.SimulateUserInteractionOk();
postsDialogBox.SimulateUserInteractionNOk();
