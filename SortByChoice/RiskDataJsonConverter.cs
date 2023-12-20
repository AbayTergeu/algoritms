using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Tolar.BiService.Domain.Abstractions.Common.Risks.Contracts;
using Tolar.BiService.Enumeration;
using JsonConverter = Newtonsoft.Json.JsonConverter;
using JsonSerializer = Newtonsoft.Json.JsonSerializer;

namespace SortByChoice;

/// <summary>
/// Json converter for RiskData.
/// </summary>
/// <typeparam name="T"></typeparam>
public class RiskDataJsonConverter<T> : JsonConverter
{
    /// <inheritdoc />
    public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
    {
        if (value is not RiskData riskData) 
            return;
        writer.WriteStartObject();
        writer.WritePropertyName(nameof(riskData.Level));
        writer.WriteValue(riskData.Level);
        writer.WriteEndObject();
    }

    /// <inheritdoc />
    public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
    {
        JObject jo = JObject.Load(reader);
        var riskLevelValue = jo.ToString();
        RiskLevel riskLevel;
        Enum.TryParse(riskLevelValue, out riskLevel);
        return new RiskData(riskLevel);
    }

    public override bool CanConvert(Type objectType)
    {
        return typeof(T).IsAssignableFrom(objectType);
    }
}