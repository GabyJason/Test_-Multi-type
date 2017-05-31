using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Multi_type
{
    class Program
    {
        public static void Main()
        {
            Parent p = new Parent();
            p.Name = "parent";
            TestPolymorphism(p);

            Child c = new Child();
            c.Name = "child";
            TestPolymorphism(c);
        }

        static void TestPolymorphism(Parent parent)
        {
            parent.Print();
        }

        /// <summary>
        /// virtual 可使 override 覆蓋
        /// </summary>
        public class Parent
        {
            public string Name { get; set; }

            public virtual void Print()
            {
                Console.WriteLine("Parent Name: " + Name);
            }
        }

        /// <summary>
        /// 覆蓋繼承
        /// </summary>
        public class Child : Parent
        {
            override public void Print()
            {
                Console.WriteLine("Child Name: " + Name);
            }
        }
    }
}
