using System;

namespace SimpleParser
{
    public class Category
    {
        public Category(string id, string active, string name, string parentCategoryName, string rootCategory, string description, string metaTitle, string metaKeywords, string metaDescription, string urlRewritten, object image, string dateAdd, string dateUpd)
        {
            Id = Int32.Parse(id);
            Active = active;
            Name = name.StartsWith("\\")? name.Substring(1, name.Length - 2):name;
            ParentCategoryName = parentCategoryName;
            RootCategory = Int32.Parse(rootCategory);
            Description = description;
            MetaTitle = metaTitle;
            MetaKeywords = metaKeywords;
            MetaDescription = metaDescription;
            UrlRewritten = urlRewritten;
            Image = image;
            var parsed = dateAdd.Substring(1, dateAdd.Length - 2);
            DateAdd = DateTime.Parse(parsed);
            parsed = dateUpd.Substring(1, dateUpd.Length - 2);
            DateUpd = DateTime.Parse(parsed);
        }

        public int Id { get; set; }

        public string Active { get; set; }

        public string Name { get; set; }

        public string ParentCategoryName { get; set; }

        public int RootCategory { get; set; }

        public string Description { get; set; }

        public string MetaTitle { get; set; }
        public string MetaKeywords { get; set; }
        public string MetaDescription { get; set; }
        public string UrlRewritten { get; set; }
        public object Image { get; set; }
        public DateTime DateAdd { get; set; }
        public DateTime DateUpd { get; set; }

        //ID ACTIVE  NAME PARENT_CATEGORY ROOT_CATEGORY DESCRIPTION META_TITLE META_KEYWORDS   META_DESCRIPTION URL_REWRITTEN   IMAGE_URL DATE_ADD    DATE_UPD
    }
}
