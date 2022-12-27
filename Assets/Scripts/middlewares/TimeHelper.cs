using UnityEngine;
public class TimeHelper 
{
    private static int totalSteps = 16; // 16 morph steps
	private static float duration = 4f; // 4 seconds
    private static float? _lerpTime;
	public static float LerpTime{
		get{
            if(_lerpTime == null){
                float mps = (float)duration*1000/(float)totalSteps;// morphs per second
                float t = Time.realtimeSinceStartup; // Should actually be since animation start
                int arrayIndex = Mathf.FloorToInt( t / mps );
                _lerpTime = (t-((float)arrayIndex)*mps) / mps;
            }
			return (float)_lerpTime;
		}
	}
}
