using Intro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.Businies;

public class CourseManager
{
    // constructer . Newlendiğinde ilk bu çalışır
    Course[] courses = new Course[3];
    public CourseManager()
    {

        Course course1 = new Course();
        course1.Id = 1;
        course1.Name = "c#";
        course1.Description = ".Net 8 vs";
        course1.Price = 10;
        Course course2 = new Course();

        course2.Id = 2;
        course2.Name = "Java";
        course2.Description = "Java vs";
        course2.Price = 15;

        Course course3 = new Course();

        course3.Id = 3;
        course3.Name = "Pyhton";
        course3.Description = " PY vs";
        course3.Price = 20;

        courses[0] = course1;
        courses[1] = course2;
        courses[2] = course3;
    }
    public Course[] GetAll()
    {
        return courses;
    }
}
