﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace TheDoxaFlameAPIApp.Models;

public partial class Church
{
    public int ChurchId { get; set; }

    public string Name { get; set; }

    public string Location { get; set; }

    public DateTime CreatedDate { get; set; }

    public virtual ICollection<AdminDashboardSetting> AdminDashboardSettings { get; set; } = new List<AdminDashboardSetting>();

    public virtual ICollection<CongregationPreference> CongregationPreferences { get; set; } = new List<CongregationPreference>();

    public virtual ICollection<Pastor> Pastors { get; set; } = new List<Pastor>();

    public virtual ICollection<Service> Services { get; set; } = new List<Service>();

    public virtual ICollection<Speaker> Speakers { get; set; } = new List<Speaker>();

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}