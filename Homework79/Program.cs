using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework79
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Branch> branches = new List<Branch>()
            {
                new Branch
                {
                    Id = 11,
                    Bname = "IT",
                    Students =
                    {
                        new Student{Id=1,Name="rahul"},
                        new Student{Id=2,Name="vishal"},
                        new Student {Id=3,Name="tejan"},
                        new Student {Id=4,Name="akshay"},
                        new Student {Id=5,Name="ajinkay"},


                    }

                },
                new Branch
                {
                    Id = 2,
                    Bname = "CS",
                    Students =
                    {
                        new Student{Id=6,Name="mayur"},
                        new Student{Id=7,Name="devinder"},
                        new Student {Id=8,Name="anish"},

                    }

                }

            };
            foreach(Branch b in branches)
            {
                Console.WriteLine(b.Id+" "+b.Bname);
                foreach(Student s in b.Students)
                {
                    Console.WriteLine("   "+s.Id+" "+s.Name);
                }


            }
            Console.WriteLine();

            List<Account> accountlist = new List<Account>()
            {
                new Account
                {
                    Name="savings",
                    Customers=
                    {
                        new Customer
                        {
                            Name="darshan",
                            loanlist=
                            {
                                new Loan{Name="car loan", Amount=200000},
                                new Loan{Name="home loan",Amount=600000},

                            }
                        },
                        new Customer
                        {
                            Name="rahul",
                            loanlist=
                            {
                                new Loan{Name="car loan", Amount=200000},
                                new Loan{Name="home loan",Amount=46006454},

                            }
                        },


                    }
                },
                new Account
                {
                    Name="current",
                    Customers=
                    {
                        new Customer
                        {
                            Name="vishal",
                            loanlist=
                            {
                                new Loan{Name="car loan",Amount=3460000},
                                new Loan{Name="persnal loan",Amount=5454000},

                            }
                        },
                         new Customer
                        {
                            Name="darshan",
                            loanlist=
                            {
                               
                                new Loan{Name="persnal loan",Amount=5454000},

                            }
                        },


                    }
                }
            };
            foreach(Account a in accountlist)
            {
                Console.WriteLine(" "+a.Name);
                foreach (Customer c in a.Customers)
                {
                    Console.WriteLine("    " + c.Name);
                    foreach(Loan l in c.loanlist)
                    {
                        Console.WriteLine("        "+l.Name+" "+l.Amount);
                    }
                }
            }

            
        }




    }
}
               

       
    





   