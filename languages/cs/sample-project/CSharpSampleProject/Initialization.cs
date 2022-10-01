namespace CSharpSampleProject;

public class Initialization
{
    static Initialization()
    {
        SampleStruct newSampleStruct = new()
            {
                FieldInt = 42,
                FieldStringOptional = "SomeString"
            };

        var newIntArray = new[]
            {
                1,
                2,
                3
            };
    }
}
