using Core;

namespace Core
{
    using System;

    public partial class Bootxportableconvert
    {
        public static Materialxportable Convert(Expressionxportable value_EXPRESSIONXPORTABLE, Materialxportable value_MATERIALXPORTABLE)
        {
            Materialxportable materialxportableResult = default;

            foreach (Expressionxportable expressionxportable in Expressionxportablemagic.ExpressionxportablemagicArrayListCastDispenser(value_EXPRESSIONXPORTABLE.LayerArrayListObject))
            {
                var reflect = (Expressionxportablestringsafe)(expressionxportable.StringIdentity as Object);

                switch (reflect.Value)
                {
                    case Expressionxportablestorehexagon.EntityKAI:
                        Materialxportablesegment.GroupDKAI(value_MATERIALXPORTABLE, expressionxportable.ObjectIdentity);
                        break;

                    case Expressionxportablestorehexagon.EntitySAJ:
                        Materialxportablesegment.GroupDSAJ(value_MATERIALXPORTABLE, expressionxportable.ObjectIdentity);
                        break;

                    case Expressionxportablestorehexagon.EntityTAK:
                        Materialxportablesegment.GroupDTAK(value_MATERIALXPORTABLE, expressionxportable.ObjectIdentity);
                        break;

                    case Expressionxportablestorehexagon.EntityNAL:
                        Materialxportablesegment.GroupDNAL(value_MATERIALXPORTABLE, expressionxportable.ObjectIdentity);
                        break;

                    case Expressionxportablestorehexagon.EntityHAM:
                        Materialxportablesegment.GroupDHAM(value_MATERIALXPORTABLE, expressionxportable.ObjectIdentity);
                        break;

                    case Expressionxportablestorehexagon.EntityMAN:
                        Materialxportablesegment.GroupDMAN(value_MATERIALXPORTABLE, expressionxportable.ObjectIdentity);
                        break;

                    default:
                        break;
                }

                //Convert(expressionxportable, value_MATERIALXPORTABLE);

                continue;
            }

            var result = value_MATERIALXPORTABLE;

            materialxportableResult = result;

            return materialxportableResult;
        }
    }
}
