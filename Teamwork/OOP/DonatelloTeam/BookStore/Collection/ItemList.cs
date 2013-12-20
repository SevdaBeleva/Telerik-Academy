using System;
using System.Linq;
using System.Collections.Generic;
using BookStore.Items;
using BookStore.Interfaces;
using BookStore.Exceptions;
using System.Text;


namespace BookStore.Collection
{
    public class ItemList : ICollection<BookStoreItem>
    {
        private List<BookStoreItem> collection;
        public int Count { get { return this.collection.Count; } }
        public bool IsReadOnly { get { return false; } }

        public ItemList()
        {
            this.collection = new List<BookStoreItem>();
        }

        public BookStoreItem this[int index]
        {
            get
            {
                if (index < 0 || index > this.Count - 1)
                {
                    throw new IndexOutOfRangeException("Index outside the bounds of the collection");
                }
                return collection[index];
            }
            set
            {
                if (index < 0 || index > this.Count - 1)
                {
                    throw new IndexOutOfRangeException("Index outside the bounds of the collection");
                }
                this.collection[index] = value;
            }
        }

        public void Add(BookStoreItem item)
        {
            if (this.IsReadOnly)
            {
                throw new NotSupportedException("The collection of library items is read-only");
            }
            if (this.FindByBarcode(item.Barcode) != null)
            {
                throw new ExistingItemException(string.Format("Item with barcode {0} already exists in collection", item.Barcode));
            }

            this.collection.Add(item);
        }

        public void AddBook(string title, string author, string barcode, byte units, bool isRentable = true)
        {
            if (barcode == null || author == null || title == null)
            {
                throw new ArgumentNullException("Can't create book with null arguments");
            }

            this.Add(new Book(title, author, barcode, units, isRentable));
        }

        public void AddMagazine(string title, string subject, string barcode, string dateOfIssue, int issue, byte units)
        {
            if (barcode == null || subject == null || title == null)
            {
                throw new ArgumentNullException("Can't create magazine with null arguments");
            }

            this.Add(new Magazines(title, subject, dateOfIssue, issue, units, barcode));
        }

        public void AddPaper(string title, string barcode, string dateOfIssue, int issue, byte units, int sections = 0, int numberOfArticles = 0)
        {
            if (barcode == null || dateOfIssue == null || title == null)
            {
                throw new ArgumentNullException("Can't create newspaper with null arguments");
            }

            this.Add(new Paper(title, dateOfIssue, issue, units, barcode, sections, numberOfArticles));
        }

        public void AddGame(string title, string release, string barcode, byte units, Carrier carrier, Platform platform, PGRaiting pgRating, bool isRentable = true)
        {
            if (barcode == null || release == null || title == null)
            {
                throw new ArgumentNullException("Can't create game with null arguments");
            }

            this.Add(new Games(title, release, carrier, platform, pgRating, barcode, units, isRentable));
        }

        public void AddVideo(string title, string release, string barcode, byte units, Carrier carrier, PGRaiting pgRating, bool isRentable = true)
        {
            if (barcode == null || title == null)
            {
                throw new ArgumentNullException("Can't create video with null arguments");
            }

            this.Add(new Video(title, release, carrier, pgRating, barcode, units, isRentable));
        }

        public void AddMusic(string title, string author, string barcode, string release, byte units, Carrier carrier, bool isRentable = true)
        {
            if (barcode == null || author == null || title == null)
            {
                throw new ArgumentNullException("Can't create music album with null arguments");
            }

            this.Add(new Music(title, author, release, carrier, barcode, units, isRentable));
        }

        public void Clear()
        {
            if (this.IsReadOnly)
            {
                throw new NotSupportedException("The collection of library items is read-only");
            }

            this.collection.Clear();
        }

        public bool Contains(BookStoreItem item)
        {
            return collection.Contains(item);
        }

        public void CopyTo(BookStoreItem[] array, int arrayIndex)
        {
            if (array == null)
            {
                throw new ArgumentNullException("Destination array not initialized!");
            }

            if (arrayIndex < 0)
            {
                throw new ArgumentOutOfRangeException("Index can't be a negative number!");
            }

            if (arrayIndex > this.Count - 1)
            {
                throw new ArgumentOutOfRangeException("Index outside bounds of the collection!");
            }

            if (this.Count > (array.Length - arrayIndex - 1))
            {
                throw new ArgumentException("Destination array insufficient capacity!");
            }

            this.collection.CopyTo(array, arrayIndex);
        }

        public bool Remove(BookStoreItem item)
        {
            if (this.IsReadOnly)
            {
                throw new NotSupportedException("The collection of library items is read-only");
            }

            return this.collection.Remove(item);
        }

        public bool Remove(string barcode)
        {
            BookStoreItem item = this.FindByBarcode(barcode);
            if (item == null)
            {
                throw new ArgumentException("Barcode not found!");
            }

            return this.Remove(item);
        }

        public bool Remove(int index)
        {
            if (index < 0 || index > this.Count)
            {
                throw new IndexOutOfRangeException("Index outside the bounds of the collection");
            }

            return this.Remove(this.collection[index]);
        }

        /**
         * Select item by barcode
         * */
        public BookStoreItem FindByBarcode(string barcode)
        {

			var itemExist = this.collection.Exists(item => item.Barcode == barcode);

			if (!itemExist)
			{
				return null;
			}

            var itemByBarcode =
                from itemsByBarcode in this.collection
                where itemsByBarcode.Barcode == barcode
                select itemsByBarcode;

            /* return found item, null if not found */
            return itemByBarcode.ElementAt(0) as BookStoreItem;
        }

        //Searches given string in all items data
        public List<BookStoreItem> Search(string substring)
        {
            if (substring == null)
            {
                return null;
            }

            List<BookStoreItem> found = new List<BookStoreItem>();

            foreach (var item in this.collection)
            {
                if (item.ToString().ToLower().IndexOf(substring.ToLower()) >= 0)
                {
                    found.Add(item);
                }
            }

            return found;
        }

        public void RentItem(string barcode)
        {
            BookStoreItem item = this.FindByBarcode(barcode);
            if (item == null)
            {
                throw new ArgumentException("Barcode not found!");
            }

            item.Rent();
        }

        public void RentItem(int index)
        {
            if (index < 0 || index > this.Count)
            {
                throw new IndexOutOfRangeException("Index outside the bounds of the collection"); 
            }
                
            this.collection[index].Rent();
        }

        public void ReturnItem(string barcode)
        {
            BookStoreItem item = this.FindByBarcode(barcode);
            if (item == null)
            {
                throw new ArgumentException("Barcode not found!");
            }

            item.Return();
        }

        public void ReturnItem(int index)
        {
            if (index < 0 || index > this.Count)
            {
                throw new IndexOutOfRangeException("Index outside the bounds of the collection");
            }

            this.collection[index].Return();
        }

        public string ToText()
        {
            if (this.Count <= 0)
            {
                return "Empty!";
            }

            StringBuilder text = new StringBuilder();
            string separator = "\r\n";

            List<BookStoreItem> sorted = this.collection;

            sorted.Sort((item1, item2) => (item1.GetType().Name.CompareTo(item2.GetType().Name)));
            string Type = String.Empty;

            for (int i = 0; i < sorted.Count; i++)
			{
                if (!Type.Equals(sorted[i].GetType().Name))
                {
                    Type = sorted[i].GetType().Name;
                    text.Append(separator);
                    text.Append(Type.ToUpper());
                    text.Append(separator);
                    text.Append("--------------------------");
                    text.Append(separator);
                }

                text.Append(separator);
                text.Append((i + 1).ToString());
                text.Append(".");
                text.Append(separator);
                text.Append(sorted[i].ToText());
                text.Append(separator);
            }

            return text.ToString();
        }

        public string ToText(string category)
        {
            System.Type Type;
            switch(category)
            {
                case "Books" : Type = new Book("0","0","0",0).GetType(); break;
                case "Newspaper" : Type = new Paper("0","0",0,0,"0",0,0).GetType(); break;
                case "Magazines" : Type = new Magazines("0","0","0",0,0,"0").GetType(); break;
                case "Video" : Type = new Video("0","0",0,0,"0",0,false).GetType(); break;
                case "Audio" : Type = new Music("0","0","0",0,"0",0,false).GetType(); break;
                case "Games" : Type = new Games("0","0",0,0,0,"0",0,false).GetType(); break;

                default: return "Category Not Found!";
            }

            List<BookStoreItem> filtered = this.collection.FindAll((item) => (item.GetType() == Type));
            if (filtered.Count <= 0)
            {
                return "None available";
            }

            StringBuilder text = new StringBuilder();
            string separator = "\r\n";

            text.Append(separator);
            text.Append(Type.Name.ToUpper());
            text.Append(separator);
            text.Append("--------------------------");
            text.Append(separator);
            
            for (int i = 0; i < filtered.Count; i++)
			{
                text.Append(separator);
                text.Append((i + 1).ToString());
                text.Append(".");
                text.Append(separator);
                text.Append(filtered[i].ToText());
                text.Append(separator);			 
			}

            return text.ToString();
        }

        /**
         * Include IEnumerator by interface
         **/
        public IEnumerator<BookStoreItem> GetEnumerator()
        {
            System.Collections.IEnumerator ie = this.collection.GetEnumerator();
            while (ie.MoveNext())
            {
                yield return (ie.Current as BookStoreItem);
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            System.Collections.IEnumerator ie = this.collection.GetEnumerator();
            while (ie.MoveNext())
            {
                yield return ie.Current;
            }
        }
    }
}
