﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift3CUSHEW
{
    class DiskData
    {

        public static string Case01 = "Case01";
        public static string Case02 = "Case02";
        public static string Case03 = "Case03";
        public static string Case04 = "Case04";
        public static string Case05 = "Case05";
        public static string Case06 = "Case06";
        public static string Case07 = "Case07";
        public static string Case08 = "Case08";
        public static string Case09 = "Case09";
        public static string Case10 = "Case10";



        public DiskData() { }


        public static List<double> Case01grupp02()
        {

            List<double> Case01 = new List<double> { 37.68717,38.57886,44.16947,50.25525,51.10078

            return Case01;

        }



        public static List<double> Case02grupp02()
        {

            List<double> Case02 = new List<double>{42.39421,48.12128,33.88914,47.78138,53.48161

            return Case02;



        }


        public static List<double> Case03Grupp02()
        {

            List<double> Case03 = new List<double> { 58.70101,37.52032,62.77808,54.79749,53.25564


            return Case03;
        }



        public static List<double> Case04Grupp02()
        {

            List<double> Case04 = new List<double> { 56.33857,52.93023,57.21098,57.70062,46.07596


            return Case04;

        }



        public static List<double> Case05Grupp02()
        {

            List<double> Case05 = new List<double> {57.71574,49.2213,66.10049,46.81753,62.61779


            return Case05;
        }



        public static List<double> Case06Grupp02()
        {

            List<double> Case06 = new List<double> { 61.99068,57.12166,45.95202,38.48158,46.83161


            return Case06;
        }


        public static List<double> Case07Grupp02()
        {

            List<double> Case07 = new List<double> {47.4349,53.12368,28.88693,62.29903,48.49269


            return Case07;
        }



        public static List<double> Case08Grupp02()
        {

            List<double> Case08 = new List<double> {63.89967,50.51263,51.40748,45.91875,41.72795


            return Case08;
        }



        public static List<double> Case09Grupp02()
        {

            List<double> Case09 = new List<double> { 56.83477,49.32441,44.96863,58.18195,60.21892


            return Case09;
        }



        public static List<double> Case10Grupp02()
        {

            List<double> Case10 = new List<double> { 44.26745,62.33587,62.66648,40.57102,53.35269


            return Case10;
        }


        public static List<List<double>> AllDisks()
        {


            List<List<double>> AllDisksAr = new List<List<double>>();


            AllDisksAr.Add(Case01grupp02());
            AllDisksAr.Add(Case02grupp02());
            AllDisksAr.Add(Case03Grupp02());
            AllDisksAr.Add(Case04Grupp02());
            AllDisksAr.Add(Case05Grupp02());
            AllDisksAr.Add(Case06Grupp02());
            AllDisksAr.Add(Case07Grupp02());
            AllDisksAr.Add(Case08Grupp02());
            AllDisksAr.Add(Case09Grupp02());
            AllDisksAr.Add(Case10Grupp02());


            return AllDisksAr; 

        }


        public static List<string> AllDisksTitels()
        {
            List<string> Titels = new List<string>();


            Titels.Add(Case01);
            Titels.Add(Case02);
            Titels.Add(Case03);
            Titels.Add(Case04);
            Titels.Add(Case05);
            Titels.Add(Case06);
            Titels.Add(Case07);
            Titels.Add(Case08);
            Titels.Add(Case09);
            Titels.Add(Case10);

            return Titels; 


        }


    }
}