using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace InvictusService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "InvictusService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select InvictusService.svc or InvictusService.svc.cs at the Solution Explorer and start debugging.
    public class InvictusService : IInvictusService
    {
        InvictusDataClassesDataContext db = new InvictusDataClassesDataContext();
        public bool DeleteUser(int ID)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllProducts()
        {
            dynamic Prods = new List<Product>();

            dynamic tempProds = (from p in db.Products
                        where p.Prod_Quantity > 0
                        select p).DefaultIfEmpty();

            if(tempProds != null)
            {
                foreach (Product p in tempProds)
                {
                    var AllProds = new Product
                    {
                        Prod_ID = p.Prod_ID,
                        Prod_Name = p.Prod_Name,
                        Prod_Image = p.Prod_Image,
                        Prod_Desciption = p.Prod_Desciption,
                        Prod_Price = p.Prod_Price,
                        Prod_Quantity = p.Prod_Quantity,
                        Category = p.Category,
                        Extra_Image1 = p.Extra_Image1,
                        Extra_Image2 = p.Extra_Image2,
                        Extra_Image3 = p.Extra_Image3,
                        DISC_DiscPercent = p.DISC_DiscPercent,
                        DISC_Active = p.DISC_Active,
                        
                    };

                    Prods.Add(AllProds);
                }

                return Prods;
            }
            else
            {
                return null;
            }

           
        }

        public Product GetProduct(int ID)
        {
            var prod = (from p in db.Products
                        where p.Prod_ID == ID
                        select p).FirstOrDefault();

            if (prod != null) 
            {
                var tempProd = prod;

                return tempProd;

        }else
                return null;
        }



        public int Register(string Name, string Surname, string Email, string Password)
        {
            var sysUser = (from s in db.SystemUsers
                           where s.UserEmail.Equals(Email)
                            select s).FirstOrDefault();

            if(sysUser == null)
            {
                var newUser = new SystemUser()
                {
                    UserName = Name,
                    UserEmail = Email,
                    UserPassword = Password,
                    UserSurname = Surname,
                    UserStatus = 1,
                    RegDate = DateTime.Now,
                    UserType = "Customer"
                };

                db.SystemUsers.InsertOnSubmit(newUser);
                try
                {
                    db.SubmitChanges();
                    //success
                    return 1;
                }
                catch (Exception ex)
                {
                    ex.GetBaseException();
                    //error
                    return 0;
                }
            }
            else
            {
                //The user already exist.
                return -1;
            }
        }

        //public bool isReg(string Email)
        //{
        //    var check = (from d in db.SystemUsers
        //                 where d.UserEmail.Equals(Email)
        //                 select d).FirstOrDefault();
        //    try
        //    {
        //        if (check != null)
        //        {
        //            return true;
        //        }
        //        else
        //            return false;
        //    }catch(Exception e)
        //    {
        //       e.GetBaseException();
        //        return false;
        //    }
           
        //}

        public int Login(string email, string password)
        {
            var user = (from s in db.SystemUsers
                           where s.UserEmail.Equals(email) &&
                           s.UserPassword.Equals(password)
                           select s).SingleOrDefault();

            if (user != null)
            {
                return user.Id;
            }
            else
                return 0;
        }

        public bool UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public bool UpdateUser(SystemUser user)
        {
            var tempUser = (from b in db.SystemUsers where b.Id == user.Id select b).FirstOrDefault();
            tempUser.Id = user.Id;
            tempUser.UserName = user.UserName;
            tempUser.UserSurname = user.UserSurname;
            tempUser.UserEmail = user.UserEmail;
            tempUser.UserPassword = user.UserPassword;

            try
            {
                db.SubmitChanges();
                return true;
            }
            catch (Exception e)
            {
                e.GetBaseException();
                return false;
            }
        }

        public List<SystemUser> getUser(int userId)
        {
            var userList = new List<SystemUser>();
            var b = (from a in db.SystemUsers where a.Id == userId select a).DefaultIfEmpty();

            foreach (SystemUser u in b)
            {
                var users = new SystemUser
                {
                    Id = u.Id,
                    UserName = u.UserName,
                    UserEmail = u.UserEmail,
                    UserPassword = u.UserPassword,
                    UserSurname =u.UserSurname,
                    UserStatus= u.UserStatus,
                    UserForgotCode = u.UserForgotCode,
                    UserForgotCodeSentTime = u.UserForgotCodeSentTime

                };
                userList.Add(users);

            }


            return userList;
        }
    }
}
