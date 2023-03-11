int Count = 1;
using (StreamReader streamReader = new StreamReader("../../../Large_Input.txt"))
{
    int n = Convert.ToInt32(streamReader.ReadLine());
    string line = streamReader.ReadLine();
    while (n-- > 0)
    {
        int House = int.Parse(line);
        line = streamReader.ReadLine();
        List<int[]> Rooms = new List<int[]>();
        for (int i = 0; i < House; i++)
        {
            Rooms.Add(line.Split(',').Select(int.Parse).ToArray());
            line = streamReader.ReadLine();
        }
        double Hours = 0, Accent = 0, Regular = 0;
        foreach (int[] SingleRoom in Rooms)
        {
            Hours += 18.0 * SingleRoom[3] + SingleRoom[2] * 12.0 + SingleRoom[1] * 9.0;
            Accent += 1.5 * (2 * SingleRoom[3] + SingleRoom[2] * 4 / 3.0 + SingleRoom[1]);
            Regular += 2.25 * (4 * SingleRoom[3] + SingleRoom[2] * 8 / 3.0 + SingleRoom[1] * 2);
        }
        Hours = Math.Round(Hours, 2);
        Accent = Math.Round(Accent, 2);
        Regular = Math.Round(Regular, 2);
        Console.WriteLine("Case #" + Count++ + " " + Hours.ToString("0.00") + "," + Accent.ToString("0.00") + "," + Regular.ToString("0.00"));
    }
}