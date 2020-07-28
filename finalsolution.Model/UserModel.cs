using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace finalsolution.Model
{
    public class UserModel
    {
        [Required]
        public string Name { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required]
        public string Email { get; set; }
    }
}
