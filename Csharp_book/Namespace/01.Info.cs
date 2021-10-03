using System;

namespace Namespace
{
    class Program
    {
        /*
         * 프로그램의 규모가 커질 때 클래스 이름이 충돌하는 것을 방지하도록 클래스를 모아서 관리하는 개념.
         * 네임스페이스를 달리하여 이름이 동일한 클래스를 하나의 프로젝트에서 사용할 수 있다.
         * 
         * 네임스페이스는 여러번 계층형으로 구분해서 사용할 수 있다.
         * 각 네임스페이스 안에는 클래스 정의 코드가 들어올 수 있다.
         * 
         * namespace AllCar
         * {
         *      namespace MyCar { }
         *      namespace YourCar{ }
         * }
         * 
         * 위와 같은 네임스페이스 중첩 구문은 마침표 구문을 사용하여 표현할 수 있다.
         * namespace AllCar.MyCar { }
         * namespace AllCar.YourCar { }
         */
    }
}
