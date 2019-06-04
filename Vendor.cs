using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JavaWebApi {
    public class Vendor {

        [Key]
        public int Id { get; set; }
        [StringLength(30)]
        [Required]
        public string Name { get; set; }
        [StringLength(30)]
        [Required]
        public string Address { get; set; }

        [StringLength(20)]
        public string City { get; set; }

        [StringLength(12)]
        [Required]
        public string Phone { get; set; }
        [StringLength(255)]
        public string Email { get; set; }

        public Vendor() {

        }
    }
}
