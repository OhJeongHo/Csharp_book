using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    class Class1
    {
        static void Main()
        {
            // 입력
            int[] data = { 1, 3, 5, 7, 9 }; // 오름차순으로 정렬되어있다고 가정
            int N = data.Length;
            int search = 3; // 검색할 데이터 : Console.ReadLine() 등으로 가져오기.

            bool flag = false;  // 플래그 변수 : 찾으면 true, 찾지 못하면 false
            int index = -1; // 인덱스 변수 : 찾은 위치

            // 처리 : 이진 검색 : Full Scan -> index Scan
            int low = 0;
            int high = N - 1;
            while (low <= high)
            {
                int mid = (low + high) / 2; // 중간 인덱스 구하기
                if (data[mid] == search)
                {
                    // 찾으면 플래그, 인덱스 저장 후 종료
                    flag = true;
                    index = mid;
                    break;
                }
                if (data[mid] > search)
                {
                    high = mid - 1; // 찾을 데이터가 작으면 왼쪽 영역으로 이동
                }
                else
                {
                    low = mid + 1;  // 찾을 데이터가 크면 오른쪽 영역으로 이동
                }
            }

            // 출력
            if (flag)
            {
                Console.WriteLine($"{search}을(를) {index}위치에서 찾았습니다.");
            }
            else
            {
                Console.WriteLine("찾지 못했습니다.");
            }
        }
    }
}
