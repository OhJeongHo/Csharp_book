using System;


namespace Class
{
    class MyFirstClass_Static유무
    {
        static void StaticMethod() => Console.WriteLine("[1] 정적 메소드");

        void InstanceMethod() => Console.WriteLine("[2] 인스턴스 메소드");

        static void Main()
        {
            MyFirstClass_Static유무.StaticMethod();                          // Static(정적) 메소드 호출
            MyFirstClass_Static유무 my = new MyFirstClass_Static유무();     // 인스턴스 메소드 호출
            my.InstanceMethod();
        }
        //Static을 사용해서 정적 메소드로 만들면 클래스내에서 공유되서 사용되기에 공유메소드가 된다.
        // static이 붙지 않은 인스턴스 맴버를 사용하려면 개체를 호출하여 사용해야 한다.
    }
}
