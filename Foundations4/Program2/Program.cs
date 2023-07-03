Address dynamite = new Address("143 Chitney Lane", "Preston", "Idaho", "USA");
Customer kip = new Customer("Kipland Dynamite", dynamite);
Product tortillas = new Product("10 Count Tortilla", "10077130621", 2.99, 3);
Product nunchucks = new Product("Realistic Wood Nunchaku", "11030012332", 10.99, 1);
Product posterBoard = new Product("White Poster-board", "10002138472", 0.99, 1);
List<Product> kipsProducts = new List<Product> {tortillas, nunchucks, posterBoard};
Order kipsOrder = new Order(kip, kipsProducts);
kipsOrder.DisplayOrder();

Address lab = new Address("2610 Silver Springs Blvd", "Calgary", "Alberta", "Canada");
Customer etho = new Customer("EthosLab", lab);
Product noteblock = new Product("NoteBlock", "12021323534", 5.99, 32);
Product tnt = new Product("TNT", "18530233832", 16.34, 16);
List<Product> ethosProducts = new List<Product> {noteblock, tnt};
Order ethosOrder = new Order(etho, ethosProducts);
ethosOrder.DisplayOrder();
