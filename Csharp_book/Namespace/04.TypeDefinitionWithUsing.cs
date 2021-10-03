using System;

namespace TypeDefinitionWithUsing
{
    // Gilbut.Education.CSharp.Lecture 형식을 Project 별칭으로 줄여 사용
    using Project = Gilbut.Education.CSharp.Lecture;

    public class TypeDifinitionWithUsing
    {
        public static void Main(string[] args)
        {
            Gilbut.Education.CSharp.Lecture l = new Gilbut.Education.CSharp.Lecture();  // 기본 호출
            Console.WriteLine(l);

            Project p = new Project();  // using 지시문 사용 호출
            Console.WriteLine(p);
        }
    }
}

namespace Gilbut
{
    namespace Education
    {
        namespace CSharp
        {
            public class Lecture
            {
                public override string ToString()
                {
                    return "Lecture 클래스 호출됨";
                }
            }
        }
    }
}
