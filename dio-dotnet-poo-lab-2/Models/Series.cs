using System;
using dio_dotnet_poo_lab_2.Enums;

namespace dio_dotnet_poo_lab_2.Models
{
    public class Series : BaseModel
    {
        private Genre Genre { get; set; }
        private string Title { get; set; }
        private string Description { get; set; }
        private int Year { get; set; }

        private bool Deleted { get; set; }

        public Series(long id, Genre genre, string title, string description, int year)
        {
            Id = id;
            Genre = genre;
            Title = title;
            Description = description;
            Year = year;
            Deleted = false;
        }

        public override string ToString()
        {
            var result = string.Empty;
            result += $"Genre: {Genre}{Environment.NewLine}";
            result += $"Title: {Title}{Environment.NewLine}";
            result += $"Description: {Description}{Environment.NewLine}";
            result += $"Year: {Year}{Environment.NewLine}";
            return result;
        }

        public string ReturnTitle()
        {
            return Title;
        }

        public long ReturnId()
        {
            return Id;
        }

        public bool IsDeleted()
        {
            return Deleted;
        }

        public void Delete()
        {
            Deleted = true;
        }
    }
}