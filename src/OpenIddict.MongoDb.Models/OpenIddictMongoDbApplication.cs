﻿/*
 * Licensed under the Apache License, Version 2.0 (http://www.apache.org/licenses/LICENSE-2.0)
 * See https://github.com/openiddict/openiddict-core for more information concerning
 * the license and the contributors participating to this project.
 */

using System.Collections.Immutable;
using System.Diagnostics;

namespace OpenIddict.MongoDb.Models;

/// <summary>
/// Represents an OpenIddict application.
/// </summary>
[DebuggerDisplay("Id = {Id.ToString(),nq} ; ClientId = {ClientId,nq} ; ClientType = {ClientType,nq}")]
public class OpenIddictMongoDbApplication
{
    /// <summary>
    /// Gets or sets the application type associated with the current application.
    /// </summary>
    [BsonElement("application_type"), BsonIgnoreIfNull]
    public virtual string? ApplicationType { get; set; }

    /// <summary>
    /// Gets or sets the client identifier associated with the current application.
    /// </summary>
    [BsonElement("client_id"), BsonIgnoreIfNull]
    public virtual string? ClientId { get; set; }

    /// <summary>
    /// Gets or sets the client secret associated with the current application.
    /// Note: depending on the application manager used to create this instance,
    /// this property may be hashed or encrypted for security reasons.
    /// </summary>
    [BsonElement("client_secret"), BsonIgnoreIfNull]
    public virtual string? ClientSecret { get; set; }

    /// <summary>
    /// Gets or sets the client type associated with the current application.
    /// </summary>
    [BsonElement("client_type"), BsonIgnoreIfNull]
    public virtual string? ClientType { get; set; }

    /// <summary>
    /// Gets or sets the concurrency token.
    /// </summary>
    [BsonElement("concurrency_token"), BsonIgnoreIfNull]
    public virtual string? ConcurrencyToken { get; set; } = Guid.NewGuid().ToString();

    /// <summary>
    /// Gets or sets the consent type associated with the current application.
    /// </summary>
    [BsonElement("consent_type"), BsonIgnoreIfNull]
    public virtual string? ConsentType { get; set; }

    /// <summary>
    /// Gets or sets the display name associated with the current application.
    /// </summary>
    [BsonElement("display_name"), BsonIgnoreIfNull]
    public virtual string? DisplayName { get; set; }

    /// <summary>
    /// Gets or sets the localized display names associated with the current application.
    /// </summary>
    [BsonElement("display_names"), BsonIgnoreIfNull]
    public virtual IReadOnlyDictionary<string, string>? DisplayNames { get; set; }
        = ImmutableDictionary.Create<string, string>();

    /// <summary>
    /// Gets or sets the unique identifier associated with the current application.
    /// </summary>
    [BsonId, BsonRequired]
    public virtual ObjectId Id { get; set; }

    /// <summary>
    /// Gets or sets the permissions associated with the current application.
    /// </summary>
    [BsonElement("permissions"), BsonIgnoreIfNull]
    public virtual IReadOnlyList<string>? Permissions { get; set; } = ImmutableList.Create<string>();

    /// <summary>
    /// Gets or sets the post-logout redirect URIs associated with the current application.
    /// </summary>
    [BsonElement("post_logout_redirect_uris"), BsonIgnoreIfNull]
    public virtual IReadOnlyList<string>? PostLogoutRedirectUris { get; set; } = ImmutableList.Create<string>();

    /// <summary>
    /// Gets or sets the additional properties associated with the current application.
    /// </summary>
    [BsonElement("properties"), BsonIgnoreIfNull]
    public virtual BsonDocument? Properties { get; set; }

    /// <summary>
    /// Gets or sets the redirect URIs associated with the current application.
    /// </summary>
    [BsonElement("redirect_uris"), BsonIgnoreIfNull]
    public virtual IReadOnlyList<string>? RedirectUris { get; set; } = ImmutableList.Create<string>();

    /// <summary>
    /// Gets or sets the requirements associated with the current application.
    /// </summary>
    [BsonElement("requirements"), BsonIgnoreIfNull]
    public virtual IReadOnlyList<string>? Requirements { get; set; } = ImmutableList.Create<string>();

    /// <summary>
    /// Gets or sets the settings associated with the current application.
    /// </summary>
    [BsonElement("settings"), BsonIgnoreIfNull]
    public virtual IReadOnlyDictionary<string, string>? Settings { get; set; }
        = ImmutableDictionary.Create<string, string>();
}
