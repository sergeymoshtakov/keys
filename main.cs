using System;
using keyListenerNamespace;
using personNameSpace;

class Program {
  public static void Main (string[] args) {
    KeyListener keyListener = new KeyListener();
    Person person = new Person(keyListener);
    keyListener.Listen();
  }
}