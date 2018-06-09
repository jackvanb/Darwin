using System;
using System.Collections.Generic;
using FreshMvvm;
namespace Darwin.PageModels
{
	public class NotificationsPageModel : FreshBasePageModel
    {
		public List<Models.Notifications> Notifications { get; set; }
		
        public NotificationsPageModel()
        {
			Notifications = new List<Models.Notifications> {
				new Models.Notifications() { Title="Himank added you as a friend.", Description= "Yesterday at 6:20 PM"},
				new Models.Notifications() { Title="Jack liked your playlist.", Description= "Yesterday at 3:13 PM"},
				new Models.Notifications() { Title="Tung sent you a friend request.", Description= "Wednesday at 10:25 AM"},
				new Models.Notifications() { Title="Eric sent you a friend request.", Description= "Wednesday at 9:16 AM"},
				new Models.Notifications() { Title="New Episode from 'Serial'.", Description="Tuesday at 12:10 PM"},
				new Models.Notifications() { Title="Hannah liked your playlist.", Description="Monday at 8:30 PM"},
				new Models.Notifications() {Title="Darwin Recomendations.", Description= "Monday at 7:25 AM"},
			};
        }
    }
}
