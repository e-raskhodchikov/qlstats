﻿namespace QLStats.Domain.Entities;

public class Match : BaseEntity
{
    public Guid MatchGuid { get; set; }
    public string Map { get; set; } = default!;

    public DateTime PlayedAt { get; set; }
    public int? TeamBlueScore { get; set; }
    public int? TeamRedScore { get; set; }

    public List<MatchPlayerStats> PlayerStats { get; set; } = null!;

    public bool Aborted { get; set; }
    public int CaptureLimit { get; set; }
    public string ExitMsg { get; set; } = default!;
    public string Factory { get; set; } = default!;
    public string FactoryTitle { get; set; } = default!;
    public string FirstScorer { get; set; } = default!;
    public int FragLimit { get; set; }
    public int GameLength { get; set; }
    public string GameType { get; set; } = default!;
    public bool Infected { get; set; }
    public bool Instagib { get; set; }
    public int LastLeadChangeTime { get; set; }
    public string? LastScorer { get; set; } = default!;
    public string? LastTeamscorer { get; set; } = default!;
    public int MercyLimit { get; set; }
    public bool Quadhog { get; set; }
    public bool Restarted { get; set; }
    public int RoundLimit { get; set; }
    public int ScoreLimit { get; set; }
    public string ServerTitle { get; set; } = default!;
    public int TimeLimit { get; set; }
    public bool Training { get; set; }
}
