﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rg.Plugins.Popup.Animations;
using Rg.Plugins.Popup.Enums;

namespace Rg.Plugins.Popup.Services
{
    internal static class AnimationServices
    {
        public static IPopupAnimation GeAnimation(AnimationsName animation)
        {
            switch (animation)
            {
                case AnimationsName.Others:
                    return null;
                case AnimationsName.Fade:
                    return new FadeAnimation();
                // Scale Up
                case AnimationsName.ScaleCenterUp:
                    return new ScaleAnimation(MoveAnimationsName.Center, MoveAnimationsName.Center, ScaleAnimationsName.Up);
                case AnimationsName.ScaleTopUp:
                    return new ScaleAnimation(MoveAnimationsName.Top, MoveAnimationsName.Top, ScaleAnimationsName.Up);
                case AnimationsName.ScaleTopBottomUp:
                    return new ScaleAnimation(MoveAnimationsName.Top, MoveAnimationsName.Bottom, ScaleAnimationsName.Up);
                case AnimationsName.ScaleBottomUp:
                    return new ScaleAnimation(MoveAnimationsName.Bottom, MoveAnimationsName.Bottom, ScaleAnimationsName.Up);
                case AnimationsName.ScaleBottomTopUp:
                    return new ScaleAnimation(MoveAnimationsName.Bottom, MoveAnimationsName.Top, ScaleAnimationsName.Up);
                case AnimationsName.ScaleLeftUp:
                    return new ScaleAnimation(MoveAnimationsName.Left, MoveAnimationsName.Left, ScaleAnimationsName.Up);
                case AnimationsName.ScaleLeftRightUp:
                    return new ScaleAnimation(MoveAnimationsName.Left, MoveAnimationsName.Right, ScaleAnimationsName.Up);
                case AnimationsName.ScaleRightUp:
                    return new ScaleAnimation(MoveAnimationsName.Right, MoveAnimationsName.Right, ScaleAnimationsName.Up);
                case AnimationsName.ScaleRightLeftUp:
                    return new ScaleAnimation(MoveAnimationsName.Right, MoveAnimationsName.Left, ScaleAnimationsName.Up);
                // Scale Down
                case AnimationsName.ScaleCenterDown:
                    return new ScaleAnimation(MoveAnimationsName.Center, MoveAnimationsName.Center, ScaleAnimationsName.Down);
                case AnimationsName.ScaleTopDown:
                    return new ScaleAnimation(MoveAnimationsName.Top, MoveAnimationsName.Top, ScaleAnimationsName.Down);
                case AnimationsName.ScaleTopBottomDown:
                    return new ScaleAnimation(MoveAnimationsName.Top, MoveAnimationsName.Bottom, ScaleAnimationsName.Down);
                case AnimationsName.ScaleBottomDown:
                    return new ScaleAnimation(MoveAnimationsName.Bottom, MoveAnimationsName.Bottom, ScaleAnimationsName.Down);
                case AnimationsName.ScaleBottomTopDown:
                    return new ScaleAnimation(MoveAnimationsName.Bottom, MoveAnimationsName.Top, ScaleAnimationsName.Down);
                case AnimationsName.ScaleLeftDown:
                    return new ScaleAnimation(MoveAnimationsName.Left, MoveAnimationsName.Left, ScaleAnimationsName.Down);
                case AnimationsName.ScaleLeftRightDown:
                    return new ScaleAnimation(MoveAnimationsName.Left, MoveAnimationsName.Right, ScaleAnimationsName.Down);
                case AnimationsName.ScaleRightDown:
                    return new ScaleAnimation(MoveAnimationsName.Right, MoveAnimationsName.Right, ScaleAnimationsName.Down);
                case AnimationsName.ScaleRightLeftDown:
                    return new ScaleAnimation(MoveAnimationsName.Right, MoveAnimationsName.Left, ScaleAnimationsName.Down);
            }

            return null;
        }
    }
}