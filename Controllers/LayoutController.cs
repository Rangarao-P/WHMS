using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WHMS_Project.Models;
namespace WHMS_Project.Controllers
{
    
    public class LayoutController : Controller
    {
        WHMS_DB_NewEntities db = new WHMS_DB_NewEntities();
        // GET: Layout
        public ActionResult Login()
        {
            string uname = Request.Form["username"];
            string pwd = Request.Form["password"];
            bool mailFlag = false;
            bool userIdFlag = false;
            if (uname != null && uname.EndsWith("@gmail.com"))
            {
                mailFlag = true;
            }
            else if (uname != null)
            {
                userIdFlag = true;
            }

            if (mailFlag)
            {
                Nullable<int> count = db.sp_ChangePassword_CheckUser(uname, pwd).FirstOrDefault();


                if (count > 0)
                {
                    return View("Index");
                }
                else
                {
                    ViewBag.ErrorMessage = "Invalid Credentials";
                }
            }



            if (userIdFlag)
            {
                Nullable<int> count = db.sp_ChangePassword_CheckUserID(uname, pwd).FirstOrDefault();



                if (count > 0)
                {
                    return View("Index");
                }
                else
                {
                    ViewBag.ErrorMessage = "Invalid Credentials";
                }
            }
            return View();
        }
        public ActionResult ChangePassword()
        {
            string uname = Request.Form["username"];
            string oldpwd = Request.Form["OldPassword"];
            string Newpwd = Request.Form["NewPassword"];



            bool mailFlag = false;
            bool userIdFlag = false;



            bool updatedPwd = false;




            if (uname != null && uname.EndsWith("@gmail.com"))
            {
                mailFlag = true;
            }
            else if (uname != null)
            {
                userIdFlag = true;
            }



            if (mailFlag)
            {
                Nullable<int> count = db.sp_ChangePassword_CheckUser(uname, oldpwd).FirstOrDefault();

                if (count > 0)
                {
                    db.sp_ChangePassword_EMail(uname, Newpwd);
                    updatedPwd = true;
                    return View("Login");
                }
                else
                {
                    ViewBag.ErrorMessage = "Invalid Credentials";
                }
            }
            if (userIdFlag)
            {
                Nullable<int> count = db.sp_ChangePassword_CheckUserID(uname, oldpwd).FirstOrDefault();
                if (count > 0)
                {
                    db.sp_ChangePassword_UID(uname, Newpwd);
                    updatedPwd = true;
                    return View("Login");
                }
                else
                {
                    ViewBag.ErrorMessage = "Invalid Credentials";
                }
            }
            return View();

        }

        public ActionResult ForgotPassword()
        {
            string uname = Request.Form["username"];
            string newpwd = Request.Form["newPassword"];




            bool mailFlag = false;
            bool userIdFlag = false;



            bool updatedPwd = false;




            if (uname != null && uname.EndsWith("@gmail.com"))
            {
                mailFlag = true;
            }
            else if (uname != null)
            {
                userIdFlag = true;
            }



            if (mailFlag)
            {
                Nullable<int> count = db.sp_ForgotPassword_CheckEmail(uname).FirstOrDefault();



                if (count > 0)
                {
                    db.sp_ChangePassword_EMail(uname, newpwd);
                    updatedPwd = true;
                    return View("Login");
                }
                else
                {
                    ViewBag.ErrorMessage = "Invalid Credentials";
                }
            }



            if (userIdFlag)
            {
                Nullable<int> count = db.sp_ForgotPassword_CheckUID(uname).FirstOrDefault();



                if (count > 0)
                {
                    db.sp_ChangePassword_UID(uname, newpwd);
                    updatedPwd = true;
                    return View("Login");
                }
                else
                {
                    ViewBag.ErrorMessage = "Invalid Credentials";
                }
            }



            return View();
        }

        public ActionResult RequestUserAccess()
        {
            return View();
        }




        public ActionResult Request_User_Access()
        {
            string uname = Request.Form["username"];
            string pwd = Request.Form["password"];
            string role = Request.Form["roleopt"];
            Nullable<int> res = db.sp_ChangePassword_CheckUserID(uname, pwd).FirstOrDefault();




            if (res > 0)
            {
                if (role == "Warehouse Operator")
                {
                    db.sp_updateUserType(uname, 0);
                    return View("Login");
                }
                if (role == "Warehouse Manager")
                {
                    db.sp_updateUserType(uname, 1);
                    return View("Login");
                }




            }
            return View();
        }


       
        public ActionResult RegisterUser()
        {
            return View();
        }

        public ActionResult RegisteruserData()
        {
            string name = Request.Form["name"];
            string username = Request.Form["username"];
            string password = Request.Form["password"];
            string email = Request.Form["email"];

            int res = db.sp_InsertUser(username, name, password, email);
            if (res > 0)
            {
                return View("Login");
            }
            return View("RegisterUser");
        }

        



        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ProductCart(Location Productdetails)
        {
            return View(Productdetails);
        }
        public ActionResult InBoundForm()
        {
         

            return View();
        }
        [HttpPost]
        public ActionResult Inboundregister()
        {
            int prod_code =Convert.ToInt32(Request.Form["product_code"]);
            string prod_nature = Request.Form["product_nature"];
            string name = Request.Form["product_name"];
            int stock = Convert.ToInt32(Request.Form["product_quantity"]);
            int length = Convert.ToInt32(Request.Form["length"]);
            int width = Convert.ToInt32(Request.Form["width"]);
            int height = Convert.ToInt32(Request.Form["height"]);
            int weight = Convert.ToInt32(Request.Form["weight"]);
            int prod_area = Convert.ToInt32(Request.Form["product_area"]);
            int  threshold= Convert.ToInt32(Request.Form["threshold_quantity"]);
            //List<Product> pp = db.sp_check_product_exit(prod_code).FirstOrDefault();
            Nullable <int> check = db.sp_check_product_exit_or_not(prod_code).FirstOrDefault();
            if (check > 0)
            {
                int update = db.sp_update_product_count(prod_code, stock);
            }
            else
            {
                int res = db.sp_add_new_product(prod_code, prod_nature, name, stock, length, width, height, weight, prod_area, threshold);
            }

            return View("Index");
        }
        public ActionResult OutboundForm()
        {
            return View();
        }
        [HttpPost]
        public ActionResult OutboundRegister()
        {

            string ProductName = Request.Form["ProductName"];
            
            int? ProductCode = Convert.ToInt32(Request.Form["ProductCode"]);
            string DeliveryLocation = Request.Form["DeliveryLocation"];
            int? Quantity = Convert.ToInt32(Request.Form["Quantity"]);

            int result = db.sp_OutLedger(ProductCode, DeliveryLocation, Quantity);
            var model = db.sp_new_locationQuery(ProductCode, Quantity).ToList();

            if (result > 0)
            {
                int res = db.sp_UpdateQuantity(ProductCode, Quantity);
                ViewBag.ProductCode = ProductCode;
                ViewBag.ProductName = ProductName;
                return View("OutboundRequisitionform", model);
            }
            return View();
        }

        public ActionResult OutboundRequisitionform(Location model)
        {
            if (ModelState.IsValid)
            {
                return View(model);

            }
            return View();
        }

        public ActionResult ProductCartDetails()
        {
            var ProductDetails = db.sp_ProductCartDetails().ToList();
            return View("ProductCart", ProductDetails);
        }

        public ActionResult Relocation()
        {
            return View();
        }

       
        public ActionResult SafetyStockIndication()
        {
            return View(db.SP_display_product_details().ToList());
            //return View();
        }
        public ActionResult TruckStatus()
        {
            return View();
        }

        public ActionResult Truck_Status()
        {
            string request_id = Request.Form["RequestId"];
            int id = int.Parse(request_id);
            return View("TruckStatus", db.sp_DisplayTruckStatus(id).ToList());
            //return View();
        }

        public ActionResult LogisticsManagement()
        {
            return View();
        }

        public ActionResult SubmitRequest()
        {
            int pCode = Convert.ToInt32(Request.Form["productcode"]);
            string pName = Request.Form["productName"];
            int qty = Convert.ToInt32(Request.Form["quantity"]);
            string pNature = Request.Form["dropdown"];
            int pArea = Convert.ToInt32(Request.Form["productArea"]);
            int weight = Convert.ToInt32(Request.Form["weight"]);
            string pickup = Request.Form["pickup"];
            string drop = Request.Form["drop"];
            Nullable<int> count = db.createLogisticsRequest(pCode, pName, qty, pNature, pArea, weight, pickup, drop);
            if (count > 0)
            {
                ViewBag.Submit = true;



            }
            return View("LogisticsManagement");
        }

        public ActionResult NewRequest()
        {
            ViewBag.Submit = false;
            return View("LogisticsManagement");
        }




    }
}