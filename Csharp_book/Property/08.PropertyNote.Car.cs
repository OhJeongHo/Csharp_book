using System;

namespace PropertyNote
{
    public class Car
    {
        // public 필드로 속성처럼 사용
        public static string Color;

        // 언더스코어(_) 문자로 속성에 대한 필드 이름 정의
        private static string _Type;

        // public한 속성 정의 : 읽고 쓰기 가능한 속성
        public static string Type
        {
            get
            {
                return _Type;
            }
            set
            {
                _Type = value;
            }
        }

        // 정적 개체를 생성하는 생성자
        static Car()
        {
            Color = "Red";
            _Type = "스포츠카";
        }
    }
}
