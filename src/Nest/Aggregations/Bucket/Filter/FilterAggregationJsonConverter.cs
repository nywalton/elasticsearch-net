﻿using Elasticsearch.Net.Utf8Json;

namespace Nest
{
	internal class FilterAggregationFormatter : IJsonFormatter<IFilterAggregation>
	{
		public void Serialize(ref JsonWriter writer, IFilterAggregation value, IJsonFormatterResolver formatterResolver)
		{
			if (value?.Filter == null || !value.Filter.IsWritable)
			{
				writer.WriteBeginObject();
				writer.WriteEndObject();
				return;
			}

			var formatter = formatterResolver.GetFormatter<QueryContainer>();
			formatter.Serialize(ref writer, value.Filter, formatterResolver);
		}

		public IFilterAggregation Deserialize(ref JsonReader reader, IJsonFormatterResolver formatterResolver)
		{
			if (reader.GetCurrentJsonToken() != JsonToken.BeginObject)
				return null;

			var formatter = formatterResolver.GetFormatter<QueryContainer>();
			var container = formatter.Deserialize(ref reader, formatterResolver);
			var agg = new FilterAggregation
			{
				Filter = container
			};

			return agg;
		}
	}
}
