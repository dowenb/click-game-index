using System;

namespace IndexApi.Models
{
    public class IndexItem
    {
        public long Id { get; set; }
        public string Name { get; set; }

        private Uri webAddress { get; set; }
    }
}