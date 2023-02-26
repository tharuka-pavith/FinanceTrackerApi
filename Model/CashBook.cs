namespace FinanceTrackerAPI.Model
{
    public class CashBook
    {
        public int Id { get; set; }

        public string name { get; set; }

        public DateTime CreatedDate { get; set; }


        public ICollection<Entry> Entries { get; set; }
    }
}
