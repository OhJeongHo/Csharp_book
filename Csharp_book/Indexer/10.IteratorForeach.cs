using System;
using System.Collections;

public class Language
{
    private string[] languages;  // 1. 필드

    public Language(int length) // 2. 생성자
    {
        languages = new string[length];
    }

    public string this[int index]   // 3. 인덱서
    {
        get { return languages[index]; }
        set { languages[index] = value; }
    }

    public IEnumerator GetEnumerator()  // 4. 반복기(이터레이터)
    {
        for (int i = 0; i < languages.Length; i++)
        {
            yield return languages[i];
        }
    }
}

class Test
{
    static void Main()
    {
        var language = new Language(2); // a 클래스의 인스턴스 생성
        language[0] = "C#";     // b 정수 형식의 인덱서로 문자열 값 저장
        language[1] = "TypeScript";

        foreach (var lang in language)  // c foreach 문을 사용하여 배열 값 출력
        {
            Console.WriteLine(lang);
        }
    }
}