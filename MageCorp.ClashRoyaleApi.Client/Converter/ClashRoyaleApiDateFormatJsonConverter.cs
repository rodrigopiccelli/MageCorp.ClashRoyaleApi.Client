using Newtonsoft.Json;
using System.Globalization;

namespace MageCorp.ClashRoyaleApi.Client.Converter;

internal class ClashRoyaleApiDateFormatJsonConverter : JsonConverter
{
    public override bool CanConvert(Type objectType)
    {
        return true;
    }

    public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
    {
        if (reader?.Value is string dateString)
        {
            var dateTime = DateTime.ParseExact(dateString, "yyyyMMddTHHmmss.fffZ", CultureInfo.InvariantCulture);
            return dateTime;
        }
        return null;
    }

    public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
    {
    }
}
