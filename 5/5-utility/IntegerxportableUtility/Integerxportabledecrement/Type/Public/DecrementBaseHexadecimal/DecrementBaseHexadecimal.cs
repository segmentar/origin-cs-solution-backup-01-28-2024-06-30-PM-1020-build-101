using Core;

namespace Core
{
    using System;

    public partial class Integerxportabledecrement
    {
        public static Char DecrementBaseHexadecimal(Char Character_VALUE)
        {
            Char characterResult = default;

            try
            {
                Char character;

                switch ((Int32)Character_VALUE)
                {
                    case Integerxportableascii.EntityZero:
                        character = (Char)Integerxportableascii.EntityLowercaseF;
                        break;

                    case Integerxportableascii.EntityOne:
                        character = (Char)Integerxportableascii.EntityZero;
                        break;

                    case Integerxportableascii.EntityTwo:
                        character = (Char)Integerxportableascii.EntityOne;
                        break;

                    case Integerxportableascii.EntityThree:
                        character = (Char)Integerxportableascii.EntityTwo;
                        break;

                    case Integerxportableascii.EntityFour:
                        character = (Char)Integerxportableascii.EntityThree;
                        break;

                    case Integerxportableascii.EntityFive:
                        character = (Char)Integerxportableascii.EntityFour;
                        break;

                    case Integerxportableascii.EntitySix:
                        character = (Char)Integerxportableascii.EntityFive;
                        break;

                    case Integerxportableascii.EntitySeven:
                        character = (Char)Integerxportableascii.EntitySix;
                        break;

                    case Integerxportableascii.EntityEight:
                        character = (Char)Integerxportableascii.EntitySeven;
                        break;

                    case Integerxportableascii.EntityNine:
                        character = (Char)Integerxportableascii.EntityEight;
                        break;

                    case Integerxportableascii.EntityLowercaseA:
                        character = (Char)Integerxportableascii.EntityNine;
                        break;

                    case Integerxportableascii.EntityLowercaseB:
                        character = (Char)Integerxportableascii.EntityLowercaseA;
                        break;

                    case Integerxportableascii.EntityLowercaseC:
                        character = (Char)Integerxportableascii.EntityLowercaseB;
                        break;

                    case Integerxportableascii.EntityLowercaseD:
                        character = (Char)Integerxportableascii.EntityLowercaseC;
                        break;

                    case Integerxportableascii.EntityLowercaseE:
                        character = (Char)Integerxportableascii.EntityLowercaseD;
                        break;

                    case Integerxportableascii.EntityLowercaseF:
                        character = (Char)Integerxportableascii.EntityLowercaseE;
                        break;

                    default:
                        character = (Char)Integerxportableascii.EntityNull;
                        break;
                }

                characterResult = character;
            }
            catch (Exception exception)
            {
                Integerxportablerender.RenderError($"{IntegerxportableCode.RenderPath.Core_Integerxportable_Fatal}", new Integerxportablefatal.DecrementBaseHexadecimal().Initialize(new String[0], exception));
            }

            return characterResult;
        }
    }
}
