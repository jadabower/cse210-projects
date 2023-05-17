Player neymar = new Player("Neymar jr.", 10, "Forward");

Player kobe = new Player("Kobe Bryant", 24);
kobe.SetPosition("Shooting Guard");

// Console.WriteLine(neymar.DisplayPlayer());
// Console.WriteLine(kobe.DisplayPlayer());

Team awesomeSauce = new Team("Awesome Sauce");

awesomeSauce.AddPlayer(neymar);
awesomeSauce.AddPlayer(kobe);

awesomeSauce.AddLoss(5);
awesomeSauce.AddWin();

awesomeSauce.DisplayRoster();