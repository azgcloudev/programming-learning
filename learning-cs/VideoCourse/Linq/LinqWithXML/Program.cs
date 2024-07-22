using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

string studentsXML =
                    @"<Students>
                            <Student>
                                <Name>Toni</Name>
                                <Age>21</Age>
                                <University>Yale</University>
                            </Student>
                            <Student>
                                <Name>Carla</Name>
                                <Age>17</Age>
                                <University>Yale</University>
                            </Student>
                            <Student>
                                <Name>Leyla</Name>
                                <Age>19</Age>
                                <University>Beijin tech</University>
                            </Student>
                        </Students>
                        ";

XDocument studentsXDoc = new XDocument();
studentsXDoc = XDocument.Parse(studentsXML);

var students = from student in studentsXDoc.Descendants("Student")
               select new
               {
                   Name = student.Element("Name").Value,
                   Age = student.Element("Age").Value,
                   University = student.Element("University").Value
               };

foreach (var s in students)
{
    Console.WriteLine("Student {0} with age {1} is from university {2}", s.Name, s.Age, s.University);
}

var studentsSortByAge = from student in studentsXDoc.Descendants("Student")
                        orderby int.Parse(student.Element("Age").Value)
                        select new
                        {
                            Name = student.Element("Name").Value,
                            Age = student.Element("Age").Value
                        };

foreach (var s in studentsSortByAge)
{
    Console.WriteLine($"{s.Name} is {s.Age} years");
}

Console.ReadKey();