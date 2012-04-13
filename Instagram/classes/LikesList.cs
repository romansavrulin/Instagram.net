﻿/**
 * Instagram.net
 * https://github.com/powerinbox/Instagram.net
 *
 * based on .NET-Instagram-API-Wrapper
 * Copyright (c) 2011 Diego Trin­cia­relli
 *
 * Additions are:
 * Copyright (c) 2012 IO Revolution Inc.
 */

using System;
using Newtonsoft.Json;

namespace Instagram.Api.Classes{
	[Serializable]
	public class LikesList : InstagramBaseObject
	{
		[JsonProperty(PropertyName = "count")]
		public int Count { get; set; }

		[JsonProperty(PropertyName = "data")]
		public User[] Data { get; set; }
	}
}