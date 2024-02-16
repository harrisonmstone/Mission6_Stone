using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Mission6_Stone.Models
{
    public class Application
    {
        [Key]
        public int ApplicationID { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        public string Director { get; set; }
        [Required]
        public string Rating { get; set; }
        [AllowNull]
        public bool ? Edited { get; set; }
        [AllowNull]
        public string ? Lent {  get; set; }
        [AllowNull]
        [MaxLength(25)]
        public string ? Notes { get; set; }



        //        public int GetApplicationID () { return ApplicationID; }

        //        public void SetApplicationID (int ApplicationID)
        //        {
        //            ApplicationID = num;
        //       }
    }
}
