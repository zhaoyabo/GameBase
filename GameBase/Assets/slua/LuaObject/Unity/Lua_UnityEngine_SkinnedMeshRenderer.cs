﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_SkinnedMeshRenderer : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.SkinnedMeshRenderer o;
			o=new UnityEngine.SkinnedMeshRenderer();
			pushValue(l,o);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int BakeMesh(IntPtr l) {
		try {
			UnityEngine.SkinnedMeshRenderer self=(UnityEngine.SkinnedMeshRenderer)checkSelf(l);
			UnityEngine.Mesh a1;
			checkType(l,2,out a1);
			self.BakeMesh(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetBlendShapeWeight(IntPtr l) {
		try {
			UnityEngine.SkinnedMeshRenderer self=(UnityEngine.SkinnedMeshRenderer)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetBlendShapeWeight(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetBlendShapeWeight(IntPtr l) {
		try {
			UnityEngine.SkinnedMeshRenderer self=(UnityEngine.SkinnedMeshRenderer)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			self.SetBlendShapeWeight(a1,a2);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_bones(IntPtr l) {
		try {
			UnityEngine.SkinnedMeshRenderer self=(UnityEngine.SkinnedMeshRenderer)checkSelf(l);
			pushValue(l,self.bones);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_bones(IntPtr l) {
		try {
			UnityEngine.SkinnedMeshRenderer self=(UnityEngine.SkinnedMeshRenderer)checkSelf(l);
			UnityEngine.Transform[] v;
			checkType(l,2,out v);
			self.bones=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rootBone(IntPtr l) {
		try {
			UnityEngine.SkinnedMeshRenderer self=(UnityEngine.SkinnedMeshRenderer)checkSelf(l);
			pushValue(l,self.rootBone);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_rootBone(IntPtr l) {
		try {
			UnityEngine.SkinnedMeshRenderer self=(UnityEngine.SkinnedMeshRenderer)checkSelf(l);
			UnityEngine.Transform v;
			checkType(l,2,out v);
			self.rootBone=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_quality(IntPtr l) {
		try {
			UnityEngine.SkinnedMeshRenderer self=(UnityEngine.SkinnedMeshRenderer)checkSelf(l);
			pushEnum(l,(int)self.quality);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_quality(IntPtr l) {
		try {
			UnityEngine.SkinnedMeshRenderer self=(UnityEngine.SkinnedMeshRenderer)checkSelf(l);
			UnityEngine.SkinQuality v;
			checkEnum(l,2,out v);
			self.quality=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_sharedMesh(IntPtr l) {
		try {
			UnityEngine.SkinnedMeshRenderer self=(UnityEngine.SkinnedMeshRenderer)checkSelf(l);
			pushValue(l,self.sharedMesh);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_sharedMesh(IntPtr l) {
		try {
			UnityEngine.SkinnedMeshRenderer self=(UnityEngine.SkinnedMeshRenderer)checkSelf(l);
			UnityEngine.Mesh v;
			checkType(l,2,out v);
			self.sharedMesh=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_updateWhenOffscreen(IntPtr l) {
		try {
			UnityEngine.SkinnedMeshRenderer self=(UnityEngine.SkinnedMeshRenderer)checkSelf(l);
			pushValue(l,self.updateWhenOffscreen);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_updateWhenOffscreen(IntPtr l) {
		try {
			UnityEngine.SkinnedMeshRenderer self=(UnityEngine.SkinnedMeshRenderer)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.updateWhenOffscreen=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_localBounds(IntPtr l) {
		try {
			UnityEngine.SkinnedMeshRenderer self=(UnityEngine.SkinnedMeshRenderer)checkSelf(l);
			pushValue(l,self.localBounds);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_localBounds(IntPtr l) {
		try {
			UnityEngine.SkinnedMeshRenderer self=(UnityEngine.SkinnedMeshRenderer)checkSelf(l);
			UnityEngine.Bounds v;
			checkType(l,2,out v);
			self.localBounds=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.SkinnedMeshRenderer");
		addMember(l,BakeMesh);
		addMember(l,GetBlendShapeWeight);
		addMember(l,SetBlendShapeWeight);
		addMember(l,"bones",get_bones,set_bones,true);
		addMember(l,"rootBone",get_rootBone,set_rootBone,true);
		addMember(l,"quality",get_quality,set_quality,true);
		addMember(l,"sharedMesh",get_sharedMesh,set_sharedMesh,true);
		addMember(l,"updateWhenOffscreen",get_updateWhenOffscreen,set_updateWhenOffscreen,true);
		addMember(l,"localBounds",get_localBounds,set_localBounds,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.SkinnedMeshRenderer),typeof(UnityEngine.Renderer));
	}
}
