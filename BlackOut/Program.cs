using BlackOut;

if (!args.Any())
    return;

if (args[0].ToLower() == "off")
    ScreenController.TurnOff();

if (args[0].ToLower() == "on")
    ScreenController.TurnOn();



//// Opret lister over ugedage og tidspunkter
//List<string> ugedage = new List<string> { "mandag", "tirsdag", "onsdag", "torsdag", "fredag", "lørdag", "søndag" };
//Dictionary<string, List<TimeSpan>> tidsplan = new Dictionary<string, List<TimeSpan>>();

//// Tilføj tidspunkter for hver dag
//tidsplan["mandag"] = new List<TimeSpan> { new TimeSpan(8, 0, 0), new TimeSpan(14, 0, 0) };
//// Gentag dette for de andre dage i ugen

//// I din timer-håndteringskode
//string aktuelDag = DateTime.Now.DayOfWeek.ToString().ToLower();
//TimeSpan aktuelTid = DateTime.Now.TimeOfDay;

//if (tidsplan.ContainsKey(aktuelDag))
//{
//    foreach (TimeSpan tidspunkt in tidsplan[aktuelDag])
//    {
//        if (aktuelTid >= tidspunkt && aktuelTid < tidspunkt.Add(new TimeSpan(0, 1, 0))) // Tjek om det er tid til at slukke eller tænde
//        {
//            // Brug Windows API til at slukke eller tænde skærmen
//        }
//    }
//}

