using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace EmployeeData.Models
{
    public class Employee
    {
        [Required(ErrorMessage = "Please Enter EmployeeID")]
        public int EmployeeID { get; set; }

        [Required(ErrorMessage ="Please Enter FirstName")]
        public string FirstName { get; set; }
        public string MiddleName { get; set; }

        [Required(ErrorMessage = "Please Enter LastName")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please Provide Gender")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Please Enter Address")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please Enter City")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please Enter State")]
        public string State { get; set; }

        [Required(ErrorMessage = "Please Enter Country")]
        public string Country { get; set; }

        [Required(ErrorMessage = "Please Enter Mobile Number")]
        public string Mobile { get; set; }
    }

    public enum City 
    { 
        Mumbai,Delhi,Bangalore,Hyderabad,Chennai,Kolkata,Jaipur,Lucknow,Bhopal,Patna,Srinagar,Rachi,Raipur,Chandigarh,Bhubaneshwar
    }

    public enum State 
    { 
        Maharashrata,Delhi,Karnataka,Telangana,TamilNadu,WestBengal,Rajasthan,UttarPradesh,MadhyaPradesh,Bihar,JammuandKashmir,Jharkhand,Chattisgarh,Chnadigarh,Odisha
    }

    public enum Country
    { 
        India
    }
}