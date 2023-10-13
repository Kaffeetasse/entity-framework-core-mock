using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkCoreMock.Tests.Models
{
    public class GeneratedKeyInheritanceModelBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
    }

    public class GeneratedKeyInheritanceModelInheritanceModel : GeneratedKeyInheritanceModelBase
    {
        public string Value { get; set; }
    }
}
