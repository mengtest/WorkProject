﻿using LitJson;
using System;

namespace LockStep.Util
{
    public class JsonUtil
    {
        public static string ToJson(object obj)
        {
            return JsonMapper.ToJson(obj);
        }

        public static T ToObject<T>(string txt)
        {
            return JsonMapper.ToObject<T>(txt);
        }
    }

    public static class JsonExtension
    {
        public static string ToJson(this object obj)
        {
            return obj == null ? "null" : JsonMapper.ToJson(obj);
        }
    }
}
