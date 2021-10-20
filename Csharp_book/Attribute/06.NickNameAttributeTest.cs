// 매개변수가 있는 사용자 지정 특성 만들기

using System;

// 1. AttributeUsage 특성을 사용하여 특성에 제약 조건 등을 설정
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, AllowMultiple = true)]
public class NicknameAttribute : Attribute
{
    public string Name { get; set; }
    public NicknameAttribute(string name) { Name = name; }
}

// 2. AllowMultiple로 여러 번 설정 가능
[Nickname("길벗")]
[Nickname("RedPlus")]
class NickNameAttributeTest
{
    static void Main() => ShowMetaData();

    static void ShowMetaData()
    {
        // 모든 커스텀 어트리뷰트 가져오기
        Attribute[] attrs = Attribute.GetCustomAttributes(typeof(NickNameAttributeTest));

        foreach (var attr in attrs)
        {
            // a. is 연산자를 사용하여 커스텀 어트리뷰트의 Name 속성 출력
            if (attr is NicknameAttribute)
            {
                NicknameAttribute ais = (NicknameAttribute)attr;
                Console.WriteLine("{0}", ais.Name);
            }

            // b. as 연산자를 사용하여 커스텀 어트리뷰트의 Name 속성 출력
            NicknameAttribute aas = attr as NicknameAttribute;
            if (aas != null)
            {
                Console.WriteLine("{0}", aas.Name);
            }
        }
    }
}
