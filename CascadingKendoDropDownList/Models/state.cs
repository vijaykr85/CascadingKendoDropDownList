using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CascadingKendoDropDownList.Models
{
    public class state
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
    }
    public class city
    {
        [Key]
        public int cityid { get; set; }
        public int id { get; set; }
        [ForeignKey("id")]
        public state state { get; set; }
        public string name { get; set; }
    }
}
