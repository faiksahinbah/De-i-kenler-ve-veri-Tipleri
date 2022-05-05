// See https://aka.ms/new-console-template for more information
using System;
static void Main (string[]Args)
{
    Console.WriteLine("");
    
    byte b = 5;                 //1 byte
    sbyte c = 5;                 

    short s = 5;
    ushort us = 5;

    Int16 i16 = 2;
    int i = 2;
    Int32 i32 =2;
    Int64 i64 = 2;


    uint ui = 2;
    long l = 4;
    ulong ul = 4;

         //Reel Sayılar

    float f = 5;
    double d = 5;
    decimal de = 5;

    char ch = '2';
    string sir ="faik bahçe";


    bool b1 = true;
    bool b2 = false;

    DateTime dt = DateTime.Now;

    Console.WriteLine(dt);


    object o1 = "x";
    object o2 = "y";
    object o3 = 4;
    object o4 = 4.3;
    
    //string ifadeler


    string str1 = string.Empty;

    str1 = "faik şahin bahçekapılı";
    string ad = "faik şahin";
    string soyad = "bahçekapılı";
    string tamIsim= ad + " " + soyad;

    //ınteger tanımlama şekilleri


    int integer1 = 5;
    int integer2 = 3;

    int integer3 = integer1 * integer2;


    //boolean


    bool bool1 = 10>2;

    //Değişken dönüşümleri

    string str20 = " 20 ";
    int int20 = 20;


    string newDeger = str20 + int20.ToString();


    Console.WriteLine(newDeger);


    int int21 = int20 + Convert.ToInt32(str20);
    Console.WriteLine(int21);    //Çıktısı 40

    int int22 = int20 + int.Parse(str20); //40 Çıktısı


    //dateTime

    string datetime = DateTime.Now.ToString("dd.MM.YYYY");
    System.Console.WriteLine(datetime );

    string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
    System.Console.WriteLine(datetime2);

    //saat


    string hour = DateTime.Now.ToString("HH:mm");
    System.Console.WriteLine(hour);














}
