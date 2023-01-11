using MvcEcommerce.Data.Static;
using MvcEcommerce.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcEcommerce.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                //Cinema
                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Name = "Gopikrishna",
                            Logo = "https://english.nepalpress.com/wp-content/uploads/2021/09/film-theatre-hall.jpg",
                            Description = "This is the description of the cinema"
                        },
                        new Cinema()
                        {
                            Name = "Kathmandu Mall",
                            Logo = "https://english.nepalpress.com/wp-content/uploads/2021/09/film-theatre-hall.jpg",
                            Description = "This is the description of the cinema"
                        },
                        new Cinema()
                        {
                            Name = "Eyeplex",
                            Logo = "https://english.nepalpress.com/wp-content/uploads/2021/09/film-theatre-hall.jpg",
                            Description = "This is the description of the cinema"
                        },
                        new Cinema()
                        {
                            Name = "Civil Mall",
                            Logo = "https://english.nepalpress.com/wp-content/uploads/2021/09/film-theatre-hall.jpg",
                            Description = "This is the description of the cinema"
                        },
                        new Cinema()
                        {
                            Name = "KL Tower",
                            Logo = "https://english.nepalpress.com/wp-content/uploads/2021/09/film-theatre-hall.jpg",
                            Description = "This is the description of the cinema"
                        },
                    });
                    context.SaveChanges();
                }
                //Actors
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            FullName = "Actor 1",
                            Bio = "This is the Bio of the first actor",
                            ProfilePictureURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRpKEAvfYq_vCcUoDg-thTLVhMSH6j0yQgyMQ&usqp=CAU"

                        },
                        new Actor()
                        {
                            FullName = "Actor 2",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRpKEAvfYq_vCcUoDg-thTLVhMSH6j0yQgyMQ&usqp=CAU"
                        },
                        new Actor()
                        {
                            FullName = "Actor 3",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRpKEAvfYq_vCcUoDg-thTLVhMSH6j0yQgyMQ&usqp=CAU"
                        },
                        new Actor()
                        {
                            FullName = "Actor 4",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRpKEAvfYq_vCcUoDg-thTLVhMSH6j0yQgyMQ&usqp=CAU"
                        },
                        new Actor()
                        {
                            FullName = "Actor 5",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRpKEAvfYq_vCcUoDg-thTLVhMSH6j0yQgyMQ&usqp=CAU"
                        }
                    });
                    context.SaveChanges();
                }
                //Producers
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            FullName = "Producer 1",
                            Bio = "This is the Bio of the first producer",
                            ProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/3e/Deepak_Raj_Giri.jpg/220px-Deepak_Raj_Giri.jpg"

                        },
                        new Producer()
                        {
                            FullName = "Producer 2",
                            Bio = "This is the Bio of the second producer",
                            ProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/3e/Deepak_Raj_Giri.jpg/220px-Deepak_Raj_Giri.jpg"
                        },
                        new Producer()
                        {
                            FullName = "Producer 3",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/3e/Deepak_Raj_Giri.jpg/220px-Deepak_Raj_Giri.jpg"
                        },
                        new Producer()
                        {
                            FullName = "Producer 4",
                            Bio = "This is the Bio of the second producer",
                            ProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/3e/Deepak_Raj_Giri.jpg/220px-Deepak_Raj_Giri.jpg"
                        },
                        new Producer()
                        {
                            FullName = "Producer 5",
                            Bio = "This is the Bio of the second producer",
                            ProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/3e/Deepak_Raj_Giri.jpg/220px-Deepak_Raj_Giri.jpg"
                        }
                    });
                    context.SaveChanges();
                }
                //Movies
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Name = "Chakka Panja",
                            Description = "This is the movie description",
                            Price = 500,
                            ImageURL = "https://english.onlinekhabar.com/wp-content/uploads/2016/09/chakkapanja.jpg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(10),
                            CinemaId = 3,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Comedy
                        },
                        new Movie()
                        {
                            Name = "Chha akan chha",
                            Description = "This is movie description",
                            Price = 29.50,
                            ImageURL = "https://english.onlinekhabar.com/wp-content/uploads/2016/09/chakkapanja.jpg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(3),
                            CinemaId = 1,
                            ProducerId = 1,
                            MovieCategory = MovieCategory.Comedy
                        },
                        new Movie()
                        {
                            Name = "Movie Name 1",
                            Description = "This is the movie description",
                            Price = 500,
                            ImageURL = "https://english.onlinekhabar.com/wp-content/uploads/2016/09/chakkapanja.jpg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(7),
                            CinemaId = 4,
                            ProducerId = 4,
                            MovieCategory = MovieCategory.Horror
                        },
                        new Movie()
                        {
                            Name = "Movie Name 2",
                            Description = "This is the movie description",
                            Price = 500,
                            ImageURL = "https://english.onlinekhabar.com/wp-content/uploads/2016/09/chakkapanja.jpg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-5),
                            CinemaId = 1,
                            ProducerId = 2,
                            MovieCategory = MovieCategory.Documentary
                        },
                        new Movie()
                        {
                            Name = "Movie Name 3",
                            Description = "This is the movie description",
                            Price = 500,
                            ImageURL = "https://english.onlinekhabar.com/wp-content/uploads/2016/09/chakkapanja.jpg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 1,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Cartoon
                        },
                        new Movie()
                        {
                            Name = "Movie Name 4",
                            Description = "This is the movie description",
                            Price = 500,
                            ImageURL = "https://english.onlinekhabar.com/wp-content/uploads/2016/09/chakkapanja.jpg",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(20),
                            CinemaId = 1,
                            ProducerId = 5,
                            MovieCategory = MovieCategory.Drama
                        }
                    });
                    context.SaveChanges();
                }
                //Actors & Movies
                if (!context.Actors_Movies.Any())
                {
                    context.Actors_Movies.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 1
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 1
                        },

                         new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 2
                        },
                         new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 2
                        },

                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 3
                        },
                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 3
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 3
                        },


                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 4
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 4
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 4
                        },


                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 5
                        },


                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 6
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 6
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 6
                        },
                    });
                    context.SaveChanges();
                }
            }

        }

        public static async Task SeedUsersAndRolesAsync(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {

                //Roles
                var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

                if (!await roleManager.RoleExistsAsync(UserRoles.Admin))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
                if (!await roleManager.RoleExistsAsync(UserRoles.User))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.User));

                //Users
                var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
                string adminUserEmail = "admin@admin.com";

                var adminUser = await userManager.FindByEmailAsync(adminUserEmail);
                if (adminUser == null)
                {
                    var newAdminUser = new ApplicationUser()
                    {
                        FullName = "Admin User",
                        UserName = "admin-user",
                        Email = adminUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAdminUser, "Password@123");
                    await userManager.AddToRoleAsync(newAdminUser, UserRoles.Admin);
                }


                string appUserEmail = "user@user.com";

                var appUser = await userManager.FindByEmailAsync(appUserEmail);
                if (appUser == null)
                {
                    var newAppUser = new ApplicationUser()
                    {
                        FullName = "Application User",
                        UserName = "app-user",
                        Email = appUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAppUser, "Password@123");
                    await userManager.AddToRoleAsync(newAppUser, UserRoles.User);
                }
            }
        }
    }
}
