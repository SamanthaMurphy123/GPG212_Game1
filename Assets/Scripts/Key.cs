using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Samantha
{
    [CreateAssetMenu(fileName = "Key", menuName = "Add-Ons/Code Monkey/Key Door System/Create Key", order = 1)]
    public class Key : MonoBehaviour
    {

        [Tooltip("Color of the Key")]
        public Color keyColor;

    }

}