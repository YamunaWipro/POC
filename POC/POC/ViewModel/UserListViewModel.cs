using POC;
using POC.Model;
using System.Collections.ObjectModel;
using System.Linq;

namespace POC
{
    public class UserListViewModel
    {
        public ObservableCollection<DetailsModel> Monkeys { get; set; }
        public ObservableCollection<Grouping<string, DetailsModel>> MonkeysGrouped { get; set; }

        public UserListViewModel()
        {

            Monkeys = UserDetailsHelper.Monkeys;
        }

        public int MonkeyCount => Monkeys.Count;
    }
}
