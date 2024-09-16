using Godot;
using System;

public class Item2D : Node2D, IDraggable, IClickable
{
    [Export]
    public bool CanClick { get; set; } = false;
    [Export]
    public bool CanDrag { get; set; } = false;

    public bool IsDragging { get; set; } = false;
    public Vector2 Offset { get; set; } = new Vector2();

    public override void _Ready()
    {
        
    }

    public override void _Process(float delta)
    {
        if (IsDragging)
        {
            GlobalPosition = GetGlobalMousePosition() - Offset;
        }
    }

    public void OnInputEvent(Node node, InputEvent @event, int index)
    {
        if (Input.IsActionJustPressed("mouse_interact"))
        {
            IsDragging = true;
            Offset = GetGlobalMousePosition() - GlobalPosition;
        }
        if (Input.IsActionJustReleased("mouse_interact"))
        {
            IsDragging = false;
        }
    }

    public void OnMouseDown()
    {
        throw new NotImplementedException();
    }

    public void OnMouseUp()
    {
        throw new NotImplementedException();
    }

    public void OnMouseClick()
    {
        throw new NotImplementedException();
    }
}
