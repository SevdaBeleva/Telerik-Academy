using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStore;
using BookStore.Collection;
using BookStore.Interfaces;

namespace BookStoreDemo
{
	public class CollectionsController
	{
		private ItemList itemsCollection;

		public ItemList ItemsCollection
		{
			get { return itemsCollection; }
			set { itemsCollection = value; }
		}

		public CollectionsController()
		{
			this.ItemsCollection = new ItemList();
            GetTextInput.LoadFromFile("../../lib.txt", ItemsCollection);
			this.ItemsCollection.AddBook("Book 1", "Author", "12", 1);
			this.ItemsCollection.AddPaper("Newspaper 1", "123", "20.02.2002", 1, 1);
			this.ItemsCollection.AddMagazine("Magazine 1", "Hi-Fi", "1234", "20.02.2002", 1, 1);
            this.ItemsCollection.AddMusic("Music 1", "Singer", "12345", "release 1", 1, Carrier.BlyRay);
			this.ItemsCollection.AddVideo("Video 1", "Release", "123456", 1, Carrier.BlyRay, PGRaiting.PGR18);
			this.ItemsCollection.AddGame("Game 1", "Release 1", "1234567", 1, Carrier.BlyRay, Platform.Nintendo, PGRaiting.PGR18);
			/* TODO: if we habe a file db, load collection items */
		}


	}
}
