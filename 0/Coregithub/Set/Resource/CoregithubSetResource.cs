using Core;

namespace Core
{
    using System;

    using System.IO;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class Coregithub
    {
        
        public static IList<DirectoryInfo> CoregithubSetResource(String[] DirectoryFullName___ARRAY)
        {
            ICollection<DirectoryInfo> collectionResult = default;

            collectionResult = new Collection<DirectoryInfo>();

            foreach (String DirectoryFullName___VALUE in DirectoryFullName___ARRAY)
            {
                DirectoryInfo directoryInfo;

                directoryInfo = new DirectoryInfo(DirectoryFullName___VALUE);

                var boolean = false;

                boolean = boolean || Object.Equals(directoryInfo.Name, ((Char)Coreascii.EntityOne).ToString()) is true;

                boolean = boolean || Object.Equals(directoryInfo.Name, ((Char)Coreascii.EntityTwo).ToString()) is true;

                boolean = boolean || Object.Equals(directoryInfo.Name, ((Char)Coreascii.EntityThree).ToString()) is true;

                boolean = boolean || Object.Equals(directoryInfo.Name, ((Char)Coreascii.EntityFour).ToString()) is true;

                boolean = boolean || Object.Equals(directoryInfo.Name, ((Char)Coreascii.EntityFive).ToString()) is true;

                boolean = boolean || Object.Equals(directoryInfo.Name, ((Char)Coreascii.EntitySix).ToString()) is true;

                Boolean isEqualCheck, shouldContinueCheck;

                isEqualCheck = boolean is true;

                shouldContinueCheck = isEqualCheck is false;

                if (shouldContinueCheck is true)
                {
                    continue;
                }
                else
                    "false".ToString();

                collectionResult.Add(directoryInfo);

                continue;
            }

            return new List<DirectoryInfo>(collectionResult);
        }
    }
}
