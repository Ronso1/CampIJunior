using CampHomework3;
{
    Cards[] cardsOfPlayer =
    {
        new Cards("Огненная карта", Element.Fire, 20, new WorldView(new Dictionary<NameOfWorldView, int>() { {NameOfWorldView.Morale, 1 }, { NameOfWorldView.Ethics, 2} })),
        new Cards("Сила земли", Element.Terra, 20, new WorldView(new Dictionary<NameOfWorldView, int>() { {NameOfWorldView.Morale, 1 }, { NameOfWorldView.Ethics, 2} })),
        new Cards("Огненная карта", Element.Fire, 20, new WorldView(new Dictionary<NameOfWorldView, int>() { {NameOfWorldView.Morale, 1 }, { NameOfWorldView.Ethics, 2} })),
        new Cards("Огненная карта", Element.Fire, 20, new WorldView(new Dictionary<NameOfWorldView, int>() { {NameOfWorldView.Morale, 1 }, { NameOfWorldView.Ethics, 2} })),
        new Cards("Огненная карта", Element.Fire, 20, new WorldView(new Dictionary<NameOfWorldView, int>() { {NameOfWorldView.Morale, 1 }, { NameOfWorldView.Ethics, 2} })),   
    };
        
    var enemy = new Enemy("Орк", Element.Water, 100f, new WorldView(new Dictionary<NameOfWorldView, int>() { { NameOfWorldView.Morale, 1 }, { NameOfWorldView.Ethics, 2 } }));
    bool isWin = false;

    while (!isWin)
    {
        Console.WriteLine("s");
    }
