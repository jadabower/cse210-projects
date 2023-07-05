// create an instance of a reception
Address hewittOaks = new Address("205 Stillwell Rd", "Bluffton", "SC", "29910");
Reception weddingReception = new Reception("rsvp_doe@gmail.com", "John and Jane Doe Wedding Reception", "Mr and Mrs Doe are happy to announce the wedding of their daughter Jane to Mr John Doe", "April 4th", "7:00pm", hewittOaks);
// print out the different types of details
Console.WriteLine("====================");
Console.WriteLine(weddingReception.GetStandardDetails());
Console.WriteLine();
Console.WriteLine(weddingReception.GetFullDetails());
Console.WriteLine();
Console.WriteLine(weddingReception.GetShortDescription());
Console.WriteLine("====================");

// create an instance of an outdoor activity
Address porterPark = new Address("S 2nd W & 3rd W", "Rexburg", "ID", "83440");
OutdoorGathering frisbee = new OutdoorGathering("Sunny", "Rexburg YSA 9th Stake Ultimate Frisbee Tournament", "Ultimate Frisbee at Porter Park! Snacks and drinks will be provided!", "July 8th", "10:00am", porterPark);
// print out the different types of details
Console.WriteLine("====================");
Console.WriteLine(frisbee.GetStandardDetails());
Console.WriteLine();
Console.WriteLine(frisbee.GetFullDetails());
Console.WriteLine();
Console.WriteLine(frisbee.GetShortDescription());
Console.WriteLine("====================");

// create an instance of a lecture
Address hinckley = new Address("488 S 2nd St E", "Rexburg", "ID", "83460");
Lecture talk = new Lecture("Brother Nate Mitchell", 100, "Where Can I Turn for Peace?", "Brother Nate Mitchell, who played Joseph Smith in JSPR, and Peter in the church's Bible Videos, will discuss Peace.", "June 15th", "11:30am", hinckley);
// print out the different types of details
Console.WriteLine("====================");
Console.WriteLine(talk.GetStandardDetails());
Console.WriteLine();
Console.WriteLine(talk.GetFullDetails());
Console.WriteLine();
Console.WriteLine(talk.GetShortDescription());
Console.WriteLine("====================");