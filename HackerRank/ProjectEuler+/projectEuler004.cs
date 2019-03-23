using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int t = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < t; a0++){
            int n = Convert.ToInt32(Console.ReadLine());
        int prod=0,a=0;
            for(int i=100;i<=999;i++){
                for(int j=100;j<=999;j++){
                    prod=i*j;
                    int num=prod;
                    int reversenum=0;
                    while(num!=0){
                    reversenum=reversenum*10;
                    reversenum=reversenum+num%10;
                    num=num/10;}
                    if(prod==reversenum && prod<n)
                    if(prod>a)
                    a=prod;
                }
            }
            Console.WriteLine(a);
        }
    }
}