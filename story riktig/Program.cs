using System.Runtime.Intrinsics.Arm;

string scene = "vakna";
string morgon;
string rutin;
string frukost;
string macka;
string yoghurt;
string badrum;
string nummret;

if (scene == "vakna")
{
    Console.WriteLine(" Efter en lugn natt kommer morgonen och knackar på fönstret");
    do
    {
        Console.WriteLine(" Vill du vakna?");
        morgon = Console.ReadLine().ToLower();

        if (morgon == "ja")
        {
            scene = "rutin";
        }
        else if (morgon == "nej")
        {
            Console.WriteLine(" okej god natt, sov gott.");
            Thread.Sleep(3000);
            System.Environment.Exit(1);
        }
    }
    while (morgon != "ja" && morgon != "nej");
}

if (scene == "rutin")
{
    Console.WriteLine(" Du vaknar ock sitter och stirrar in i inget\n Du funderar på vad du ska göra \n antingen kan du gå till köket för att äta\n eller till badrumet");
    do
    {
        Console.WriteLine(" Vart vill du gå?");
        rutin = Console.ReadLine().ToLower();
        if (rutin == "kök" || rutin == "köket")
        {
            scene = "köket";
        }
        if (rutin == "badrumet" || rutin == "badrum")
        {
            scene = "badrum";
        }
    }
    while (rutin != "kök" && rutin != "köket" && rutin != "badrumet" && rutin != "badrum");
}

if (scene == "köket")
{

    Console.WriteLine(" Trött och deprimerad går du till kylskåpet och funderar på vad du ska äta");
    do
    {
        Console.WriteLine(" vill du äta macka eller yoghurt");
        frukost = Console.ReadLine().ToLower();
        if (frukost == "macka" || frukost == "mackan")
        {
            scene = "macka";
        }
        if (frukost == "yoghurt" || frukost == "yoghurten")
        {
            scene = "yoghurt";
        }
    }
    while (frukost != "macka" && frukost != "mackan" && frukost != "yoghurt" && frukost != "yoghurten");
}

if (scene == "macka")
{
    Console.WriteLine(" Du tar smör  och en Fallu råg rut macka \n du brer på smöret och tar en tugga");
    do
    {
        Console.WriteLine(" Var den god?");
        macka = Console.ReadLine().ToLower();
        if (macka == "ja")
        {
            Console.WriteLine(" synd för du satte i halsen och kvävdes");
            Thread.Sleep(5000);
            System.Environment.Exit(1);
        }
        if (macka == "nej")
        {
            Console.WriteLine(" tur för dig så kommer du inte ta en tugga till \n för du satte i halsen och kvävdes");
            Thread.Sleep(7000);
            System.Environment.Exit(1);
        }
    }
    while (macka != "ja" && macka != "nej");
}

if (scene == "yoghurt")
{
    System.Console.WriteLine(" Du häller up en skål av yoghurt och går och äter. \n efter några skedar märker du att det blir bara mer yoghurt\n Efter en stund börjar yoghurten läcka över\n Hela rummet har fyllts med yoghurt\n Du kan antingen pröva fly eller äta.");
    do
    {
        System.Console.WriteLine(" vad vill du göra?");
        yoghurt = Console.ReadLine().ToLower();

        if (yoghurt == "äta")
        {
            System.Console.WriteLine(" Du tar din sked och tar ett jupt andetag\n du förbereder dig för måltiden du kommer att ha\n Sked efter sked äter du yoghurten tills det finn inget kvar\n Tröt och belåten sommnar du i din stol");
            Thread.Sleep(15000);
            System.Environment.Exit(1);
        }
        if (yoghurt == "fly")
        {
            System.Console.WriteLine(" I panik försöker du ställa dig up för att springa\n Tyvär var yoghurten för tung och du sitter fast\n Medans du sitter där tänker du hur pinsamt det är att dö av att drunkna i yoghurt");
            Thread.Sleep(15000);
            System.Environment.Exit(1);
        }

    }
    while (yoghurt != "äta" && yoghurt != "fly");
}

if (scene == "badrum")
{
    System.Console.WriteLine(" Glatt skuttar du till badrummet\n Men när du kommer fram ser du att toan är borta och bytts ut med en lapp\n På lappen står det\n VI HAR DIN TOA OM DU VILL HA TILLBAKA DEN RING\n 0739876791");
    do
    {
        System.Console.WriteLine(" Ringer du nummret eller tar du en dusch?");
        badrum = Console.ReadLine().ToLower();

        if (badrum == "ring" || badrum == "ringa" || badrum == "ringer" || badrum == "nummret" || badrum == "ring nummret")
        {
            scene = "nummer";
        }
        if (badrum == "dusch" || badrum == "duscha" || badrum == "duschen")
        {
            System.Console.WriteLine(" Du börjar klä av dig men du börjar snubla på på dina braller\n Du halka och slog i huvut i handfatet\n Huvut gick itur och du dog\n synd");
            Thread.Sleep(15000);
            System.Environment.Exit(1);
        }
    }
    while (badrum != "dusch" && badrum != "duscha" && badrum != "duschen" && badrum != "ring" && badrum != "ringa" && badrum != "ringer" && badrum != "nummret" && badrum != "ring nummret");

}

if (scene == "nummer")
{
    System.Console.WriteLine(" Rädd och desperat på en skit ringer du numret\n Du hör en ond röst i telefonen");
    Console.ForegroundColor
    = ConsoleColor.Red;
    System.Console.WriteLine(" Vi har din toalet kom till \"addres\" ");
    Console.ForegroundColor
    = ConsoleColor.White;
    do
    {
        System.Console.WriteLine(" Vill du gå till adressen?");
        nummret = Console.ReadLine().ToLower();

        if (nummret == "ja")
        {
            System.Console.WriteLine(" Det är bra att du bryr dig om din toa men \n När du gick ut för dörre blev du påkörd av en båt");
            Thread.Sleep(7000);
            System.Environment.Exit(1);
        }
        if (nummret == "nej")
        {
            System.Console.WriteLine(" Du gick vidare med din dag");
            Thread.Sleep(5000);
            System.Environment.Exit(1);
        }
    }
    while (nummret != "ja" && nummret != "nej");
}
Console.ReadLine();