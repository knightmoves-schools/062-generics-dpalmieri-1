namespace Tests;

using knightmoves;
using Xunit;

public class AutogradingTest
{
    [Fact]
    public void Should_Add_A_Generic_T_To_The_Class_Declaration_On_Line_Three_And_Replace_All_References_To_String_With_T(){
       var stringBox = new Box<string>();
       stringBox.Add("test");
       Assert.Single(stringBox.Items);

       stringBox.Remove("test");
       Assert.Empty(stringBox.Items);

       var intBox = new Box<int>();
       intBox.Add(1);
       Assert.Single(intBox.Items);
       
       intBox.Remove(1);
       Assert.Empty(intBox.Items);
    }
}