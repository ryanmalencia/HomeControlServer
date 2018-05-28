namespace HomeControlServer.Interfaces
{
    public interface ICollection
    {
        /// <summary>
        /// Add model to collection
        /// </summary>
        /// <param name="model">IModel to add</param>
        /// <returns>Bool with success/failure</returns>
        bool Add(IModel model);
    }
}
