
//Console.WriteLine("Hello, World!");

// == Lika med
// != Inte lika med
// > Större än
// < Mindre än
// >= Större än eller lika med
// <= Mindre än eller lika med

// && Och
// || Eller
// ! Inte

// ?? Null-coalescing operator

// new Skapa ny instans av objekt
// typeof Hämta typ av objekt
// is Typkontroll
// as Typomvandling med null-chceck

//if (true)
//{
//    Console.WriteLine("Sant");
//}
//else
//{
//    Console.WriteLine("Falskt");
//}

//int minValue = 0;
//int maxValue = 100;

//int currentValue = 10;

//if(currentValue < maxValue)
//{
//    Console.WriteLine("Påståendet är sant");
//}

//int minValue = 0;
//int maxValue = 100;

//int currentValue = 110;

//if(currentValue <= maxValue)
//{
//    Console.WriteLine("Påståendet är sant");
//}
//else
//{
//    Console.WriteLine("Påståendet är falskt");
//}

//    Console.ReadKey();

//int minValue = 0;
//int maxValue = 100;

//int currentValue = 110;

//if(currentValue <= maxValue)
//    Console.WriteLine("Påståendet är sant");
//else
//    Console.WriteLine("Påståendet är falskt");

//Console.ReadKey();

//int minValue = 0;
//int maxValue = 100;

//int currentValue = 110;

//if(currentValue <= maxValue)
//{
//    Console.WriteLine("Påståendet är sant");
//}
//else
//    Console.WriteLine("Påståendet är falskt");

//Console.ReadKey();

//int minValue = 0;
//int maxValue = 100;

//int currentValue = 50;

//if(currentValue <= maxValue)
//{
//    Console.WriteLine("Påståendet är sant");
//}
//else
//    Console.WriteLine("Påståendet är falskt");

//Console.ReadKey();

//int minValue = 0;
//int maxValue = 100;

//int currentValue = 50;

//if(currentValue <= maxValue && currentValue > minValue)
//{
//    Console.WriteLine("Påståendet är sant");
//}
//else
//    Console.WriteLine("Påståendet är falskt");

//Console.ReadKey();

//int minValue = 0;
//int maxValue = 100;

//int currentValue = 0;

//if(currentValue <= maxValue && currentValue > minValue)
//{
//    Console.WriteLine("Påståendet är sant");
//}
//else
//    Console.WriteLine("Påståendet är falskt");

//Console.ReadKey();

//int minValue = 0;
//int maxValue = 100;

//int currentValue = 0;

//if(currentValue < maxValue)
//{
//    Console.WriteLine("Värdet är mindre än maxvärdet");
//}
//else if(currentValue > minValue)
//{
//    Console.WriteLine("Värdet är störra än minvärdet");
//}
//else
//{
//    Console.WriteLine("Inget av påståendena är sanna");
//}

//Console.ReadKey();

//int minValue = 0;
//int maxValue = 100;

//int currentValue = 0;

//if(currentValue <= maxValue)
//{
//    Console.WriteLine("Värdet är mindre än maxvärdet");
//}
//else if(currentValue > minValue)
//{
//    Console.WriteLine("Värdet är störra än minvärdet");
//}
//else
//{
//    Console.WriteLine("Inget av påståendena är sanna");
//}

//Console.ReadKey();

//int minValue = 0;
//int maxValue = 100;

//int currentValue = 100;

//if(currentValue <= minValue)
//{
//    Console.WriteLine("Värdet är mindre än maxvärdet");
//}
//else if(currentValue > maxValue)
//{
//    Console.WriteLine("Värdet är störra än minvärdet");
//}
//else
//{
//    Console.WriteLine("Inget av påståendena är sanna");
//}

//int minValue = 0;
//int maxValue = 100;

//int currentValue = 100;

//string result = (currentValue < maxValue) ? "Detta är sant": "Detta är falskt";

//Console.WriteLine(result);
//Console.ReadKey();

//switch ("ddd")
//{
//    case "ddd":
//        break;
//}

//return 10 switch
//{
//    10 => "tio",
//    20 => "tjugo",
//    30 => "tretti"
//}


//string option = "1";

//switch(option.ToLower())
//{
//    case "1":
//        Console.WriteLine("Alternativ 1 körs");
//        break;
//    case "2":
//        Console.WriteLine("Alternativ 3 körs");
//        break;

//    default:
//        Console.WriteLine("Standard körs");
//        break;
//}

//int option = 20;

//switch(option)
//{
//    case <=10:
//        Console.WriteLine("Alternativ 1 körs");
//        break;
//    case <= 50:
//        Console.WriteLine("Alternativ 2 körs");
//        break;

//    default:
//        Console.WriteLine("Standard körs");
//        break;
//}

//var currentStatus = PrintingStatus.Starting;

//while (true) {
//    switch (currentStatus)
//    {
//        case PrintingStatus.Idle:
//            currentStatus = PrintingStatus.Starting;
//            Console.WriteLine("Printer is starting up");
//            break;
//        case PrintingStatus.Starting:
//            currentStatus = PrintingStatus.Loading;
//            Console.WriteLine("Printer is loading paper");
//            break;
//        case PrintingStatus.Loading:
//            currentStatus = PrintingStatus.Printing;
//            Console.WriteLine("Printer is printing");
//            break;
//        case PrintingStatus.Printing:
//            currentStatus = PrintingStatus.Cleaning;
//            Console.WriteLine("Printer is cleaning");
//            break;
//        case PrintingStatus.Cleaning:
//            currentStatus = PrintingStatus.Stopping;
//            Console.WriteLine("Printer is stopping");
//            break;
//        case PrintingStatus.Stopping:
//            currentStatus = PrintingStatus.Idle;
//            Console.WriteLine("Printer is idle");
//            break;
//    }

//    Thread.Sleep(2000);
//}

//string current_age = null!;

//Console.Write("Ange din ålder: ");

//string input_age = current_age ?? "0";

//Console.WriteLine("Din ålder är " + input_age);