namespace Lab4;

// Объявляем публичный класс Track
public class Track 
{
    // Публичное свойство Name типа string
    public string Name { get; set; } 

    // Публичное свойство Album типа string
    public string Album { get; set; }

    // Объявляем конструктор класса Track, который инициализирует объект трека
    public Track(string name, string album) 
    {
        // Присваиваем полю Name значение, переданное в конструктор
        Name = name;

        // Присваиваем полю Album значение, переданное в конструктор
        Album = album; 
    }
}

// Объявляем класс Program
class Program 
{
    // Объявляем точку входа в программу с помощью статистического метода Main
    static void Main(string[] args) 
    {
        // Создаем новый список треков с именем tracks
        List<Track> tracks = new List<Track>() 
            {
                // Добавляем новые объекты Track в списки с именами и альбомами
                new Track("wokeuplikethis", "Playboi Carti"),
                new Track("magnolia", "Playboi Carti"),
                new Track("lookin", "Playboi Carti"),
                new Track("shoota", "Die Lit"), 
                new Track("long time", "Die Lit"), 
                new Track("rockstar made", "Whole Lotta Red")
            };

        // Объявляем запрос LINQ для упорядочивания треков по алфавиту в указанном альбоме
        string targetAlbum = "Playboi Carti";

        // Присваиваем переменной sortedTracks результат запроса LINQ
        var sortedTracks = tracks

            // Фильтруем список tracks, оставляя только треки из заданного альбома
            .Where(track => track.Album == targetAlbum)

            // Сортируем отфильтрованные треки по полю Name в алфавитном порядке
            .OrderBy(track => track.Name);

        // Выводим строку с названием альбома
        Console.WriteLine($"Треки из альбома '{targetAlbum}' в алфавитном порядке:");

        // Перебираем отсортированные треки в цикле
        foreach (var track in sortedTracks) 
        {
            // Выводим название каждого трека в консоль
            Console.WriteLine($"{track.Name}"); 
        }
    }
}