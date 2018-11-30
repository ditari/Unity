using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Text101 : MonoBehaviour {

    [SerializeField] Text textComponent;
    [SerializeField] States startingState;
    [SerializeField] States finalState;
    States state;
    bool f1, f2, f3;

    // Use this for initialization
    void Start ()
    {
        gameStart(); 
	}

    void gameStart()
    {
        f1 = false;
        f2 = false;
        f3 = false;
        state = startingState;
        textComponent.text = state.getStoryState();
    }
	
	// Update is called once per frame
	void Update () {
        var nextStates = state.getNextState(); //var di sini States []
        string sn = state.getName();
        
        if (sn.Equals("FFe")) //if statename 1 = f1 true
            f1 = true;
        else if (sn.Equals("SFe"))
            f2 = true;
        else if (sn.Equals("TFg"))
            f3 = true;

        if (f1 != true || f2 != true || f3 != true)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
                state = nextStates[0];
            else if (Input.GetKeyDown(KeyCode.Alpha2))
                state = nextStates[1];
            else if (Input.GetKeyDown(KeyCode.Alpha3))
                state = nextStates[2];
        }

        else if (sn.Equals("FFe")|| sn.Equals("SFe")|| sn.Equals("TFg"))
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
                state = finalState;
        }

        else 
        {
            f1 = false;
            f2 = false;
            f3 = false;
        }

        textComponent.text = state.getStoryState();


    }
}
