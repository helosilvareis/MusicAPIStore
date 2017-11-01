using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicAPIStore.Models
{
    [Table("MusicStore")]
    public class MusicStore
    {
        [Key]
        public int MusicStoreId { get; set; }
    }
}