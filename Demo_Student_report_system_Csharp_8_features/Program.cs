// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using Demo_Student_report_system_Csharp_8_features;





var genrator = new ReportGenerator();//creating object
var students = new List<Student>();

await foreach (var s in genrator.LoadStudntAsync())
{
    students.Add(s);// this will iterate through the values 
}

var top3 = ReportUtils.GeTopPerformers(students);
genrator.GenerateReport(top3);// passing top 3 values of the collection 

ExportHelper.ExporReport(top3);
