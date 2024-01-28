using Core;

namespace Core
{
    using System;

    public partial class Expressionxportable
    {
        [Expressionxportableism]
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] { 
            
                String.Empty + nameof(Expressionxportable) + ' ' + "::" + ' ' + '{',
                String.Empty + '.' + "compress",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(IsDebug) + ':' + ' ' + IsDebug,
                String.Empty + '.' + "compress-raw",
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(StringIdentity) + ':' + ' ' + "<hidden>",
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(StringIdentity) + ':' + ' ' + $"<safe><<{((Expressionxportablestringsafe)StringIdentity).ValueSafe}>>",
                String.Empty + '\t' + '~' + "04" + ' ' + nameof(ObjectIdentity) + ':' + ' ' + ". . ." + ' ' + $"<{ObjectIdentity == default}>",
                String.Empty + '.' + "information-raw",
                String.Empty + '\t' + '~' + "05" + ' ' + nameof(RemoteArrayObject) + ':' + ' ' + ". . ." + ' ' + $"<{((Byte[])RemoteArrayObject).Length}>",
                String.Empty + '\t' + '~' + "06" + ' ' + nameof(LayerArrayListObject) + ':' + ' ' + ". . ." + ' ' + $"<{Expressionxportablemagic.ExpressionxportablemagicArrayListCastDispenser(LayerArrayListObject).Count}>",
                String.Empty + '\t' + '~' + "07" + ' ' + ". . . . .",
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(ObjectIdentity) + ':',
                String.Empty + ObjectIdentity,
                String.Empty,
                String.Empty + '~' + "20" + ' ' + nameof(LayerArrayListObject) + ':',
                String.Empty + String.Join('\n'.ToString(), Expressionxportablemagic.ExpressionxportablemagicArrayListCastDispenser(LayerArrayListObject).ToArray()),
                String.Empty,
                String.Empty + '~' + "30" + ' ' + nameof(RemoteArrayObject) + ':',
                String.Empty + String.Join('\n'.ToString(), (Byte[])RemoteArrayObject),
                String.Empty,
                String.Empty + '~' + "40" + ' ' + ". . . . ." + ':',
                String.Empty + Expressionxportableformat.RepresentString(this, 1),
            });
        }
    }
}
