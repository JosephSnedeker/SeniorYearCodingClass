package com.asd20;
import java.util.*;
import java.io.*;

public class ReadingFromAFile {

	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		int nTests = scanner.nextInt();
		
		List<Integer> names = new ArrayList<Integer>();
		for (int i = 0; i < nTests; i++) {
			names.add(Integer.parseInt(scanner.next())); 
		}
		for (int i = 0; i< nTests; i++){
			if(names.get(i) % 3 == 0) {
				System.out.print("code ");
				
			}
			if(names.get(i) % 7 == 0) {
				System.out.print("quest");	
			}
			if(names.get(i) % 7 != 0 && names.get(i) % 3 != 0) {
				System.out.print(names.get(i));
			}
			System.out.println();
		
			
			
		}
			
			
	}

}
