namespace Aledrogo.Repositories.Filters.FilterDTOs
{
    public class SpecificFieldFilter
    {
        public int SpecificFieldId { get; set; }
        public int? SpecificFieldValueId { get; set; }
        public int? MinValue { get; set; }
        public int? MaxValue { get; set; }
    }
}
