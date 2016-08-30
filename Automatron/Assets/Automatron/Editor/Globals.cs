﻿using System;
using UnityEngine;

namespace TNRD.Automatron {

    public static class Globals {

        public static Vector2 Camera;

        public static bool IsError;
        public static bool IsExecuting;

        public static FieldLine TempFieldLine;
        public static AutomationLine TempAutomationLine;

        public static Exception LastError;
    }
}