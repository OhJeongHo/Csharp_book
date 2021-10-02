using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObject
{
    public class Counter    // 1. 클래스 생성
    {
        public void GetTodayVisitCount()    // 2. 메소드 생성
        {
            Console.WriteLine("오늘 1234명이 접속했습니다.");
        }
    }

    // 1처럼 클래스를 생성할 때는 따로 정적 맴버와 인스턴스 맴버 내용을 지정하지 않는다.
    // 클래스 내에는 정적 맴버와 인스턴스 맴버를 원하는 만큼 만들 수 있다.

    // 2에서는 static이 빠진 형태로 메소드를 만들어 인스턴스 맴버인 인스턴스 메소드를 만들었다.

    class ObjectNote
    {
        static void Main()
        {
            Counter counter = new Counter();    // a. 클래스의 인스턴스 생성
            counter.GetTodayVisitCount();   // b. 개체이름.맴버이름으로 클래스의 맴버 호출
        }
    }


    // 클래스 내에 선언된 메소드 중에서 static 키워드가 붙지 않은 메소드를 인스턴스 메소드라고 함.
    // 인스턴스 메소드를 호출하려면 클래스의 인스턴스를 생성하여 개체를 만들어야함.
    // 클래스의 인스턴스를 생성하여 개체를 만드려면 new 키워드를 사용해야 함.
    // Car car = new Car();

    // 인스턴스 메소드를 호출하려면 개체.인스턴스메소드이름(); 형태를 사용함.
    // Car 클래스의 Go() 인스턴스 메소드 호출 하는 법
    // Car car = new Car();
    // car.Go();
}
