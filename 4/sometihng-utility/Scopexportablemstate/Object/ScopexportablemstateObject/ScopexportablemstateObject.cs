using Core;

namespace Core
{
    using System;

    public partial struct Scopexportablemstate
    {
        [Scopexportableism]
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] { 
            
                String.Empty + nameof(Scopexportablemstate) + ' ' + "::" + ' ' + '{',
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(IsRun) + ':' + ' ' + (Boolean)IsRun,
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(IsPauseObject) + ':' + ' ' + (Boolean)IsPauseObject,
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(ShouldSkip) + ':' + ' ' + (Boolean)ShouldSkip,
                String.Empty + '\t' + '~' + "04" + ' ' + nameof(IntervalObject) + ':' + ' ' + (Int32)IntervalObject,
                String.Empty + '}'
            });
        }
    }
}
