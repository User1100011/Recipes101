namespace Recipes
{
    public class User
    {
        private static int currnetId = 0;

        public int Id { get; init; }
        public string Name { get; init; }
        public string Email { get; init; }
        public string Password { get; init; }
        public User()
        {
            currnetId++;
            Id = currnetId;
        }
    }
}
