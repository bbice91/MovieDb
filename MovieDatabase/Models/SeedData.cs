using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MovieDatabase.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace SeedData.Models
{
    public class SeedData : System.Data.Entity.DropCreateDatabaseIfModelChanges<MovieDatabaseContext>
    {
        protected override void Seed(MovieDatabaseContext context)
        {
            var Movies = new List<Movies>
            {
                new Movies{Title="The Godfather",Genre="Drama",Runtime=175},
                new Movies{Title="The Shawshank Redemption",Genre="Drama",Runtime=129},
                new Movies{Title="Raging Bull",Genre="Biography",Runtime=102},
                new Movies{Title="Casablance",Genre="Drama",Runtime=119},
                new Movies{Title="Citizen Kane",Genre="Drama",Runtime=238},
                new Movies{Title="Gone with the Wind",Genre="Romance",Runtime=102},
                new Movies{Title="The Wizard of Oz",Genre="Adventure",Runtime=218},
                new Movies{Title="Lawrence of Arabia",Genre="Biography",Runtime=175},
                new Movies{Title="12 Angry Men",Genre="Crime",Runtime=96},
                new Movies{Title="Forrest Gump",Genre="Romance",Runtime=142},
                new Movies{Title="Sunset Blvd.",Genre="Film-Noir",Runtime=110},
                new Movies{Title="On the Waterfront",Genre="Thriller",Runtime=108},
                new Movies{Title="The Godfather: Part II",Genre="Crime",Runtime=202},
                new Movies{Title="Psycho",Genre="Horror",Runtime=109},
                new Movies{Title="Vertigo",Genre="Mystery",Runtime=128},
            };
        }
 
    }
}