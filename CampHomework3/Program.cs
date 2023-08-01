using CampHomework3;
{
    Cards[] cardsOfPlayer =
    {
        new Cards("Огненная карта", Element.Fire, 20, new WorldView(new Dictionary<NameOfWorldView, int>() { {NameOfWorldView.Morale, 1 }, { NameOfWorldView.Ethics, 2} })),
        new Cards("Сила земли", Element.Terra, 20, new WorldView(new Dictionary<NameOfWorldView, int>() { {NameOfWorldView.Morale, 1 }, { NameOfWorldView.Ethics, 2} })),
        new Cards("Магия воды", Element.Water, 20, new WorldView(new Dictionary<NameOfWorldView, int>() { {NameOfWorldView.Morale, 1 }, { NameOfWorldView.Ethics, 2} })),
        new Cards("Сила воздуха", Element.Air, 20, new WorldView(new Dictionary<NameOfWorldView, int>() { {NameOfWorldView.Morale, 1 }, { NameOfWorldView.Ethics, 2} })),
        new Cards("Мощная огненная карта", Element.Fire, 20, new WorldView(new Dictionary<NameOfWorldView, int>() { {NameOfWorldView.Morale, 1 }, { NameOfWorldView.Ethics, 2} })),
    };

    var enemy = new Enemy("Орком", Element.Water, 100f, new WorldView(new Dictionary<NameOfWorldView, int>() { { NameOfWorldView.Morale, 1 }, { NameOfWorldView.Ethics, 2 } }));
    bool isWin = false;

    while (!isWin)
    {
        Console.WriteLine("Добро пожаловать в карточную игру!");
        Console.WriteLine();
        Console.WriteLine($"Вам предстоит сразиться с {enemy.Name}.");
        Console.WriteLine("Выберите карту: ");
        for (int i = 0; i < cardsOfPlayer.Length; i++)
        {
            Console.WriteLine($"{i + 1} - {cardsOfPlayer[i].Name}, сила атаки: {cardsOfPlayer[i].Power}");
        }
        Console.ReadKey();
    }
}
