namespace api.tork.challenge.domain.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int TotalCopies { get; set; }
        public int CopiesInUse { get; set; }
        public string Type { get; set; }
        public string Isbn { get; set; }
        public string Category { get; set; }

        public Book()
        {
            Validate();
        }

        private void Validate()
        {
            if (Id <= 0)
            { 
                throw new ArgumentNullException("Id is required");
            }

            if (string.IsNullOrEmpty(Title)) 
            { 
                throw new ArgumentNullException("Title is required");
            }

            if (string.IsNullOrEmpty(FirstName))
            {
                throw new ArgumentNullException("FirstName is required");
            }

            if (string.IsNullOrEmpty(LastName))
            {
                throw new ArgumentNullException("LastName is required");
            }

            if (TotalCopies < 0)
            {
                throw new ArgumentNullException("TotalCopies is invalid");
            }

            if (CopiesInUse < 0 || CopiesInUse > TotalCopies)
            {
                throw new ArgumentNullException("CopiesInUse is invalid");
            }

            if (string.IsNullOrEmpty(Type))
            {
                throw new ArgumentNullException("Type is required");
            }

            if (string.IsNullOrEmpty(Isbn))
            {
                throw new ArgumentNullException("Isbn is required");
            }

            if (string.IsNullOrEmpty(Category))
            {
                throw new ArgumentNullException("Category is required");
            }
        }
    }
}
