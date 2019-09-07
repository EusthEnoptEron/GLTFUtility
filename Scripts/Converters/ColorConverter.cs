﻿using System;
using Newtonsoft.Json;
using UnityEngine;

namespace Siccity.GLTFUtility.Converters {
	public class ColorRGBConverter : JsonConverter {
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) {
			Color c = (Color) value;
			writer.WriteStartArray();
			writer.WriteValue(c.r);
			writer.WriteValue(c.g);
			writer.WriteValue(c.b);
			writer.WriteEndArray();
		}

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) {
			float[] a = serializer.Deserialize<float[]>(reader);
			return new Color(a[0], a[1], a[2]);
		}

		public override bool CanConvert(Type objectType) {
			return objectType == typeof(Color);
		}
	}

	public class ColorRGBAConverter : JsonConverter {
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) {
			Color c = (Color) value;
			writer.WriteStartArray();
			writer.WriteValue(c.r);
			writer.WriteValue(c.g);
			writer.WriteValue(c.b);
			writer.WriteValue(c.a);
			writer.WriteEndArray();
		}

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) {
			float[] a = serializer.Deserialize<float[]>(reader);
			return new Color(a[0], a[1], a[2], a[3]);
		}

		public override bool CanConvert(Type objectType) {
			return objectType == typeof(Color);
		}
	}
}