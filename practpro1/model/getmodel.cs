using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace practpro1.model
{
    [Table("Movie Reviews")]
    public class getmodel
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string movie { get; set; }
        public string comments { get; set; }
        public int rating {  get; set; }
    }
}
