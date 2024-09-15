using Godot;

public interface IDraggable
{
    bool CanDrag { get; set; }
    bool IsDragging { get; set; }
    Vector2 Offset { get; set; }

    void OnMouseDown();
    void OnMouseUp();
}
