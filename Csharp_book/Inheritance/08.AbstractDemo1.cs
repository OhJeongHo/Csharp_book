using System;

public abstract class TableBase
{
    public int Id { get; set; }
    public bool Active { get; set; }
}
// 추상클래스의 인스턴스는 만들수가 없으므로, 시도하면 에러가 발생한다.
