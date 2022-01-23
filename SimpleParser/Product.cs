using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleParser
{
    public class Product
    {
        public Product(ICollection<Category> categoriesTypes, string id, string active, string name, string categories, string priceTaxExclude, string taxRule, string wholeSalePrice, string onSale, string discountAmount, string discountPercent, string discountFrom, string discountTo, string bbReference, string supplierReference, string supplier, string manufacter, string ean13, string upc, string ecotax, string width, string height, string depth, string weight, string quantity, string minimalQuantity, string visibility, string additionalShippingCost, string unity, string unitPrice, string shortDescription, string description, string tags, string metaTitle, string metaKeywords, string metaDescription, string urlRewritten, string textWhenInStock, string textWhenBackoderAllowed, string availableForOrder, string productAvailableDate, string productCreationDate, string productUpdateDate, string showPrice, string imagesUrl, string deleteExistingImages, string feature, string availableOnlineOnly, string condition, string customizable, string uploadableFiles, string textFields, string outOfStock, string idNameOfShop, string advancedStockManagement, string dependsOnStock, string warehouse)
        {
            Id = Convert.ToInt32(id);
            Active = active;
            Name = name.Substring(1,name.Length-2);
            Categories = ParseCategories(categories,categoriesTypes);
            PriceTaxExclude = priceTaxExclude;
            TaxRule = taxRule ;
            WholeSalePrice = wholeSalePrice;
            OnSale = onSale;
            DiscountAmount = discountAmount;
            DiscountPercent = discountPercent;
            DiscountFrom = discountFrom;
            DiscountTo = discountTo;
            BbReference = bbReference;
            SupplierReference = supplierReference;
            Supplier = supplier;
            Manufacter = manufacter;
            Ean13 = ean13;
            Upc = upc;
            Ecotax = ecotax;
            Width = width;
            Height = height;
            Depth = depth;
            Weight = weight;
            Quantity = quantity;
            MinimalQuantity = minimalQuantity;
            Visibility = visibility;
            AdditionalShippingCost = additionalShippingCost;
            Unity = unity;
            UnitPrice = unitPrice;
            ShortDescription = shortDescription.StartsWith("\\") ? shortDescription.Substring(1, shortDescription.Length - 2) : shortDescription;
            Description = description.StartsWith("\\") ? description.Substring(1, description.Length - 2) : description;
            Tags = tags;
            MetaTitle = metaTitle;
            MetaKeywords = metaKeywords;
            MetaDescription = metaDescription;
            UrlRewritten = urlRewritten;
            TextWhenInStock = textWhenInStock;
            TextWhenBackoderAllowed = textWhenBackoderAllowed;
            AvailableForOrder = availableForOrder;
            ProductAvailableDate = productAvailableDate;
            ProductCreationDate = productCreationDate;
            ProductUpdateDate = productUpdateDate;
            ShowPrice = showPrice;
            ImagesUrl = imagesUrl;
            DeleteExistingImages = deleteExistingImages;
            Feature = feature;
            AvailableOnlineOnly = availableOnlineOnly;
            Condition = condition;
            Customizable = customizable;
            UploadableFiles = uploadableFiles;
            TextFields = textFields;
            OutOfStock = outOfStock;
            IdNameOfShop = idNameOfShop;
            AdvancedStockManagement = advancedStockManagement;
            DependsOnStock = dependsOnStock;
            Warehouse = warehouse;
        }

        private ICollection<Category> ParseCategories(string categories, ICollection<Category> categoriesTypes)
        {
            var categoryIds = categories.Split(',', StringSplitOptions.RemoveEmptyEntries);
            ICollection < Category > result = new List<Category>();
            foreach (var categoryId in categoryIds)
            {
                var category = categoriesTypes.FirstOrDefault(x => x.Id == int.Parse(categoryId));
                if(category != null)
                    result.Add(category);
            }

            return result;
        }

        public int Id { get; set; }
        public string Active { get; set; }
        public string Name { get; set; }
        public ICollection<Category> Categories { get; set; }
        public string PriceTaxExclude { get; set; }
        public string TaxRule { get; set; }
        public string WholeSalePrice { get; set; }
        public string OnSale { get; set; }
        public string DiscountAmount { get; set; }
        public string DiscountPercent { get; set; }
        public string DiscountFrom { get; set; }
        public string DiscountTo { get; set; }
        public string BbReference { get; set; }
        public string SupplierReference { get; set; }
        public string Supplier { get; set; }
        public string Manufacter { get; set; }
        public string Ean13 { get; set; }
        public string Upc { get; set; }
        public string Ecotax { get; set; }
        public string Width { get; set; }
        public string Height { get; set; }
        public string Depth { get; set; }
        public string Weight { get; set; }
        public string Quantity { get; set; }
        public string MinimalQuantity { get; set; }
        public string Visibility { get; set; }
        public string AdditionalShippingCost { get; set; }
        public string Unity { get; set; }
        public string UnitPrice { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public string Tags { get; set; }
        public string MetaTitle { get; set; }
        public string MetaKeywords { get; set; }
        public string MetaDescription { get; set; }
        public string UrlRewritten { get; set; }
        public string TextWhenInStock { get; set; }
        public string TextWhenBackoderAllowed { get; set; }
        public string AvailableForOrder { get; set; }
        public string ProductAvailableDate { get; set; }
        public string ProductCreationDate { get; set; }
        public string ProductUpdateDate { get; set; }
        public string ShowPrice { get; set; }
        public string ImagesUrl { get; set; }
        public string DeleteExistingImages { get; set; }
        public string Feature { get; set; }
        public string AvailableOnlineOnly { get; set; }
        public string Condition { get; set; }
        public string Customizable { get; set; }
        public string UploadableFiles { get; set; }
        public string TextFields { get; set; }
        public string OutOfStock { get; set; }
        public string IdNameOfShop { get; set; }
        public string AdvancedStockManagement { get; set; }
        public string DependsOnStock { get; set; }
        public string Warehouse { get; set; }
    }
}
