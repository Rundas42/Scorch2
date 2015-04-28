using UnityEngine;
using System.Collections;

public class CGUIManager : MonoBehaviour {

    private static CGUIManager instance;
    private CGUIManager() { }

    public static CGUIManager Instance
    {
        get
        {
            if(instance == null)
            {
                instance = new CGUIManager();
            }
            return instance;
        }
    }
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
