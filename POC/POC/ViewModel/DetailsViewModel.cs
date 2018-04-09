using System;
using POC.Model;

namespace POC
{
    public class DetailsViewModel
    {
        public DetailsModel Monkey { get; set; }
        public DetailsViewModel(DetailsModel monkey)
        {
            Monkey = monkey;
        }
    }
}

