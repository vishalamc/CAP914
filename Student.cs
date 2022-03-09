using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewMobileApp
{
    class Student
    {
        public double CGPAmarks(double ca, double mte, double ete, double att)
        {
            double wca = 25;
            double wmte = 20;
            double wete = 50;
            double tca = 100;
            double tmte = 40;
            double tete = 70;
            double actualCA = (ca * wca) / tca;
            double actualMTE = (mte * wmte) / tmte;
            double actualETE = (ete * wete) / tete;
            double TotalActualMarks = actualCA + actualMTE + actualETE + att;
            double CGPAmarks = TotalActualMarks / 10;
            return CGPAmarks;
        }
      

    }
}
