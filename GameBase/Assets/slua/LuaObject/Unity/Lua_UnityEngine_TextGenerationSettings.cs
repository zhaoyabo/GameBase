﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_TextGenerationSettings : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.TextGenerationSettings o;
			o=new UnityEngine.TextGenerationSettings();
			pushValue(l,o);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_font(IntPtr l) {
		try {
			UnityEngine.TextGenerationSettings self;
			checkType(l,1,out self);
			pushValue(l,self.font);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_font(IntPtr l) {
		try {
			UnityEngine.TextGenerationSettings self;
			checkType(l,1,out self);
			UnityEngine.Font v;
			checkType(l,2,out v);
			self.font=v;
			setBack(l,self);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_color(IntPtr l) {
		try {
			UnityEngine.TextGenerationSettings self;
			checkType(l,1,out self);
			pushValue(l,self.color);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_color(IntPtr l) {
		try {
			UnityEngine.TextGenerationSettings self;
			checkType(l,1,out self);
			UnityEngine.Color v;
			checkType(l,2,out v);
			self.color=v;
			setBack(l,self);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_fontSize(IntPtr l) {
		try {
			UnityEngine.TextGenerationSettings self;
			checkType(l,1,out self);
			pushValue(l,self.fontSize);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_fontSize(IntPtr l) {
		try {
			UnityEngine.TextGenerationSettings self;
			checkType(l,1,out self);
			System.Int32 v;
			checkType(l,2,out v);
			self.fontSize=v;
			setBack(l,self);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_lineSpacing(IntPtr l) {
		try {
			UnityEngine.TextGenerationSettings self;
			checkType(l,1,out self);
			pushValue(l,self.lineSpacing);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_lineSpacing(IntPtr l) {
		try {
			UnityEngine.TextGenerationSettings self;
			checkType(l,1,out self);
			System.Single v;
			checkType(l,2,out v);
			self.lineSpacing=v;
			setBack(l,self);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_richText(IntPtr l) {
		try {
			UnityEngine.TextGenerationSettings self;
			checkType(l,1,out self);
			pushValue(l,self.richText);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_richText(IntPtr l) {
		try {
			UnityEngine.TextGenerationSettings self;
			checkType(l,1,out self);
			System.Boolean v;
			checkType(l,2,out v);
			self.richText=v;
			setBack(l,self);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_scaleFactor(IntPtr l) {
		try {
			UnityEngine.TextGenerationSettings self;
			checkType(l,1,out self);
			pushValue(l,self.scaleFactor);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_scaleFactor(IntPtr l) {
		try {
			UnityEngine.TextGenerationSettings self;
			checkType(l,1,out self);
			System.Single v;
			checkType(l,2,out v);
			self.scaleFactor=v;
			setBack(l,self);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_fontStyle(IntPtr l) {
		try {
			UnityEngine.TextGenerationSettings self;
			checkType(l,1,out self);
			pushEnum(l,(int)self.fontStyle);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_fontStyle(IntPtr l) {
		try {
			UnityEngine.TextGenerationSettings self;
			checkType(l,1,out self);
			UnityEngine.FontStyle v;
			checkEnum(l,2,out v);
			self.fontStyle=v;
			setBack(l,self);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_textAnchor(IntPtr l) {
		try {
			UnityEngine.TextGenerationSettings self;
			checkType(l,1,out self);
			pushEnum(l,(int)self.textAnchor);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_textAnchor(IntPtr l) {
		try {
			UnityEngine.TextGenerationSettings self;
			checkType(l,1,out self);
			UnityEngine.TextAnchor v;
			checkEnum(l,2,out v);
			self.textAnchor=v;
			setBack(l,self);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_resizeTextForBestFit(IntPtr l) {
		try {
			UnityEngine.TextGenerationSettings self;
			checkType(l,1,out self);
			pushValue(l,self.resizeTextForBestFit);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_resizeTextForBestFit(IntPtr l) {
		try {
			UnityEngine.TextGenerationSettings self;
			checkType(l,1,out self);
			System.Boolean v;
			checkType(l,2,out v);
			self.resizeTextForBestFit=v;
			setBack(l,self);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_resizeTextMinSize(IntPtr l) {
		try {
			UnityEngine.TextGenerationSettings self;
			checkType(l,1,out self);
			pushValue(l,self.resizeTextMinSize);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_resizeTextMinSize(IntPtr l) {
		try {
			UnityEngine.TextGenerationSettings self;
			checkType(l,1,out self);
			System.Int32 v;
			checkType(l,2,out v);
			self.resizeTextMinSize=v;
			setBack(l,self);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_resizeTextMaxSize(IntPtr l) {
		try {
			UnityEngine.TextGenerationSettings self;
			checkType(l,1,out self);
			pushValue(l,self.resizeTextMaxSize);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_resizeTextMaxSize(IntPtr l) {
		try {
			UnityEngine.TextGenerationSettings self;
			checkType(l,1,out self);
			System.Int32 v;
			checkType(l,2,out v);
			self.resizeTextMaxSize=v;
			setBack(l,self);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_updateBounds(IntPtr l) {
		try {
			UnityEngine.TextGenerationSettings self;
			checkType(l,1,out self);
			pushValue(l,self.updateBounds);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_updateBounds(IntPtr l) {
		try {
			UnityEngine.TextGenerationSettings self;
			checkType(l,1,out self);
			System.Boolean v;
			checkType(l,2,out v);
			self.updateBounds=v;
			setBack(l,self);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_verticalOverflow(IntPtr l) {
		try {
			UnityEngine.TextGenerationSettings self;
			checkType(l,1,out self);
			pushEnum(l,(int)self.verticalOverflow);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_verticalOverflow(IntPtr l) {
		try {
			UnityEngine.TextGenerationSettings self;
			checkType(l,1,out self);
			UnityEngine.VerticalWrapMode v;
			checkEnum(l,2,out v);
			self.verticalOverflow=v;
			setBack(l,self);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_horizontalOverflow(IntPtr l) {
		try {
			UnityEngine.TextGenerationSettings self;
			checkType(l,1,out self);
			pushEnum(l,(int)self.horizontalOverflow);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_horizontalOverflow(IntPtr l) {
		try {
			UnityEngine.TextGenerationSettings self;
			checkType(l,1,out self);
			UnityEngine.HorizontalWrapMode v;
			checkEnum(l,2,out v);
			self.horizontalOverflow=v;
			setBack(l,self);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_generationExtents(IntPtr l) {
		try {
			UnityEngine.TextGenerationSettings self;
			checkType(l,1,out self);
			pushValue(l,self.generationExtents);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_generationExtents(IntPtr l) {
		try {
			UnityEngine.TextGenerationSettings self;
			checkType(l,1,out self);
			UnityEngine.Vector2 v;
			checkType(l,2,out v);
			self.generationExtents=v;
			setBack(l,self);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pivot(IntPtr l) {
		try {
			UnityEngine.TextGenerationSettings self;
			checkType(l,1,out self);
			pushValue(l,self.pivot);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_pivot(IntPtr l) {
		try {
			UnityEngine.TextGenerationSettings self;
			checkType(l,1,out self);
			UnityEngine.Vector2 v;
			checkType(l,2,out v);
			self.pivot=v;
			setBack(l,self);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_generateOutOfBounds(IntPtr l) {
		try {
			UnityEngine.TextGenerationSettings self;
			checkType(l,1,out self);
			pushValue(l,self.generateOutOfBounds);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_generateOutOfBounds(IntPtr l) {
		try {
			UnityEngine.TextGenerationSettings self;
			checkType(l,1,out self);
			System.Boolean v;
			checkType(l,2,out v);
			self.generateOutOfBounds=v;
			setBack(l,self);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.TextGenerationSettings");
		addMember(l,"font",get_font,set_font,true);
		addMember(l,"color",get_color,set_color,true);
		addMember(l,"fontSize",get_fontSize,set_fontSize,true);
		addMember(l,"lineSpacing",get_lineSpacing,set_lineSpacing,true);
		addMember(l,"richText",get_richText,set_richText,true);
		addMember(l,"scaleFactor",get_scaleFactor,set_scaleFactor,true);
		addMember(l,"fontStyle",get_fontStyle,set_fontStyle,true);
		addMember(l,"textAnchor",get_textAnchor,set_textAnchor,true);
		addMember(l,"resizeTextForBestFit",get_resizeTextForBestFit,set_resizeTextForBestFit,true);
		addMember(l,"resizeTextMinSize",get_resizeTextMinSize,set_resizeTextMinSize,true);
		addMember(l,"resizeTextMaxSize",get_resizeTextMaxSize,set_resizeTextMaxSize,true);
		addMember(l,"updateBounds",get_updateBounds,set_updateBounds,true);
		addMember(l,"verticalOverflow",get_verticalOverflow,set_verticalOverflow,true);
		addMember(l,"horizontalOverflow",get_horizontalOverflow,set_horizontalOverflow,true);
		addMember(l,"generationExtents",get_generationExtents,set_generationExtents,true);
		addMember(l,"pivot",get_pivot,set_pivot,true);
		addMember(l,"generateOutOfBounds",get_generateOutOfBounds,set_generateOutOfBounds,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.TextGenerationSettings),typeof(System.ValueType));
	}
}
