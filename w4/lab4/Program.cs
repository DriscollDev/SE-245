namespace week4_lab
{
    class Program
    {
        public class Person
        {
            private string fName;
            private string mName;
            private string lName;
            private string street1;
            private string street2;
            private string city;
            private string state;
            private string zip;
            private string phone;
            private string email;

            public string FName{
                get { return fName;  }
                set { fName=value;   }
            }
            public string MName{
                get { return mName;  }
                set { mName=value;   }
            }
            public string LName{
                get { return lName;  }
                set { lName=value;   }
            }
            public string Street1{
                get { return street1;  }
                set { street1=value;   }
            }
            public string Street2{
                get { return street2;  }
                set { street2=value;   }
            }
            public string City{
                get { return city;  }
                set { city=value;   }
            }
            public string State{
                get { return state;  }
                set { state=value;   }
            }
            public string Zip{
                get { return zip;  }
                set { zip=value;   }
            }
            public string Phone{
                get { return phone;  }
                set { phone=value;   }
            }
            public string Email{
                get { return email;  }
                set { email=value;   }
            }
        }
        static void Main(string[] args)
        {
            Person person = new Person();
            System.Console.WriteLine("Enter First name");
            person.FName= Console.ReadLine();
            System.Console.WriteLine("Enter Middle name");
            person.MName= Console.ReadLine();
            System.Console.WriteLine("Enter Last name");
            person.LName= Console.ReadLine();
            System.Console.WriteLine("Enter Street 1");
            person.Street1= Console.ReadLine();
            System.Console.WriteLine("Enter Street 2");
            person.Street2= Console.ReadLine();
            System.Console.WriteLine("Enter City");
            person.City= Console.ReadLine();
            System.Console.WriteLine("Enter State");
            person.State= Console.ReadLine();
            System.Console.WriteLine("Enter Zip");
            person.Zip= Console.ReadLine();
            System.Console.WriteLine("Enter Phone");
            person.Phone= Console.ReadLine();
            System.Console.WriteLine("Enter Email");
            person.Email= Console.ReadLine();


            System.Console.WriteLine($"{person.FName} {person.MName} {person.LName} who lives in {person.Street1} {person.Street2} {person.City}, {person.State} {person.Zip}, can be contacted at either {person.Phone} or {person.Email}");
            
        }
    }
    
}