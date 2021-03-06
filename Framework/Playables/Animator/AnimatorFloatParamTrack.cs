using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace Framework
{
	namespace Playables
	{
		[TrackColor(180f / 255f, 115f / 255f, 215f / 255f)]
		[TrackBindingType(typeof(Animator))]
		[TrackClipType(typeof(AnimatorFloatParamClip))]
		public class AnimatorFloatParamTrack : AnimatorParamTrack, IParentBindableTrack
		{	
			public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
			{
				ScriptPlayable<AnimatorFloatParamTrackMixer> playable = TimelineUtils.CreateTrackMixer<AnimatorFloatParamTrackMixer>(this, graph, go, inputCount);

				ParentBindableTrack.OnCreateTrackMixer(this, playable.GetBehaviour(), graph);

				return playable;
			}
		}
	}
}