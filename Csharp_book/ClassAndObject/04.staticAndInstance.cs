using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 정적 맴버와 인스턴스 맴버
 * 클래스 내에서 선언되는 모든 맴버는 두가지 유형 중에서 하나를 가질 수 있다.
 * 맴버를 선언할 때 static 키워드를 붙이느냐(정적맴버)
 * 붙이지 않느냐(인스턴스 맴버)로 구분됨
 * 정적 맴버는 클래스이름.맴버이름; 형태로 접근하면 되고
 * 인스턴스맴버는 클래스의 인스턴스를 생성하고 생성된 개체이름.맴버이름; 형태로 접근한다.
 * 
 * static 키워드가 붙은 변수를 클래스 변수라고 하며, 붙지 않은 변수를 인스턴스 변수라고 함.
 * static 키워드가 붙으면 일반적으로 공유 개념이다. 클래스 내의 여러 메소드에서 해당 클래스 변수를 공유해서 사용함.
 * 정적 메소드를 포함한 모든 정적 맴버들은 모두 정적인 맴버만 호출할 수 있다.
 */

namespace ClassAndObject
{
    //클래스 생성
    class SharedAndInstance
    {
        public static void StaticMember() => Console.WriteLine("[1] Static Member");

        public void InstanceMember() => Console.WriteLine("[2] Instance Member");

        static void Main()
        {
            SharedAndInstance.StaticMember();   // 정적 맴버 사용 => 클래스.맴버; 형태

            SharedAndInstance obj = new SharedAndInstance();
            obj.InstanceMember();       // 인스턴스 맴버 사용 => 개체.맴버; 형태
        }
    }
}
