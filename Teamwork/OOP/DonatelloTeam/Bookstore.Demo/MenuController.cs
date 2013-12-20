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
	public class MenuController
	{
		public ItemList collection;
		public MenuController()
		{
            collection = new ItemList();
            GetTextInput.LoadFromFile("../../lib.txt", collection);
		}

		/* Display items by type - get Bookstore.Collection.List by type and print on console */
		public string GetCollectionItemsByType(string collectionType)
		{
            switch (collectionType)
            {
                case "All":
                    return this.collection.ToText();
                default:
                    return this.collection.ToText(collectionType);
            }
		}

		/* call BookStore.Collection.Remove(barcode) method to remove the item */
		public bool RemoveItemByBarcode(string itemBarcode)
		{
            return this.collection.Remove(itemBarcode);
		}

		/* Call BookStore.Collection.Rent by barcode Item */
		public void RentItemByBarcode(string itemBarcode)
		{
            this.collection.RentItem(itemBarcode);
		}

		/* Call BookStore.Collection.Return by barcode Item */
		public void ReturnItemByBarcode(string itemBarcode)
		{
			this.collection.ReturnItem(itemBarcode);
        }

		/**
		 * Adding new items to collection
		 * */

		/* Get the carrier choise value */
		private static Carrier GetCarrierEnumValue(int index)
		{
			switch (index)
			{
				case 1:
					return Carrier.CD;					
				case 2:
					return Carrier.DVD;
				case 3:
					return Carrier.BlyRay;
				default:
					throw new ArgumentException("Invalid index for enumeration");
			}
		}

		/* Get the platform choise value */
		private static Platform GetPlatforEnumValue(int index)
		{
			switch (index)
			{
				case 1:
					return Platform.Xbox;
				case 2:
					return Platform.Sega;
				case 3:
					return Platform.Nintendo;
				default:
					throw new ArgumentException("Invalid index for enumeration");
			}
		}

		/* Get the pgrating choise value */
		private static PGRaiting GetPGRaitingEnumValue(int index)
		{
			switch (index)
			{
				case 1:
					return PGRaiting.PGR12;
				case 2:
					return PGRaiting.PGR14;
				case 3:
					return PGRaiting.PGR18;
				default:
					throw new ArgumentException("Invalid index for enumeration");
			}
		}

		/* Call Bookstore.AddGame() */
		public void AddNewGame(string[] fields)
		{
			string title = fields[0];
			string barcode = fields[1];
			
			bool isRentable;
			switch (fields[2])
			{
				case "y":
					isRentable = true;
					break;
				case "n":
					isRentable = false;
					break;
				default:
					throw new ArgumentException("Invalid bool index");
			}

			string release = fields[3];
            Carrier carrier = GetCarrierEnumValue(Int32.Parse(fields[4]));
			Platform platform = GetPlatforEnumValue(Int32.Parse(fields[5]));
			PGRaiting pgRating = GetPGRaitingEnumValue(Int32.Parse(fields[6]));

			collection.AddGame(title, release, barcode, 1, carrier, platform, pgRating, isRentable);
		}

		/* Call Bookstore.AddMusic() */
		public void AddNewAudio(string[] fields)
		{
			string title = fields[0];
			string barcode = fields[1];

			bool isRentable;
			switch (fields[2])
			{
				case "y":
					isRentable = true;
					break;
				case "n":
					isRentable = false;
					break;
				default:
					throw new ArgumentException("Invalid bool index");
			}

			string release = fields[3];
			Carrier carrier = GetCarrierEnumValue(Int32.Parse(fields[4]));

			string author = fields[5];

			this.collection.AddMusic(title, author, barcode, release, 1, carrier, isRentable);

/*			bool success = false;
			if (collections.ItemsCollection.FindByBarcode(barcode).Units > 0)
			{
				success = true;
			}

			return success;
 */
		}

		/* Call Bookstore.AddVIdeo() */
		public void AddNewVideo(string[] fields)
		{
			string title = fields[0];
			string barcode = fields[1];

			bool isRentable;
			switch (fields[2])
			{
				case "y":
					isRentable = true;
					break;
				case "n":
					isRentable = false;
					break;
				default:
					throw new ArgumentException("Invalid bool index");
			}

			string release = fields[4];
			Carrier carrier = GetCarrierEnumValue(Int32.Parse(fields[4]));
			var pgRating = GetPGRaitingEnumValue(Int32.Parse(fields[5]));

/*			if (collections.ItemsCollection.FindByBarcode(barcode) != null)
			{
				Exception ExistingItemException = new Exception("Item already exists");
				throw ExistingItemException;
			}

			collections.ItemsCollection.AddVideo(title, release, barcode, 1, carrier, pgRating, isRentable);

			bool success = false;
			if (collections.ItemsCollection.FindByBarcode(barcode).Units > 0)
			{
				success = true;
			}

			return success;
 */

            collection.AddVideo(title, release, barcode, 1, carrier, pgRating, isRentable);
		}


		/* Call Bookstore.AddMagazine() */
		public void AddNewMagazine(string[] fields)
		{
			string title = fields[0];
			string barcode = fields[1];
			string subject = fields[3];

/*			bool isRentable;
			switch (fields[2])
			{
				case "y":
					isRentable = true;
					break;
				case "n":
					isRentable = false;
					break;
				default:
					throw new ArgumentException("Invalid bool index");
			} */

			string dateIssue = fields[4];
			int issue = Int32.Parse(fields[5]);

			/*if (collections.ItemsCollection.FindByBarcode(barcode) != null)
			{
				Exception ExistingItemException = new Exception("Item already exists");
				throw ExistingItemException;
			}

			collections.ItemsCollection.AddMagazine(title, subject, barcode, dateIssue, issue, 1);

			bool success = false;
			if (collections.ItemsCollection.FindByBarcode(barcode).Units > 0)
			{
				success = true;
			}

			return success;
             */

            collection.AddMagazine(title, subject, barcode, dateIssue, issue, 1);
		}

		/* Call Bookstore.AddMagazine() */
		public void AddNewNewspaper(string[] fields)
		{
			string title = fields[0];
			string barcode = fields[1];

/*			bool isRentable;
			switch (fields[2])
			{
				case "y":
					isRentable = true;
					break;
				case "n":
					isRentable = false;
					break;
				default:
					throw new ArgumentException("Invalid bool index");
			} */

			string dateIssue = fields[3];
			int issue = Int32.Parse(fields[4]);

/*			if (collections.ItemsCollection.FindByBarcode(barcode) != null)
			{
				Exception ExistingItemException = new Exception("Item already exists");
				throw ExistingItemException;
			}

			collections.ItemsCollection.AddPaper(title, barcode, dateIssue, issue, 1);

			bool success = false;
			if (collections.ItemsCollection.FindByBarcode(barcode).Units > 0)
			{
				success = true;
			}

			return success;
 */
            collection.AddPaper(title, barcode, dateIssue, issue, 1);
    	}

		/* Call Bookstore.AddMagazine() */
		public void AddNewBook(string[] fields)
		{
			string title = fields[0];
			string barcode = fields[1];

			bool isRentable;
			switch (fields[2])
			{
				case "y":
					isRentable = true;
					break;
				case "n":
					isRentable = false;
					break;
				default:
					throw new ArgumentException("Invalid bool index");
			}

			string author = fields[3];

/*			if (collections.ItemsCollection.FindByBarcode(barcode) != null)
			{
				throw new BookStore.Exceptions.ExistingItemException();
			}

			collections.ItemsCollection.AddBook(title, author, barcode, 1, isRentable);

			bool success = false;
			if (collections.ItemsCollection.FindByBarcode(barcode).Units > 0)
			{
				success = true;
			}

			return success;
 */
            collection.AddBook(title, author, barcode, 1, isRentable);
		}
	}
}
