// See https://aka.ms/new-console-template for more information



using Intro.Businies;
using Intro.Entities;

//Course course1 =new Course();
//course1.Id = 1;
//course1.Name = "c#";
//course1.Description = ".Net 8 vs";
//course1.Price= 10;  
//Course course2 =new Course();

//course2.Id = 2;
//course2.Name = "Java";
//course2.Description = "Java vs";
//course2.Price = 15;

//Course course3 =new Course();

//course3.Id = 3;
//course3.Name = "Pyhton";
//course3.Description = " PY vs";
//course3.Price = 20;

//Course[] courses = { course1, course2, course3 };

//for (int i = 0; i < courses.Length; i++)
//{
//    Console.WriteLine(courses[i].Name + " / " + courses[i].Price);

//}
CourseManager courseManager = new();
Course[] courses2 = courseManager.GetAll();

for (int i = 0; i < courses2.Length; i++)
{
    Console.WriteLine(courses2[i].Name + " / " + courses2[i].Price);

}

