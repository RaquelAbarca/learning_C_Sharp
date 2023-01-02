// https://www.codewars.com/kata/51f2d1cafc9c0f745c00037d/train/csharp

//Complete the solution so that it returns true if the first argument(string) passed in ends with the 2nd argument (also a string).

//Examples:

// solution('abc', 'bc') // returns true
// solution('abc', 'd') // returns false

public class Kata
{
  public static bool Solution(string str, string ending)
  {
    int y = str.Length - ending.Length;

    if(str.Length>=ending.Length && str.Contains(ending) && str.Substring(y) == ending){
      return true;
    }else{
      return false;
      }
  }
}