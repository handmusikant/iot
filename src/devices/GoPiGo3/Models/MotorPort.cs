﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Iot.Device.GoPiGo3.Models
{
    /// <summary>
    /// Port used to select the ports for motors
    /// </summary>
    public enum MotorPort
    {
        MotorLeft = 0x01,
        MotorRight = 0x02,
        Both = MotorLeft + MotorRight
    }
}
