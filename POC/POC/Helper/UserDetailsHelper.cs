using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using POC.Model;
using System.Linq;
using POC.Helper;
namespace POC
{
    public static class UserDetailsHelper
    {

        private static Random random;
      

        public static DetailsModel GetRandomMonkey()
        {
            //var output = Newtonsoft.Json.JsonConvert.SerializeObject(Monkeys);
            return Monkeys[random.Next(0, Monkeys.Count)];
        }


        public static ObservableCollection<Grouping<string, DetailsModel>> MonkeysGrouped { get; set; }

        public static ObservableCollection<DetailsModel> Monkeys { get; set; }

        static UserDetailsHelper()
        {
            random = new Random();
            Monkeys = new ObservableCollection<DetailsModel>();
            Monkeys.Add(new DetailsModel
            {
                Name = AppConstants.object1.Name,
                Location = AppConstants.object1.Location,
                Details=AppConstants.object1.Details,
                Image=AppConstants.object1.Image

               
            });

            Monkeys.Add(new DetailsModel
            {
                Name = AppConstants.object2.Name,
                Location = AppConstants.object2.Location,
                Details = AppConstants.object2.Details,
                Image = AppConstants.object2.Image
            });

            Monkeys.Add(new DetailsModel
            {
                Name = AppConstants.object3.Name,
                Location = AppConstants.object3.Location,
                Details = AppConstants.object3.Details,
                Image = AppConstants.object3.Image

            });


            Monkeys.Add(new DetailsModel
            {
                Name = AppConstants.object4.Name,
                Location = AppConstants.object4.Location,
                Details = AppConstants.object4.Details,
                Image = AppConstants.object4.Image

            });

            Monkeys.Add(new DetailsModel
            {
                Name = AppConstants.object5.Name,
                Location = AppConstants.object5.Location,
                Details = AppConstants.object5.Details,
                Image = AppConstants.object5.Image

            });

            Monkeys.Add(new DetailsModel
            {
                Name = AppConstants.object6.Name,
                Location = AppConstants.object6.Location,
                Details = AppConstants.object6.Details,
                Image = AppConstants.object6.Image

            });

            Monkeys.Add(new DetailsModel
            {
                Name = AppConstants.object7.Name,
                Location = AppConstants.object7.Location,
                Details = AppConstants.object7.Details,
                Image = AppConstants.object7.Image

            });

            Monkeys.Add(new DetailsModel
            {
                Name = AppConstants.object8.Name,
                Location = AppConstants.object8.Location,
                Details = AppConstants.object8.Details,
                Image = AppConstants.object8.Image

            });

            Monkeys.Add(new DetailsModel
            {
                Name = AppConstants.object9.Name,
                Location = AppConstants.object9.Location,
                Details = AppConstants.object9.Details,
                Image = AppConstants.object9.Image

            });


            var sorted = from monkey in Monkeys
                         orderby monkey.Name
                         group monkey by monkey.NameSort into monkeyGroup
                         select new Grouping<string, DetailsModel>(monkeyGroup.Key, monkeyGroup);

            MonkeysGrouped = new ObservableCollection<Grouping<string, DetailsModel>>(sorted);

        }
    }
}
