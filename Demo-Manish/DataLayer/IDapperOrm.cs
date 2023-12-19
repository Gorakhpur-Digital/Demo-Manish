namespace Demo_Manish.DataLayer
{
    public interface IDapperOrm
    {
        IEnumerable<T> Returnlist<T, U>(string procedurName, U param);
    }
}
