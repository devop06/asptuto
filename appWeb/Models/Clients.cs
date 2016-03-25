using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace appWeb.Models
{
    public class Clients
    {
        public List<Client> LesClients()
        {
            return new List<Client>() {
                new Client {
                    Nom = "Tony", Age = 23
                },
                new Client {
                    Nom = "Clément",
                    Age = 15
                },
               new Client {
                    Nom = "Meggie",
                    Age = 21
                },
                new Client {
                    Nom = "Enzo",
                    Age = 1
                }
            };
        }
    }
}