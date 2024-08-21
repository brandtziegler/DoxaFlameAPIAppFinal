﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace TheDoxaFlameAPIApp.Models;

public partial class User
{
    public int UserId { get; set; }

    public string Username { get; set; }

    public string Email { get; set; }

    public string PasswordHash { get; set; }

    public int RoleId { get; set; }

    public int? PreferredCongregationId { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime? LastLoginDate { get; set; }

    public virtual ICollection<CongregationPreference> CongregationPreferences { get; set; } = new List<CongregationPreference>();

    public virtual ICollection<FeedbackSupportTicket> FeedbackSupportTickets { get; set; } = new List<FeedbackSupportTicket>();

    public virtual ICollection<Notification> Notifications { get; set; } = new List<Notification>();

    public virtual Church PreferredCongregation { get; set; }

    public virtual Role Role { get; set; }
}