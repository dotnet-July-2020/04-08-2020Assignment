﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListAssignment
{
    public class Person
    {
        int age;
        string fname;
        string lname;
        string city;
        Person()
        {

        }
        public Person(int _age,string _fname,string _lname,string _city)
        {
            age = _age;
            fname = _fname;
            lname = _lname;
            city = _city;
        }
        public void DisplayPerson()
        {
            Console.WriteLine("The age is {0},and firstname is {1},and lastname is {2},and city is {3}",age,fname,lname,city);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> li = new List<Person>();
            li.Add(new Person(22, "geethu", "duddupudi", "rajahmundry"));
            li.Add(new Person(18, "bhoomi", "duddupudi", "rajahmundry"));
            li.Add(new Person(7, "ammu", "duddupdui", "rajahmudry"));
            li.Add(new Person(12, "chowdary", "vallepalli", "rajahmundry"));
            li.Add(new Person(11, "honey", "duddupudi", "rajahmundry"));
            li.ForEach(delegate (Person p1) {
                 p1.DisplayPerson();
            }
            );
            Console.Read();
        }
    }
}
