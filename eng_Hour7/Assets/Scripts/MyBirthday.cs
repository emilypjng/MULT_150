using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBirthday : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
     for(int i = 1; i < 13; i++)
       {
        if (i == 1) {
            print ("1 is January");
        } else if (i ==2){
            print ("2 is February");
        } else if (i ==3){
            print ("3 is March");
        } else if (i ==4){
            print("4 is April");
        } else if (i ==5){
            print("It's my birthday!");
        } else if (i ==6){
            print("6 is June");
        } else if (i ==7){
            print("7 is July");
        } else if (i ==8){
            print("8 is August");
        } else if (i ==9){
            print("9 is September");
        } else if (i ==10){
            print("10 is October");
        } else if (i ==11){
            print("11 is November");
        } else if (i ==12){
            print("12 is December");
        }
    
       } 
       for(int i = 1; i < 32; i++)
       {
        if (i ==16) {
            print ("It's my birthday!");
        }
        else {
            print (i);
        }
        }

       }

    

    // Update is called once per frame
    void Update()
    {
        
    }
}
