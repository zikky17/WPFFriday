﻿using SQLite;
using System.ComponentModel.DataAnnotations;

namespace IOT.Resources.Models;

public class DeviceSettings
{

    [Key]
    [PrimaryKey]
    public string Id { get; set; } = null!;

    public string? Location { get; set; }

    public string? Type { get; set; }

    public string? ConnectionString { get; set; }


}
