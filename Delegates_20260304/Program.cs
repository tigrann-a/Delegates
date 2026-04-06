using Delegates_20260304;

//WorkPerformedHandler del1 = new WorkPerformedHandler(WorkPerformed_1);
//WorkPerformedHandler del2 = new WorkPerformedHandler(WorkPerformed_2);
//WorkPerformedHandler del3 = new WorkPerformedHandler(WorkPerformed_3);

//del1(5, WorkType.Meeting);
//del2(10, WorkType.Research);

//Console.WriteLine();

//DoWork(del2);

//del1 += del2;
//del1 += del3;

//int finalHours = del1(10, WorkType.Reports);

//Console.WriteLine("---");

//Console.WriteLine(finalHours);

//Console.ReadKey();

//static void DoWork(WorkPerformedHandler del)
//{
//    del(5, WorkType.Meeting);
//}

//static int WorkPerformed_1(int hours, WorkType workType)
//{
//    Console.WriteLine("1");
//    return hours + 1;
//}

//static int WorkPerformed_2(int hours, WorkType workType)
//{
//    Console.WriteLine("2");
//    return hours + 1;
//}

//static int WorkPerformed_3(int hours, WorkType workType)
//{
//    Console.WriteLine("3");
//    return hours + 1;
//}

var worker = new Worker();

worker.WorkPerformed += new EventHandler<WorkPerformetEventArgs>(Worker_WorkCompleted);

worker.DoWork(8, WorkType.Research);

void Worker_WorkCompleted(object? sender, WorkPerformetEventArgs e)
{
    Console.WriteLine($"Hours worked: " + e.Hours + " " + e.WorkType);
}