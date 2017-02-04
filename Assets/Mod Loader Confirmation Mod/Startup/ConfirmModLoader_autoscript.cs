using UnityEngine;
using System.Collections;

public class ConfirmModLoader_autoscript : MonoBehaviour {

    bool show = true;
	// Use this for initialization
	void Start () {
        string filename = "ModLoaderConfirmed.txt";
        using (System.IO.StreamWriter file = new System.IO.StreamWriter(filename, true))
            {
            System.DateTime date = System.DateTime.Now;
            file.WriteLine(date.ToLongDateString() + ", " + date.ToLongTimeString() + " ~ " + filename);
            }
        }

    void Update() 
    {
        if (Input.GetKeyDown(KeyCode.BackQuote)) { show = !show; }
    }

    void OnGUI() 
    {
        if (show) 
        {
            GUI.Label(new Rect(0 + 32f, 8f, 200f, 40f), "@~Dazl Debug is Running~@");
        }
    }
}
