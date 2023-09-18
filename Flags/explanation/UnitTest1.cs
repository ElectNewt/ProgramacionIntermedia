namespace explanation;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Permissions userPermissions = Permissions.View | Permissions.Delete;
        var t = userPermissions.ToString();
        if (userPermissions.HasFlag(Permissions.View))
        {
            //Then we can see the page;
            Assert.True(true);
        }

        if (userPermissions.HasFlag(Permissions.Create))
        {
            throw new Exception("the code should not go here");
            //then the user can see the create button
        }

    }

    [Flags]
    public enum Permissions
    {
        //None = 0, //0b0000
        View = 1, //0b0001
        Create = 2, //0b0010
        Edit = 4, //0b0100
        Delete = 8 //0b1000
    }
}