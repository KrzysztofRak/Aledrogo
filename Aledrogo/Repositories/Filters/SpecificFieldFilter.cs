namespace Aledrogo.Repositories.Filters.FilterDTOs
{
    public class SpecificFieldFilter
    {
        public int SpecificFieldId { get; set; }
        public int? SpecificFieldValueId { get; set; } = null;
        public int? MinValue { get; set; } = null;
        public int? MaxValue { get; set; } = null;
    }
}
