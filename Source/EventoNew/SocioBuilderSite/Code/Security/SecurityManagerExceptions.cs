using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;
namespace SocioBuilderSite.Code.RbmSecurity
{
    [Serializable]
    public class smInvalidLoginException : Exception
    {
        public smInvalidLoginException() : base(Resources.Resource.err_LoginNotFound) { }
    }

    [Serializable]
    public class smInvalidPasswordException : Exception
    {
        public smInvalidPasswordException() : base(Resources.Resource.valerr_Password) { }
    }

    [Serializable]
    public class smLoginInactiveException : Exception
    {
        public smLoginInactiveException() : base(Resources.Resource.err_NotActiveUser) { }
    }

}