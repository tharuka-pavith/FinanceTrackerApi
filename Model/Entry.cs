﻿namespace FinanceTrackerAPI.Model
{
    public class Entry
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public decimal Amount { get; set; }

        public  DateTime CreatedDate { get; set; }

    }
}
