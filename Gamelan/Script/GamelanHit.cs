using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamelanHit : MonoBehaviour {

    public List<int> WhichGamelan = new List<int>();
    public List<int> MusicSheet = new List<int>();

    public void GetGamelan(int hit)
    {
        WhichGamelan.Add(hit);
        CompareList();
    }

    //call this everytime hit gamelan
    public bool CompareList()
    {
        for(int i=0; i<WhichGamelan.Count; i++)
        {
            if(WhichGamelan[i] != MusicSheet[i])
            {
                print("Lose");
                return false;
            }
        }
        return true;
    }
}
