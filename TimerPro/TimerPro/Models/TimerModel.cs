using System;

namespace TimerPro.Models
{
    public class TimerModel : BaseModel
    {
        private int days;
        private DateTime expires;

        public string Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string OwnerId { get; set; }

        public DateTime Expires
        {
            get => expires;
            set
            {
                expires = value;
                days = (expires - DateTime.Now).Days;
            }
        }

        public int Days
        {
            get => days;
            set
            {
                days = value;
                expires = DateTime.Now.AddDays(value);
            }
        }
    }
}