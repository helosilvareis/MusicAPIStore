using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicAPIStore.Models
{
    [Table("ClientKeys")]
    public class ClientKeys
    {
        [Key]
        public int ClientId { get; set; }
    }
}