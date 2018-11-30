using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="States")]
public class States : ScriptableObject {

    [TextArea(10,14)][SerializeField] string storyText;
    [SerializeField] States[] nextState;
    [SerializeField]  string nama;

    public string getStoryState()
    {
        return storyText;
    }

    public string getName()
    {
        return nama;
    }

    public States [] getNextState()
    {
        return nextState;
    }
}
