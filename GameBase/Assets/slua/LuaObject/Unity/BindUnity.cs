﻿using System;
namespace SLua {
	[LuaBinder(0)]
	public class BindUnity {
		public static void Bind(IntPtr l) {
			Lua_UnityEngine_AsyncOperation.reg(l);
			Lua_UnityEngine_AssetBundleCreateRequest.reg(l);
			Lua_UnityEngine_AssetBundleRequest.reg(l);
			Lua_UnityEngine_Object.reg(l);
			Lua_UnityEngine_AssetBundle.reg(l);
			Lua_UnityEngine_AssetBundleManifest.reg(l);
			Lua_UnityEngine_SendMessageOptions.reg(l);
			Lua_UnityEngine_PrimitiveType.reg(l);
			Lua_UnityEngine_Space.reg(l);
			Lua_UnityEngine_LayerMask.reg(l);
			Lua_UnityEngine_RuntimePlatform.reg(l);
			Lua_UnityEngine_SystemLanguage.reg(l);
			Lua_UnityEngine_LogType.reg(l);
			Lua_UnityEngine_DeviceType.reg(l);
			Lua_UnityEngine_SystemInfo.reg(l);
			Lua_UnityEngine_WaitForSeconds.reg(l);
			Lua_UnityEngine_WaitForFixedUpdate.reg(l);
			Lua_UnityEngine_WaitForEndOfFrame.reg(l);
			Lua_UnityEngine_ScriptableObject.reg(l);
			Lua_UnityEngine_ThreadPriority.reg(l);
			Lua_UnityEngine_Profiler.reg(l);
			Lua_UnityEngine_CrashReport.reg(l);
			Lua_UnityEngine_Component.reg(l);
			Lua_UnityEngine_OcclusionArea.reg(l);
			Lua_UnityEngine_OcclusionPortal.reg(l);
			Lua_UnityEngine_RenderSettings.reg(l);
			Lua_UnityEngine_QualitySettings.reg(l);
			Lua_UnityEngine_MeshFilter.reg(l);
			Lua_UnityEngine_CombineInstance.reg(l);
			Lua_UnityEngine_Mesh.reg(l);
			Lua_UnityEngine_BoneWeight.reg(l);
			Lua_UnityEngine_Renderer.reg(l);
			Lua_UnityEngine_SkinnedMeshRenderer.reg(l);
			Lua_UnityEngine_Flare.reg(l);
			Lua_UnityEngine_Behaviour.reg(l);
			Lua_UnityEngine_LensFlare.reg(l);
			Lua_UnityEngine_Projector.reg(l);
			Lua_UnityEngine_Skybox.reg(l);
			Lua_UnityEngine_TrailRenderer.reg(l);
			Lua_UnityEngine_LineRenderer.reg(l);
			Lua_UnityEngine_MaterialPropertyBlock.reg(l);
			Lua_UnityEngine_Graphics.reg(l);
			Lua_UnityEngine_LightmapData.reg(l);
			Lua_UnityEngine_LightmapsModeLegacy.reg(l);
			Lua_UnityEngine_LightProbes.reg(l);
			Lua_UnityEngine_LightmapSettings.reg(l);
			Lua_UnityEngine_GeometryUtility.reg(l);
			Lua_UnityEngine_Screen.reg(l);
			Lua_UnityEngine_SleepTimeout.reg(l);
			Lua_UnityEngine_GL.reg(l);
			Lua_UnityEngine_MeshRenderer.reg(l);
			Lua_UnityEngine_StaticBatchingUtility.reg(l);
			Lua_UnityEngine_ImageEffectTransformsToLDR.reg(l);
			Lua_UnityEngine_ImageEffectOpaque.reg(l);
			Lua_UnityEngine_Texture.reg(l);
			Lua_UnityEngine_Texture2D.reg(l);
			Lua_UnityEngine_Cubemap.reg(l);
			Lua_UnityEngine_Texture3D.reg(l);
			Lua_UnityEngine_SparseTexture.reg(l);
			Lua_UnityEngine_RenderTexture.reg(l);
			Lua_UnityEngine_ReflectionProbe.reg(l);
			Lua_UnityEngine_LODFadeMode.reg(l);
			Lua_UnityEngine_LOD.reg(l);
			Lua_UnityEngine_LODGroup.reg(l);
			Lua_UnityEngine_GradientColorKey.reg(l);
			Lua_UnityEngine_GradientAlphaKey.reg(l);
			Lua_UnityEngine_Gradient.reg(l);
			Lua_UnityEngine_ScaleMode.reg(l);
			Lua_UnityEngine_FocusType.reg(l);
			Lua_UnityEngine_RectOffset.reg(l);
			Lua_UnityEngine_ImagePosition.reg(l);
			Lua_UnityEngine_Event.reg(l);
			Lua_UnityEngine_KeyCode.reg(l);
			Lua_UnityEngine_FlareLayer.reg(l);
			Lua_UnityEngine_LightProbeGroup.reg(l);
			Lua_UnityEngine_Vector2.reg(l);
			Lua_UnityEngine_Vector3.reg(l);
			Lua_UnityEngine_Color.reg(l);
			Lua_UnityEngine_Color32.reg(l);
			Lua_UnityEngine_Quaternion.reg(l);
			Lua_UnityEngine_Rect.reg(l);
			Lua_UnityEngine_Matrix4x4.reg(l);
			Lua_UnityEngine_Bounds.reg(l);
			Lua_UnityEngine_Vector4.reg(l);
			Lua_UnityEngine_Ray.reg(l);
			Lua_UnityEngine_Ray2D.reg(l);
			Lua_UnityEngine_Plane.reg(l);
			Lua_UnityEngine_Mathf.reg(l);
			Lua_UnityEngine_DrivenTransformProperties.reg(l);
			Lua_UnityEngine_DrivenRectTransformTracker.reg(l);
			Lua_UnityEngine_Transform.reg(l);
			Lua_UnityEngine_RectTransform.reg(l);
			Lua_UnityEngine_RectTransform_Edge.reg(l);
			Lua_UnityEngine_RectTransform_Axis.reg(l);
			Lua_UnityEngine_Rendering_CommandBuffer.reg(l);
			Lua_UnityEngine_ResourceRequest.reg(l);
			Lua_UnityEngine_Resources.reg(l);
			Lua_UnityEngine_TextAsset.reg(l);
			Lua_UnityEngine_Security.reg(l);
			Lua_UnityEngine_Shader.reg(l);
			Lua_UnityEngine_Material.reg(l);
			Lua_UnityEngine_Rendering_SphericalHarmonicsL2.reg(l);
			Lua_UnityEngine_ProceduralProcessorUsage.reg(l);
			Lua_UnityEngine_ProceduralCacheSize.reg(l);
			Lua_UnityEngine_ProceduralLoadingBehavior.reg(l);
			Lua_UnityEngine_ProceduralPropertyType.reg(l);
			Lua_UnityEngine_ProceduralOutputType.reg(l);
			Lua_UnityEngine_ProceduralPropertyDescription.reg(l);
			Lua_UnityEngine_ProceduralMaterial.reg(l);
			Lua_UnityEngine_ProceduralTexture.reg(l);
			Lua_UnityEngine_SpriteAlignment.reg(l);
			Lua_UnityEngine_SpritePackingMode.reg(l);
			Lua_UnityEngine_SpritePackingRotation.reg(l);
			Lua_UnityEngine_SpriteMeshType.reg(l);
			Lua_UnityEngine_Sprite.reg(l);
			Lua_UnityEngine_SpriteRenderer.reg(l);
			Lua_UnityEngine_Sprites_DataUtility.reg(l);
			Lua_UnityEngine_Hash128.reg(l);
			Lua_UnityEngine_WWW.reg(l);
			Lua_UnityEngine_WWWForm.reg(l);
			Lua_UnityEngine_Caching.reg(l);
			Lua_UnityEngine_UnityEventQueueSystem.reg(l);
			Lua_UnityEngine_Application.reg(l);
			Lua_UnityEngine_UserAuthorization.reg(l);
			Lua_UnityEngine_ApplicationInstallMode.reg(l);
			Lua_UnityEngine_ApplicationSandboxType.reg(l);
			Lua_UnityEngine_Camera.reg(l);
			Lua_UnityEngine_ComputeShader.reg(l);
			Lua_UnityEngine_ComputeBuffer.reg(l);
			Lua_UnityEngine_Debug.reg(l);
			Lua_UnityEngine_Display.reg(l);
			Lua_UnityEngine_MonoBehaviour.reg(l);
			Lua_UnityEngine_TouchPhase.reg(l);
			Lua_UnityEngine_IMECompositionMode.reg(l);
			Lua_UnityEngine_Touch.reg(l);
			Lua_UnityEngine_DeviceOrientation.reg(l);
			Lua_UnityEngine_AccelerationEvent.reg(l);
			Lua_UnityEngine_Gyroscope.reg(l);
			Lua_UnityEngine_LocationInfo.reg(l);
			Lua_UnityEngine_LocationServiceStatus.reg(l);
			Lua_UnityEngine_LocationService.reg(l);
			Lua_UnityEngine_Compass.reg(l);
			Lua_UnityEngine_Input.reg(l);
			Lua_UnityEngine_HideFlags.reg(l);
			Lua_UnityEngine_Light.reg(l);
			Lua_UnityEngine_GameObject.reg(l);
			Lua_UnityEngine_Time.reg(l);
			Lua_UnityEngine_Random.reg(l);
			Lua_UnityEngine_PlayerPrefsException.reg(l);
			Lua_UnityEngine_PlayerPrefs.reg(l);
			Lua_UnityEngine_Motion.reg(l);
			Lua_UnityEngine_BillboardAsset.reg(l);
			Lua_UnityEngine_BillboardRenderer.reg(l);
			Lua_UnityEngine_WindZoneMode.reg(l);
			Lua_UnityEngine_WindZone.reg(l);
			Lua_UnityEngine_DynamicGI.reg(l);
			Lua_UnityEngine_ParticleSystemRenderMode.reg(l);
			Lua_UnityEngine_ParticleSystemSimulationSpace.reg(l);
			Lua_UnityEngine_ParticleSystem.reg(l);
			Lua_UnityEngine_ParticleSystem_Particle.reg(l);
			Lua_UnityEngine_ParticleSystemRenderer.reg(l);
			Lua_UnityEngine_ParticleCollisionEvent.reg(l);
			Lua_UnityEngine_ParticlePhysicsExtensions.reg(l);
			Lua_UnityEngine_Particle.reg(l);
			Lua_UnityEngine_ParticleEmitter.reg(l);
			Lua_UnityEngine_EllipsoidParticleEmitter.reg(l);
			Lua_UnityEngine_MeshParticleEmitter.reg(l);
			Lua_UnityEngine_ParticleAnimator.reg(l);
			Lua_UnityEngine_ParticleRenderMode.reg(l);
			Lua_UnityEngine_ParticleRenderer.reg(l);
			Lua_UnityEngine_ForceMode.reg(l);
			Lua_UnityEngine_Physics.reg(l);
			Lua_UnityEngine_RigidbodyConstraints.reg(l);
			Lua_UnityEngine_Rigidbody.reg(l);
			Lua_UnityEngine_RigidbodyInterpolation.reg(l);
			Lua_UnityEngine_JointMotor.reg(l);
			Lua_UnityEngine_JointSpring.reg(l);
			Lua_UnityEngine_JointLimits.reg(l);
			Lua_UnityEngine_Joint.reg(l);
			Lua_UnityEngine_HingeJoint.reg(l);
			Lua_UnityEngine_SpringJoint.reg(l);
			Lua_UnityEngine_FixedJoint.reg(l);
			Lua_UnityEngine_SoftJointLimit.reg(l);
			Lua_UnityEngine_SoftJointLimitSpring.reg(l);
			Lua_UnityEngine_JointDriveMode.reg(l);
			Lua_UnityEngine_JointProjectionMode.reg(l);
			Lua_UnityEngine_JointDrive.reg(l);
			Lua_UnityEngine_CharacterJoint.reg(l);
			Lua_UnityEngine_ConfigurableJointMotion.reg(l);
			Lua_UnityEngine_RotationDriveMode.reg(l);
			Lua_UnityEngine_ConfigurableJoint.reg(l);
			Lua_UnityEngine_ConstantForce.reg(l);
			Lua_UnityEngine_CollisionDetectionMode.reg(l);
			Lua_UnityEngine_Collider.reg(l);
			Lua_UnityEngine_BoxCollider.reg(l);
			Lua_UnityEngine_SphereCollider.reg(l);
			Lua_UnityEngine_MeshCollider.reg(l);
			Lua_UnityEngine_CapsuleCollider.reg(l);
			Lua_UnityEngine_WheelFrictionCurve.reg(l);
			Lua_UnityEngine_WheelHit.reg(l);
			Lua_UnityEngine_WheelCollider.reg(l);
			Lua_UnityEngine_RaycastHit.reg(l);
			Lua_UnityEngine_PhysicMaterialCombine.reg(l);
			Lua_UnityEngine_PhysicMaterial.reg(l);
			Lua_UnityEngine_ContactPoint.reg(l);
			Lua_UnityEngine_Collision.reg(l);
			Lua_UnityEngine_CollisionFlags.reg(l);
			Lua_UnityEngine_ControllerColliderHit.reg(l);
			Lua_UnityEngine_CharacterController.reg(l);
			Lua_UnityEngine_ClothSkinningCoefficient.reg(l);
			Lua_UnityEngine_ClothSphereColliderPair.reg(l);
			Lua_UnityEngine_Cloth.reg(l);
			Lua_UnityEngine_Physics2D.reg(l);
			Lua_UnityEngine_RaycastHit2D.reg(l);
			Lua_UnityEngine_RigidbodyInterpolation2D.reg(l);
			Lua_UnityEngine_RigidbodySleepMode2D.reg(l);
			Lua_UnityEngine_CollisionDetectionMode2D.reg(l);
			Lua_UnityEngine_ForceMode2D.reg(l);
			Lua_UnityEngine_RigidbodyConstraints2D.reg(l);
			Lua_UnityEngine_Rigidbody2D.reg(l);
			Lua_UnityEngine_Collider2D.reg(l);
			Lua_UnityEngine_CircleCollider2D.reg(l);
			Lua_UnityEngine_BoxCollider2D.reg(l);
			Lua_UnityEngine_EdgeCollider2D.reg(l);
			Lua_UnityEngine_PolygonCollider2D.reg(l);
			Lua_UnityEngine_ContactPoint2D.reg(l);
			Lua_UnityEngine_Collision2D.reg(l);
			Lua_UnityEngine_JointLimitState2D.reg(l);
			Lua_UnityEngine_JointAngleLimits2D.reg(l);
			Lua_UnityEngine_JointTranslationLimits2D.reg(l);
			Lua_UnityEngine_JointMotor2D.reg(l);
			Lua_UnityEngine_JointSuspension2D.reg(l);
			Lua_UnityEngine_Joint2D.reg(l);
			Lua_UnityEngine_AnchoredJoint2D.reg(l);
			Lua_UnityEngine_SpringJoint2D.reg(l);
			Lua_UnityEngine_DistanceJoint2D.reg(l);
			Lua_UnityEngine_HingeJoint2D.reg(l);
			Lua_UnityEngine_SliderJoint2D.reg(l);
			Lua_UnityEngine_WheelJoint2D.reg(l);
			Lua_UnityEngine_PhysicsMaterial2D.reg(l);
			Lua_UnityEngine_PhysicsUpdateBehaviour2D.reg(l);
			Lua_UnityEngine_ConstantForce2D.reg(l);
			Lua_UnityEngine_EffectorSelection2D.reg(l);
			Lua_UnityEngine_EffectorForceMode2D.reg(l);
			Lua_UnityEngine_Effector2D.reg(l);
			Lua_UnityEngine_AreaEffector2D.reg(l);
			Lua_UnityEngine_PointEffector2D.reg(l);
			Lua_UnityEngine_PlatformEffector2D.reg(l);
			Lua_UnityEngine_SurfaceEffector2D.reg(l);
			Lua_UnityEngine_ObstacleAvoidanceType.reg(l);
			Lua_UnityEngine_NavMeshAgent.reg(l);
			Lua_UnityEngine_NavMeshHit.reg(l);
			Lua_UnityEngine_NavMeshTriangulation.reg(l);
			Lua_UnityEngine_NavMesh.reg(l);
			Lua_UnityEngine_NavMeshObstacleShape.reg(l);
			Lua_UnityEngine_NavMeshObstacle.reg(l);
			Lua_UnityEngine_NavMeshPathStatus.reg(l);
			Lua_UnityEngine_NavMeshPath.reg(l);
			Lua_UnityEngine_OffMeshLinkType.reg(l);
			Lua_UnityEngine_OffMeshLinkData.reg(l);
			Lua_UnityEngine_OffMeshLink.reg(l);
			Lua_UnityEngine_AudioSpeakerMode.reg(l);
			Lua_UnityEngine_AudioDataLoadState.reg(l);
			Lua_UnityEngine_AudioConfiguration.reg(l);
			Lua_UnityEngine_AudioSettings.reg(l);
			Lua_UnityEngine_AudioType.reg(l);
			Lua_UnityEngine_AudioCompressionFormat.reg(l);
			Lua_UnityEngine_AudioClipLoadType.reg(l);
			Lua_UnityEngine_AudioClip.reg(l);
			Lua_UnityEngine_AudioVelocityUpdateMode.reg(l);
			Lua_UnityEngine_AudioListener.reg(l);
			Lua_UnityEngine_AudioRolloffMode.reg(l);
			Lua_UnityEngine_AudioSource.reg(l);
			Lua_UnityEngine_AudioReverbPreset.reg(l);
			Lua_UnityEngine_AudioReverbZone.reg(l);
			Lua_UnityEngine_AudioLowPassFilter.reg(l);
			Lua_UnityEngine_AudioHighPassFilter.reg(l);
			Lua_UnityEngine_AudioDistortionFilter.reg(l);
			Lua_UnityEngine_AudioEchoFilter.reg(l);
			Lua_UnityEngine_AudioChorusFilter.reg(l);
			Lua_UnityEngine_AudioReverbFilter.reg(l);
			Lua_UnityEngine_Microphone.reg(l);
			Lua_UnityEngine_Audio_AudioMixer.reg(l);
			Lua_UnityEngine_Audio_AudioMixerSnapshot.reg(l);
			Lua_UnityEngine_Audio_AudioMixerGroup.reg(l);
			Lua_UnityEngine_WebCamFlags.reg(l);
			Lua_UnityEngine_WebCamDevice.reg(l);
			Lua_UnityEngine_WebCamTexture.reg(l);
			Lua_UnityEngine_AnimationClipPair.reg(l);
			Lua_UnityEngine_RuntimeAnimatorController.reg(l);
			Lua_UnityEngine_AnimatorOverrideController.reg(l);
			Lua_UnityEngine_WrapMode.reg(l);
			Lua_UnityEngine_AnimationEvent.reg(l);
			Lua_UnityEngine_AnimationClip.reg(l);
			Lua_UnityEngine_Keyframe.reg(l);
			Lua_UnityEngine_AnimationCurve.reg(l);
			Lua_UnityEngine_PlayMode.reg(l);
			Lua_UnityEngine_QueueMode.reg(l);
			Lua_UnityEngine_AnimationBlendMode.reg(l);
			Lua_UnityEngine_AnimationPlayMode.reg(l);
			Lua_UnityEngine_AnimationCullingType.reg(l);
			Lua_UnityEngine_Animation.reg(l);
			Lua_UnityEngine_AnimationState.reg(l);
			Lua_UnityEngine_AvatarTarget.reg(l);
			Lua_UnityEngine_AvatarIKGoal.reg(l);
			Lua_UnityEngine_AvatarIKHint.reg(l);
			Lua_UnityEngine_AnimatorControllerParameterType.reg(l);
			Lua_UnityEngine_AnimatorRecorderMode.reg(l);
			Lua_UnityEngine_AnimatorClipInfo.reg(l);
			Lua_UnityEngine_AnimatorCullingMode.reg(l);
			Lua_UnityEngine_AnimatorUpdateMode.reg(l);
			Lua_UnityEngine_AnimatorStateInfo.reg(l);
			Lua_UnityEngine_AnimatorTransitionInfo.reg(l);
			Lua_UnityEngine_MatchTargetWeightMask.reg(l);
			Lua_UnityEngine_Animator.reg(l);
			Lua_UnityEngine_AnimatorControllerParameter.reg(l);
			Lua_UnityEngine_AnimatorUtility.reg(l);
			Lua_UnityEngine_SkeletonBone.reg(l);
			Lua_UnityEngine_HumanLimit.reg(l);
			Lua_UnityEngine_HumanBone.reg(l);
			Lua_UnityEngine_HumanDescription.reg(l);
			Lua_UnityEngine_AvatarBuilder.reg(l);
			Lua_UnityEngine_HumanBodyBones.reg(l);
			Lua_UnityEngine_Avatar.reg(l);
			Lua_UnityEngine_HumanTrait.reg(l);
			Lua_UnityEngine_TextAnchor.reg(l);
			Lua_UnityEngine_HorizontalWrapMode.reg(l);
			Lua_UnityEngine_VerticalWrapMode.reg(l);
			Lua_UnityEngine_TextMesh.reg(l);
			Lua_UnityEngine_CharacterInfo.reg(l);
			Lua_UnityEngine_Font.reg(l);
			Lua_UnityEngine_UICharInfo.reg(l);
			Lua_UnityEngine_UILineInfo.reg(l);
			Lua_UnityEngine_RenderMode.reg(l);
			Lua_UnityEngine_Canvas.reg(l);
			Lua_UnityEngine_CanvasGroup.reg(l);
			Lua_UnityEngine_UIVertex.reg(l);
			Lua_UnityEngine_CanvasRenderer.reg(l);
			Lua_UnityEngine_RectTransformUtility.reg(l);
			Lua_UnityEngine_VR_VRDeviceType.reg(l);
			Lua_UnityEngine_VR_VRNode.reg(l);
			Lua_UnityEngine_VR_VRSettings.reg(l);
			Lua_UnityEngine_VR_VRDevice.reg(l);
			Lua_UnityEngine_VR_InputTracking.reg(l);
			Lua_UnityEngine_Resolution.reg(l);
			Lua_UnityEngine_RenderBuffer.reg(l);
			Lua_UnityEngine_RenderingPath.reg(l);
			Lua_UnityEngine_TransparencySortMode.reg(l);
			Lua_UnityEngine_ComputeBufferType.reg(l);
			Lua_UnityEngine_LightType.reg(l);
			Lua_UnityEngine_LightRenderMode.reg(l);
			Lua_UnityEngine_LightShadows.reg(l);
			Lua_UnityEngine_FogMode.reg(l);
			Lua_UnityEngine_ShadowProjection.reg(l);
			Lua_UnityEngine_CameraClearFlags.reg(l);
			Lua_UnityEngine_DepthTextureMode.reg(l);
			Lua_UnityEngine_TexGenMode.reg(l);
			Lua_UnityEngine_AnisotropicFiltering.reg(l);
			Lua_UnityEngine_BlendWeights.reg(l);
			Lua_UnityEngine_MeshTopology.reg(l);
			Lua_UnityEngine_SkinQuality.reg(l);
			Lua_UnityEngine_ColorSpace.reg(l);
			Lua_UnityEngine_ScreenOrientation.reg(l);
			Lua_UnityEngine_FilterMode.reg(l);
			Lua_UnityEngine_TextureWrapMode.reg(l);
			Lua_UnityEngine_NPOTSupport.reg(l);
			Lua_UnityEngine_TextureFormat.reg(l);
			Lua_UnityEngine_CubemapFace.reg(l);
			Lua_UnityEngine_RenderTextureFormat.reg(l);
			Lua_UnityEngine_RenderTextureReadWrite.reg(l);
			Lua_UnityEngine_LightmapsMode.reg(l);
			Lua_UnityEngine_MaterialGlobalIlluminationFlags.reg(l);
			Lua_UnityEngine_Rendering_OpaqueSortMode.reg(l);
			Lua_UnityEngine_Rendering_RenderBufferLoadAction.reg(l);
			Lua_UnityEngine_Rendering_RenderBufferStoreAction.reg(l);
			Lua_UnityEngine_Rendering_BlendMode.reg(l);
			Lua_UnityEngine_Rendering_BlendOp.reg(l);
			Lua_UnityEngine_Rendering_CompareFunction.reg(l);
			Lua_UnityEngine_Rendering_CullMode.reg(l);
			Lua_UnityEngine_Rendering_ColorWriteMask.reg(l);
			Lua_UnityEngine_Rendering_StencilOp.reg(l);
			Lua_UnityEngine_Rendering_AmbientMode.reg(l);
			Lua_UnityEngine_Rendering_DefaultReflectionMode.reg(l);
			Lua_UnityEngine_Rendering_CameraEvent.reg(l);
			Lua_UnityEngine_Rendering_LightEvent.reg(l);
			Lua_UnityEngine_Rendering_BuiltinRenderTextureType.reg(l);
			Lua_UnityEngine_Rendering_PassType.reg(l);
			Lua_UnityEngine_Rendering_ShadowCastingMode.reg(l);
			Lua_UnityEngine_Rendering_GraphicsDeviceType.reg(l);
			Lua_UnityEngine_Rendering_RenderTargetIdentifier.reg(l);
			Lua_UnityEngine_Rendering_ReflectionProbeUsage.reg(l);
			Lua_UnityEngine_Rendering_ReflectionProbeType.reg(l);
			Lua_UnityEngine_Rendering_ReflectionProbeClearFlags.reg(l);
			Lua_UnityEngine_Rendering_ReflectionProbeMode.reg(l);
			Lua_UnityEngine_Rendering_ReflectionProbeBlendInfo.reg(l);
			Lua_UnityEngine_Rendering_ReflectionProbeRefreshMode.reg(l);
			Lua_UnityEngine_Rendering_ReflectionProbeTimeSlicingMode.reg(l);
			Lua_JetBrains_Annotations_ImplicitUseKindFlags.reg(l);
			Lua_JetBrains_Annotations_ImplicitUseTargetFlags.reg(l);
			Lua_UnityEngine_StackTraceUtility.reg(l);
			Lua_UnityEngine_UnityException.reg(l);
			Lua_UnityEngine_MissingComponentException.reg(l);
			Lua_UnityEngine_UnassignedReferenceException.reg(l);
			Lua_UnityEngine_MissingReferenceException.reg(l);
			Lua_UnityEngine_StateMachineBehaviour.reg(l);
			Lua_UnityEngine_TextGenerationSettings.reg(l);
			Lua_UnityEngine_Events_PersistentListenerMode.reg(l);
			Lua_UnityEngine_Events_UnityEventCallState.reg(l);
			Lua_UnityEngine_Events_UnityEventBase.reg(l);
			Lua_UnityEngine_Events_UnityEvent.reg(l);
			Lua_UnityEngine_Assertions_Assert.reg(l);
			Lua_UnityEngine_Assertions_AssertionException.reg(l);
			Lua_UnityEngine_Assertions_Comparers_FloatComparer.reg(l);
			Lua_UnityEngine_Assertions_Must_MustExtensions.reg(l);
		}
	}
}
