using System;

/*
 * 인터페이스를 사용하여 멤버 이름 강제로 적용하기
 * 인터페이스를 사용하면 특정 클래스들에 특정 멤버를 강제로 구현하도록 명시할 수 있다.
 * 표준을 미리 정의하고 이를 지키도록(구현하도록) 인터페이스를 설계한 후 인터페이스대로 클래스를 구현하도록 지시하면,
 * 공통되고 표준화된 내용을 함께 구현할 수 있다.
 * 그러기에 인터페이스를 사용한 상속 기능은 프로그램이 복잡해질수록 그 가치가 높아진다.
 */

namespace InterfaceFriends
{
    // 1. 인터페이스: 설계, Run() 이라는 단어 설계(명사)
    public interface IStandard { void Run(); }

    // 2. 추상 클래스 : 설계 + 구현
    public abstract class KS
    {
        public abstract void Back();
        public void Left() => Console.WriteLine("좌회전");
    }

    // 3. 분할 클래스
    public partial class MyCar : KS
    {
        public override void Back() => Console.WriteLine("후진");
    }
    public partial class MyCar : KS
    {
        public void Right() => Console.WriteLine("우회전");
    }

    //4. 봉인(최종) 클래스
    public sealed class Car : MyCar, IStandard
    {
        public void Run() => Console.WriteLine("전진");
    }

    // 5. 다음 코드는 에러( 봉인 클래스는 상속 받을 수 없음 )
    // public class SelfCar : Car { }

    class InterfaceFriends
    {
        static void Main()
        {
            Car cla = new Car();
            cla.Run();
            cla.Left();
            cla.Right();
            cla.Back();
        }
    }
}
