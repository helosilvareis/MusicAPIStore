using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicAPIStore.Models
{
    [Table("RegisterCompany")]
    public class RegisterCompany
    {
        [Key]
        public int CompanyId { get; set; }
    }
}