using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStore;
using BookStore.Collection;
using BookStore.Interfaces;
using System.IO;

namespace BookStoreDemo
{
    public static class GetTextInput
    {
        public static bool LoadFromFile(string fileName, ItemList Lib)
        {
/*            List<Book> BooksItems = new List<Book>();
            List<Music> MusicItems = new List<Music>();
            List<Games> GamesItems = new List<Games>();
            List<Video> VideoItems = new List<Video>();
            List<Paper> PaperItems = new List<Paper>();
            List<Magazines> MagazinesItems = new List<Magazines>();
 */ 
            using (StreamReader reader = new StreamReader(@fileName, Encoding.GetEncoding("windows-1251")))
            {
                string currentAdd = string.Empty;

                while (reader.Peek() >= 0)
                {
                    string line = reader.ReadLine();

                    string[] strArray = line.Split(',');

                    switch (line)
                    {
                        case "BOOK":
                            {
                                line = reader.ReadLine();
                                currentAdd = "BOOK";
                                strArray = line.Split(',');
                            }
                            break;
                        case "MUSIC":
                            {
                                line = reader.ReadLine();
                                currentAdd = "MUSIC";
                                strArray = line.Split(',');
                            }
                            break;
                        case "GAMES":
                            {
                                line = reader.ReadLine();
                                currentAdd = "GAMES";
                                strArray = line.Split(',');
                            }
                            break;
                        case "VIDEO":
                            {
                                line = reader.ReadLine();
                                currentAdd = "VIDEO";
                                strArray = line.Split(',');
                            }
                            break;
                        case "PAPER":
                            {  
                                line = reader.ReadLine();
                                currentAdd = "PAPER";
                                strArray = line.Split(',');
                            }
                            break;
                        case "MAGAZINES":
                            {
                                line = reader.ReadLine();
                                currentAdd = "MAGAZINES";
                                strArray = line.Split(',');
                            }
                            break;
                        default: { break; }
                    }

                    if (currentAdd == "BOOK")
                    {
                        /*Book currentBook = new Book(strArray[0], strArray[1], strArray[2], byte.Parse(strArray[3]), 
                                Convert.ToBoolean(strArray[4]));
                        BooksItems.Add(currentBook); */
                        Lib.AddBook(strArray[0], strArray[1], strArray[2], byte.Parse(strArray[3]), 
                                Convert.ToBoolean(strArray[4]));
                    }
                    else if (currentAdd == "MUSIC")
                    {
                        /*Music currentMusic = new Music(strArray[0], strArray[1], strArray[2], (Carrier)Enum.Parse(typeof(Carrier), strArray[3]),
                            strArray[4], byte.Parse(strArray[5]), Convert.ToBoolean(strArray[6]));
                        MusicItems.Add(currentMusic);*/
                        Lib.AddMusic(strArray[0], strArray[2], strArray[4], strArray[1], byte.Parse(strArray[5]),
                            (Carrier)Enum.Parse(typeof(Carrier), strArray[3]), Convert.ToBoolean(strArray[6]));
                    }
                    else if (currentAdd == "GAMES")
                    {
                        /*Games currentGames = new Games(strArray[0], strArray[1], (Carrier)Enum.Parse(typeof(Carrier), strArray[2]),
                            (Platform)Enum.Parse(typeof(Platform), strArray[3]), (PGRaiting)Enum.Parse(typeof(PGRaiting), strArray[4]), 
                            strArray[5], byte.Parse(strArray[6]), Convert.ToBoolean(strArray[7]));
                        GamesItems.Add(currentGames);*/
                        Lib.AddGame(strArray[0], strArray[1],  strArray[5], byte.Parse(strArray[6]), 
                            (Carrier)Enum.Parse(typeof(Carrier),strArray[2]),
                            (Platform)Enum.Parse(typeof(Platform), strArray[3]),
                            (PGRaiting)Enum.Parse(typeof(PGRaiting), strArray[4]),
                            Convert.ToBoolean(strArray[7]));
                    }
                    else if (currentAdd == "VIDEO")
                    {
                        /*Video currentVideo = new Video(strArray[0], strArray[1], (Carrier)Enum.Parse(typeof(Carrier), strArray[2]), 
                            (PGRaiting)Enum.Parse(typeof(PGRaiting), strArray[3]), strArray[4], byte.Parse(strArray[5]), Convert.ToBoolean(strArray[6]));
                        VideoItems.Add(currentVideo);*/
                        Lib.AddVideo(strArray[0], strArray[1], strArray[4], byte.Parse(strArray[5]),
                            (Carrier)Enum.Parse(typeof(Carrier), strArray[2]),
                            (PGRaiting)Enum.Parse(typeof(PGRaiting), strArray[3]), 
                            Convert.ToBoolean(strArray[6]));
                    }
                    else if (currentAdd == "PAPER")
                    {
                        /*Paper currentPaper = new Paper(strArray[0], strArray[1], int.Parse(strArray[2]), byte.Parse(strArray[3]), strArray[4], 
                             int.Parse(strArray[5]), int.Parse(strArray[6]));
                        PaperItems.Add(currentPaper);*/
                        Lib.AddPaper(strArray[0], strArray[4], strArray[1], int.Parse(strArray[2]), byte.Parse(strArray[3]),
                             int.Parse(strArray[5]), int.Parse(strArray[6]));

                    }
                    else if (currentAdd == "MAGAZINES")
                    {
                        /*Magazines currentMagazines = new Magazines(strArray[0], strArray[1], strArray[2], int.Parse(strArray[3]),
                                            byte.Parse(strArray[4]), strArray[5]);
                        MagazinesItems.Add(currentMagazines);*/
                        Lib.AddMagazine(strArray[0], strArray[1], strArray[5], strArray[2], int.Parse(strArray[3]),
                            byte.Parse(strArray[4]));
                    }
                }
            }

            return true;

/*            if (BooksItems != null)
            {
                Lib.AddRange(BooksItems);
            }
            if (MusicItems != null)
            {
                Lib.AddRange(MusicItems);
            }
            if (VideoItems != null)
            {
                Lib.AddRange(VideoItems);
            }
            if (GamesItems != null)
            {
                Lib.AddRange(GamesItems);
            }
            if (PaperItems != null)
            {
                Lib.AddRange(PaperItems);
            }
            if (MagazinesItems != null)
            {
                Lib.AddRange(MagazinesItems);
            }
            return Lib;
 */
        }

    }
}
