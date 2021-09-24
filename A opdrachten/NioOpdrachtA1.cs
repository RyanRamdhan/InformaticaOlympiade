using System;
using System.Collections.Generic;

class NioOpdrachtA1{

    static void Main(string[] args){
		
		string input = Console.ReadLine();
        var unique = new HashSet<char>(input);
		int aantalChar = 0;
        
        foreach (char c in unique){
			aantalChar++;
		}
        
        Console.Write("Aantal letters: "+aantalChar);
        
    } 
}

