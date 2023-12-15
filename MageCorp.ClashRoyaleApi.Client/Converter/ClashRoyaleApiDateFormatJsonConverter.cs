using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace MageCorp.ClashRoyaleApi.Client.Converter;

internal class ClashRoyaleApiDateFormatJsonConverter : JsonConverter<DateTime>
{

    public override bool CanConvert(Type objectType)
    {
        return true;
    }

    public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) =>
        DateTime.ParseExact(reader.GetString()!, "yyyyMMddTHHmmss.fffZ", CultureInfo.InvariantCulture);


    public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options) =>
        writer.WriteStringValue(value.ToString("yyyyMMddTHHmmss.fffZ", CultureInfo.InvariantCulture));

}
