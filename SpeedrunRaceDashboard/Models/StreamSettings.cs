using System.ComponentModel.DataAnnotations;

namespace SpeedrunRaceDashboard.Models
{
    using System.ComponentModel.DataAnnotations;

    public class StreamSettings
    {
        [Key]
        public int Id { get; set; }

        // Stream metadata
        public string StreamTitle { get; set; } = string.Empty;
        public DateTime? TimerStartedAt { get; set; }
        public bool IsTimerRunning { get; set; }

        // Header customization
        public bool UseHeaderImage { get; set; }
        public string HeaderImageUrl { get; set; } = string.Empty;
        public string HeaderTextColour { get; set; } = "#FFFFFF"; // Default white

        // Background customization
        public bool UseBackgroundImage { get; set; }
        public string BackgroundImageUrl { get; set; } = string.Empty;
        public string BackgroundColour { get; set; } = "#000000"; // Default black
        public string MainBackgroundColour { get; set; } = "#000000";

        // Sidebar customization
        public string SidebarTextColour { get; set; } = "#FFFFFF";
        public string SidebarBackgroundColour { get; set; } = "#1A1A1A";
        public string SidebarImageUrl { get; set; } = string.Empty;

        // Accent / highlight colour
        public string AccentColour { get; set; } = "#FF9900";

        // Font family
        public string FontFamily { get; set; } = "Arial, sans-serif";
        public string GoogleFontUrl { get; set; } = "";

        // Show team colours on borders?
        public bool ShowTeamBorders { get; set; }

        // Layout options
        public bool CompactMode { get; set; } // Use a more compressed layout
        public bool ShowLeaderboard { get; set; } = true;
        public bool ShowFacts { get; set; } = true;
        public bool ShowCommentaryBox { get; set; } = true;

        // Future extension fields
        public string CustomCSS { get; set; } = string.Empty;
        public string Notes { get; set; } = string.Empty;
    }


}
