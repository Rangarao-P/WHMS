﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WHMS_Project.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class WHMS_DB_NewEntities : DbContext
    {
        public WHMS_DB_NewEntities()
            : base("name=WHMS_DB_NewEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Driver> Drivers { get; set; }
        public virtual DbSet<InLedger> InLedgers { get; set; }
        public virtual DbSet<InLedgerLocation> InLedgerLocations { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Logistic> Logistics { get; set; }
        public virtual DbSet<OutLedger> OutLedgers { get; set; }
        public virtual DbSet<OutLedgerLocation> OutLedgerLocations { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Truck> Trucks { get; set; }
        public virtual DbSet<User> Users { get; set; }
    
        public virtual int createLogisticsRequest(Nullable<int> pcode, string pname, Nullable<int> quantity, string pnature, Nullable<int> parea, Nullable<int> weight, string pickup, string drop)
        {
            var pcodeParameter = pcode.HasValue ?
                new ObjectParameter("pcode", pcode) :
                new ObjectParameter("pcode", typeof(int));
    
            var pnameParameter = pname != null ?
                new ObjectParameter("pname", pname) :
                new ObjectParameter("pname", typeof(string));
    
            var quantityParameter = quantity.HasValue ?
                new ObjectParameter("quantity", quantity) :
                new ObjectParameter("quantity", typeof(int));
    
            var pnatureParameter = pnature != null ?
                new ObjectParameter("pnature", pnature) :
                new ObjectParameter("pnature", typeof(string));
    
            var pareaParameter = parea.HasValue ?
                new ObjectParameter("parea", parea) :
                new ObjectParameter("parea", typeof(int));
    
            var weightParameter = weight.HasValue ?
                new ObjectParameter("weight", weight) :
                new ObjectParameter("weight", typeof(int));
    
            var pickupParameter = pickup != null ?
                new ObjectParameter("pickup", pickup) :
                new ObjectParameter("pickup", typeof(string));
    
            var dropParameter = drop != null ?
                new ObjectParameter("drop", drop) :
                new ObjectParameter("drop", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("createLogisticsRequest", pcodeParameter, pnameParameter, quantityParameter, pnatureParameter, pareaParameter, weightParameter, pickupParameter, dropParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> sp_ChangePassword_CheckUser(string email, string pwd)
        {
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            var pwdParameter = pwd != null ?
                new ObjectParameter("pwd", pwd) :
                new ObjectParameter("pwd", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("sp_ChangePassword_CheckUser", emailParameter, pwdParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> sp_ChangePassword_CheckUserID(string uid, string pwd)
        {
            var uidParameter = uid != null ?
                new ObjectParameter("uid", uid) :
                new ObjectParameter("uid", typeof(string));
    
            var pwdParameter = pwd != null ?
                new ObjectParameter("pwd", pwd) :
                new ObjectParameter("pwd", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("sp_ChangePassword_CheckUserID", uidParameter, pwdParameter);
        }
    
        public virtual int sp_ChangePassword_EMail(string email, string pwd)
        {
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            var pwdParameter = pwd != null ?
                new ObjectParameter("pwd", pwd) :
                new ObjectParameter("pwd", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_ChangePassword_EMail", emailParameter, pwdParameter);
        }
    
        public virtual int sp_ChangePassword_UID(string uid, string pwd)
        {
            var uidParameter = uid != null ?
                new ObjectParameter("uid", uid) :
                new ObjectParameter("uid", typeof(string));
    
            var pwdParameter = pwd != null ?
                new ObjectParameter("pwd", pwd) :
                new ObjectParameter("pwd", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_ChangePassword_UID", uidParameter, pwdParameter);
        }
    
        public virtual ObjectResult<SP_display_product_details_Result> SP_display_product_details()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_display_product_details_Result>("SP_display_product_details");
        }
    
        public virtual ObjectResult<sp_DisplayTruckStatus_Result> sp_DisplayTruckStatus(Nullable<int> requestId)
        {
            var requestIdParameter = requestId.HasValue ?
                new ObjectParameter("RequestId", requestId) :
                new ObjectParameter("RequestId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_DisplayTruckStatus_Result>("sp_DisplayTruckStatus", requestIdParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> sp_ForgotPassword_CheckEmail(string email)
        {
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("sp_ForgotPassword_CheckEmail", emailParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> sp_ForgotPassword_CheckUID(string uID)
        {
            var uIDParameter = uID != null ?
                new ObjectParameter("UID", uID) :
                new ObjectParameter("UID", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("sp_ForgotPassword_CheckUID", uIDParameter);
        }
    
        public virtual int sp_InsertUser(string username, string name, string password, string eMail)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            var eMailParameter = eMail != null ?
                new ObjectParameter("EMail", eMail) :
                new ObjectParameter("EMail", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_InsertUser", usernameParameter, nameParameter, passwordParameter, eMailParameter);
        }
    
        public virtual int sp_OutLedger(Nullable<int> productcode, string deliverylocation, Nullable<int> quantity)
        {
            var productcodeParameter = productcode.HasValue ?
                new ObjectParameter("productcode", productcode) :
                new ObjectParameter("productcode", typeof(int));
    
            var deliverylocationParameter = deliverylocation != null ?
                new ObjectParameter("deliverylocation", deliverylocation) :
                new ObjectParameter("deliverylocation", typeof(string));
    
            var quantityParameter = quantity.HasValue ?
                new ObjectParameter("quantity", quantity) :
                new ObjectParameter("quantity", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_OutLedger", productcodeParameter, deliverylocationParameter, quantityParameter);
        }
    
        public virtual int sp_UpdateQuantity(Nullable<int> productcode, Nullable<decimal> quantity)
        {
            var productcodeParameter = productcode.HasValue ?
                new ObjectParameter("productcode", productcode) :
                new ObjectParameter("productcode", typeof(int));
    
            var quantityParameter = quantity.HasValue ?
                new ObjectParameter("quantity", quantity) :
                new ObjectParameter("quantity", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_UpdateQuantity", productcodeParameter, quantityParameter);
        }
    
        public virtual int sp_updateUserType(string uid, Nullable<int> utype)
        {
            var uidParameter = uid != null ?
                new ObjectParameter("uid", uid) :
                new ObjectParameter("uid", typeof(string));
    
            var utypeParameter = utype.HasValue ?
                new ObjectParameter("utype", utype) :
                new ObjectParameter("utype", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_updateUserType", uidParameter, utypeParameter);
        }
    
        public virtual ObjectResult<sp_new_locationQuery_Result> sp_new_locationQuery(Nullable<int> productCode, Nullable<int> quantity)
        {
            var productCodeParameter = productCode.HasValue ?
                new ObjectParameter("productCode", productCode) :
                new ObjectParameter("productCode", typeof(int));
    
            var quantityParameter = quantity.HasValue ?
                new ObjectParameter("Quantity", quantity) :
                new ObjectParameter("Quantity", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_new_locationQuery_Result>("sp_new_locationQuery", productCodeParameter, quantityParameter);
        }
    
        public virtual ObjectResult<sp_ProductCartDetails_Result> sp_ProductCartDetails()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_ProductCartDetails_Result>("sp_ProductCartDetails");
        }
    
        public virtual int sp_add_new_product(Nullable<int> productcode, string productnature, string name, Nullable<decimal> currentstock, Nullable<int> length, Nullable<int> width, Nullable<int> height, Nullable<int> weight, Nullable<int> productarea, Nullable<int> threshold)
        {
            var productcodeParameter = productcode.HasValue ?
                new ObjectParameter("productcode", productcode) :
                new ObjectParameter("productcode", typeof(int));
    
            var productnatureParameter = productnature != null ?
                new ObjectParameter("productnature", productnature) :
                new ObjectParameter("productnature", typeof(string));
    
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var currentstockParameter = currentstock.HasValue ?
                new ObjectParameter("currentstock", currentstock) :
                new ObjectParameter("currentstock", typeof(decimal));
    
            var lengthParameter = length.HasValue ?
                new ObjectParameter("length", length) :
                new ObjectParameter("length", typeof(int));
    
            var widthParameter = width.HasValue ?
                new ObjectParameter("width", width) :
                new ObjectParameter("width", typeof(int));
    
            var heightParameter = height.HasValue ?
                new ObjectParameter("height", height) :
                new ObjectParameter("height", typeof(int));
    
            var weightParameter = weight.HasValue ?
                new ObjectParameter("weight", weight) :
                new ObjectParameter("weight", typeof(int));
    
            var productareaParameter = productarea.HasValue ?
                new ObjectParameter("productarea", productarea) :
                new ObjectParameter("productarea", typeof(int));
    
            var thresholdParameter = threshold.HasValue ?
                new ObjectParameter("threshold", threshold) :
                new ObjectParameter("threshold", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_add_new_product", productcodeParameter, productnatureParameter, nameParameter, currentstockParameter, lengthParameter, widthParameter, heightParameter, weightParameter, productareaParameter, thresholdParameter);
        }
    
        public virtual int sp_update_product_count(Nullable<int> productcode, Nullable<int> quantity)
        {
            var productcodeParameter = productcode.HasValue ?
                new ObjectParameter("productcode", productcode) :
                new ObjectParameter("productcode", typeof(int));
    
            var quantityParameter = quantity.HasValue ?
                new ObjectParameter("quantity", quantity) :
                new ObjectParameter("quantity", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_update_product_count", productcodeParameter, quantityParameter);
        }
    
        public virtual ObjectResult<sp_check_product_exit_Result> sp_check_product_exit(Nullable<int> productcode)
        {
            var productcodeParameter = productcode.HasValue ?
                new ObjectParameter("productcode", productcode) :
                new ObjectParameter("productcode", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_check_product_exit_Result>("sp_check_product_exit", productcodeParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> sp_check_product_exit_or_not(Nullable<int> productcode)
        {
            var productcodeParameter = productcode.HasValue ?
                new ObjectParameter("productcode", productcode) :
                new ObjectParameter("productcode", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("sp_check_product_exit_or_not", productcodeParameter);
        }
    }
}
