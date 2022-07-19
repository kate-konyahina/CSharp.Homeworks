// See https://aka.ms/new-console-template for more information
using HW._09.Task3;

Console.WriteLine("Hello, World!");

Film[] films = new Film[2];
films[0] = new Film("Drive", "123", "drama", 13, "Nicolas Winding Refn", "Ryan Gosling", "Carey Mulligan");
films[1] = new Film("Vertigo", "124", "thriller", 9, "Alfred hitchcock", "James Stewart", "Kim Novak");

for (int i = 0; i < films.Length; i++)
{
    films[i].Play();
    films[i]. RetrieveInformation();
}

Music[] songs = new Music[2];
songs[0] = new Music("Build a Bridge", "12345", "rock", 16, "Limp Bizkit", 225);
songs[0] = new Music("Adams song", "12344", "pop-punk", 12, "Blink-182", 180);

for (int i = 0; i < songs.Length; i++)
{
    songs[i].Play();
    songs[i].RetrieveInformation();
}

ComputerProgram[] computerPrograms = new ComputerProgram[2];
computerPrograms[0] = new ComputerProgram("Genshin", "0987", "game", 12);
computerPrograms[1] = new ComputerProgram("Player", "0986", "standart", 5);