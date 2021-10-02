using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 그룹 알고리즘은 반별 총점이나 평균, 제품별 판매금액의 합 같은 그룹별로 구분되는 데이터의 통계를 산출할 때 사용합니다.
 * 그룹 알고리즘은 데이터가 미리 정렬되어 있어야 함.
 * 
 * 코드 관점으로 보면 그룹 알고리즘은 2차원 배열 형태의 리스트에서 특정 속성을 키로 잡아 데이터를 그룹화할때 사용.
 * 
 * 그룹 아록리즘은 정렬된 데이터를 기준으로 수량을 SUM하는 형태가 가장 기본적.
 */

namespace Algorithm
{
    // 클래스, 속성, 컬렉션 이니셜 라이저 등의 개념 사용.


    class GroupAlgorithm
    {
        class Record   // 테스트용 레크도 클래스
        {
            public string Name { get; set; } // 상품 이름
            public int Quantity { get; set; } // 수량
        }

        static void Main()
        {
            // 테스트용 데이터 채우기 로컬 함수
            List<Record> GetAll()
            {
                return new List<Record>
                {
                    new Record{ Name = "RADIO", Quantity = 3},
                    new Record{ Name = "TV", Quantity = 1},
                    new Record{ Name = "RADIO", Quantity = 2},
                    new Record{ Name = "DVD", Quantity = 4}
                };
            }

            void PrintData(string message, List<Record> data)
            {
                Console.WriteLine(message);
                foreach (var item in data)
                {
                    Console.WriteLine($"{item.Name,5} - {item.Quantity}");
                }
            }

            // 입력
            List<Record> records = GetAll();            // 입력 데이터
            List<Record> groups = new List<Record>();   // 출력 데이터
            int N = records.Count;   // 의사 코드

            // 처리 : Group 알고리즘 (SORT -> SUM -> GROUP)
            // 그룹 정렬 : SORT
            for (int i = 0; i < N - 1; i++)
            {
                for (int j = i + 1; j < N; j++)
                {
                    if (String.Compare(records[i].Name, records[j].Name) > 0)
                    {
                        var t = records[i];
                        records[i] = records[j];
                        records[j] = t;
                    }
                }
            }

            // 그룹 소계 : GROUP
            int subtotal = 0;   // 소계
            for (int i = 0; i < N; i++)
            {
                subtotal += records[i].Quantity;    // 같은 상품 이름의 수량을 누적(SUM)

                if ((i + 1) == N || (records[i].Name != records[i + 1].Name))   // 단락이면 아래 조건 무시
                {
                    // 다음 레코드가 없거나 현재 레코드와 다음 레코드가 다르면 저장
                    groups.Add(new Record
                    {
                        Name = records[i].Name, // 한 그룹의 키(key) 지정
                        Quantity = subtotal // 소계
                    }); // 한 그룹 저장
                    subtotal = 0;   // 한 그룹이 완료되면 소계 초기화
                }
            }

            // 출력
            PrintData("[1] 정렬된 원본 데이터 : ", records);
            PrintData("[2] 이름으로 그룹화된 데이터 : ", groups);
            PrintData("[3] LINQ로 그룹화된 데이터 : ", records
                .GroupBy(r => r.Name).Select(g => new Record {
                Name = g.Key, Quantity = g.Sum(n => n.Quantity) }).ToList());
        }
    }
}
