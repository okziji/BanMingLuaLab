﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class TestStartWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(TestStart), typeof(UnityEngine.MonoBehaviour));
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("networkManager", get_networkManager, set_networkManager);
		L.RegVar("ip", get_ip, set_ip);
		L.RegVar("port", get_port, set_port);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int op_Equality(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Object arg0 = (UnityEngine.Object)ToLua.ToObject(L, 1);
			UnityEngine.Object arg1 = (UnityEngine.Object)ToLua.ToObject(L, 2);
			bool o = arg0 == arg1;
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_networkManager(IntPtr L)
	{
		try
		{
			ToLua.PushObject(L, TestStart.networkManager);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_ip(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, TestStart.ip);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_port(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, TestStart.port);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_networkManager(IntPtr L)
	{
		try
		{
			NetFramework.NetworkManager arg0 = (NetFramework.NetworkManager)ToLua.CheckObject<NetFramework.NetworkManager>(L, 2);
			TestStart.networkManager = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_ip(IntPtr L)
	{
		try
		{
			string arg0 = ToLua.CheckString(L, 2);
			TestStart.ip = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_port(IntPtr L)
	{
		try
		{
			string arg0 = ToLua.CheckString(L, 2);
			TestStart.port = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

