using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Models
{
    public class Server
    {
        #region Constructor
        //Initializes a new instance of the Server class with a random online status.
        public Server()
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 2);
            IsOnLine = randomNumber == 0 ? false : true;
        }
        #endregion

        #region properties
        public int ServerId { get; set; }
        public bool IsOnLine { get; set; }
        [Required] //date annotation
        // [StringLength(50, ErrorMessage = "Name cannot be longer than 50 characters.")]
        // [Display(Name = "Server Name")]
        // [DataType(DataType.Text)]
        // [RegularExpression(@"^[a-zA-Z0-9\s]+$", ErrorMessage = "Name can only contain letters, numbers, and spaces.")]
        // [MinLength(3, ErrorMessage = "Name must be at least 3 characters long.")]
        // [MaxLength(50, ErrorMessage = "Name cannot exceed 50 characters.")]
        // [DisplayFormat(ConvertEmptyStringToNull = true)]
        // [Required(ErrorMessage = "Server name is required.")]
        // [StringLength(100, ErrorMessage = "Name cannot be longer than 100 characters.")]
        // [Display(Name = "Server Name")]
        public string? Name { get; set; }
        [Required]
        public string? City { get; set; }
        #endregion

        #region Methods
        #endregion
    }
}