using System;

namespace Attribute
{
    class Class1
    {
        static void Main()
        {
            // Obsolete를 사용하면 코드에는 차이가 없지만, 비쥬얼 스튜디오에서는 경고가 표시되고 메세지도 넣을 수 있음. 두번째 매개변수로 true값을 주면 경고가 아닌 에러 발생.
            [Obsolete("Using New Member Method", true)]
            void OldMember() => Console.WriteLine("Old Method");
            void NewMember() => Console.WriteLine("New Method");

            OldMember();
            NewMember();
        }

    }
}
