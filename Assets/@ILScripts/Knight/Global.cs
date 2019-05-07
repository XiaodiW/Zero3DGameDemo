﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zero;
using IL.Zero;

namespace Knight
{
    public class Global : ASingleton<Global>
    {
        public int fps = 60;
        public int quality = 1;
        public int resolution = 1;
        public Vector2Int defaultResolution;
        public Vector2Int resolutionSize;
    }
}