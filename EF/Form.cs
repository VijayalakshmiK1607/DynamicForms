using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoForms
{
    public class Form
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ID { get; set; }
        public string FormId { get; set; }

        public string FormName { get; set; }

        public string Description { get; set; }

        public List<FrmField> FormFields { get; set; }

      
    }
}
