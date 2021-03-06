using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Enum
{
    public enum EStatus
    {
        None = -1,
        Disable = 0,
        Enable = 1,
    }

    public enum EReadingStatus
    {
        None = -1,
        NotYet = 0,
        InProgress = 1,
        Wishlist = 2,
        Done = 3,
    }
}
