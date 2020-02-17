using System;
using System.Collections.Generic;
using System.Linq;
using CAP2.Data;
using CAP2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CAP2.Data {
    public static class SeedData {
        public static void Initialize (IServiceProvider serviceProvider) {
            using (var context = new TeamContext (serviceProvider.GetRequiredService<DbContextOptions<TeamContext>> ())) {

                if (context.Teams.Any ()) {
                    return; // DB has been seeded
                }

                context.Teams.AddRange (
                    //T1
                    new Team {
                        TeamID = 1,
                        Clients = new List<Client> {
                            new Client {
                                Name = "Joe Dans",
                                    Email = "JD@gmail.com",
                                    PhoneNumber = "214-887-1221"
                            }
                        }
                    },
                    //T2
                    new Team {
                        Clients = new List<Client> {
                            new Client {
                                Name = "Bills Tow",
                                    Email = "BT@gmail.cpm",
                                    PhoneNumber = "547-887-6621"
                            }
                        }
                    },
                    //T3
                    new Team {
                        Clients = new List<Client> {
                            new Client {
                                Name = "Milly Mill Grow",
                                    Email = "milly@yahoo.com",
                                    PhoneNumber = "817-267-0000"
                            }
                        }
                    },
                    //T4
                    new Team {
                        Clients = new List<Client> {
                            new Client {
                                Name = "Donut Heaven",
                                    Email = "DN@gmail.cpm",
                                    PhoneNumber = "717-117-5551"
                            }
                        }
                    }

                );

                context.SaveChanges ();
            }
        }

    }
}