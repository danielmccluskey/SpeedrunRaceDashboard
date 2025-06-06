using System.ComponentModel.DataAnnotations;

namespace SpeedrunRaceDashboard.Models
{
    public class StreamSettings
    {
        [Key]
        public int Id { get; set; }

        public string StreamTitle { get; set; } = string.Empty;

        public DateTime? TimerStartedAt { get; set; }

        public bool IsTimerRunning { get; set; }
    }

}
