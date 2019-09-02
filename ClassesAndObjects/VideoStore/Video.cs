using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoStore
{
    class Video
    {
        private string _title;
        private bool _isAvailable;
        private List<double> _ratintList;
        private double _rating;

        public Video(string title)
        {
            _title = title;
            _isAvailable = true;
            _ratintList = new List<double>();
        }
        public void beingCheckedOut()
        {
            _isAvailable = false;
        }
        public void beingReturned()
        {
            _isAvailable = true;
        }
        public void receivingRating(double raiting)
        {
            _ratintList.Add(raiting);
        }
        public double AvarageRating()
        {
            double sum = 0;
            foreach(var rating in _ratintList)
            {
                sum += rating;
            }
            return sum / _ratintList.Count;
        }
        public bool Available()
        {
            return _isAvailable;
        }
        public string Title
        {
            get { return _title; }
        }
    }
}
