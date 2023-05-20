using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingD;

namespace Test2
{
   
    public class Student
    {
 
        public int StudentID { get; set; }  
        public string StudentName { get; set; }
        public int Age { get; set; }
        public int StandardID { get; set; }

   
        /*
        public int CompareTo(Student other)
        {
            if (this.StudentName.Length >= other.StudentName.Length)
                return 1;

            return 0;
        }
        */
    } 

    public class testingPro : UpdatedModifier
    {
        private readonly Student a = new Student();
        public void bad()
        {
 
       
        }

    }
 


    public class Standard 
    {
        public int StandardID { get; set; }
        public string StandardName { get; set; }

      
    }

    public class StudentComparer : IEqualityComparer<Student>
    {
        public bool Equals(Student x, Student y)
        {
           var condition = x.StudentName.ToLower() == y.StudentName.ToLower()
                  && x.StudentID == y.StudentID;
            return condition;
        }

        public int GetHashCode( Student obj)
        {
            return obj.StudentID.GetHashCode();
        }
    }
    

    internal static class LinqPractise
    {
        public static void testing() {
            t();
           // var stude = new StudentTest("Sri", 32, 1);
            //Console.WriteLine(stude.StudentName, stude.Age, stude.StudentID, stude.StandardID);

            static void t() { Console.WriteLine("Function inside another function"); }


            List<Student> studentList = new List<Student>() {
       new Student() { StudentID = 1, StudentName = "John", StandardID =1 },
    new Student() { StudentID = 2, StudentName = "Moin", StandardID =1 },
    new Student() { StudentID = 3, StudentName = "Bill", StandardID =2 },
    new Student() { StudentID = 10, StudentName = "Ram",  StandardID =2 },
    new Student() { StudentID = 5, StudentName = "Ron" , StandardID =4},
        new Student() { StudentID = 5, StudentName = "Ron" , StandardID =4},
      
    };
             
            IList<Standard> standardList = new List<Standard>() {
    new Standard(){ StandardID = 1, StandardName="John"},
    new Standard(){ StandardID = 2, StandardName="Ram"},
    new Standard(){ StandardID = 3, StandardName="Standard 3"}
};
            var stake = standardList.Take(1..3); //skip - 1 take -2
            stake = standardList.Take(^2..); //skip -2
            Func<Student, bool> studentFunction = (student) => student.StudentName == "John";
            // LINQ Query Syntax to find out teenager students
            var teenAgerStudent = from s1 in studentList
                                  where studentFunction(s1)
                                  select s1;
            var teen = studentList.Where(studentFunction).ToList();
            studentList.Add(new Student() { StudentID = 6, StudentName = "John", StandardID = 11 });
            foreach (var item in teen)
            {
                Console.WriteLine(item.StandardID);
            }

           // Student std = new Student() { Age = 21 };
            //Console.WriteLine(std.StudentID);

            Action<Student> printStudent = (student) => Console.WriteLine($"This is the  age of the student :{student.Age}");
            //printStudent(std);
            var student = studentList.Where(studentFunction).ToList();
            var student1 = studentList.Where((student) => student.StudentName == "John" || student.Age == 12).
                OrderByDescending(s => (s.StudentID, s.Age)).ThenByDescending(s => s.StudentName)

                // .Select(s => new Student { StudentID = s.StudentID})
                .ToList();

            var groupedAge = (from s1 in studentList
                                  //where s.Age == 18
                              group s1 by (s1.Age, s1.StudentName)).Where(k => k.Count() > 1).Select(s => s.Key.Age);

            var stGroupByMthd = studentList.GroupBy(s => (s.Age, s.StudentName)).Where(k => k.Count() > 1).Select(studentList => studentList.Key.StudentName);

            var innerJoin = from outer in studentList
                                         join inner1 in standardList on    outer.StudentName  equals    inner1.StandardName 
                            select inner1.StandardID;

            //Multiple Composite Join
            var innerJoinMethod = studentList.Join(standardList, 
                outer => (outer.StudentName,outer.StudentID), 
                inner => (inner.StandardName,inner.StandardID), 
                (outer, inner) => new { outer.StudentID,outer.StudentName });
          
          string[] b = new string[] { "1", "2", "3" };
          var a =   string.Join(':', b);

            var leftJoin = (from outer in studentList
                            join inner in standardList
                            on outer.StudentID equals inner.StandardID into intermediate
                            from consolidate in intermediate.DefaultIfEmpty(new Standard { StandardID = -1 ,StandardName = "Not Found or Empty" })
                            select 
                            new
                            {
                                // StandardName = consolidate?.StandardName ?? string.Empty,
                                StandardName = consolidate.StandardName ,
                                StudentName = outer.StudentName,
                                StudentId = outer.StudentID
                            }
                                    ).ToList();

            var groupJoin = from outer in standardList
                             join inner in studentList
                             on outer.StandardID equals inner.StandardID into grouped
                             select (new { student = grouped,
                                 StandardName = outer.StandardName
                             });

            var groupJoin1 = (from outer in studentList
                             join inner in standardList
                             on outer.StandardID equals inner.StandardID into grouped
                             select (new
                             {
                                 student = grouped,
                                 StudentID = outer.StudentID,
                                 StudentName = outer.StudentName
                             }));


            Console.WriteLine(studentList.All(st => st.StudentName.Contains("John")));

            var aggreagate = studentList.Aggregate<Student,string>("", (st1,st2)=>  st1 += st2.StudentName + ",");
            var aggregateRemoveLastComma = studentList.Aggregate<Student, string,string>("Student List :", // seed value
                                                                                                                                    (s, list) => s += list.StudentName + ",", 
                                                                                                                                    (str) => str.Substring(0,str.Length - 1) // remove last comma
                                                                                                                                    );

            var averageAge = studentList.AsEnumerable().Average(st => st.Age);
            //var count = studentList.Max( );
            var count1 = studentList.Max(s => s.StudentID);
            
           // Console.WriteLine(count);

            IList<int> l = new List<int>() { 100, 200, 201, 301 };
            var s = l.Max(sum =>  sum % 2 == 0 ?   sum :   0);
            var sum = studentList.Sum(s=>s.StudentID);
           var postion =  l.ElementAtOrDefault(1);
            IList<string> strList = new List<string>() {  "Two", "Three", "Four", "Five" };
            IList<string> strList1 = new List<string>() { "Two", "Three", "Four", "Five" };

        var resultSequence =    strList.Zip(strList1,(first,second)=> first + "-" + second);
            foreach (var item in resultSequence)
            {
                Console.WriteLine(item);
            }

            Student std1 = new Student() { StudentID = 1, StudentName = "Bill" };
            Student std2 = new Student() { StudentID = 1, StudentName = "Bill" };
            strList1.Concat(strList);
            Console.WriteLine("1st Even Element in intList: {0}",
                          strList.FirstOrDefault(s =>
                          s.Contains("T")));
            Console.WriteLine("1st Even Element in intList: {0}",
                          strList.LastOrDefault(s =>
                          s.Contains("T")));

            var seq = strList.SequenceEqual(strList1);
          var c =   std1.Equals(std2);

            char[] ch = new char[] { 'h', 'e' };
               object  str = new string(ch);
            object str1 = "he";
            Console.WriteLine(str == str1);
            Console.WriteLine(str.Equals(str1));

          
            IEnumerable<int> num = Enumerable.Range(5, 10);
            for (int i = 0; i < num.Count(); i++) {
                Console.WriteLine($" Index : {i} , {num.ElementAtOrDefault(i)}");
            }
            IEnumerable<int> numRepeat = Enumerable.Repeat(5, 6);
            for (int i = 0; i < numRepeat.Count(); i++)
            {
                Console.WriteLine($" Index : {i} , {numRepeat.ElementAtOrDefault(i)}");
            }
       
            /*
            var distinctStudents = studentList.Distinct(new StudentComparer());
            foreach (var item in distinctStudents)
            {
                    Console.WriteLine(item.StudentName);
            }
            */

            IList<Student> studentList1 = new List<Student>() {
        new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
        new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
        new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
        new Student() { StudentID = 31, StudentName = "Bill",  Age = 25 } ,
        new Student() { StudentID = 32, StudentName = "Bill",  Age = 25 } ,
        new Student() { StudentID = 36, StudentName = "Bill",  Age = 25 } ,
        new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 }
    }; 

        var skipLAST =    studentList1.SkipLast( 2); // last 2 element skipped
         var takeLast =   studentList1.TakeLast(2); // last 2 element taken
            var skipwhile = studentList1.SkipWhile(s => s.StudentID <= 32); // till the condition matches thoese are not shown
                                                                            // once condition failed those will shown after that all records will be shown
            var takewhile = studentList1.TakeWhile(s => s.StudentID <= 32);// till the condition matches thoese are   shown
                                                                           // once condition failed those will not be shown after that all records will be shown
            var skipr =       studentList1.Skip(2);
       var skipt =     studentList1.Take(2);
            Console.WriteLine();

            IDictionary<int, Student> students = studentList1.ToDictionary<Student, int>(s => s.StudentID);

            if ( students.TryGetValue(5, out Student stu))
            {
                Console.WriteLine(stu);
            }
                foreach(var item in students.Keys)
                    Console.WriteLine($"{item}, {(students[item] as Student).StudentName}");
          

            var e = Enumerable.Range(1, 100);
            var page = 3;
            var itemsPerPage = 10;
            var offset = (page - 1) * itemsPerPage ;
            var noOfPage = e.Count() / itemsPerPage;
            var elementsTobeShow = e.Skip((page - 1) * itemsPerPage).Take(itemsPerPage);
            Console.WriteLine($"Page : { page}/{noOfPage}- {elementsTobeShow.FirstOrDefault()} - {elementsTobeShow.LastOrDefault()} of {e.Count()} ");
            for (int i = 0; i < elementsTobeShow.Count(); i++)
            {
                Console.WriteLine($" Index : {i} , {elementsTobeShow.ElementAtOrDefault(i)}");
            }


            IList<string> strList2 = new List<string>() {
                  "",
                                            "One",
                                            "Two",
                                            "Three",
                                            "Four",
                                            "Five",
                                            "Six7890000----"  };

            var result = strList2.TakeWhile((s, i) => s.Length > i);

            foreach (string str2 in result)
                Console.WriteLine(str2);

            /*
            var distinctStudents = studentList1.Distinct(new StudentComparer());

            foreach (Student std in distinctStudents)
                Console.WriteLine(std.StudentName);
            */

            /* foreach (var item in groupJoin1)
             {
                 foreach (var item1 in item.student)
                 {
                     Console.WriteLine("----------------");
                     Console.WriteLine(item.StudentID);
                     Console.WriteLine(item.StudentName);
                     Console.WriteLine(item1.StandardID);
                     Console.WriteLine("----------------");
                 }
                 //Console.WriteLine( item);
                 //Console.WriteLine($"{item.Key},{item.Count()}");
                 //Console.WriteLine(item);

             } 
              */

            Console.ReadLine();
        }
    }
}
