using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CorePortfolio.Models
{
    public class WPViewModel
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("date")]
        public DateTimeOffset Date { get; set; }

        [JsonProperty("date_gmt")]
        public DateTimeOffset DateGmt { get; set; }

        [JsonProperty("guid")]
        public Guid Guid { get; set; }

        [JsonProperty("modified")]
        public DateTimeOffset Modified { get; set; }

        [JsonProperty("modified_gmt")]
        public DateTimeOffset ModifiedGmt { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("title")]
        public Guid Title { get; set; }

        [JsonProperty("content")]
        public Content Content { get; set; }

        [JsonProperty("excerpt")]
        public Content Excerpt { get; set; }

        [JsonProperty("author")]
        public long Author { get; set; }

        [JsonProperty("featured_media")]
        public long FeaturedMedia { get; set; }

        [JsonProperty("comment_status")]
        public string CommentStatus { get; set; }

        [JsonProperty("ping_status")]
        public string PingStatus { get; set; }

        [JsonProperty("sticky")]
        public bool Sticky { get; set; }

        [JsonProperty("template")]
        public string Template { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("meta")]
        public object[] Meta { get; set; }

        [JsonProperty("categories")]
        public int[] Categories { get; set; }

        [JsonProperty("tags")]
        public List<string> Tags { get; set; }

        [JsonProperty("_links")]
        public WelcomeLinks Links { get; set; }

        [JsonProperty("_embedded")]
        public Embedded Embedded { get; set; }


    }

    public class Content
    {
        [JsonProperty("rendered")]
        public string Rendered { get; set; }

        [JsonProperty("protected")]
        public bool Protected { get; set; }
    }

    public class Embedded
    {
        [JsonProperty("author")]
        public EmbeddedAuthor[] Author { get; set; }

        [JsonProperty("wp:featuredmedia")]
        public WpFeaturedmedia[] WpFeaturedmedia { get; set; }

        [JsonProperty("wp:term")]
        public EmbeddedWpTerm[][] WpTerm { get; set; }
    }

    public class EmbeddedAuthor
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("avatar_urls")]
        public Dictionary<string, string> AvatarUrls { get; set; }

        [JsonProperty("_links")]
        public AuthorLinks Links { get; set; }
    }

    public class AuthorLinks
    {
        [JsonProperty("self")]
        public About[] Self { get; set; }

        [JsonProperty("collection")]
        public About[] Collection { get; set; }
    }

    public class About
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public class WpFeaturedmedia
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("date")]
        public DateTimeOffset Date { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("title")]
        public Guid Title { get; set; }

        [JsonProperty("author")]
        public long Author { get; set; }

        [JsonProperty("caption")]
        public Guid Caption { get; set; }

        [JsonProperty("alt_text")]
        public string AltText { get; set; }

        [JsonProperty("media_type")]
        public string MediaType { get; set; }

        [JsonProperty("mime_type")]
        public string MimeType { get; set; }

        [JsonProperty("media_details")]
        public MediaDetails MediaDetails { get; set; }

        [JsonProperty("source_url")]
        public string SourceUrl { get; set; }

        [JsonProperty("_links")]
        public WpFeaturedmediaLinks Links { get; set; }
    }

    public class Guid
    {
        [JsonProperty("rendered")]
        public string Rendered { get; set; }
    }

    public class WpFeaturedmediaLinks
    {
        [JsonProperty("self")]
        public About[] Self { get; set; }

        [JsonProperty("collection")]
        public About[] Collection { get; set; }

        [JsonProperty("about")]
        public About[] About { get; set; }

        [JsonProperty("author")]
        public ReplyElement[] Author { get; set; }

        [JsonProperty("replies")]
        public ReplyElement[] Replies { get; set; }
    }

    public class ReplyElement
    {
        [JsonProperty("embeddable")]
        public bool Embeddable { get; set; }

        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public class MediaDetails
    {
        [JsonProperty("width")]
        public long Width { get; set; }

        [JsonProperty("height")]
        public long Height { get; set; }

        [JsonProperty("file")]
        public string File { get; set; }

        [JsonProperty("image_meta")]
        public ImageMeta ImageMeta { get; set; }

        [JsonProperty("sizes")]
        public Sizes Sizes { get; set; }
    }

    public class Sizes
    {
        [JsonProperty("thumbnail")]
        public Full Thumbnail { get; set; }

        [JsonProperty("medium")]
        public Full Medium { get; set; }

        [JsonProperty("medium_large")]
        public Full MediumLarge { get; set; }

        [JsonProperty("full")]
        public Full Full { get; set; }
    }

    public class Full
    {
        [JsonProperty("file")]
        public string File { get; set; }

        [JsonProperty("width")]
        public long Width { get; set; }

        [JsonProperty("height")]
        public long Height { get; set; }

        [JsonProperty("mime_type")]
        public string MimeType { get; set; }

        [JsonProperty("source_url")]
        public string SourceUrl { get; set; }
    }

    public class ImageMeta
    {
        [JsonProperty("aperture")]
        public long Aperture { get; set; }

        [JsonProperty("credit")]
        public string Credit { get; set; }

        [JsonProperty("camera")]
        public string Camera { get; set; }

        [JsonProperty("caption")]
        public string Caption { get; set; }

        [JsonProperty("created_timestamp")]
        public long CreatedTimestamp { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("focal_length")]
        public long FocalLength { get; set; }

        [JsonProperty("iso")]
        public long Iso { get; set; }

        [JsonProperty("shutter_speed")]
        public long ShutterSpeed { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("orientation")]
        public long Orientation { get; set; }

        [JsonProperty("keywords")]
        public object[] Keywords { get; set; }
    }

    public class EmbeddedWpTerm
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("taxonomy")]
        public string Taxonomy { get; set; }

        [JsonProperty("_links")]
        public WpTermLinks Links { get; set; }
    }

    public class WpTermLinks
    {
        [JsonProperty("self")]
        public About[] Self { get; set; }

        [JsonProperty("collection")]
        public About[] Collection { get; set; }

        [JsonProperty("about")]
        public About[] About { get; set; }

        [JsonProperty("wp:post_type")]
        public About[] WpPostType { get; set; }


        [JsonProperty("up", NullValueHandling = NullValueHandling.Ignore)]
        public ReplyElement[] Up { get; set; }
    }


    public class WelcomeLinks
    {
        [JsonProperty("self")]
        public About[] Self { get; set; }

        [JsonProperty("collection")]
        public About[] Collection { get; set; }

        [JsonProperty("about")]
        public About[] About { get; set; }

        [JsonProperty("author")]
        public ReplyElement[] Author { get; set; }

        [JsonProperty("replies")]
        public ReplyElement[] Replies { get; set; }

        [JsonProperty("version-history")]
        public About[] VersionHistory { get; set; }

        [JsonProperty("wp:featuredmedia")]
        public ReplyElement[] WpFeaturedmedia { get; set; }

        [JsonProperty("wp:attachment")]
        public About[] WpAttachment { get; set; }

        [JsonProperty("wp:term")]
        public LinksWpTerm[] WpTerm { get; set; }

    }

    public class LinksWpTerm
    {
        [JsonProperty("taxonomy")]
        public string Taxonomy { get; set; }

        [JsonProperty("embeddable")]
        public bool Embeddable { get; set; }

        [JsonProperty("href")]
        public string Href { get; set; }
    }

}
