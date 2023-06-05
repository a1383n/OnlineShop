﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Core.Model.Provider;

[BsonDiscriminator("email")]
public class EmailProviderInfo : ProviderInfo
{
    public override string Id => "email";
    
    public BsonTimestamp VerifiedAt { get; set; } = new(DateTimeOffset.Now.ToUnixTimeSeconds());
}