using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
namespace pntt_231220952.Models
{
    [Table("pnttComputer")]
    public class PnttComputer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PnttComId { get; set; }
        [StringLength(200)]
        public string PnttComName { get; set;}
        [Range(100,5000)]
        public double PnttComPrice { get; set; }

        [StringLength(200)]
        public string PnttComImage { get; set;}
        [StringLength(200)]
        public string PnttComStatus { get; set; }
    }
}
