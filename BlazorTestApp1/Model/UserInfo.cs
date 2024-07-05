#pragma warning disable IDE0130 // Namespace does not match folder structure
namespace BlazingPizza
#pragma warning restore IDE0130 // Namespace does not match folder structure
{
    public class UserInfo
    {
        public bool IsAuthenticated { get; set; }

        public required string Name { get; set; }
    }
}
