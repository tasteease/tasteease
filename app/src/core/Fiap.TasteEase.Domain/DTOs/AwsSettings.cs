﻿namespace Fiap.TasteEase.Domain.DTOs;

public class AwsSettings
{
    public string Region { get; set; }
    public string UserPoolId { get; set; }
    public string UserPoolClientId { get; set; }
    public string UserPoolClientSecret { get; set; }
}