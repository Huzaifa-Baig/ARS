using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ARS.Models
{
    [Table("Admin_Login")]
    public class AdminLogin
    {
        [Key]
        public int AdminId { get; set; }

        [Required(ErrorMessage ="User Name required")]
        [Display(Name ="User Name")]
        [MinLength(3, ErrorMessage = "Minimum 3 Characters"), MaxLength(20, ErrorMessage = "Maximum 20 Character")]
        public string AdminName { get; set; }

        [Required(ErrorMessage = "Password required")]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        [MinLength(5, ErrorMessage ="Minimum 5 Characters"),MaxLength(20,ErrorMessage ="Maximum 20 Character")]
        public string AdminPassword { get; set; }
    }
    [Table("User_Accounts")]
    public class UserAccount
    {
        [Key]
        public int UserId { get; set; }

        [Required(ErrorMessage ="First Name required")]
        [MinLength(5,ErrorMessage ="Minimum 5 Characters Required"),MaxLength(40,ErrorMessage ="Maximum 40 Characters Required")]
        [Display(Name="First Name")]
        public string UserFirstName { get; set; }

        [Required(ErrorMessage = "Last Name required")]
        [MinLength(5, ErrorMessage = "Minimum 5 Characters Required"), MaxLength(40, ErrorMessage = "Maximum 40 Characters Required")]
        [Display(Name = "First Name")]
        public string UserLastName { get; set; }

        [Required(ErrorMessage ="Enter Email ID")]
        [Display(Name ="Email ID Required")]
        [DataType(DataType.EmailAddress)]
        public string UserEmail { get; set; }

        [Required(ErrorMessage = "Password Required")]
        [MinLength(5, ErrorMessage = "Minimum 5 Characters Required"), MaxLength(20, ErrorMessage = "Maximum 20 Characters Required")]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string UserPassword { get; set; }

        [Compare("Password",ErrorMessage ="Passwords don't match")]
        [MinLength(5, ErrorMessage = "Minimum 5 Characters Required"), MaxLength(20, ErrorMessage = "Maximum 20 Characters Required")]
        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        public string UserConfirmPassword { get; set; }

        [Required(ErrorMessage ="Enter Age")]
        [Range(18,150,ErrorMessage = "You have to be a minimum  of 18 years")]
        [Display(Name = "Age")]
        public int UserAge { get; set; }

        [Required(ErrorMessage = "Phone number required"),RegularExpression(@"^([0-9]{11})$", ErrorMessage = "Phone Number Not Valid")]
        [Display(Name = "Phone Number")]
        [StringLength(11)]
        public string UserPhoneNumber { get; set; }

        [Display(Name ="N.I.C")]
        [Required(ErrorMessage ="N.I.C or ID is Required"), RegularExpression(@"^([0-9]{11})$", ErrorMessage = "Invalid N.I.C number")]
        [StringLength(13)]
        public string UserNIC { get; set; }
    }

    public class AirlinePlaneInfo
    {
        [Key]
        public int PlaneId { get; set; }
        
        [Required(ErrorMessage ="Plane Name Required")]
        [Display(Name ="Plane Name")]
        [MaxLength(30,ErrorMessage ="Maximin 30 Charaters"),MinLength(3,ErrorMessage ="Minimum 3 Charaters")]
        public string PlaneName { get; set;}

        [Required(ErrorMessage ="Maximum Capacity Required")]
        [Display(Name ="Seating Capacity")]
        public int PlaneSeatingCapacity { get; set; }

        [Required(ErrorMessage = "Plane Price Required")]
        [Display (Name ="Plane Price")]
        public float PlaneSeatingPrice { get; set; }
    }
    [Table("Plane_Booking")]
    public class PlaneBooking
    {
        [Key]
        public int BookingID { get; set; }

        [Required(ErrorMessage ="Departing City Required")]
        [Display(Name ="Departing City")]
        [StringLength(40,ErrorMessage ="Max 40 Characters")]
        public String DepartingCity { get; set; }

        [Required(ErrorMessage = "Destination Required")]
        [Display(Name = "Destination")]
        [StringLength(40, ErrorMessage = "Max 40 Characters")]
        public String Destination { get; set; }

        [Display(Name = "Departing Date")]
        [DataType(DataType.Date)]
        public DateTime DepartingDate { get; set; }

        [Display(Name = "Departing Time")]
        public DateTime DepartingTime { get; set; }

        public int PlaneId { get; set; }
        public virtual AirlinePlaneInfo PlaneInfo { get; set; }

        [Display(Name ="Seat Type")]
        [StringLength(30)]
        public String PlaneSeatType { get; set; }
    }

}