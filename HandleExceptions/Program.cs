class Program
{
    static int GetInt(int[] array, int index)
    {
        try
        {
            return array[index];
        }
        catch (IndexOutOfRangeException e) // CS0168
        {
            // IndexOutOfRangeException isn't the most appropriate exception.
            // ArgumentOutOfRangeException makes more sense for the method because the error is
            // caused by the index argument passed in by the caller.

            Console.WriteLine(e.Message);
            // Set IndexOutOfRangeException to the new exceptin's InnerException.
            throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
        }
    }
}
