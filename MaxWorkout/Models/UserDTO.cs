using System;
using System.ComponentModel.DataAnnotations;

namespace MaxWorkout.Models
{
	public class UserDTO
	{
        [Required]
		public string Name { get; set; } = "";

        [Required]
        public string Email { get; set; } = "";

        [Required]
        public string Password { get; set; } = "";

        [Required]
        public string Gender { get; set; } = "";

        [Required]
        public int Weight { get; set; } = 0;

        [Required]
        public int Height { get; set; } = 0;

        [Required]
        public int BenchMax { get; set; } = 0;

        [Required]
        public int SquatMax { get; set; } = 0;

        [Required]
        public int DeadliftMax { get; set; } = 0;
    }
}

