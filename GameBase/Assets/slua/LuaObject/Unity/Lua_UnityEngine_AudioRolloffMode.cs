﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_AudioRolloffMode : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.AudioRolloffMode");
		addMember(l,0,"Logarithmic");
		addMember(l,1,"Linear");
		addMember(l,2,"Custom");
		LuaDLL.lua_pop(l, 1);
	}
}
