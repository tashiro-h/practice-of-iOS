using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using System.Collections.Generic;

namespace FifthApp
{
	public partial class TableViewController : UIViewController
	{
		private const string FileName = "data.xml";

		public TableViewController () : base ("TableViewController", null)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
			TableViewDelegate tDelegate = new TableViewDelegate ();
			tDelegate.TransferDetail += delegate {
				NavigationController.PushViewController (new DetailViewController (), false);
			};
			
			personTableView.Delegate = tDelegate;
			personTableView.DataSource = new DataSource (InitTableData ());

			titleLabel.Text = "Lists";
		}

		private List<Item> InitTableData ()
		{
//			string fileNmae = Path.Combine (Directory.GetCurrentDirectory (), FileName);
//			string source = "file://" + fileNmae;
//
//			XDocument xDocument = XDocument.Load (source);
//
//			var items = from c in xDocument.Descendants ("item")
//			            select new Item {
//				name = (string)c.Element ("name"),
//				pref = (string)c.Element ("pref")
//			};

			List<Item> itemList = new List<Item> ();

			Item tashiro = new Item ();
			tashiro.name = "tashiro";
			tashiro.pref = "tokyo";
			itemList.Add (tashiro);

			Item jito = new Item ();
			jito.name = "jito";
			jito.pref = "tokyo";
			itemList.Add (jito);

			Item mitsu = new Item ();
			mitsu.name = "mitsu";
			mitsu.pref = "fukuoka";
			itemList.Add (mitsu);

			return itemList;
		}
	}

	public class Item
	{
		public Item ()
		{

		}

		public string name;
		public string pref;
	}

	public class TableViewDelegate : UITableViewDelegate
	{
		public event EventHandler<EventArgs> TransferDetail;
		// 行選択時に処理される
		public override void RowSelected (UITableView tableView, NSIndexPath indexPath)
		{
			TransferDetail (null, null);

		}
	}

	public class DataSource : UITableViewDataSource
	{
		private List<Item> itemList = new List<Item> ();

		public DataSource (List<Item> itemList)
		{
			this.itemList = itemList;
		}
		// 行数を返す
		public override int RowsInSection (UITableView tableView, int section)
		{
			return itemList.Count;
		}
		// セルを返す
		public UITableViewCell CellForRowAtIndexPath (NSIndexPath indexPath)
		{
			return new UITableViewCell ();
		}

		public override UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
		{
			UITableViewCell cell = new UITableViewCell ();
			cell.TextLabel.Text = itemList [indexPath.Row].name;
			return cell;
		}
	}
}

