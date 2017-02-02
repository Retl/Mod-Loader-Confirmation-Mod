using UnityEngine;
using System.Collections;

public class ConfirmModLoader : MonoBehaviour {

	// Use this for initialization
	void Start () {
        string filename = "ModLoaderConfirmed.txt";
        using (System.IO.StreamWriter file = new System.IO.StreamWriter(filename, true))
            {
            System.DateTime date = System.DateTime.Now;
            file.WriteLine(date.ToLongDateString() + ", " + date.ToLongTimeString() + " ~ " + filename);
            }
        }
}
