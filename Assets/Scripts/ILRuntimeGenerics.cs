﻿using System;
using Zero;

namespace Sokoban
{
    class ILRuntimeGenerics : BaseILRuntimeGenerics
    {
        public override void Register(ILRuntime.Runtime.Enviorment.AppDomain appdomain)
        {
            appdomain.DelegateManager.RegisterMethodDelegate<System.String>();
            {
                return new DG.Tweening.TweenCallback(() =>
                {
                    ((Action)act)();
                });
            });

        }
    }
}