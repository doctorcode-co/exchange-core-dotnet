﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenHFT.Chronicle.WireMock
{
    public interface IBytesOut
    {
        IBytesOut writeLong(long askPrice);
        IBytesOut writeInt(object p);
        IBytesOut writeByte(byte direction);
    }
}
