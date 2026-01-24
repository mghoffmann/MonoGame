// MonoGame - Copyright (C) MonoGame Foundation, Inc
// This file is subject to the terms and conditions defined in
// file 'LICENSE.txt', which is part of this source code package.

#nullable enable

using System;

namespace Microsoft.Xna.Framework.Audio;

partial class WaveBank
{
    private SoundEffectInstance PlatformCreateStream(StreamInfo stream)
    {
        throw new NotSupportedException();
    }
}
