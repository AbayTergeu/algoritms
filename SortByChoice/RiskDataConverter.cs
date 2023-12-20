using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Tolar.BiService.Domain.Abstractions.Common.Risks.Contracts;
using Tolar.BiService.Enumeration;

namespace SortByChoice;

public class RiskDataConverter : JsonConverter<RiskData>
{
    // omitted for brevity
    public override void WriteJson(JsonWriter writer, RiskData? contact, JsonSerializer serializer)
    {
        if (contact is null) return;
        JObject jo = new();
        jo[nameof(contact.Level)] = JToken.FromObject(contact.Level, serializer);
        jo.WriteTo(writer);
    }

    public override RiskData? ReadJson(JsonReader reader, Type objectType, RiskData? existingValue,
        bool hasExistingValue, JsonSerializer serializer)
    {
        JsonTextReader readerTxt = (JsonTextReader)reader;
        var data = readerTxt.Value;
        JObject jo = JObject.Load(reader);
        return jo.ToObject<RiskData>();
    }
}