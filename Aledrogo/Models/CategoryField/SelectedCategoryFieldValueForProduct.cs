using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aledrogo.Models
{
    public class SelectedValueForCategoryField
    {
        public int Id { get; set; }

        public int? ProductId { get; set; }
        public virtual Product Product { get; set; }

        public int CategoryFieldId { get; set; }
        public virtual CategoryField CategoryField { get; set; }

        public string Value { get; set; }
    }
}
