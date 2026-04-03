using Delegates_20260304;

WorkPerformedHandler del1 = new WorkPerformedHandler(WorkPerformed_1);
WorkPerformedHandler del2 = new WorkPerformedHandler(WorkPerformed_2);
WorkPerformedHandler del3 = new WorkPerformedHandler(WorkPerformed_3);

//del1(5, WorkType.Meeting);
//del2(10, WorkType.Research);

Console.WriteLine();

//DoWork(del2);

del1 += del2;
del1 += del3;

del1(10, WorkType.Reports);

Console.ReadKey();

static void DoWork(WorkPerformedHandler del)
{
    del(5, WorkType.Meeting);
}

static void WorkPerformed_1(int hours, WorkType workType)
{
    Console.WriteLine("1");
}

static void WorkPerformed_2(int hours, WorkType workType)
{
    Console.WriteLine("2");
}

static void WorkPerformed_3(int hours, WorkType workType)
{
    Console.WriteLine("3");
}