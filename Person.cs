using System;
using keyListenerNamespace;

namespace personNameSpace
{
  public class Person
  {
    public Person(KeyListener keyListener)
    {
      keyListener.EnterKeyPressed += KeyListener_EnterKeyPressed;
      keyListener.SpaceKeyPressed += KeyListener_SpaceKeyPressed;
      keyListener.EscapeKeyPressed += KeyListener_EscapeKeyPressed;
      keyListener.F1KeyPressed += KeyListener_F1KeyPressed;
      keyListener.LeftKeyPressed += KeyListener_LeftKeyPressed;
      keyListener.RightKeyPressed += KeyListener_RightKeyPressed;
      keyListener.UpKeyPressed += KeyListener_UpKeyPressed;
      keyListener.DownKeyPressed += KeyListener_DownKeyPressed;
    }
    private void KeyListener_EnterKeyPressed(object sender, EventArgs e)
    {
        Select();
    }

    private void KeyListener_SpaceKeyPressed(object sender, EventArgs e)
    {
        Jump();
    }

    private void KeyListener_EscapeKeyPressed(object sender, EventArgs e)
    {
        Exit();
    }

    private void KeyListener_F1KeyPressed(object sender, EventArgs e)
    {
        Rotate();
    }

    private void KeyListener_LeftKeyPressed(object sender, EventArgs e)
    {
        Move("left");
    }

    private void KeyListener_RightKeyPressed(object sender, EventArgs e)
    {
        Move("right");
    }

    private void KeyListener_UpKeyPressed(object sender, EventArgs e)
    {
        Move("up");
    }

    private void KeyListener_DownKeyPressed(object sender, EventArgs e)
    {
        Move("down");
    }
    private void Move(string direction)
    {
      Console.WriteLine($"Move {direction}!");
    }
    private void Exit()
    {
      Console.WriteLine("Good bye!");
    }
    private void Select()
    {
      Console.WriteLine("Selected!");
    }
    private void Jump()
    {
      Console.WriteLine("Jump!");
    }
    private void Rotate()
    {
      Console.WriteLine("Rotate!");
    }
  }  
}