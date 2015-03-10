

namespace PioPortal.ViewModels
{
    public abstract class On
    {
        public int Id { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public decimal? Value { get; set; }
        public string Comment { get; set; }
    }
}
