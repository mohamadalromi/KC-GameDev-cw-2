using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cw3 : MonoBehaviour
{
string heroname = "mono";
int heroage = 14;
int heroheghit = 162;
string herosuperpower = "psychokinesis";
string villainName = "strange";
 int villainage = 18;
 int villainheghit = 172;
string villainsuperpower = "timecontrolling";
// Start is called before the first frame update
void start()
    { 
    int agedifference = heroage - villainage;
    print("hero name is" + heroname + "hero age is" + heroage + "hero heghit is" + heroheghit + "hero superpower is" + herosuperpower);
    print("villain name is" + villainName + "villain age is" + villainage + "villain heghit is" + villainheghit + "villain superpower is" + villainsuperpower);
    print("age difference is" + agedifference);
    }   

    
    //  Update is called once per frame
    void Update()
    {
        
    }
}