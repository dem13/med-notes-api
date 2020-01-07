using System;
using System.ComponentModel.DataAnnotations;

namespace MedNotes.Models
{
    public class Note
    {
        public int Id { get; set; }
        public string Body { get; set; }

        [DataType(DataType.Date)] public DateTime CreatedAt { get; set; } = new DateTime();
    }
}