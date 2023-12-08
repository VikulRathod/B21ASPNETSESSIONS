using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _2_ViewsDemo.Custom
{
    public static class CustomHtmlHelper
    {
        public static MvcHtmlString Button(this HtmlHelper html, string type, string value)
        {
            TagBuilder btn = new TagBuilder("input");
            btn.Attributes.Add("type", type);
            btn.Attributes.Add("value", value);

            return new MvcHtmlString(btn.ToString());
        }

        public static MvcHtmlString Image(this HtmlHelper html, 
            string path, string altText, string width, string height)
        {
            TagBuilder img = new TagBuilder("img");
            img.Attributes.Add("src",path);
            img.Attributes.Add("alt", altText);
            img.Attributes.Add("width", width);
            img.Attributes.Add("height", height);

            return new MvcHtmlString(img.ToString());
        }
    }
}