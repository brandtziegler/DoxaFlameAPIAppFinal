﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace TheDoxaFlameAPIApp.Models;

public partial class MemoryPassage
{
    public int MemoryPassageId { get; set; }

    public string Passage { get; set; }

    public string Book { get; set; }

    public int Chapter { get; set; }

    public int VerseStart { get; set; }

    public int? VerseEnd { get; set; }

    public DateTime CreatedDate { get; set; }

    public virtual ICollection<Service> Services { get; set; } = new List<Service>();
}