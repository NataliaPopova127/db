﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TextileStore2.Models.Entities
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class TradeEntities : DbContext
    {
        public TradeEntities()
            : base("name=TradeEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<OrderPickupPoint> OrderPickupPoint { get; set; }
        public virtual DbSet<OrderStatus> OrderStatus { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProductStatus> ProductStatus { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<isNotDeletedUsers> isNotDeletedUsers { get; set; }
        public virtual DbSet<ProductCategory> ProductCategory { get; set; }
        public virtual DbSet<ProductManufacter> ProductManufacter { get; set; }
        public virtual DbSet<ProductProvider> ProductProvider { get; set; }
        public virtual DbSet<ProductUnit> ProductUnit { get; set; }
        public virtual DbSet<ProductListForManagerAndClient> ProductListForManagerAndClient { get; set; }
    
        public virtual int AddUser(string userSurname, string userName, string userPatronymic, string userLogin, string userPassword, string userRole)
        {
            var userSurnameParameter = userSurname != null ?
                new ObjectParameter("UserSurname", userSurname) :
                new ObjectParameter("UserSurname", typeof(string));
    
            var userNameParameter = userName != null ?
                new ObjectParameter("UserName", userName) :
                new ObjectParameter("UserName", typeof(string));
    
            var userPatronymicParameter = userPatronymic != null ?
                new ObjectParameter("UserPatronymic", userPatronymic) :
                new ObjectParameter("UserPatronymic", typeof(string));
    
            var userLoginParameter = userLogin != null ?
                new ObjectParameter("UserLogin", userLogin) :
                new ObjectParameter("UserLogin", typeof(string));
    
            var userPasswordParameter = userPassword != null ?
                new ObjectParameter("UserPassword", userPassword) :
                new ObjectParameter("UserPassword", typeof(string));
    
            var userRoleParameter = userRole != null ?
                new ObjectParameter("UserRole", userRole) :
                new ObjectParameter("UserRole", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddUser", userSurnameParameter, userNameParameter, userPatronymicParameter, userLoginParameter, userPasswordParameter, userRoleParameter);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual int AddProduct(string productArticul, string productName, string productDescription, string productCategory, string productPhoto, string productManufacturer, Nullable<decimal> productCost, Nullable<byte> productDiscountAmount, Nullable<int> productMaxDiscountAmount, Nullable<int> productQuantityInStock, string productStatus, string productUnit, string productProvider, Nullable<bool> isDeleted)
        {
            var productArticulParameter = productArticul != null ?
                new ObjectParameter("ProductArticul", productArticul) :
                new ObjectParameter("ProductArticul", typeof(string));
    
            var productNameParameter = productName != null ?
                new ObjectParameter("ProductName", productName) :
                new ObjectParameter("ProductName", typeof(string));
    
            var productDescriptionParameter = productDescription != null ?
                new ObjectParameter("ProductDescription", productDescription) :
                new ObjectParameter("ProductDescription", typeof(string));
    
            var productCategoryParameter = productCategory != null ?
                new ObjectParameter("ProductCategory", productCategory) :
                new ObjectParameter("ProductCategory", typeof(string));
    
            var productPhotoParameter = productPhoto != null ?
                new ObjectParameter("ProductPhoto", productPhoto) :
                new ObjectParameter("ProductPhoto", typeof(string));
    
            var productManufacturerParameter = productManufacturer != null ?
                new ObjectParameter("ProductManufacturer", productManufacturer) :
                new ObjectParameter("ProductManufacturer", typeof(string));
    
            var productCostParameter = productCost.HasValue ?
                new ObjectParameter("ProductCost", productCost) :
                new ObjectParameter("ProductCost", typeof(decimal));
    
            var productDiscountAmountParameter = productDiscountAmount.HasValue ?
                new ObjectParameter("ProductDiscountAmount", productDiscountAmount) :
                new ObjectParameter("ProductDiscountAmount", typeof(byte));
    
            var productMaxDiscountAmountParameter = productMaxDiscountAmount.HasValue ?
                new ObjectParameter("ProductMaxDiscountAmount", productMaxDiscountAmount) :
                new ObjectParameter("ProductMaxDiscountAmount", typeof(int));
    
            var productQuantityInStockParameter = productQuantityInStock.HasValue ?
                new ObjectParameter("ProductQuantityInStock", productQuantityInStock) :
                new ObjectParameter("ProductQuantityInStock", typeof(int));
    
            var productStatusParameter = productStatus != null ?
                new ObjectParameter("ProductStatus", productStatus) :
                new ObjectParameter("ProductStatus", typeof(string));
    
            var productUnitParameter = productUnit != null ?
                new ObjectParameter("ProductUnit", productUnit) :
                new ObjectParameter("ProductUnit", typeof(string));
    
            var productProviderParameter = productProvider != null ?
                new ObjectParameter("ProductProvider", productProvider) :
                new ObjectParameter("ProductProvider", typeof(string));
    
            var isDeletedParameter = isDeleted.HasValue ?
                new ObjectParameter("IsDeleted", isDeleted) :
                new ObjectParameter("IsDeleted", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddProduct", productArticulParameter, productNameParameter, productDescriptionParameter, productCategoryParameter, productPhotoParameter, productManufacturerParameter, productCostParameter, productDiscountAmountParameter, productMaxDiscountAmountParameter, productQuantityInStockParameter, productStatusParameter, productUnitParameter, productProviderParameter, isDeletedParameter);
        }
    
        public virtual int EditProduct(string productArticul, string productName, string productDescription, string productCategory, string productPhoto, string productManufacturer, Nullable<decimal> productCost, Nullable<byte> productDiscountAmount, Nullable<int> productMaxDiscountAmount, Nullable<int> productQuantityInStock, string productStatus, string productUnit, string productProvider, Nullable<bool> isDeleted)
        {
            var productArticulParameter = productArticul != null ?
                new ObjectParameter("ProductArticul", productArticul) :
                new ObjectParameter("ProductArticul", typeof(string));
    
            var productNameParameter = productName != null ?
                new ObjectParameter("ProductName", productName) :
                new ObjectParameter("ProductName", typeof(string));
    
            var productDescriptionParameter = productDescription != null ?
                new ObjectParameter("ProductDescription", productDescription) :
                new ObjectParameter("ProductDescription", typeof(string));
    
            var productCategoryParameter = productCategory != null ?
                new ObjectParameter("ProductCategory", productCategory) :
                new ObjectParameter("ProductCategory", typeof(string));
    
            var productPhotoParameter = productPhoto != null ?
                new ObjectParameter("ProductPhoto", productPhoto) :
                new ObjectParameter("ProductPhoto", typeof(string));
    
            var productManufacturerParameter = productManufacturer != null ?
                new ObjectParameter("ProductManufacturer", productManufacturer) :
                new ObjectParameter("ProductManufacturer", typeof(string));
    
            var productCostParameter = productCost.HasValue ?
                new ObjectParameter("ProductCost", productCost) :
                new ObjectParameter("ProductCost", typeof(decimal));
    
            var productDiscountAmountParameter = productDiscountAmount.HasValue ?
                new ObjectParameter("ProductDiscountAmount", productDiscountAmount) :
                new ObjectParameter("ProductDiscountAmount", typeof(byte));
    
            var productMaxDiscountAmountParameter = productMaxDiscountAmount.HasValue ?
                new ObjectParameter("ProductMaxDiscountAmount", productMaxDiscountAmount) :
                new ObjectParameter("ProductMaxDiscountAmount", typeof(int));
    
            var productQuantityInStockParameter = productQuantityInStock.HasValue ?
                new ObjectParameter("ProductQuantityInStock", productQuantityInStock) :
                new ObjectParameter("ProductQuantityInStock", typeof(int));
    
            var productStatusParameter = productStatus != null ?
                new ObjectParameter("ProductStatus", productStatus) :
                new ObjectParameter("ProductStatus", typeof(string));
    
            var productUnitParameter = productUnit != null ?
                new ObjectParameter("ProductUnit", productUnit) :
                new ObjectParameter("ProductUnit", typeof(string));
    
            var productProviderParameter = productProvider != null ?
                new ObjectParameter("ProductProvider", productProvider) :
                new ObjectParameter("ProductProvider", typeof(string));
    
            var isDeletedParameter = isDeleted.HasValue ?
                new ObjectParameter("IsDeleted", isDeleted) :
                new ObjectParameter("IsDeleted", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("EditProduct", productArticulParameter, productNameParameter, productDescriptionParameter, productCategoryParameter, productPhotoParameter, productManufacturerParameter, productCostParameter, productDiscountAmountParameter, productMaxDiscountAmountParameter, productQuantityInStockParameter, productStatusParameter, productUnitParameter, productProviderParameter, isDeletedParameter);
        }
    }
}
