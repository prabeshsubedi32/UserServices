using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UserServices.POCO.Models
{
    [Table("user")]
    public partial class User
    {
        [Key]
        [Column("user_id")]
        public int UserId { get; set; }
        [Required]
        [Column("address", TypeName = "character varying")]
        public string Address { get; set; }
        [Required]
        [Column("first_name", TypeName = "character varying")]
        public string FirstName { get; set; }
        [Required]
        [Column("last_name", TypeName = "character varying")]
        public string LastName { get; set; }
    }
}
