

namespace Adapter.Interface;

public interface IJsonParser<T> // The interface that the client expects
{
    T Parse(string data);
    string ConvertToJson(T obj);
}