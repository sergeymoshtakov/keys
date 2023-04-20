using System;

namespace keyListenerNamespace
{
  public class KeyListener
  {
    public event EventHandler EnterKeyPressed;
    public event EventHandler SpaceKeyPressed;
    public event EventHandler EscapeKeyPressed;
    public event EventHandler F1KeyPressed;
    public event EventHandler LeftKeyPressed;
    public event EventHandler RightKeyPressed;
    public event EventHandler UpKeyPressed;
    public event EventHandler DownKeyPressed;

    public void Listen()
    {
      if (Console.KeyAvailable)
      {
        ConsoleKeyInfo keyInfo = Console.ReadKey(true);
        switch(keyInfo.Key)
        {
        case ConsoleKey.Enter:
          EnterKeyPressed?.Invoke(this, EventArgs.Empty);
          break;
        case ConsoleKey.Spacebar:
          SpaceKeyPressed?.Invoke(this, EventArgs.Empty);
          break;
        case ConsoleKey.Escape:
          EscapeKeyPressed?.Invoke(this, EventArgs.Empty);
          break;
        case ConsoleKey.F1:
          F1KeyPressed?.Invoke(this, EventArgs.Empty);
          break;
        case ConsoleKey.LeftArrow:
          LeftKeyPressed?.Invoke(this, EventArgs.Empty);
          break;
        case ConsoleKey.RightArrow:
          RightKeyPressed?.Invoke(this, EventArgs.Empty);
          break;
        case ConsoleKey.UpArrow:
          UpKeyPressed?.Invoke(this, EventArgs.Empty);
          break;
        case ConsoleKey.DownArrow:
          DownKeyPressed?.Invoke(this, EventArgs.Empty);
          break;
        default:
          break;
        }
      }
    }
  }  
}