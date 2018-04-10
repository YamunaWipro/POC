using POC;
using POC.Model;
using System.Collections.ObjectModel;
using System.Linq;

namespace POC
{
    public class UserListViewModel
    {
        public static class ViewModelLocator
        {
            static UserListViewModel monkeysVM;
            public static UserListViewModel MonkeysViewModel
            => monkeysVM ?? (monkeysVM = new UserListViewModel());

            static DetailsViewModel detailsVM;
            public static DetailsViewModel DetailsViewModel
            => detailsVM ?? (detailsVM = new DetailsViewModel(UserDetailsHelper.Monkeys[0]));
        }
        public ObservableCollection<DetailsModel> Monkeys { get; set; }
        public ObservableCollection<Grouping<string, DetailsModel>> MonkeysGrouped { get; set; }

        public UserListViewModel()
        {

            Monkeys = UserDetailsHelper.Monkeys;
        }

        public int MonkeyCount => Monkeys.Count;
    }
}
