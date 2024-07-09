using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

namespace DemoForms
{
    public class FrmField
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int FieldId { get; set; }
      
        public string FieldName { get; set; }
        public string FieldType { get; set; }
        public bool IsRequired { get; set; }
        public string ValidationRegex { get; set; }

        [ForeignKey("FormID")]
        public int FormID { get; set; }
        public string Value { get; set; }
        
    }
}
