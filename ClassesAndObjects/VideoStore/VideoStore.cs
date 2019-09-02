using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoStore
{
    class VideoStore
    {
        private List<Video> _inventory;
        public VideoStore()
        {
            _inventory = new List<Video>();
        }
        public void AddVideo(string title)
        {
            _inventory.Add(new Video(title));
        }
        public void CheckOutVideo(string title)
        {
            foreach(var video in _inventory)
            {
                if (video.Title == title)
                    video.beingCheckedOut();
            }
        }
        public void ReturnVideo(string title)
        {
            foreach (var video in _inventory)
            {
                if (video.Title == title)
                    video.beingReturned();
            }
        }
        public void TakeUserRating(double rating,string title)
        {
            foreach (var video in _inventory)
            {
                if (video.Title == title)
                    video.receivingRating(rating);
            }
        }

        

        public void ListOfVideosInStore()
        {
            foreach (var video in _inventory)
            {
                Console.WriteLine("{0}{1}{3}", video.Title, video.AvarageRating(), video.Available());
            }
        }
    }
}
