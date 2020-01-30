using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace practise{

    class MonkeyProgram{
        public String input{get;set;}
        List<String> arrayofnumbers {get;set;}
        
        void Calc(){
            int position=0;
            int count=0;
            int i=0;
            //sort the array.
            var sortedarrayofnumbers =arrayofnumbers.OrderBy(x=>x.Length).ToList();
            while(i<arrayofnumbers.Count && input.Length >0){            
                position=input.IndexOf(sortedarrayofnumbers[i]);
                if(position!=-1){
                    //hit anndremove these elements from the string 
                    input=input.Remove(position,arrayofnumbers[i].Length);
                    count++;                    
                }           
                else
                    i++;   
            }   
            Console.WriteLine(count);       
        }
        
    }
}