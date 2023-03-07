using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Passenger

    {
        //public int Id { get; set; }
        [Display(Name =" Date of Birht ")]
        [DataType(DataType.DateTime)]
        public DateTime Birthdate { get; set; }
        [Key]
        [StringLength(7)]
        public string PassportNumber { get; set; }
        //[EmailAddress]
        [DataType(DataType.EmailAddress)]
        public string?  EmailAddress { get; set; }
        [MinLength(3,ErrorMessage ="min liength must be > 3 ")]
        [MaxLength(25, ErrorMessage = "max liength must be < 25 ")]
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        [RegularExpression(@"^[0-9]{8}$", ErrorMessage = "Invalid Phone Number!")]
        public string?  telNumber { get; set; }

        public ICollection<Flight> Flights { get; set; }

        public override string ToString()
        {
            return "passenger first name : "+this.FirstName+"\n passenger last name : "+this.LastName;
        }

/*        public bool CheckProfile(string firstname,string lastname)
        {
            return firstname == this.FirstName && lastname == this.LastName;
        }

        public bool CheckProfile(string firstname, string lastname,string email)
        {
            return firstname == this.FirstName && lastname == this.LastName && email==this.EmailAddress;
        }*/

        public bool CheckProfile(string firstname, string lastname, string email = null)
        {
            if(email == null) { return firstname == this.FirstName && lastname == this.LastName; }
            else
            {
                return firstname == this.FirstName && lastname == this.LastName
                    && email == this.EmailAddress;
            }
        }

        public virtual void PassengerType()
        {
            Console.WriteLine("I am a passenger ");
        }
    }
}
