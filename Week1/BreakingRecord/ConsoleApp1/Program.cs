class Result
{

    /*
     * Complete the 'breakingRecords' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY scores as parameter.
     */

    public static List<int> breakingRecords(List<int> scores)
    {
        var recordsbroke = new List<int>() { scores[0], scores[0] };
        for (int i = 1; i < scores.Count; i++)
        {
            Console.WriteLine($"Most Points: {recordsbroke[0]}\nLeast Points: {recordsbroke[1]}\nRead Points:{scores[i]}");
            if (scores[i] > recordsbroke[0])
            {
                recordsbroke[0] = scores[i];
                recordsbroke[0] += 1;
            }
            if (scores[i] < recordsbroke[1])
            {
                recordsbroke[1] = scores[i];
                recordsbroke[1] += 1;
            }
        }

        return recordsbroke;

    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> scores = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(scoresTemp => Convert.ToInt32(scoresTemp)).ToList();

        List<int> result = Result.breakingRecords(scores);

        textWriter.WriteLine(String.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
