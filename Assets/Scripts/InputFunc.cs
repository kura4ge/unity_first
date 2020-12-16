using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class InputFunc : MonoBehaviour
{
    public InputField inputField;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickSaveButton()
    {
        StreamWriter sw;
        FileInfo fi;
        string path = Application.dataPath + @"/MemoData/testmemo.txt";
        fi = new FileInfo(path);
        sw = fi.AppendText();

        string text = inputField.text;
        sw.WriteLine(text);

        sw.Flush();
        sw.Close();
        Debug.Log("Save Completed");
    }
}
