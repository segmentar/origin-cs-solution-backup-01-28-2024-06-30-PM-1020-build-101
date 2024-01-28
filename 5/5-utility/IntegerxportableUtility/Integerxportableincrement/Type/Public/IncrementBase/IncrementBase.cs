using Core;

namespace Core
{
    using System;

    public partial class Integerxportableincrement
    {
        public static Char IncrementBase(Char Character_VALUE)
        {
            Char characterResult = default;

            try
            {
                Char character;

                switch ((Int32)Character_VALUE)
                {
                    case Integerxportableascii.EntityZero:
                        character = (Char)Integerxportableascii.EntityOne;
                        break;

                    case Integerxportableascii.EntityOne:
                        character = (Char)Integerxportableascii.EntityTwo;
                        break;

                    case Integerxportableascii.EntityTwo:
                        character = (Char)Integerxportableascii.EntityThree;
                        break;

                    case Integerxportableascii.EntityThree:
                        character = (Char)Integerxportableascii.EntityFour;
                        break;

                    case Integerxportableascii.EntityFour:
                        character = (Char)Integerxportableascii.EntityFive;
                        break;

                    case Integerxportableascii.EntityFive:
                        character = (Char)Integerxportableascii.EntitySix;
                        break;

                    case Integerxportableascii.EntitySix:
                        character = (Char)Integerxportableascii.EntitySeven;
                        break;

                    case Integerxportableascii.EntitySeven:
                        character = (Char)Integerxportableascii.EntityEight;
                        break;

                    case Integerxportableascii.EntityEight:
                        character = (Char)Integerxportableascii.EntityNine;
                        break;

                    case Integerxportableascii.EntityNine:
                        character = (Char)Integerxportableascii.EntityZero;
                        break;

                    default:
                        character = (Char)Integerxportableascii.EntityNull;
                        break;
                }

                characterResult = character;
            }
            catch (Exception exception)
            {
                Integerxportablerender.RenderError($"{IntegerxportableCode.RenderPath.Core_Integerxportable_Fatal}", new Integerxportablefatal.IncrementBase().Initialize(new String[0], exception));
            }

            return characterResult;
        }
    }
}
