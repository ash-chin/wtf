using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Dialogue
{
    [TextArea(3, 12)]
    public string[] stenences;
    public string characterName;
}