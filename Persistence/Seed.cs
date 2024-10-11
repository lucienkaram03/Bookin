using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context)
        {
            if (context.Books.Any()) return;
            
            var books = new List<Book>
{
    new Book
    {
        Title = "The Art of Mixology",
        Author = "John Smith",
        Description = "A detailed guide on crafting the perfect cocktails, published 2 months ago.",
        Genre = "Non-Fiction", // Logical genre for a book on cocktail making
    },
    new Book
    {
        Title = "Cultural Revolution: A History",
        Author = "Maria Lopez",
        Description = "An exploration of cultural movements from the last century, published 1 month ago.",
        Genre = "History", // A historical exploration of cultural movements
    },
    new Book
    {
        Title = "The Future of Technology",
        Author = "Alex Johnson",
        Description = "An insightful look into upcoming technological advancements, set to be released 1 month from now.",
        Genre = "Science & Technology", // Logical genre for future tech insights
    },
    new Book
    {
        Title = "The Symphony of Life",
        Author = "Victor Muller",
        Description = "A musical journey exploring how music shapes our emotions, set to be released 2 months from now.",
        Genre = "Music", // A book exploring music fits into this genre
    },
    new Book
    {
        Title = "Crafting the Perfect Brew",
        Author = "Emily Brown",
        Description = "A comprehensive guide to making the finest alcoholic beverages, set to be released 3 months from now.",
        Genre = "Food & Drink", // A genre for beverage crafting
    },
    new Book
    {
        Title = "Cocktails Around the World",
        Author = "David Wilson",
        Genre = "Travel", // Logical genre for a book that explores international cocktails
        Description = "An international guide to the best cocktail recipes, set to be released 4 months from now.",
    },
    new Book
    {
        Title = "Mastering Mixology",
        Author = "Sarah Taylor",
        Genre = "Non-Fiction", // Fits with a guide on mixology
        Description = "A deep dive into the art and science of mixology, set to be released 5 months from now.",
    },
    new Book
    {
        Title = "The Sounds of the Soul",
        Author = "Lisa Green",
        Genre = "Philosophy", // Music’s emotional impact is philosophical in nature
        Description = "An exploration of music’s impact on human consciousness, set to be released 6 months from now.",
    },
    new Book
    {
        Title = "Wonders of the World",
        Author = "Christopher White",
        Genre = "Travel", // Fits with the guide on global locations
        Description = "A travel guide to the most breathtaking locations around the globe, published 2 months ago.",
    },
    new Book
    {
        Title = "Cinema Through the Ages",
        Author = "Anna Collins",
        Genre = "Film & Cinema", // A study on cinema fits in this genre
        Description = "An in-depth study of the evolution of cinema, set to be released 8 months from now.",
    }
};
            await context.Books.AddRangeAsync(books); //it adds the seeded data to memory
            await context.SaveChangesAsync();
        }
    }
}