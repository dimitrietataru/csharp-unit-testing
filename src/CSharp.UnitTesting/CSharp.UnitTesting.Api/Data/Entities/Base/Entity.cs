namespace CSharp.UnitTesting.Api.Data.Entities.Base
{
    public abstract class Entity<TId>
        where TId : struct
    {
        public TId Id { get; set; }
        public bool IsDeleted { get; set; }
    }
}
