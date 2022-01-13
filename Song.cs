namespace FCC_CS_Full_Course
{
    class Song
    {
        public string title;
        public string artist;
        public int duration;
        public static int songCount;

        public Song(string aTitle, string aArtist, int aDuration)
        {
            title = aTitle;
            artist = aArtist;
            duration = aDuration;
            songCount++;
        }

        public void AddSongs()
        {
            Song holiday = new Song("Holiday", "Green Day", 200);
            Song kashmir = new Song("Kashmir", "Led Zeppelin", 150);

            Console.WriteLine(Song.songCount);
            Console.WriteLine(kashmir.GetSongCount);

            Console.ReadLine();

        }

        public int GetSongCount()
        {
            return songCount;
        }

    }
}