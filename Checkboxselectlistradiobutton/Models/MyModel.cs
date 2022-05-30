using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Checkboxselectlistradiobutton.Models
{
    public class Player
    {
        [Key]
        public int PlayerId { get; set; }


        [Column(TypeName = "nvarchar(63)")]
        [DisplayName("Player Name")]
        [Required(ErrorMessage = "This Field is required.")]
        [MaxLength(63, ErrorMessage = "Maximum 63 characters only")]
        public string PlayerName { get; set; }
        [DisplayName("Clubs Played for")]
        public string SelectedIdsstring { get; set; }
        public string Loggedinuser { get; set; }
        [DisplayName("Player's Photo")]
        public string ImagePath { get; set; }

        public int TeamId { get; set; }
        public int AgeId { get; set; }
        public virtual Team Team { get; set; } // This is new

        public virtual Age Age { get; set; } // This is new
        public bool Living { get; set; }
        [NotMapped]
        public IFormFile Resim { get; set; }

    }

    public class Team
    {
        [Key]
        public int TeamId { get; set; }

        [Column(TypeName = "nvarchar(62)")]
        [DisplayName("Club Name")]
        [Required(ErrorMessage = "This Field is required.")]
        [MaxLength(62, ErrorMessage = "Maximum 62 characters only")]
        public string TeamName { get; set; }
        public string City { get; set; }
        public DateTime Founded { get; set; }

        public virtual ICollection<Player> Player { get; set; }
    }

    public class Age
    {
        [Key]
        public int AgeId { get; set; }
        [Column(TypeName = "nvarchar(62)")]
        [DisplayName("Age Name")]
        [Required(ErrorMessage = "This Field is required.")]
        [MaxLength(62, ErrorMessage = "Maximum 62 characters only")]
        public string AgeName { get; set; }


        public virtual ICollection<Player> Player { get; set; }
    }
    public class TeamPlayerViewModel
    {
        public Team Team { get; set; }
        public Player Player { get; set; }
    }
}
