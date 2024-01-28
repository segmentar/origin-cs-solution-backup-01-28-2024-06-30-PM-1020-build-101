using Core;

namespace Core
{
    using System;

    using System.Threading;
    using System.Threading.Tasks;

    public partial class Expressionxportableexecute
    {
        public static Expressionxportable ExecuteAsync(Expressionxportable value_EXPRESSIONXPORTABLE)
        {
            Expressionxportable expressionxportableResult = default;

            var list = Expressionxportablemagic.ExpressionxportablemagicArrayListCastDispenser(Expressionxportable.ScheduleArrayListObject);

            Expressionxportable.LockObject = false;

            Action one, two;

            one = new Action(() => {

                while (Object.Equals((Boolean)Expressionxportable.LockObject, true))
                {
                    continue;
                }

                Expressionxportable.LockObject = true;

                value_EXPRESSIONXPORTABLE = ExecuteFull(value_EXPRESSIONXPORTABLE, (String[])list[0]);

                Expressionxportable.LockObject = false;
            });

            two = new Action(() => {

                while (Object.Equals((Boolean)Expressionxportable.LockObject, true))
                {
                    continue;
                }

                Expressionxportable.LockObject = true;

                value_EXPRESSIONXPORTABLE = ExecuteFull(value_EXPRESSIONXPORTABLE, (String[])list[1]);

                Expressionxportable.LockObject = false;
            });

            Task three, four;

            three = new Task(one);

            four = new Task(two);

            three.Start();

            four.Start();

            Task.WaitAll(three, four);



            /*oreach (String[] value in list)
            {
                Task task;

                task = new Task(() => {

                    System.Windows.Forms.MessageBox.Show($"asd [{String.Join(','.ToString(), value)}]");

                    expressionxportableResult = ExecuteFull(value_EXPRESSIONXPORTABLE, value);
                });

                task.Start();

                task.Wait();

                continue;
            }*/

            expressionxportableResult = value_EXPRESSIONXPORTABLE;

            return expressionxportableResult;
        }
    }
}
