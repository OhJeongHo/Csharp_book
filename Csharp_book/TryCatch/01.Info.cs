using System;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            // 문법 오류(syntax error) : 잘못된 명령어 입력, 입력 실수 등. 이는 컴파일 오류라고 하며 컴파일러가 잡아줌.
            // 런타임 오류(runtime error) : 프로그램을 만든 후 실행할 때 발생하는 오류, 컴파일 과정에는 발생하지 않음.
            // 알고리즘 오류(logic error) : 잘못된 해석으로 잘못된 결과를 초래하는 오류를 알고리즘 오류라고 함.

            // try ~ catch ~ finally
            try
            {
                // 예외가 발생할만한 코드 작성
            }
            catch
            {
                // 예외가 발생할 때 처리해야 할 코드 블록
            }
            finally
            {
                // 예외가 발생하거나 정상일 때 모두 처리해야 할 코드 블록
            }
        }
    }
}
