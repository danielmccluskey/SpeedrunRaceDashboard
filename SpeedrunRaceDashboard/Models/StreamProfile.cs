using System.ComponentModel.DataAnnotations;

namespace SpeedrunRaceDashboard.Models
{
    public class StreamProfile
    {
        [Key]
        public int Id { get; set; }

        public string TwitchUsername { get; set; } = string.Empty;

        public string TwitchDisplayName { get; set; } = string.Empty;

        public string UserDisplayName { get; set; } = string.Empty;

        public string TeamColour { get; set; } = string.Empty;

        public string GameName { get; set; } = string.Empty;

        public string CompletedTime { get; set; } = string.Empty;

        public string PersonalBest { get; set; } = string.Empty;

        public List<StreamSlot> StreamSlots { get; set; } = new();
    }

}
