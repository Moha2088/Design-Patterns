namespace Adapter.Interface;

public interface IXmlParser<T> // The incompatible interface
{
    T Parse(string data);
    string ConvertToXml(T obj);
}