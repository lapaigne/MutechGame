using Godot;
using System;

public class SubViewportContainer : ViewportContainer
{
    public override void _Input(InputEvent @event)
    {
        GetViewport()._UnhandledInput(@event);
        GetNode<Viewport>("SubViewport")._UnhandledInput(@event);
    }
}
