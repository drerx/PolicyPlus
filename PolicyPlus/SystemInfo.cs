﻿using System.Linq;

namespace PolicyPlus
{
    public static class SystemInfo
    {

        public static bool HasGroupPolicyInfrastructure()
        {
            var windowsEdition = default(int);
            PInvoke.GetProductInfo(6, 0, 0, 0, ref windowsEdition);
            return new[] { 6, 0x10, 0x12, 0x40, 0x50, 8, 0xC, 0x27, 0x25, 0xA, 0xE, 0x29, 0xF, 0x26, 0x3C, 0x3E, 0x3B, 0x3D, 0x2A, 0x1E, 0x20, 0x1F, 0x4D, 0x4C, 0x67, 0x32, 0x36, 0x33, 0x37, 0x18, 0x23, 0x21, 9, 0x19, 0x3F, 0x38, 0x4F, 7, 0xD, 0x28, 0x24, 0x34, 0x35, 0x17, 0x2E, 0x14, 0x2B, 0x60, 0x15, 0x2C, 0x5F, 0x16, 0x2D, 1, 0x1C, 0x11, 0x1D, 0x79, 0x7A }.Contains(windowsEdition);
        }
    }
}