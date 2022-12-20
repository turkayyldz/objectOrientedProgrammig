using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class İnsan
{
    //ctrl+K+S - region
    #region Encapsulation Ornek
    /* private string _firstName;
//    private string _lastName;
private int _age;


public string FirstName
{
   get { return _firstName; }
   set { _firstName = value; }
}
//new property
public string LastName { get; set; }
// old property.
public int Age
{
   get
   {
       return _age;

   }
   set
   {
       if (value<1||value>110)
       {
           Debug.LogError("yanlış yaş ");
           throw new System.Exception("Hatali Yas Girisi.");
       }
   }
}*/
    #endregion
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public DateTime BirtDate { get; set; }
}
