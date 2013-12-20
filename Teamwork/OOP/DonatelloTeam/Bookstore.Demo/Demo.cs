using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStore.Exceptions;

namespace BookStoreDemo
{
	class Demo
	{
		private static void DisplayMainMenu(MenuController libMenu)
		{
			ClearConsole();
			Console.WriteLine("Main Menu:");
			Console.WriteLine();
			Console.WriteLine("1 List Items");
			Console.WriteLine("2 Rent Item");
			Console.WriteLine("3 Return Item");
			Console.WriteLine(new string('=', 30));
			Console.WriteLine("4 Add New Item");
			Console.WriteLine("5 Remove Item");
			Console.WriteLine(new string('=', 30));
			Console.WriteLine("0 Exit");
			Console.WriteLine();
			Console.Write("Make a selection 1-5: ");

			short selection = ParseSelection(6);
			switch (selection)
			{
				case 1:
					DisplayCollectionTypesMenu(libMenu, true);
					break;
				case 2:
					DisplayRentItem(libMenu);
					break;
				case 3:
					DisplayReturnItem(libMenu);
					break;
				case 4:
					DisplayAddNewItem(libMenu);
					break;
				case 5:
					DisplayRemoveItem(libMenu);
					break;
				case 0:
					System.Environment.Exit(1);
					break;
				default:
					break;
			}
			
		}

		private static void DisplayRemoveItem(MenuController libMenu)
		{
			ClearConsole();
			Console.WriteLine("Remove an item from collections\n");
			Console.Write("Please, enter item barcode: ");
			string removeBarcode = Console.ReadLine();

			try
			{
				bool success = libMenu.RemoveItemByBarcode(removeBarcode);
				if (success == true)
				{
					Console.WriteLine("Successfully removed item with barcode: {0}.", removeBarcode);
				}
			}
			catch (ArgumentException barcodeNotFOund)
			{
				Console.WriteLine(barcodeNotFOund.Message);
			}
			finally
			{
				Console.WriteLine();
				Console.WriteLine("Press Enter to go back to main menu.");
				Console.ReadLine();

				DisplayMainMenu(libMenu);
			}
		}

		private static void DisplayAddNewItem(MenuController libMenu)
		{
			ClearConsole();
			Console.WriteLine("Add New Item to collections");
			Console.WriteLine();

			PrintCollectionTypesMenu(false);

			short selection = ParseSelection(6);
			ClearConsole();
			switch (selection)
			{
				case 2:
					DisplayNewBookForm(libMenu);
					break;
				case 3:
					DisplayNewNewspaperForm(libMenu);
					break;
				case 4:
					DisplayNewMagazineForm(libMenu);
					break;
				case 5:
					DisplayNewVideoForm(libMenu);
					break;
				case 6:
					DisplayNewAudioForm(libMenu);
					break;
				case 7:
					DisplayNewGameForm(libMenu);
					break;
				default:
					DisplayMainMenu(libMenu);
					break;
			}
		}

		/* Will server entering Title, Barcode and IsRentable */
		private static string[] DisplayItemGenericFormFields()
		{
			Console.WriteLine("Please, enter all necessary fields for a new Item\n\n");
			//string[] collectedFields = new string[3];

			string[] collectedFields = new string[3];

			// Title
			Console.Write("Title: ");
			collectedFields[0] = Console.ReadLine();

			// Barcode
			Console.Write("Bracode: ");
			collectedFields[1] = Console.ReadLine();

			// IsRentable
			Console.Write("Is available for rent take-out (y/n): ");

			// Check valid y/n input
			string yesNo;
			while (true)
			{
				yesNo = Console.ReadLine();
				if (yesNo == "y" || yesNo == "n")
				{
					collectedFields[2] = yesNo;
					return collectedFields;
				}
				else
				{
					Console.Write("Invalid choise, plsease enter 'y' or 'n': ");
				}
			}

		}
		
		/* Will server entering game specific info */
		private static void DisplayNewGameForm(MenuController libMenu)
		{
			Console.WriteLine("Add new Game\n");
			string[] genericFields = DisplayItemGenericFormFields();
			string[] gameFields = new string[7];
			genericFields.CopyTo(gameFields, 0);

			// Release
			Console.Write("Release: ");
			gameFields[3] = Console.ReadLine();

			Console.Write("Carrier (select 1 = CD | 2 = DVD | 3 = Blu-Ray): ");
			int newGameCarrier;
			while (true)
			{
				if (Int32.TryParse(Console.ReadLine(), out newGameCarrier))
				{
					if (newGameCarrier > 0 && newGameCarrier <= 3)
					{
						gameFields[4] = newGameCarrier.ToString();
						break;
					}
					else
					{
						Console.Write("Invalid Selection. Please choose between 1 and 3: ");
					}
				}
				else
				{
					Console.Write("Invalid Character. Please, enter a number between 1 and 3: ");
				}
			}

			Console.Write("Platform (select 1 = XBOX | 2 = Sega | 3 = Nintendo): ");
			int newGamePlatform;
			while (true)
			{
				if (Int32.TryParse(Console.ReadLine(), out newGamePlatform))
				{
					if (newGamePlatform > 0 && newGamePlatform <= 3)
					{
						gameFields[5] = newGamePlatform.ToString();
						break;
					}
					else
					{
						Console.Write("Invalid Selection. Please choose between 1 and 3: ");
					}
				}
				else
				{
					Console.Write("Invalid Character. Please, enter a number between 1 and 3: ");
				}
			}

			Console.Write("MPAA Rating (select 1 = PG12 | 2 = PG14 | 3 = PG18): ");
			int newGamePGRating;
			while (true)
			{
				if (Int32.TryParse(Console.ReadLine(), out newGamePGRating))
				{
					if (newGamePGRating > 0 && newGamePGRating <= 3)
					{
						gameFields[6] = newGamePGRating.ToString();
						break;
					}
					else
					{
						Console.Write("Invalid Selection. Please choose between 1 and 3: ");
					}
				}
				else
				{
					Console.Write("Invalid Character. Please, enter a number between 1 and 3: ");
				}
			}

			try
			{
				libMenu.AddNewGame(gameFields);
    			Console.WriteLine("\nSuccessfully added!");
			}
			catch (ArgumentNullException emptyArguments)
			{
				Console.WriteLine(emptyArguments.Message);
			}
			catch (ExistingItemException existException)
			{
				Console.WriteLine(existException.Message);
			}
			finally
			{
				Console.WriteLine("Press Enter key to return to Main Menu...");
				Console.ReadLine();
				DisplayMainMenu(libMenu);
			}
		}

		/* Will server entering audio specific info */
		private static void DisplayNewAudioForm(MenuController libMenu)
		{
			Console.WriteLine("Add new Audio\n");
			string[] genericFields = DisplayItemGenericFormFields();
			string[] audioFields = new string[6];
			genericFields.CopyTo(audioFields, 0);

			// Release
			Console.Write("Release: ");
			audioFields[3] = Console.ReadLine();

			Console.Write("Carrier (select 1 = CD | 2 = DVD | 3 = Blu-Ray): ");
			int newAudioCarrier;
			while (true)
			{
				if (Int32.TryParse(Console.ReadLine(), out newAudioCarrier))
				{
					if (newAudioCarrier > 0 && newAudioCarrier <= 3)
					{
						audioFields[4] = newAudioCarrier.ToString();
						break;
					}
					else
					{
						Console.Write("Invalid Selection. Please choose between 1 and 3: ");
					}
				}
				else
				{
					Console.Write("Invalid Character. Please, enter a number between 1 and 3: ");
				}
			}

			// Author
			Console.Write("Author: ");
			audioFields[5] = Console.ReadLine();

			try
			{
				libMenu.AddNewAudio(audioFields);
                Console.WriteLine("\nSuccessfully added!");
			}
			catch (ArgumentNullException emptyArguments)
			{
				Console.WriteLine(emptyArguments.Message);
			}
			catch (ExistingItemException existException)
			{
				Console.WriteLine(existException.Message);
			}
			finally
			{
				Console.WriteLine("Press Enter key to return to Main Menu...");
				Console.ReadLine();
				DisplayMainMenu(libMenu);
			}

		}

		/* Will server entering Video specific info */
		private static void DisplayNewVideoForm(MenuController libMenu)
		{
			Console.WriteLine("Add new Video\n");
			string[] genericFields = DisplayItemGenericFormFields();
			string[] videoFields = new string[6];
			genericFields.CopyTo(videoFields, 0);


			// Release
			Console.Write("Release: ");
			videoFields[3] = Console.ReadLine();

			Console.Write("Carrier (select 1 = CD | 2 = DVD | 3 = Blu-Ray): ");
			int newVideoCarrier;
			while (true)
			{
				if (Int32.TryParse(Console.ReadLine(), out newVideoCarrier))
				{
					if (newVideoCarrier > 0 && newVideoCarrier <= 3)
					{
						videoFields[4] = newVideoCarrier.ToString();
						break;
					}
					else
					{
						Console.Write("Invalid Selection. Please choose between 1 and 3: ");
					}
				}
				else
				{
					Console.Write("Invalid Character. Please, enter a number between 1 and 3: ");
				}
			}

			Console.Write("MPAA Rating (select 1 = PG12 | 2 = PG14 | 3 = PG18): ");
			int newVideoPGRating;
			while (true)
			{
				if (Int32.TryParse(Console.ReadLine(), out newVideoPGRating))
				{
					if (newVideoPGRating > 0 && newVideoPGRating <= 3)
					{
						videoFields[5] = newVideoCarrier.ToString();
						break;
					}
					else
					{
						Console.Write("Invalid Selection. Please choose between 1 and 3: ");
					}
				}
				else
				{
					Console.Write("Invalid Character. Please, enter a number between 1 and 3: ");
				}
			}

			try
			{
				libMenu.AddNewVideo(videoFields);
    			Console.WriteLine("\nSuccessfully added!");
			}
			catch (ArgumentNullException emptyArguments)
			{
				Console.WriteLine(emptyArguments.Message);
			}
			catch (ExistingItemException existException)
			{
				Console.WriteLine(existException.Message);
			}
			finally
			{
				Console.WriteLine("Press Enter key to return to Main Menu...");
				Console.ReadLine();
				DisplayMainMenu(libMenu);
			}

		}

		/* Will server entering Magazine specific info */
		private static void DisplayNewMagazineForm(MenuController libMenu)
		{
			Console.WriteLine("Add new Magazine\n");
			string[] genericFields = DisplayItemGenericFormFields();
			string[] magFields = new string[6];
			genericFields.CopyTo(magFields, 0);

			// Subject
			Console.Write("Magazine Subject/Category: ");
			magFields[3] = Console.ReadLine();

			// Date
			Console.Write("Issue Date (format DD.MM.YYYY): ");
			magFields[4] = Console.ReadLine();

			/* Issue */
			Console.Write("Issue number (enter a number): ");
			int NewMagIssue;
			while (true)
			{
				if (Int32.TryParse(Console.ReadLine(), out NewMagIssue))
				{
					magFields[5] = NewMagIssue.ToString();
					break;
				}
				else
				{
					Console.Write("Invalid Character. Please, enter a number: ");
				}
			}

			try
			{
                libMenu.AddNewMagazine(magFields);
				Console.WriteLine("\nSuccessfully added!");
			}
			catch (ArgumentNullException emptyArguments)
			{
				Console.WriteLine(emptyArguments.Message);
			}
			catch (ExistingItemException existException)
			{
				Console.WriteLine(existException.Message);
			}
			finally
			{
				Console.WriteLine("Press Enter key to return to Main Menu...");
				Console.ReadLine();
				DisplayMainMenu(libMenu);
			}
		}

		/* Will server entering Newspaper specific info */
		private static void DisplayNewNewspaperForm(MenuController libMenu)
		{
			Console.WriteLine("Add new Newspaper\n");
			string[] genericFields = DisplayItemGenericFormFields();
			string[] paperFields = new string[5];
			genericFields.CopyTo(paperFields, 0);

			// Date
			Console.Write("Issue Date (format DD.MM.YYYY): ");
			paperFields[3] = Console.ReadLine();

			/* Issue */
			Console.Write("Issue number (enter a number): ");
			int newPaperIssue;
			while (true)
			{
				if (Int32.TryParse(Console.ReadLine(), out newPaperIssue))
				{
					paperFields[4] = newPaperIssue.ToString();
					break;
				}
				else
				{
					Console.Write("Invalid Character. Please, enter a number: ");
				}
			}

			try
			{
                libMenu.AddNewNewspaper(paperFields);
				Console.WriteLine("\nSuccessfully added!");
			}
			catch (ArgumentNullException emptyArguments)
			{
				Console.WriteLine(emptyArguments.Message);
			}
			catch (ExistingItemException existException)
			{
				Console.WriteLine(existException.Message);
			}
			finally
			{
				Console.WriteLine("Press Enter key to return to Main Menu...");
				Console.ReadLine();
				DisplayMainMenu(libMenu);
			}
		}

		/* Will server entering Book specific info */
		private static void DisplayNewBookForm(MenuController libMenu)
		{
			Console.WriteLine("Add new Book\n");
			string[] genericFields = DisplayItemGenericFormFields();
			string[] bookFields = new string[4];
			genericFields.CopyTo(bookFields, 0);
			
			// Author
			Console.Write("Author: ");
			bookFields[3] = Console.ReadLine();

			try
			{
				libMenu.AddNewBook(bookFields);
				Console.WriteLine("\nSuccessfully added!");					
			}
			catch (ArgumentNullException emptyArguments)
			{
				Console.WriteLine(emptyArguments.Message);
			}
			catch (ExistingItemException existException)
			{
				Console.WriteLine(existException.Message);
			}
			finally
			{
				Console.WriteLine("Press Enter key to return to Main Menu...");
				Console.ReadLine();
				DisplayMainMenu(libMenu);
			}
		}

		private static void DisplayReturnItem(MenuController libMenu)
		{
			Console.WriteLine("Return item\n");
			Console.Write("Please, enter item barcode: ");
			string returnBarcode = Console.ReadLine();

			try
			{
				libMenu.ReturnItemByBarcode(returnBarcode);
    			Console.WriteLine("\nItem with barcode: {0} Returned!", returnBarcode);
			}
			catch (MoreUnitsThanDefinedException illegalReturn)
			{
				Console.WriteLine(illegalReturn.Message);
			}
            catch (ArgumentException barcodeNotFOund)
            {
                Console.WriteLine(barcodeNotFOund.Message);
            }
			finally
			{
				Console.WriteLine("Press Enter key to return to Main Menu...");
				Console.ReadLine();
				DisplayMainMenu(libMenu);
			}
			
		}

		private static void DisplayRentItem(MenuController libMenu)
		{
			Console.WriteLine("Rent Item\n");
			Console.Write("Please, enter item barcode: ");
			string rentBarcode = Console.ReadLine();

			try
			{
                libMenu.RentItemByBarcode(rentBarcode);
				Console.WriteLine("\nItem barcode: {0} Rented!", rentBarcode);					
			}
			catch (OutOfStockException outOfStock)
			{
				Console.WriteLine(outOfStock.Message);
			}
			catch (NotRentableException notAvailableToRent)
			{
				Console.WriteLine(notAvailableToRent.Message);
			}
            catch (ArgumentException barcodeNotFOund)
            {
                Console.WriteLine(barcodeNotFOund.Message);
            }
			finally
			{
				Console.WriteLine("Press Enter key to return to Main Menu...");
				Console.ReadLine();
				DisplayMainMenu(libMenu);
			}
		}

		private static void DisplayCollectionTypesMenu(MenuController libMenu, bool includeAllSelection = false)
		{
			ClearConsole();
			Console.WriteLine("Select a List type to view items:");
			Console.WriteLine();
			PrintCollectionTypesMenu(includeAllSelection);

			short selection = ParseSelection(7);
            switch (selection)
            {
                case 1:
                    DisplayCollectionItems(libMenu.GetCollectionItemsByType("All"));
                    break;
                case 2:
                    DisplayCollectionItems(libMenu.GetCollectionItemsByType("Books"));
                    break;
                case 3:
                    DisplayCollectionItems(libMenu.GetCollectionItemsByType("Newspapers"));
                    break;
                case 4:
                    DisplayCollectionItems(libMenu.GetCollectionItemsByType("Magazines"));
                    break;
                case 5:
                    DisplayCollectionItems(libMenu.GetCollectionItemsByType("Video"));
                    break;
                case 6:
                    DisplayCollectionItems(libMenu.GetCollectionItemsByType("Audio"));
                    break;
                case 7:
                    DisplayCollectionItems(libMenu.GetCollectionItemsByType("Games"));
                    break;
                default:
                    DisplayMainMenu(libMenu);
                    break;
            }

			Console.WriteLine("Press any key to return to List Items");
			Console.ReadLine();
			DisplayCollectionTypesMenu(libMenu, true);
		}

		private static void DisplayCollectionItems(string items)
		{
			ClearConsole();
			Console.WriteLine("Collection Items\n");
			Console.WriteLine(items);
		}

		private static void PrintCollectionTypesMenu(bool includeAllSelection = false)
		{
			if (includeAllSelection == true)
			{
				Console.WriteLine("1 All");
			}
			
			/* TODO: Add Metods for listing each category in Collection.ItemManager */
			Console.WriteLine(new string('-', 80));
			Console.WriteLine("2 Books");
			Console.WriteLine("3 Newspapers");
			Console.WriteLine("4 Magazines");
			Console.WriteLine("5 Video");
			Console.WriteLine("6 Audio");
			Console.WriteLine("7 Games");			
			Console.WriteLine();
			Console.WriteLine("0 Go To Main Menu");
			Console.WriteLine();
			if (includeAllSelection == true)
			{
				Console.Write("Please, make a selection 1-7: ");
			}
			else
			{
				Console.Write("Please, make a selection 1-6: ");
			}
		}

		private static short ParseSelection(short endRange)
		{
			short selection;

			while (true)
			{
				if (Int16.TryParse(Console.ReadLine(), out selection))
				{
					if (selection >= 0 && selection <= endRange)
					{
						return selection;
					}
					else
					{
						Console.Write("Invalid selection. Please, make a selection 1-{0}: ", endRange);
					}
				}
				else
				{
					Console.Write("Invalid character, please, enter a number for selection 1-{0}: ", endRange);
				}
			}
		}

		static void ClearConsole()
		{
			Console.Clear();
		}
		static void Main()
		{
			Console.WriteLine("Welcome to The Guinea Pig Bookstore");
			MenuController libMenu = new MenuController();
			DisplayMainMenu(libMenu);
		}
	}
}
