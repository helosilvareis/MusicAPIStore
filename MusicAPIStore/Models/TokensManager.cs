using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicAPIStore.Models
{
    [Table("TokensManager")]
    public class TokensManager
    {
        [Key]
        public int TokenId { get; set; }
    }
}