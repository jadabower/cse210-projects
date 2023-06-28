Console.WriteLine();

// Video 1 Creation, comments creation (and addition), and display.
Video video1 = new Video("The essence of calculus", "3Blue1Brown", 3660);
Comment com1vid1 = new Comment("Lil' Johnny", "This taught me more than 4 years of college calculus.");
Comment com2vid1 = new Comment("mathzfornerdz", "Who else is here before a calc exam??");
Comment com3vid1 = new Comment("Nathan", "real kids watched him when he was at khan academy");
video1.AddComment(com1vid1);
video1.AddComment(com2vid1);
video1.AddComment(com3vid1);
video1.DisplayVideo();

Console.WriteLine();

// Video 2
Video video2 = new Video("Never Ending Song (Official Music Video)", "Conan Gray", 216);
Comment com1vid2 = new Comment("gamergirl123", "we do not deserve him fr");
Comment com2vid2 = new Comment("ur mom", "i want this song playing at my funeral");
Comment com3vid2 = new Comment("don't click my pfp", "hey conan, r u ok?");
video2.AddComment(com1vid2);
video2.AddComment(com2vid2);
video2.AddComment(com3vid2);
video2.DisplayVideo();

Console.WriteLine();

// Video 3
Video video3 = new Video("Hermitcraft Season 9: Modded Minecraft - #50", "docm77", 4471);
Comment com1vid3 = new Comment("gamergirl123", "uh oh guys, he found mods");
Comment com2vid3 = new Comment("DaWorkOfJypsys", "doc could take over the world and it would probably be better for it.");
Comment com3vid3 = new Comment("NOTaSpamAccount", "CONGRADULATIONS! You won 1 free cruise! Follow link in my bio to cash in!");
Comment com4vid3 = new Comment("wow", "wow");
video3.AddComment(com1vid3);
video3.AddComment(com2vid3);
video3.AddComment(com3vid3);
video3.AddComment(com4vid3);
video3.DisplayVideo();

Console.WriteLine();