using Content.Client.IconSmoothing;
using Content.Shared.Chemistry.Components;
using Content.Shared.Fluids;
using Content.Shared.Fluids.Components;
using Robust.Client.GameObjects;
using Robust.Shared.Map;

namespace Content.Client.Fluids;

public sealed class PoolSystem
{
    public sealed class DrownSystem : SharedPuddleSystem
    {
        [Dependency] private readonly IconSmoothSystem _smooth = default!;
        [Dependency] private readonly SpriteSystem _sprite = default!;
    }
}
