using System;

class Program {
  static void Main(string[] args){
    Console.WriteLine("abi voer getal in abi:");
    string test = Console.ReadLine();
    int input = Convert.ToInt32(test);
    string binary = Convert.ToString(input, 2);

    char[] binaryArray = binary.ToCharArray();
    char[] unoReverse = binaryArray;
    Array.Reverse(unoReverse);
    Console.WriteLine(unoReverse);

    int m = 0;
    for(int i=0; i<unoReverse.Length; i++){
      if(unoReverse[i] == '0'){
        m++;

      }
      else{
        break;
      }
    }
    Console.WriteLine(m);

	string reverse = new string(unoReverse);
	Console.WriteLine(reverse.Remove(0, m));

	int output = Convert.ToInt32(reverse, 2);
	Console.WriteLine(output);
  }

}