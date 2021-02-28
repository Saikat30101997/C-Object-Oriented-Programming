using System;
namespace visual_studio
{
 public interface A
 {
    void play();
 }

 public class c:A,B
 {
    public void play()
    {
       Console.WriteLine("Hello");
    }
 }

}