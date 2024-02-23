using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace Mission6_Stone.Models
{
    public class Movie
    {
        [Key]
        [Required]
        public int MovieId { get; set; }
        [ForeignKey("CategoryId")]
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }
        [Required(ErrorMessage = "Title is required.")]

        public string Title { get; set; }
        [Required(ErrorMessage = "Year is required.")]
        [Range(1888, int.MaxValue, ErrorMessage = "Year must be at least 1888")]
        public int Year { get; set; }
        public string? Director { get; set; }
        [Required(ErrorMessage = "Rating is required.")]

        public string? Rating { get; set; }
        [Required(ErrorMessage = "Edited status is required.")]
        public bool? Edited { get; set; }
        public string? LentTo { get; set; }
        [Required(ErrorMessage = "Copied to plex response is required.")]
        public bool? CopiedToPlex {  get; set; }

        [MaxLength(25)]
        public string? Notes { get; set; }



        //        public int GetApplicationID () { return ApplicationID; }

        //        public void SetApplicationID (int ApplicationID)
        //        {
        //            ApplicationID = num;
        //       }
    }
}
