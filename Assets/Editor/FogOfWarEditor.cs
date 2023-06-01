using System;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(FogOfWar))]
public class FogOfWarEditor : Editor
{
    void OnSceneGUI()
    {
        FogOfWar fogw = (FogOfWar)target;
        Handles.color = Color.white;
        Handles.DrawWireArc(fogw.transform.position, 
                            Vector3.up, 
                            Vector3.forward, 
                            360, 
                            fogw.viewRadius);
        
        // Draw line that only takes 0-180 degree in a circle
        Vector3 viewAngleA = fogw.DirFromAngle(-fogw.viewAngle/2, false);
        Vector3 viewAngleB = fogw.DirFromAngle(fogw.viewAngle/2, false);
        
        Handles.DrawLine(fogw.transform.position, fogw.transform.position + viewAngleA * fogw.viewRadius);
        Handles.DrawLine(fogw.transform.position, fogw.transform.position + viewAngleB * fogw.viewRadius);

        Handles.color = Color.red;
        foreach (Transform visibleTarget in fogw.visibleTargets)
        {
            Handles.DrawLine(fogw.transform.position, visibleTarget.transform.position);
        }
    }
}
