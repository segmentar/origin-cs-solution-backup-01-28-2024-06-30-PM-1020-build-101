using Core;

namespace Core
{
    using System;

    using System.IO;

    using System.Collections;

    public partial struct Bootxportablecompilecontext
    {
        public static Bootxportablecompilecontext Data()
        {
            Bootxportablecompilecontext bootxportablecompilecontextResult = default;

            var value = Bootxportablefolder.Folder(true);

            var deflect = new IEnumerable[4];

            deflect[0] = Bootxportableio.FunctionDirectoryInfoSetSurface(value, true, true);

            deflect[1] = Bootxportableio.BootxportableFileInfoSetSurface((DirectoryInfo[])deflect[0]);

            deflect[2] = Bootxportableio.FunctionDirectoryInfoSetSurface(value, true, false);

            deflect[3] = Bootxportableio.BootxportableFileInfoSetSurface((DirectoryInfo[])deflect[2]);

            Bootxportablecompilecontext bootxportablecompilecontext;

            bootxportablecompilecontext = new Bootxportablecompilecontext();

            bootxportablecompilecontext.BootFileInfoArray = (FileInfo[])deflect[1];

            //bootxportablecompilecontext.

            //bootxportablecompilecontext.ChaoticFileInfoArray = (FileInfo[])deflect[3];

            //bootxportablecompilecontextResult = bootxportablecompilecontext;

            return bootxportablecompilecontextResult;
        }
    }
}
