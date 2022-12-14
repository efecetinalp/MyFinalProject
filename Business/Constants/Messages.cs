using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Product added successfully";
        public static string InvalidProductName = "Product name is invalid";
        public static string MaintenanceTime = "Server is on maintenance";
        public static string ProductsListed = "Products are listed successfully";
        public static string InvalidUnitPrice = "Unit price cannot be lover or equal to zero";
        public static string ProductCountOfCategoryError = "Max 10 products can be added on each category";
        public static string ProductNameAlreadyExist = "This product name is already exist";
        public static string CategoryLimitExceded = "Reached maximum category limit";
        public static string AuthorizationDenied = "No access to make this operation";
        public static string UserRegistered = "User registered successfully";
        public static string UserNotFound = "This user is not exists";
        public static string PasswordError = "Password incorrect";
        public static string SuccessfulLogin = "Success Log-in";
        public static string UserAlreadyExists = "This user is already exists";
        public static string AccessTokenCreated = "Token created successfully";



    }
}
