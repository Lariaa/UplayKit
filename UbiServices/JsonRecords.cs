﻿using Newtonsoft.Json;

namespace UbiServices.Records
{
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    #region Login
    public record LoginJson(
            [property: JsonProperty("platformType", NullValueHandling = NullValueHandling.Ignore)] string PlatformType,
            [property: JsonProperty("ticket", NullValueHandling = NullValueHandling.Ignore)] string Ticket,
            [property: JsonProperty("twoFactorAuthenticationTicket", NullValueHandling = NullValueHandling.Ignore)] string TwoFactorAuthenticationTicket,
            [property: JsonProperty("profileId", NullValueHandling = NullValueHandling.Ignore)] string ProfileId,
            [property: JsonProperty("userId", NullValueHandling = NullValueHandling.Ignore)] string UserId,
            [property: JsonProperty("nameOnPlatform", NullValueHandling = NullValueHandling.Ignore)] string NameOnPlatform,
            [property: JsonProperty("environment", NullValueHandling = NullValueHandling.Ignore)] string Environment,
            [property: JsonProperty("expiration", NullValueHandling = NullValueHandling.Ignore)] DateTime? Expiration,
            [property: JsonProperty("spaceId", NullValueHandling = NullValueHandling.Ignore)] string SpaceId,
            [property: JsonProperty("clientIp", NullValueHandling = NullValueHandling.Ignore)] string ClientIp,
            [property: JsonProperty("clientIpCountry", NullValueHandling = NullValueHandling.Ignore)] string ClientIpCountry,
            [property: JsonProperty("serverTime", NullValueHandling = NullValueHandling.Ignore)] DateTime? ServerTime,
            [property: JsonProperty("sessionId", NullValueHandling = NullValueHandling.Ignore)] string SessionId,
            [property: JsonProperty("sessionKey", NullValueHandling = NullValueHandling.Ignore)] string SessionKey,
            [property: JsonProperty("rememberMeTicket", NullValueHandling = NullValueHandling.Ignore)] string RememberMeTicket,
            [property: JsonProperty("rememberDeviceTicket", NullValueHandling = NullValueHandling.Ignore)] string RememberDeviceTicket
    );
    #endregion
    #region UsersMe
    public record UsersMe(
        [property: JsonProperty("userId", NullValueHandling = NullValueHandling.Ignore)] string UserId,
        [property: JsonProperty("username", NullValueHandling = NullValueHandling.Ignore)] string Username,
        [property: JsonProperty("nameOnPlatform", NullValueHandling = NullValueHandling.Ignore)] string NameOnPlatform,
        [property: JsonProperty("accountIssues", NullValueHandling = NullValueHandling.Ignore)] object AccountIssues,
        [property: JsonProperty("communicationOptIn", NullValueHandling = NullValueHandling.Ignore)] bool? CommunicationOptIn,
        [property: JsonProperty("communicationThirdPartyOptIn", NullValueHandling = NullValueHandling.Ignore)] bool? CommunicationThirdPartyOptIn,
        [property: JsonProperty("country", NullValueHandling = NullValueHandling.Ignore)] string Country,
        [property: JsonProperty("dateCreated", NullValueHandling = NullValueHandling.Ignore)] DateTime? DateCreated,
        [property: JsonProperty("dateAnonymized", NullValueHandling = NullValueHandling.Ignore)] object DateAnonymized,
        [property: JsonProperty("dateOfBirth", NullValueHandling = NullValueHandling.Ignore)] DateTime? DateOfBirth,
        [property: JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)] string Email,
        [property: JsonProperty("firstName", NullValueHandling = NullValueHandling.Ignore)] string FirstName,
        [property: JsonProperty("gender", NullValueHandling = NullValueHandling.Ignore)] string Gender,
        [property: JsonProperty("hasAcceptedLegalOptins", NullValueHandling = NullValueHandling.Ignore)] bool? HasAcceptedLegalOptins,
        [property: JsonProperty("lastName", NullValueHandling = NullValueHandling.Ignore)] string LastName,
        [property: JsonProperty("preferredLanguage", NullValueHandling = NullValueHandling.Ignore)] string PreferredLanguage,
        [property: JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)] Status Status,
        [property: JsonProperty("phone", NullValueHandling = NullValueHandling.Ignore)] object Phone,
        [property: JsonProperty("accountType", NullValueHandling = NullValueHandling.Ignore)] string AccountType,
        [property: JsonProperty("ageGroup", NullValueHandling = NullValueHandling.Ignore)] string AgeGroup
    );

    public record Status(
        [property: JsonProperty("autoGeneratedUsername", NullValueHandling = NullValueHandling.Ignore)] bool? AutoGeneratedUsername,
        [property: JsonProperty("dateOfBirthApproximated", NullValueHandling = NullValueHandling.Ignore)] bool? DateOfBirthApproximated,
        [property: JsonProperty("invalidEmail", NullValueHandling = NullValueHandling.Ignore)] bool? InvalidEmail,
        [property: JsonProperty("missingRequiredInformation", NullValueHandling = NullValueHandling.Ignore)] bool? MissingRequiredInformation,
        [property: JsonProperty("pendingDeactivation", NullValueHandling = NullValueHandling.Ignore)] bool? PendingDeactivation,
        [property: JsonProperty("targetDeactivationDate", NullValueHandling = NullValueHandling.Ignore)] object TargetDeactivationDate,
        [property: JsonProperty("recoveringPassword", NullValueHandling = NullValueHandling.Ignore)] bool? RecoveringPassword,
        [property: JsonProperty("passwordUpdateRequired", NullValueHandling = NullValueHandling.Ignore)] bool? PasswordUpdateRequired,
        [property: JsonProperty("reserved", NullValueHandling = NullValueHandling.Ignore)] bool? Reserved,
        [property: JsonProperty("changeEmailPending", NullValueHandling = NullValueHandling.Ignore)] bool? ChangeEmailPending,
        [property: JsonProperty("inactiveAccount", NullValueHandling = NullValueHandling.Ignore)] bool? InactiveAccount,
        [property: JsonProperty("generalStatus", NullValueHandling = NullValueHandling.Ignore)] string GeneralStatus,
        [property: JsonProperty("suspiciousActivity", NullValueHandling = NullValueHandling.Ignore)] bool? SuspiciousActivity,
        [property: JsonProperty("locked", NullValueHandling = NullValueHandling.Ignore)] bool? Locked,
        [property: JsonProperty("minor", NullValueHandling = NullValueHandling.Ignore)] bool? Minor,
        [property: JsonProperty("testAccount", NullValueHandling = NullValueHandling.Ignore)] bool? TestAccount,
        [property: JsonProperty("phoneActivated", NullValueHandling = NullValueHandling.Ignore)] bool? PhoneActivated,
        [property: JsonProperty("phoneSanctioned", NullValueHandling = NullValueHandling.Ignore)] bool? PhoneSanctioned
    );
    #endregion
    #region ProfilesFriends
    public record ProfilesFriends(
        [property: JsonProperty("friends", NullValueHandling = NullValueHandling.Ignore)] IReadOnlyList<Friend> Friends
    );
    public record Friend(
        [property: JsonProperty("pid", NullValueHandling = NullValueHandling.Ignore)] string Pid,
        [property: JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)] string State,
        [property: JsonProperty("isFavorite", NullValueHandling = NullValueHandling.Ignore)] bool? IsFavorite,
        [property: JsonProperty("nickname", NullValueHandling = NullValueHandling.Ignore)] string Nickname,
        [property: JsonProperty("lastModified", NullValueHandling = NullValueHandling.Ignore)] DateTime? LastModified,
        [property: JsonProperty("friendshipDate", NullValueHandling = NullValueHandling.Ignore)] DateTime? FriendshipDate
    );
    #endregion
    #region VxApplications
    public record V1Applications(
        [property: JsonProperty("applicationId", NullValueHandling = NullValueHandling.Ignore)] string ApplicationId,
        [property: JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)] string Name,
        [property: JsonProperty("platform", NullValueHandling = NullValueHandling.Ignore)] string Platform,
        [property: JsonProperty("spaceId", NullValueHandling = NullValueHandling.Ignore)] string SpaceId,
        [property: JsonProperty("overrideResponse", NullValueHandling = NullValueHandling.Ignore)] object OverrideResponse
    );

    public record AgeRating(
    [property: JsonProperty("ratingSystem", NullValueHandling = NullValueHandling.Ignore)] object RatingSystem,
    [property: JsonProperty("ratingImage", NullValueHandling = NullValueHandling.Ignore)] object RatingImage,
    [property: JsonProperty("descriptors", NullValueHandling = NullValueHandling.Ignore)] IReadOnlyList<object> Descriptors
);

    public record Images(
        [property: JsonProperty("lowThumbnail", NullValueHandling = NullValueHandling.Ignore)] string LowThumbnail,
        [property: JsonProperty("highThumbnail", NullValueHandling = NullValueHandling.Ignore)] string HighThumbnail,
        [property: JsonProperty("background", NullValueHandling = NullValueHandling.Ignore)] string Background,
        [property: JsonProperty("lowLogo", NullValueHandling = NullValueHandling.Ignore)] string LowLogo,
        [property: JsonProperty("highLogo", NullValueHandling = NullValueHandling.Ignore)] string HighLogo,
        [property: JsonProperty("lowBoxArt", NullValueHandling = NullValueHandling.Ignore)] string LowBoxArt,
        [property: JsonProperty("highBoxArt", NullValueHandling = NullValueHandling.Ignore)] string HighBoxArt
    );

    public record V2Applications(
        [property: JsonProperty("applicationId", NullValueHandling = NullValueHandling.Ignore)] string ApplicationId,
        [property: JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)] string Name,
        [property: JsonProperty("platform", NullValueHandling = NullValueHandling.Ignore)] string Platform,
        [property: JsonProperty("spaceId", NullValueHandling = NullValueHandling.Ignore)] string SpaceId,
        [property: JsonProperty("overrideResponse", NullValueHandling = NullValueHandling.Ignore)] object OverrideResponse,
        [property: JsonProperty("genre", NullValueHandling = NullValueHandling.Ignore)] object Genre,
        [property: JsonProperty("displayName", NullValueHandling = NullValueHandling.Ignore)] string DisplayName,
        [property: JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)] string Description,
        [property: JsonProperty("images", NullValueHandling = NullValueHandling.Ignore)] Images Images,
        [property: JsonProperty("ageRating", NullValueHandling = NullValueHandling.Ignore)] AgeRating AgeRating
    );
    #endregion
    #region V2UserME
    public record Profile(
        [property: JsonProperty("idOnPlatform", NullValueHandling = NullValueHandling.Ignore)] string IdOnPlatform,
        [property: JsonProperty("nameOnPlatform", NullValueHandling = NullValueHandling.Ignore)] string NameOnPlatform,
        [property: JsonProperty("platformType", NullValueHandling = NullValueHandling.Ignore)] string PlatformType,
        [property: JsonProperty("profileId", NullValueHandling = NullValueHandling.Ignore)] string ProfileId,
        [property: JsonProperty("userId", NullValueHandling = NullValueHandling.Ignore)] string UserId
    );

    public record v2UserMe(
        [property: JsonProperty("userId", NullValueHandling = NullValueHandling.Ignore)] string UserId,
        [property: JsonProperty("username", NullValueHandling = NullValueHandling.Ignore)] string Username,
        [property: JsonProperty("nameOnPlatform", NullValueHandling = NullValueHandling.Ignore)] object NameOnPlatform,
        [property: JsonProperty("accountIssues", NullValueHandling = NullValueHandling.Ignore)] object AccountIssues,
        [property: JsonProperty("communicationOptIn", NullValueHandling = NullValueHandling.Ignore)] bool? CommunicationOptIn,
        [property: JsonProperty("communicationThirdPartyOptIn", NullValueHandling = NullValueHandling.Ignore)] bool? CommunicationThirdPartyOptIn,
        [property: JsonProperty("country", NullValueHandling = NullValueHandling.Ignore)] string Country,
        [property: JsonProperty("dateCreated", NullValueHandling = NullValueHandling.Ignore)] DateTime? DateCreated,
        [property: JsonProperty("dateAnonymized", NullValueHandling = NullValueHandling.Ignore)] object DateAnonymized,
        [property: JsonProperty("dateOfBirth", NullValueHandling = NullValueHandling.Ignore)] DateTime? DateOfBirth,
        [property: JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)] string Email,
        [property: JsonProperty("firstName", NullValueHandling = NullValueHandling.Ignore)] string FirstName,
        [property: JsonProperty("gender", NullValueHandling = NullValueHandling.Ignore)] string Gender,
        [property: JsonProperty("hasAcceptedLegalOptins", NullValueHandling = NullValueHandling.Ignore)] bool? HasAcceptedLegalOptins,
        [property: JsonProperty("lastName", NullValueHandling = NullValueHandling.Ignore)] string LastName,
        [property: JsonProperty("preferredLanguage", NullValueHandling = NullValueHandling.Ignore)] string PreferredLanguage,
        [property: JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)] v2Status Status,
        [property: JsonProperty("phone", NullValueHandling = NullValueHandling.Ignore)] object Phone,
        [property: JsonProperty("profiles", NullValueHandling = NullValueHandling.Ignore)] IReadOnlyList<Profile> Profiles,
        [property: JsonProperty("accountType", NullValueHandling = NullValueHandling.Ignore)] string AccountType,
        [property: JsonProperty("ageGroup", NullValueHandling = NullValueHandling.Ignore)] string AgeGroup
    );

    public record v2Status(
        [property: JsonProperty("autoGeneratedUsername", NullValueHandling = NullValueHandling.Ignore)] bool? AutoGeneratedUsername,
        [property: JsonProperty("dateOfBirthApproximated", NullValueHandling = NullValueHandling.Ignore)] bool? DateOfBirthApproximated,
        [property: JsonProperty("invalidEmail", NullValueHandling = NullValueHandling.Ignore)] bool? InvalidEmail,
        [property: JsonProperty("missingRequiredInformation", NullValueHandling = NullValueHandling.Ignore)] bool? MissingRequiredInformation,
        [property: JsonProperty("pendingDeactivation", NullValueHandling = NullValueHandling.Ignore)] bool? PendingDeactivation,
        [property: JsonProperty("targetDeactivationDate", NullValueHandling = NullValueHandling.Ignore)] object TargetDeactivationDate,
        [property: JsonProperty("recoveringPassword", NullValueHandling = NullValueHandling.Ignore)] bool? RecoveringPassword,
        [property: JsonProperty("passwordUpdateRequired", NullValueHandling = NullValueHandling.Ignore)] bool? PasswordUpdateRequired,
        [property: JsonProperty("reserved", NullValueHandling = NullValueHandling.Ignore)] bool? Reserved,
        [property: JsonProperty("changeEmailPending", NullValueHandling = NullValueHandling.Ignore)] bool? ChangeEmailPending,
        [property: JsonProperty("inactiveAccount", NullValueHandling = NullValueHandling.Ignore)] bool? InactiveAccount,
        [property: JsonProperty("generalStatus", NullValueHandling = NullValueHandling.Ignore)] string GeneralStatus,
        [property: JsonProperty("suspiciousActivity", NullValueHandling = NullValueHandling.Ignore)] bool? SuspiciousActivity,
        [property: JsonProperty("locked", NullValueHandling = NullValueHandling.Ignore)] bool? Locked,
        [property: JsonProperty("minor", NullValueHandling = NullValueHandling.Ignore)] bool? Minor,
        [property: JsonProperty("testAccount", NullValueHandling = NullValueHandling.Ignore)] bool? TestAccount,
        [property: JsonProperty("phoneActivated", NullValueHandling = NullValueHandling.Ignore)] bool? PhoneActivated,
        [property: JsonProperty("phoneSanctioned", NullValueHandling = NullValueHandling.Ignore)] bool? PhoneSanctioned
    );
    #endregion
    #region catalog
    public record AgeRatingGame(
        [property: JsonProperty("system", NullValueHandling = NullValueHandling.Ignore)] string System,
        [property: JsonProperty("imageUrl", NullValueHandling = NullValueHandling.Ignore)] string ImageUrl,
        [property: JsonProperty("descriptors", NullValueHandling = NullValueHandling.Ignore)] IReadOnlyList<Descriptor> Descriptors
    );

    public record Descriptor(
        [property: JsonProperty("imageUrl", NullValueHandling = NullValueHandling.Ignore)] object ImageUrl,
        [property: JsonProperty("displayName", NullValueHandling = NullValueHandling.Ignore)] string DisplayName
    );

    public record Game(
        [property: JsonProperty("spaceId", NullValueHandling = NullValueHandling.Ignore)] string SpaceId,
        [property: JsonProperty("installmentSpaceId", NullValueHandling = NullValueHandling.Ignore)] string InstallmentSpaceId,
        [property: JsonProperty("displayName", NullValueHandling = NullValueHandling.Ignore)] string DisplayName,
        [property: JsonProperty("displayDescription", NullValueHandling = NullValueHandling.Ignore)] string DisplayDescription,
        [property: JsonProperty("platforms", NullValueHandling = NullValueHandling.Ignore)] IReadOnlyList<Platform> Platforms,
        [property: JsonProperty("siblingGames", NullValueHandling = NullValueHandling.Ignore)] IReadOnlyList<SiblingGame> SiblingGames,
        [property: JsonProperty("installmentDefault", NullValueHandling = NullValueHandling.Ignore)] bool? InstallmentDefault,
        [property: JsonProperty("ageRating", NullValueHandling = NullValueHandling.Ignore)] AgeRatingGame AgeRating,
        [property: JsonProperty("releaseAt", NullValueHandling = NullValueHandling.Ignore)] DateTime? ReleaseAt,
        [property: JsonProperty("releaseStatusDisplayName", NullValueHandling = NullValueHandling.Ignore)] string ReleaseStatusDisplayName,
        [property: JsonProperty("imageUrls", NullValueHandling = NullValueHandling.Ignore)] ImageUrls ImageUrls,
        [property: JsonProperty("linkUrls", NullValueHandling = NullValueHandling.Ignore)] LinkUrls LinkUrls
    );

    public record ImageUrls(
        [property: JsonProperty("lowThumbnail", NullValueHandling = NullValueHandling.Ignore)] string LowThumbnail,
        [property: JsonProperty("highThumbnail", NullValueHandling = NullValueHandling.Ignore)] string HighThumbnail,
        [property: JsonProperty("background", NullValueHandling = NullValueHandling.Ignore)] string Background,
        [property: JsonProperty("lowBoxArt", NullValueHandling = NullValueHandling.Ignore)] string LowBoxArt,
        [property: JsonProperty("highBoxArt", NullValueHandling = NullValueHandling.Ignore)] string HighBoxArt,
        [property: JsonProperty("gameLogoFlat", NullValueHandling = NullValueHandling.Ignore)] string GameLogoFlat,
        [property: JsonProperty("gameLogoColor", NullValueHandling = NullValueHandling.Ignore)] string GameLogoColor,
        [property: JsonProperty("gameAvatar", NullValueHandling = NullValueHandling.Ignore)] string GameAvatar
    );

    public record LinkUrls(
        [property: JsonProperty("facebook", NullValueHandling = NullValueHandling.Ignore)] string Facebook,
        [property: JsonProperty("twitter", NullValueHandling = NullValueHandling.Ignore)] string Twitter,
        [property: JsonProperty("instagram", NullValueHandling = NullValueHandling.Ignore)] string Instagram,
        [property: JsonProperty("reddit", NullValueHandling = NullValueHandling.Ignore)] string Reddit,
        [property: JsonProperty("website", NullValueHandling = NullValueHandling.Ignore)] string Website
    );

    public record Platform(
        [property: JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)] string Type,
        [property: JsonProperty("displayName", NullValueHandling = NullValueHandling.Ignore)] string DisplayName,
        [property: JsonProperty("applicationId", NullValueHandling = NullValueHandling.Ignore)] string ApplicationId
    );

    public record CatalogRoot(
        [property: JsonProperty("games", NullValueHandling = NullValueHandling.Ignore)] IReadOnlyList<Game> Games
    );

    public record SiblingGame(
        [property: JsonProperty("spaceId", NullValueHandling = NullValueHandling.Ignore)] string SpaceId,
        [property: JsonProperty("platforms", NullValueHandling = NullValueHandling.Ignore)] IReadOnlyList<Platform> Platforms
    );
    #endregion
    #region Requests
    public class Request
    {
        [JsonProperty("indexName", NullValueHandling = NullValueHandling.Ignore)]

        public string IndexName;


        [JsonProperty("params", NullValueHandling = NullValueHandling.Ignore)]
        public string Params;
    }

    public record RequestRoot(
        [property: JsonProperty("requests", NullValueHandling = NullValueHandling.Ignore)] IReadOnlyList<Request> Requests
    );
    #endregion
    #region Spaces
    public record Spaces(
        [property: JsonProperty("spaceId", NullValueHandling = NullValueHandling.Ignore)] string SpaceId,
        [property: JsonProperty("spaceType", NullValueHandling = NullValueHandling.Ignore)] string SpaceType,
        [property: JsonProperty("spaceName", NullValueHandling = NullValueHandling.Ignore)] string SpaceName,
        [property: JsonProperty("parentSpaceId", NullValueHandling = NullValueHandling.Ignore)] string ParentSpaceId,
        [property: JsonProperty("parentSpaceName", NullValueHandling = NullValueHandling.Ignore)] string ParentSpaceName,
        [property: JsonProperty("releaseType", NullValueHandling = NullValueHandling.Ignore)] string ReleaseType,
        [property: JsonProperty("platformType", NullValueHandling = NullValueHandling.Ignore)] string PlatformType,
        [property: JsonProperty("dateCreated", NullValueHandling = NullValueHandling.Ignore)] DateTime DateCreated,
        [property: JsonProperty("dateLastModified", NullValueHandling = NullValueHandling.Ignore)] DateTime DateLastModified,
        [property: JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)] object Tags
    );
    #endregion
    #region Betas
    public record BetaPhase(
    [property: JsonProperty("BetaPhaseId", NullValueHandling = NullValueHandling.Ignore)] int BetaPhaseId,
    [property: JsonProperty("PhaseType", NullValueHandling = NullValueHandling.Ignore)] int PhaseType,
    [property: JsonProperty("Name", NullValueHandling = NullValueHandling.Ignore)] string Name,
    [property: JsonProperty("Tags", NullValueHandling = NullValueHandling.Ignore)] string Tags,
    [property: JsonProperty("Active", NullValueHandling = NullValueHandling.Ignore)] bool Active,
    [property: JsonProperty("SystemFields", NullValueHandling = NullValueHandling.Ignore)] IReadOnlyList<SystemField> SystemFields,
    [property: JsonProperty("PlayerGroups", NullValueHandling = NullValueHandling.Ignore)] IReadOnlyList<PlayerGroup> PlayerGroups,
    [property: JsonProperty("WebSiteUrl", NullValueHandling = NullValueHandling.Ignore)] string WebSiteUrl,
    [property: JsonProperty("ThumbnailUrl", NullValueHandling = NullValueHandling.Ignore)] string ThumbnailUrl,
    [property: JsonProperty("StartDate", NullValueHandling = NullValueHandling.Ignore)] DateTime? StartDate,
    [property: JsonProperty("EndDate", NullValueHandling = NullValueHandling.Ignore)] DateTime? EndDate
);

    public record PlayerGroup(
        [property: JsonProperty("PlayerGroupId", NullValueHandling = NullValueHandling.Ignore)] int PlayerGroupId,
        [property: JsonProperty("Name", NullValueHandling = NullValueHandling.Ignore)] string Name,
        [property: JsonProperty("Tags", NullValueHandling = NullValueHandling.Ignore)] string Tags,
        [property: JsonProperty("PlatformId", NullValueHandling = NullValueHandling.Ignore)] int PlatformId,
        [property: JsonProperty("DistributionMode", NullValueHandling = NullValueHandling.Ignore)] int DistributionMode,
        [property: JsonProperty("AttributionDate", NullValueHandling = NullValueHandling.Ignore)] DateTime? AttributionDate
    );

    public record BetasRoot(
        [property: JsonProperty("Code", NullValueHandling = NullValueHandling.Ignore)] string Code,
        [property: JsonProperty("Name", NullValueHandling = NullValueHandling.Ignore)] string Name,
        [property: JsonProperty("IntegrationType", NullValueHandling = NullValueHandling.Ignore)] int IntegrationType,
        [property: JsonProperty("AllowC2S", NullValueHandling = NullValueHandling.Ignore)] bool AllowC2S,
        [property: JsonProperty("SystemFields", NullValueHandling = NullValueHandling.Ignore)] IReadOnlyList<SystemField> SystemFields,
        [property: JsonProperty("BetaPhases", NullValueHandling = NullValueHandling.Ignore)] IReadOnlyList<BetaPhase> BetaPhases,
        [property: JsonProperty("Platforms", NullValueHandling = NullValueHandling.Ignore)] IReadOnlyList<int> Platforms
    );

    public record SystemField(
        [property: JsonProperty("SystemFieldId", NullValueHandling = NullValueHandling.Ignore)] int SystemFieldId,
        [property: JsonProperty("FieldName", NullValueHandling = NullValueHandling.Ignore)] string FieldName,
        [property: JsonProperty("FieldValue", NullValueHandling = NullValueHandling.Ignore)] string FieldValue,
        [property: JsonProperty("FieldDefaultValue", NullValueHandling = NullValueHandling.Ignore)] string FieldDefaultValue,
        [property: JsonProperty("UsedForPlayerRegistration", NullValueHandling = NullValueHandling.Ignore)] bool UsedForPlayerRegistration,
        [property: JsonProperty("Description", NullValueHandling = NullValueHandling.Ignore)] string Description,
        [property: JsonProperty("OrderNumber", NullValueHandling = NullValueHandling.Ignore)] int? OrderNumber,
        [property: JsonProperty("IsMandatory", NullValueHandling = NullValueHandling.Ignore)] bool IsMandatory
    );
    #endregion
    #region BetasProfile
    public record PlayerSystemField(
    [property: JsonProperty("FieldName", NullValueHandling = NullValueHandling.Ignore)] string FieldName,
    [property: JsonProperty("FieldValue", NullValueHandling = NullValueHandling.Ignore)] string FieldValue
);

    public record BetasProfileRoot(
        [property: JsonProperty("BetaPhaseId", NullValueHandling = NullValueHandling.Ignore)] int BetaPhaseId,
        [property: JsonProperty("PlayerGroupId", NullValueHandling = NullValueHandling.Ignore)] int? PlayerGroupId,
        [property: JsonProperty("PlatformId", NullValueHandling = NullValueHandling.Ignore)] int PlatformId,
        [property: JsonProperty("IsApproved", NullValueHandling = NullValueHandling.Ignore)] bool IsApproved,
        [property: JsonProperty("IsBanned", NullValueHandling = NullValueHandling.Ignore)] bool IsBanned,
        [property: JsonProperty("DateRegistered", NullValueHandling = NullValueHandling.Ignore)] DateTime DateRegistered,
        [property: JsonProperty("DateApprovedAction", NullValueHandling = NullValueHandling.Ignore)] DateTime? DateApprovedAction,
        [property: JsonProperty("AccessCode", NullValueHandling = NullValueHandling.Ignore)] object AccessCode,
        [property: JsonProperty("PlayerSourceIds", NullValueHandling = NullValueHandling.Ignore)] IReadOnlyList<int> PlayerSourceIds,
        [property: JsonProperty("CountryCode", NullValueHandling = NullValueHandling.Ignore)] string CountryCode,
        [property: JsonProperty("PlayerKey", NullValueHandling = NullValueHandling.Ignore)] object PlayerKey,
        [property: JsonProperty("PlayerSystemFields", NullValueHandling = NullValueHandling.Ignore)] IReadOnlyList<PlayerSystemField> PlayerSystemFields
    );
    #endregion
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
}
