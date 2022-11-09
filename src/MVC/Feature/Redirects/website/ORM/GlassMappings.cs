﻿using Glass.Mapper.Sc.Maps;
using Helixbase.Feature.Redirects.Models;

namespace Helixbase.Feature.Redirects.ORM
{
    public class RedirectFolderMap : SitecoreGlassMap<IRedirectFolder>
    {
        public override void Configure()
        {
            Map(config =>
            {
                config.AutoMap();
                config.TemplateId(Templates.RedirectFolder.TemplateId);
                config.Query(y => y.Children)
                    .Query($".//*[@@templateid='{Templates.RedirectContentItem.TemplateId.ToString("B").ToUpper()}']")
                    .IsRelative(); //A query is required as we need all descendants, not just children
            });
        }
    }

    public class RedirectMap : SitecoreGlassMap<I301Redirect>
    {
        public override void Configure()
        {
            Map(config =>
            {
                config.AutoMap();
                config.TemplateId(Templates.RedirectContentItem.TemplateId);
            });
        }
    }

    public class GlassBaseMappings : SitecoreGlassMap<IRedirectGlassBase>
    {
        public override void Configure()
        {
            Map(config =>
            {
                config.AutoMap();
            });
        }
    }
}