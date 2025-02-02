﻿using Grand.Domain.Catalog;

namespace Grand.Business.Catalog.Services.ExportImport.Dto
{
    public class ProductDto
    {
        public string Id { get; set; }
        public ProductType? ProductTypeId { get; set; }
        public string ParentGroupedProductId { get; set; }
        public bool? VisibleIndividually { get; set; }
        public string Name { get; set; }
        public string SeName { get; set; }
        public string ShortDescription { get; set; }
        public string FullDescription { get; set; }
        public string AdminComment { get; set; }
        public string ProductLayoutId { get; set; }
        public string BrandId { get; set; }
        public string VendorId { get; set; }
        public bool? ShowOnHomePage { get; set; }
        public bool? BestSeller { get; set; }
        public string MetaKeywords { get; set; }
        public string MetaDescription { get; set; }
        public string MetaTitle { get; set; }
        public bool? AllowCustomerReviews { get; set; }
        public int? ApprovedRatingSum { get; set; }
        public int? NotApprovedRatingSum { get; set; }
        public int? ApprovedTotalReviews { get; set; }
        public int? NotApprovedTotalReviews { get; set; }
        public string ExternalId { get; set; }
        public string Sku { get; set; }
        public string Mpn { get; set; }
        public string Gtin { get; set; }
        public bool? IsGiftVoucher { get; set; }
        public GiftVoucherType? GiftVoucherTypeId { get; set; }
        public double? OverGiftAmount { get; set; }
        public bool? RequireOtherProducts { get; set; }
        public string RequiredProductIds { get; set; }
        public bool? AutoAddRequiredProducts { get; set; }
        public bool? IsDownload { get; set; }
        public bool? UnlimitedDownloads { get; set; }
        public int? MaxNumberOfDownloads { get; set; }
        public int? DownloadExpirationDays { get; set; }
        public DownloadActivationType? DownloadActivationTypeId { get; set; }
        public bool? HasSampleDownload { get; set; }
        public bool? HasUserAgreement { get; set; }
        public string UserAgreementText { get; set; }
        public bool? IsRecurring { get; set; }
        public int? RecurringCycleLength { get; set; }
        public RecurringCyclePeriod? RecurringCyclePeriodId { get; set; }
        public int? RecurringTotalCycles { get; set; }
        public bool? IncBothDate { get; set; }
        public int? Interval { get; set; }
        public IntervalUnit? IntervalUnitId { get; set; }
        public bool? IsShipEnabled { get; set; }
        public bool? IsFreeShipping { get; set; }
        public bool? ShipSeparately { get; set; }
        public double? AdditionalShippingCharge { get; set; }
        public string DeliveryDateId { get; set; }
        public bool? IsTaxExempt { get; set; }
        public string TaxCategoryId { get; set; }
        public bool? IsTele { get; set; }
        public ManageInventoryMethod? ManageInventoryMethodId { get; set; }
        public bool? UseMultipleWarehouses { get; set; }
        public string WarehouseId { get; set; }
        public int? StockQuantity { get; set; }
        public int? ReservedQuantity { get; set; }
        public bool? StockAvailability { get; set; }
        public bool? DisplayStockQuantity { get; set; }
        public int? MinStockQuantity { get; set; }
        public bool? LowStock { get; set; }
        public LowStockActivity? LowStockActivityId { get; set; }
        public int? NotifyAdminForQuantityBelow { get; set; }
        public BackorderMode? BackorderModeId { get; set; }
        public bool? AllowOutOfStockSubscriptions { get; set; }
        public int? OrderMinimumQuantity { get; set; }
        public int? OrderMaximumQuantity { get; set; }
        public string AllowedQuantities { get; set; }
        public bool? NotReturnable { get; set; }
        public bool? DisableBuyButton { get; set; }
        public bool? DisableWishlistButton { get; set; }
        public bool? AvailableForPreOrder { get; set; }
        public DateTime? PreOrderDateTimeUtc { get; set; }
        public bool? CallForPrice { get; set; }
        public double? Price { get; set; }
        public double? OldPrice { get; set; }
        public double? CatalogPrice { get; set; }
        public double? ProductCost { get; set; }
        public bool? EnteredPrice { get; set; }
        public double? MinEnteredPrice { get; set; }
        public double? MaxEnteredPrice { get; set; }
        public bool? BasepriceEnabled { get; set; }
        public double? BasepriceAmount { get; set; }
        public string BasepriceUnitId { get; set; }
        public double? BasepriceBaseAmount { get; set; }
        public string BasepriceBaseUnitId { get; set; }
        public string UnitId { get; set; }
        public string CourseId { get; set; }
        public bool? MarkAsNew { get; set; }
        public DateTime? MarkAsNewStartDateTimeUtc { get; set; }
        public DateTime? MarkAsNewEndDateTimeUtc { get; set; }
        public double? Weight { get; set; }
        public double? Length { get; set; }
        public double? Width { get; set; }
        public double? Height { get; set; }
        public DateTime? AvailableStartDateTimeUtc { get; set; }
        public DateTime? AvailableEndDateTimeUtc { get; set; }
        public int? DisplayOrder { get; set; }
        public int? DisplayOrderCategory { get; set; }
        public int? DisplayOrderBrand { get; set; }
        public int? DisplayOrderCollection { get; set; }
        public bool? Published { get; set; }
        public int? Sold { get; set; }
        public Int64? Viewed { get; set; }
        public int? OnSale { get; set; }
        public string Flag { get; set; }
        public string CategoryIds { get; set; }
        public string CollectionIds { get; set; }
        public string Picture1 { get; set; }
        public string Picture2 { get; set; }
        public string Picture3 { get; set; }
    }
}
