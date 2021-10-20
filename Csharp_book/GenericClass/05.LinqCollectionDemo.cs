using System;
using System.Collections.Generic;
using System.Linq;

// LINQ를 사용하여 특정 클래스 형태의 컬렉션 데이터를 다루는 방법

class Car
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
}

class NewType
{
    public string Maker { get; set; }
}

class Test
{
    static void Main()
    {
        List<Car> cars = new List<Car>()    // 컬렉션 이니셜라이저를 사용하여 데이터 담기
        {
            new Car() { Make = "Camper", Model = "Camper1", Year = 2015 },
            new Car() { Make = "Camper", Model = "Camper2", Year = 2016 },
            new Car() { Make = "SUV", Model = "AAA", Year = 2017 },
            new Car() { Make = "SUV", Model = "BBB", Year = 2018 },
            new Car() { Make = "SUV", Model = "CCC", Year = 2019 },
            new Car() { Make = "SUV", Model = "DDD", Year = 2020 }
        };

        // LINQ를 사용해서 Camper만 출력 : select * from cars where make = 'Camper'
        var campers = from car in cars where car.Make == "Camper" select car;

        foreach (var item in campers)
        {
            Console.WriteLine(item);
        }
    }
}
