using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SpeedrunRaceDashboard.Models
{
    public class StreamSlot
    {
        [Key]
        public int Id { get; set; }

        public int ViewOrder { get; set; }

        public bool ShowLoading { get; set; }

        public string TeamColour { get; set; } = string.Empty;

        public int ProfileId { get; set; }

        [ForeignKey(nameof(ProfileId))]
        public StreamProfile? Profile { get; set; }

        public bool Hidden { get; set; }

        public bool Paused { get; set; }

        public bool Muted { get; set; }
    }

}
