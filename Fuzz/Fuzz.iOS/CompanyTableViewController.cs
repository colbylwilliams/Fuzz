// This file has been autogenerated from a class added in the UI designer.

using System;

using Foundation;
using UIKit;
using System.Collections.Generic;
using Fuzz.Domain;
using Fuzz.Shared;

namespace Fuzz.iOS
{
	public partial class CompanyTableViewController : UITableViewController
	{
		List<Company> companies => OtisClient.Shared.Companies;

		public CompanyTableViewController (IntPtr handle) : base (handle) { }

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			TestDataProvider.InitTestDataAsync ();
		}

		public override nint RowsInSection (UITableView tableView, nint section) => companies.Count;


		public override UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
		{
			var cell = tableView.DequeueReusableCell ("companyCell", indexPath);

			var company = companies [indexPath.Row];

			cell.TextLabel.Text = company.Name;

			cell.DetailTextLabel.Text = $"{company.Elevators.Count} Elevators";

			return cell;
		}
	}
}