public interface IClickable
{
    bool CanClick { get; set; }
    void OnMouseClick();
}