﻿using System.Text.Json.Serialization;

namespace StabilityMatrix.Models.Api;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum CivitPeriod
{
    AllTime,
    Year,
    Month,
    Week,
    Day
}
