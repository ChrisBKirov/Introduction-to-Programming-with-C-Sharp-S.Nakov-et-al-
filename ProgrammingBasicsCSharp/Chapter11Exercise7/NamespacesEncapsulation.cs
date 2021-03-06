﻿/*
   <summary>    
   TITLE              Namespaces                Chapter11Exercise7
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: 
               Input: -
              Output: -
                  
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>15.10.2016</datecreated>
*/
using System;

namespace Chapter11Exercise7
{
    class NamespacesEncapsulation
    {
        static void Main(string[] args)
        {

        }
    }
}

/// <summary>
/// 
/// </summary>
namespace Chapter11
{
    public class Sequence
    {
        // Static field, holding the current sequence value
        private static int currentValue = 0;
        // Intentionally deny instantiation of this class
        private Sequence()
        {
        }
        // Static method for taking the next sequence value
        public static int NextValue()
        {
            currentValue++;
            return currentValue;
        }
    }
    //===============================================================

    public class Cat
    {
        // Field name
        private string name;
        // Field color
        private string color;

        public string Name
        {
            // Getter of the property "Name"
            get
            {
                return this.name;
            }
            // Setter of the property "Name"
            set
            {
                this.name = value;
            }
        }

        public string Color
        {
            // Getter of the property "Color"
            get
            {
                return this.color;
            }
            // Setter of the property "Color"
            set
            {
                this.color = value;
            }
        }

        // Default constructor
        public Cat()
        {
            this.name = "Unnamed";
            this.color = "gray";
        }

        // Constructor with parameters
        public Cat(string name, string color)
        {
            this.name = name;
            this.color = color;
        }

        // Method SayMiau
        public void SayMiau()
        {
            Console.WriteLine("Cat {0} said: Miauuuuuu!", name);
        }
}

/// <summary>
/// 
/// </summary>
namespace Chapter11.Example
{

}