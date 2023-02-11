using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    [CreateAssetMenu(fileName = "Key", menuName = "Add-Ons/Code Monkey/Key Door System/Create Key", order = 1)]
    
    {
        [Tooltip("Color of the Key")]
        public Color keyColor;
    }
}
