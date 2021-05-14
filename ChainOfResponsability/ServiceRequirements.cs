using System;

namespace ChainOfResponsability
{
    [Flags]
    enum ServiceRequirements
    {
        None = 0,
        WheelAlignement = 1,
        Dirty = 2,
        EngineTune = 4,
        TestDrive = 8
    }
}
