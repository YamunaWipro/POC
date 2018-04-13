using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace POC.Helper
{
    public class AppConstants : ContentPage
    {
        public static DetailsModel object1 = new DetailsModel
        { Name= "Baboon",
            Location = "Africa",
            Details= "Baboons are African and Arabian Old World monkeys belonging to the genus Papio, part of the subfamily Cercopithecinae.",
            Image = "img1.jpg",
        Latitude=0,
        Longitude=0};
        public static DetailsModel object2 = new DetailsModel
        {
            Name = "Capuchin Monkey",
            Location = "South America",
            Details = "The capuchin monkeys are New World monkeys of the subfamily Cebinae. Prior to 2011, the subfamily contained only a single genus, Cebus.",
            Image = "img2.jpg",
            Latitude = 0,
            Longitude = 0
        };
        public static DetailsModel object3 = new DetailsModel
        {
            Name = "Blue Monkey",
            Location = "Central Africa",
            Details = "The blue monkey or diademed monkey is a species of Old World monkey native to Central and East Africa, ranging from the upper Congo River basin east to the East African Rift and south to northern Angola and Zambia",
            Image = "img3.jpg",
            Latitude = 0,
            Longitude = 0
        };
        public static DetailsModel object4 = new DetailsModel
        {
            Name = "Squirrel Monkey",
            Location = "South America",
            Details = "The squirrel monkeys are the New World monkeys of the genus Saimiri. They are the only genus in the subfamily Saimirinae. The name of the genus Saimiri is of Tupi origin, and was also used as an English name by early researchers.",
            Image = "img4.jpg",
            Latitude = 0,
            Longitude = 0
        };
        public static DetailsModel object5 = new DetailsModel
        {
            Name = "Golden Lion Tamarin",
            Location = "Brazil",
            Details = "The golden lion tamarin also known as the golden marmoset, is a small New World monkey of the family Callitrichidae.",
            Image = "img5.jpg",
            Latitude = 0,
            Longitude = 0
        };
        public static DetailsModel object6 = new DetailsModel
        {
            Name = "Howler Monkey",
            Location = "South America",
            Details = "Howler monkeys are among the largest of the New World monkeys. Fifteen species are currently recognised. Previously classified in the family Cebidae, they are now placed in the family Atelidae.",
            Image = "img6.jpg"
        };
        public static DetailsModel object7 = new DetailsModel
        {
            Name = "Japanese Macaque",
            Location = "Japan",
            Details = "The Japanese macaque, is a terrestrial Old World monkey species native to Japan. They are also sometimes known as the snow monkey because they live in areas where snow covers the ground for months each",
            Image = "img7.jpg",
            Latitude = 0,
            Longitude = 0
        };
        public static DetailsModel object8 = new DetailsModel
        {
            Name = "Mandrill",
            Location = "Southern Cameroon,Congo",
            Details = "The mandrill is a primate of the Old World monkey family, closely related to the baboons and even more closely to the drill. It is found in southern Cameroon, Gabon, Equatorial Guinea, and Congo.",
            Image = "img8.jpg",
            Latitude = 0,
            Longitude = 0
        };
        public static DetailsModel object9 = new DetailsModel
        {
            Name = "Proboscis Monkey",
            Location = "Borneo",
            Details = "The proboscis monkey or long-nosed monkey, known as the bekantan in Malay, is a reddish-brown arboreal Old World monkey that is endemic to the south-east Asian island of Borneo.",
            Image = "img9.jpg",
            Latitude = 0,
            Longitude = 0
        };
        public AppConstants ()
		{
            
        }
	}
}