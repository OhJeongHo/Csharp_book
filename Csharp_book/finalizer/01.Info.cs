﻿/*
 * 소멸자는 생성자와 반대 개념으로 클래스에서 인스턴스화된 개체가
 * 메모리상에서 없어질때 실행되는 메소드입니다.
 * 자동차 클래스를 예로들면 자동차 주차 대행, 시동 끄기 등으로 볼 수 있다.
 * 
 * 종료자라고도 하는 소멸자는 닷넷의 가비지 수집기에서
 * 클래스의 인스턴스를 사용한 후 최종 정리할 때 실행되는
 * 클래스에서 가장 늦게 호출되는 메소드.
 * 
 * 자동차 시동을 끄는 것에 비유할 수 있으며,
 * 운전수가 주차하고 시동 끄는게 아니라 주차요원이 대신 해주는 것.
 * 소멸자는 클래스 이름과 동일한 메소드로 앞에 ~를 붙여 만든다.
 * 생성자와 달리 매개변수를 받을 수 없다.
 * 소멸자는 오버로드를 지원하지 않고, 직접 호출할 수도 없다.
 * 
 * class Car
 * {
 *      ~Car()
 *      {
 *          // 개체가 소멸될 때 필요한 기능 수행
 *      }
 * }
 * 
 * 닷넷 프레임워크 기반으로 콘솔 만들면 소멸자 내용 출력됨.
 * 닷넷 코어 기반으로 콘솔 만들면 소멸자 내용 출력되지 않음.
 */