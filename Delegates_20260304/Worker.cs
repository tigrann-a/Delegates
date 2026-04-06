namespace Delegates_20260304;

// աշխատակից դաս
internal class Worker
{
    //public event WorkPerformedHandler WorkPerformed; // Task-ի մակարդակով
    public event EventHandler<WorkPerformetEventArgs> WorkPerformed;

    public event EventHandler WorkCompleted; // Ընդհանուր

    public void DoWork(int hours, WorkType workType)
    {
        for (int i = 0; i < hours; i++)
        {
            OnWorkPerformed(i + 1, workType);
            Thread.Sleep(3000);
        }
        OnWorkCompleted();
    }

    public virtual void OnWorkPerformed(int hours, WorkType workType)
    {
        //var del = WorkPerformed as WorkPerformedHandler; // ստուգում ենք WorkPerformed-ը WorkPerformedHandler տիպի է, թե ոչ, եթե այո պահում ենք del-ի մեջ, երե ոչ del-ը մնում է null
        var del = WorkPerformed as EventHandler<WorkPerformetEventArgs>;
        if (del != null)
        {
            del(this, new WorkPerformetEventArgs(hours, workType));
        }
    }
    public virtual void OnWorkCompleted()
    {
        var del = WorkCompleted as EventHandler;
        if(del != null)
            del(this, EventArgs.Empty);
    }
}
