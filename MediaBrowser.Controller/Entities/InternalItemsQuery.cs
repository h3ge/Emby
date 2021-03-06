﻿using MediaBrowser.Model.Entities;
using System;
using System.Collections.Generic;
using MediaBrowser.Model.Configuration;
using System.Linq;
using MediaBrowser.Controller.Dto;

namespace MediaBrowser.Controller.Entities
{
    public class InternalItemsQuery
    {
        public bool Recursive { get; set; }

        public int? StartIndex { get; set; }

        public int? Limit { get; set; }

        public User User { get; set; }

        public BaseItem SimilarTo { get; set; }

        public bool? IsFolder { get; set; }
        public bool? IsFavorite { get; set; }
        public bool? IsFavoriteOrLiked { get; set; }
        public bool? IsLiked { get; set; }
        public bool? IsPlayed { get; set; }
        public bool? IsResumable { get; set; }
        public bool? IncludeItemsByName { get; set; }

        public string[] MediaTypes { get; set; }
        public string[] IncludeItemTypes { get; set; }
        public string[] ExcludeItemTypes { get; set; }
        public string[] ExcludeTags { get; set; }
        public string[] ExcludeInheritedTags { get; set; }
        public string[] Genres { get; set; }

        public bool? HasOwnerId { get; set; }
        public Dictionary<string, string> HasAnyProviderId { get; set; }

        public bool? IsSpecialSeason { get; set; }
        public bool? IsMissing { get; set; }
        public bool? IsUnaired { get; set; }
        public bool? CollapseBoxSetItems { get; set; }

        public string NameStartsWithOrGreater { get; set; }
        public string NameStartsWith { get; set; }
        public string NameLessThan { get; set; }
        public string NameContains { get; set; }
        public string SearchTerm { get; set; }
        public string MinSortName { get; set; }

        public string PresentationUniqueKey { get; set; }
        public string Path { get; set; }
        public string PathNotStartsWith { get; set; }
        public string Name { get; set; }

        public string Person { get; set; }
        public Guid[] PersonIds { get; set; }
        public Guid[] ItemIds { get; set; }
        public Guid[] ExcludeItemIds { get; set; }
        public string AdjacentTo { get; set; }
        public string[] PersonTypes { get; set; }

        public int? MinWidth { get; set; }
        public int? MinHeight { get; set; }
        public int? MaxWidth { get; set; }
        public int? MaxHeight { get; set; }

        public bool? Is3D { get; set; }
        public bool? IsLocked { get; set; }
        public bool? IsPlaceHolder { get; set; }

        public bool? HasImdbId { get; set; }
        public bool? HasOverview { get; set; }
        public bool? HasTmdbId { get; set; }
        public bool? HasOfficialRating { get; set; }
        public bool? HasTvdbId { get; set; }
        public bool? HasThemeSong { get; set; }
        public bool? HasThemeVideo { get; set; }
        public bool? HasSubtitles { get; set; }
        public bool? HasSpecialFeature { get; set; }
        public bool? HasTrailer { get; set; }
        public bool? HasParentalRating { get; set; }

        public Guid[] StudioIds { get; set; }
        public Guid[] GenreIds { get; set; }
        public ImageType[] ImageTypes { get; set; }
        public VideoType[] VideoTypes { get; set; }
        public UnratedItem[] BlockUnratedItems { get; set; }
        public int[] Years { get; set; }
        public string[] Tags { get; set; }
        public string[] OfficialRatings { get; set; }

        public DateTime? MinPremiereDate { get; set; }
        public DateTime? MaxPremiereDate { get; set; }
        public DateTime? MinStartDate { get; set; }
        public DateTime? MaxStartDate { get; set; }
        public DateTime? MinEndDate { get; set; }
        public DateTime? MaxEndDate { get; set; }
        public bool? IsAiring { get; set; }
        public bool? HasAired { get; set; }

        public bool? IsHD { get; set; }
        public bool? Is4K { get; set; }

        public bool? IsMovie { get; set; }
        public bool? IsSports { get; set; }
        public bool? IsKids { get; set; }
        public bool? IsNews { get; set; }
        public bool? IsSeries { get; set; }

        public int? MinPlayers { get; set; }
        public int? MaxPlayers { get; set; }
        public int? MinIndexNumber { get; set; }
        public double? MinCriticRating { get; set; }
        public double? MinCommunityRating { get; set; }

        public Guid[] ChannelIds { get; set; }

        public int? ParentIndexNumber { get; set; }
        public int? ParentIndexNumberNotEquals { get; set; }
        public int? IndexNumber { get; set; }
        public int? MinParentalRating { get; set; }
        public int? MaxParentalRating { get; set; }

        public bool? HasDeadParentId { get; set; }
        public bool? IsVirtualItem { get; set; }

        public Guid ParentId { get; set; }
        public string ParentType { get; set; }
        public Guid[] AncestorIds { get; set; }
        public Guid[] TopParentIds { get; set; }

        public Guid[] BoxSetLibraryFolders { get; set; }

        public BaseItem Parent
        {
            set
            {
                if (value == null)
                {
                    ParentId = Guid.Empty;
                    ParentType = null;
                }
                else
                {
                    ParentId = value.Id;
                    ParentType = value.GetType().Name;
                }
            }
        }

        public string[] PresetViews { get; set; }
        public TrailerType[] TrailerTypes { get; set; }
        public SourceType[] SourceTypes { get; set; }

        public SeriesStatus[] SeriesStatuses { get; set; }
        public string ExternalSeriesId { get; set; }
        public string ExternalId { get; set; }

        public Guid[] AlbumIds { get; set; }
        public Guid[] ArtistIds { get; set; }
        public Guid[] AlbumArtistIds { get; set; }
        public Guid[] ContributingArtistIds { get; set; }
        public Guid[] ExcludeArtistIds { get; set; }
        public string AncestorWithPresentationUniqueKey { get; set; }
        public string SeriesPresentationUniqueKey { get; set; }

        public bool GroupByPresentationUniqueKey { get; set; }
        public bool GroupBySeriesPresentationUniqueKey { get; set; }
        public bool EnableTotalRecordCount { get; set; }
        public bool ForceDirect { get; set; }
        public Dictionary<string, string> ExcludeProviderIds { get; set; }
        public bool EnableGroupByMetadataKey { get; set; }
        public bool? HasChapterImages { get; set; }

        public ValueTuple<string, SortOrder>[] OrderBy { get; set; }

        public DateTime? MinDateCreated { get; set; }
        public DateTime? MinDateLastSaved { get; set; }
        public DateTime? MinDateLastSavedForUser { get; set; }

        public DtoOptions DtoOptions { get; set; }
        public int MinSimilarityScore { get; set; }
        public string HasNoAudioTrackWithLanguage { get; set; }
        public string HasNoInternalSubtitleTrackWithLanguage { get; set; }
        public string HasNoExternalSubtitleTrackWithLanguage { get; set; }
        public string HasNoSubtitleTrackWithLanguage { get; set; }
        public string SeriesTimerId { get; set; }
        public bool? IsDeadArtist { get; set; }
        public bool? IsDeadStudio { get; set; }
        public bool? IsDeadPerson { get; set; }

        public InternalItemsQuery()
        {
            MinSimilarityScore = 20;

            GroupByPresentationUniqueKey = true;
            EnableTotalRecordCount = true;

            DtoOptions = new DtoOptions();
            AlbumIds = Array.Empty<Guid>();
            ArtistIds = Array.Empty<Guid>();
            AlbumArtistIds = Array.Empty<Guid>();
            ContributingArtistIds = Array.Empty<Guid>();
            ExcludeArtistIds = Array.Empty<Guid>();
            ExcludeProviderIds = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            HasAnyProviderId = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

            BlockUnratedItems = new UnratedItem[] { };
            Tags = Array.Empty<string>();
            OfficialRatings = Array.Empty<string>();
            MediaTypes = Array.Empty<string>();
            IncludeItemTypes = Array.Empty<string>();
            ExcludeItemTypes = Array.Empty<string>();
            Genres = Array.Empty<string>();
            StudioIds = Array.Empty<Guid>();
            GenreIds = Array.Empty<Guid>();
            BoxSetLibraryFolders = Array.Empty<Guid>();
            ImageTypes = new ImageType[] { };
            VideoTypes = new VideoType[] { };
            Years = Array.Empty<int>();
            PersonTypes = Array.Empty<string>();
            PersonIds = Array.Empty<Guid>();
            ChannelIds = Array.Empty<Guid>();
            ItemIds = Array.Empty<Guid>();
            ExcludeItemIds = Array.Empty<Guid>();
            AncestorIds = Array.Empty<Guid>();
            TopParentIds = Array.Empty<Guid>();
            ExcludeTags = Array.Empty<string>();
            ExcludeInheritedTags = Array.Empty<string>();
            PresetViews = Array.Empty<string>();
            TrailerTypes = new TrailerType[] { };
            SourceTypes = new SourceType[] { };
            SeriesStatuses = new SeriesStatus[] { };
            OrderBy = Array.Empty<ValueTuple<string, SortOrder>>();
        }

        public InternalItemsQuery(User user)
            : this()
        {
            SetUser(user);
        }

        public void SetUser(User user)
        {
            if (user != null)
            {
                var policy = user.Policy;
                MaxParentalRating = policy.MaxParentalRating;

                if (policy.MaxParentalRating.HasValue)
                {
                    BlockUnratedItems = policy.BlockUnratedItems.Where(i => i != UnratedItem.Other).ToArray();
                }

                ExcludeInheritedTags = policy.BlockedTags;

                User = user;
            }
        }
    }
}
