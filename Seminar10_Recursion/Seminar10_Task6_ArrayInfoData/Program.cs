int[] data = { 0, 1, 1, 1, 1, 0, 0, 0, 1 };
int[] info = { 2, 3, 3, 1 };
TransformArray(data, info);
// 111 перевести это будет (1*2)^2 + (1*2)^1 + 1 = 7
int Transform(string binary)
{
    int result = 0;
    int n = binary.Length;
    for (int i = 0; i < n; i++)
    {
    result = result+Convert.ToInt32(Convert.ToString(binary[i])) * Convert.ToInt32(Math.Pow(2, (n - 1 - i)));
    }
    return result;
}
int[] TransformArray(int[] data, int[] info)
{
    int start = 0, 
    end = info[0];
    int[] resultArray = new int[info.Length];
    for (int i = 0; i < info.Length; i++)
    {
        string binary = "";
        for (int j = start; j < end; j++)
        {
            binary = binary + Convert.ToString(data[j]);
        }
        Console.Write(binary + " ");
         resultArray[i] = Transform(binary);
         if ((i + 1) == info.Length) break;
         start = start + info[i];
         end = end + info[i + 1];
    }
    Console.WriteLine("");
    Console.WriteLine("[{0}]", string.Join(",", resultArray));
    return resultArray;
}
