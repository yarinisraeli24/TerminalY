using TerminalY.Controllers;
using TerminalY.Migrations;
using TerminalY.Models;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;
using TerminalY.Data;



namespace TerminalY.Data
{
    public class DataBaseInfo
    {
        private static object TotalPrice;
        private static object ordersItems;

        public static Order Order { get; private set; }
        public static object OrderItems { get; private set; }
        public static object OrdersItems { get; private set; }

        public static void Initialize(TerminalYContext context)
        {
            context.Database.EnsureCreated();
            if (context.Category.Any())
            {
                return;
            }


            var branches = new Branches[]
            {
                new Branches{Country = "Israel", Address="Rishon-LeZion", latitude = "31.9635712", longitude = "34.8101149"},
                new Branches{Country = "Israel", Address="Hod-Hasharon", latitude = "32.1561974", longitude = "34.8930354"},
                new Branches{Country = "Israel", Address="Tel-Aviv", latitude = "32.0852997", longitude = "34.7818064"},
                new Branches{Country = "Israel", Address="Herzliya", latitude = "32.1656255", longitude = "34.8469023"},
            };

            foreach (Branches b in branches)
            {
                context.Branches.Add(b);
            }
            context.SaveChanges();

            var categories = new Category[]
            {
                new Category{Name = "Shorts"},
                new Category{Name = "T-Shirts"},
                new Category{Name = "Tights"},
                new Category{Name = "Sleeveless"},
                new Category{Name = "Shoes"}
            };


            foreach (Category c in categories)
            {
                context.Category.Add(c);
            }

            context.SaveChanges();

            var Branches1 = new List<Branches>();
            Branches1.Add(branches[0]);
            Branches1.Add(branches[1]);
            Branches1.Add(branches[2]);

            var Branches2 = new List<Branches>();
            Branches2.Add(branches[0]);
            Branches2.Add(branches[2]);

            var Branches3 = new List<Branches>();
            Branches3.Add(branches[0]);
            Branches3.Add(branches[1]);
            Branches3.Add(branches[2]);
            Branches3.Add(branches[3]);

            var Branches4 = new List<Branches>();
            Branches4.Add(branches[0]);
            Branches4.Add(branches[1]);
            Branches4.Add(branches[2]);
            Branches4.Add(branches[3]);
            
            
            var products = new Product[]
            {
                                new Product{Name = "Training First Mile mid support sports bra in black", Created = DateTime.Today,
                    Description = "Part of our responsible edit + Suitable for " +
                    "mid - impact activities + Scoop neck + Padded cups + Removable padding + Wire - free + Elasticated underband for a secure fit + Crossover straps + Pull - on style",
                    Price = 75,Category=categories[0],
                    Image="https://images.unsplash.com/photo-1585036156404-f11b0f784515?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=1868&q=80",
                },

                new Product{Name ="4505 icon training sleeveless t-shirt with quick dry in black", Created = DateTime.Today,
                    Description = "Rep and repeat + Crew neck + Sleeveless style + Logo print to chest + Regular fit + True to size"
                    ,Price = 20,Category=categories[0],
                    Image="https://images.unsplash.com/photo-1585036156404-f11b0f784515?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=1868&q=80",
                },

                new Product{Name ="Training Evoknit seamless light support sports bra in charcoal grey", Created = DateTime.Today,
                    Description = "Motivation starts with new kit + Seamless design + V-neck + Sleeveless style + Cropped length + Slim fit + Close - fitting cut " ,
                    Price = 29,Category=categories[0],
                    Image="https://images.unsplash.com/photo-1585036156404-f11b0f784515?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=1868&q=80",
                },

                new Product{Name ="Training Contour seamless sleeveless crop top in orange", Created = DateTime.Today,
                    Description = "Rep and repeat + Seamless design helps minimise friction + High neck + Partial zip fastening + Breathable mesh inserts + Cropped length + Slim fit + Close-fitting cut ",
                    Price = 16,Category=categories[0],
                    Image="https://images.unsplash.com/photo-1585036156404-f11b0f784515?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=1868&q=80",
                },
                new Product{Name ="vest with large logo in black", Created = DateTime.Today,
                 Description = "Part of our responsible edit + High neck + Branded design + Racer back + Regular fit + True to size"
                 ,Price=815,Category=categories[0],
                    Image="https://images.unsplash.com/photo-1585036156404-f11b0f784515?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=1868&q=80",
                },

                 new Product{Name ="Training One cropped tights in black", Created = DateTime.Today,
                   Description= "Elasticated waistband + Pro branding + logo print to upper left thigh + Flat seams feel smooth against skin + Form-fitting design",
                     Price=29,Category=categories[1],
                    Image="https://images.unsplash.com/photo-1585036156404-f11b0f784515?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=1868&q=80",
                },

                 new Product{Name ="Pro Training tights in black", Created = DateTime.Today,
                             Description= "Elasticated waistband + Pro branding + logo print to upper left thigh + Flat seams feel smooth against skin + Form-fitting design",
                    Price=125,Category=categories[1],
                    Image="https://images.unsplash.com/photo-1585036156404-f11b0f784515?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=1868&q=80",
                },
                 new Product{Name ="4505 training tights with text print in recycled polyester ", Created = DateTime.Today,
                            Description="Part of our responsible edit + Elasticated waist + Text print + Form-fitting style",
                            Price=42,Category=categories[1],
                    Image="https://images.unsplash.com/photo-1585036156404-f11b0f784515?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=1868&q=80",
                },

                 new Product{Name ="Training One tight 7/8 leggings in colourblock", Created = DateTime.Today,
                 Description= "Part of our responsible edit + Colour-block design + Mid-rise + Elasticated waist + Two inner waistband pockets +  logo print to leg + Bodycon fit + Figure-hugging cut",
                     Price=45,Category=categories[1],
                    Image="https://images.unsplash.com/photo-1585036156404-f11b0f784515?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=1868&q=80",
                },
                 new Product{Name ="Indy light support logo t-shirt sports bra in black", Created = DateTime.Today,
                             Description= "Rep and repeat  + Suitable for low - impact activities + Scoop neck + Adjustable strap + Branded, elasticated underband for a secure fit + Racer back for unrestricted movement + Pull - on style",
                     Price=59,Category=categories[2],
                    Image="https://images.unsplash.com/photo-1585036156404-f11b0f784515?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=1868&q=80",
                },

                    new Product{Name ="New Look SPORT recycled polyester running t-shirt in black", Created = DateTime.Today,
                                Description= "Part of our responsible edit + Crew neck + Short sleeves + Reflective details for increased visibility in low lighting + Tonal seams + Regular fit + True to size",
                        Price=40,Category=categories[2],
                    Image="https://images.unsplash.com/photo-1585036156404-f11b0f784515?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=1868&q=80",
                },
                    new Product{Name ="recycled polyester running t-shirt in grey", Created = DateTime.Today,
                        Description= "Part of our responsible edit + Crew neck + Short sleeves + Reflective details for increased visibility in low lighting + Tonal seams + Regular fit + True to size",
                        Price=15,Category=categories[2],
                    Image="https://images.unsplash.com/photo-1585036156404-f11b0f784515?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=1868&q=80",
                },
                    new Product{Name ="Training gradient t-shirt in yellow", Created = DateTime.Today,
                        Description= "Part of our responsible edit + Crew neck + Short sleeves + Reflective details for increased visibility in low lighting + Tonal seams + Regular fit + True to size",
                         Price=28,Category=categories[2],
                    Image="https://images.unsplash.com/photo-1585036156404-f11b0f784515?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=1868&q=80",
                },
                     new Product{Name ="Pink Soda Sport rezi 5inch shorts in cream", Created = DateTime.Today,
                                Description="Rep and repeat + High rise + Elasticated waist + Logo print to back + Bodycon fit + Figure-hugging cut ",
                         Price=299,Category=categories[3],
                    Image="https://images.unsplash.com/photo-1585036156404-f11b0f784515?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=1868&q=80",
                },

                     new Product{Name ="Training Flex woven shorts in blue", Created = DateTime.Today,
                             Description="Rep and repeat + High rise + Elasticated waist + Logo print to back + Bodycon fit + Figure-hugging cut " , Price = 17,Category=categories[3],
                    Image="https://images.unsplash.com/photo-1585036156404-f11b0f784515?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=1868&q=80",
                },

                     new Product{Name ="Pro Training 365 3inch shorts in dark navy", Created = DateTime.Today,
                                Description="Rep and repeat + High rise + Elasticated waist + Logo print to back + Bodycon fit + Figure-hugging cut " , Price = 24,Category=categories[3],
                    Image="https://images.unsplash.com/photo-1585036156404-f11b0f784515?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=1868&q=80",
                },

                      new Product{Name ="Training Play Up shorts 3.0 in pink", Created = DateTime.Today,
                                  Description="Rep and repeat + High rise + Elasticated waist + Logo print to back + Bodycon fit + Figure-hugging cut " , Price = 23,Category=categories[3],
                    Image="https://images.unsplash.com/photo-1585036156404-f11b0f784515?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=1868&q=80",
                },

                      new Product{Name ="Training HIIT 2.0 trainer sin white", Created = DateTime.Today,
                                  Description = "Sock-like cuffs for comfort  + Signature Reebok branding + Floatride Energy Foam provides lightweight, responsive cushioning + Durable rubber outsole with forefoot flex grooves for stability+ Textured grip tread" ,
                          Price = 32,Category=categories[4],
                    Image="https://images.unsplash.com/photo-1585036156404-f11b0f784515?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=1868&q=80",
                },

                       new Product{Name ="SuperRep Go trainers in grey", Created = DateTime.Today,
                                   Description = "Sock-like cuffs for comfort  + Signature Reebok branding + Floatride Energy Foam provides lightweight, responsive cushioning + Durable rubber outsole with forefoot flex grooves for stability+ Textured grip tread",
                           Price = 225,Category=categories[4],
                    Image="https://images.unsplash.com/photo-1585036156404-f11b0f784515?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=1868&q=80",
                },

                        new Product{Name ="Cali Sport trainers in white and silver", Created = DateTime.Today,
                                    Description = "Sock-like cuffs for comfort  + Signature Reebok branding + Floatride Energy Foam provides lightweight, responsive cushioning + Durable rubber outsole with forefoot flex grooves for stability+ Textured grip tread"
                                    , Price = 36,Category=categories[4],
                    Image="https://images.unsplash.com/photo-1585036156404-f11b0f784515?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=1868&q=80",
                },

                         new Product{Name ="Training Disperse XT trainers in black", Created = DateTime.Today,
                                     Description = "Sock-like cuffs for comfort  + Signature Reebok branding + Floatride Energy Foam provides lightweight, responsive cushioning + Durable rubber outsole with forefoot flex grooves for stability+ Textured grip tread"
                                     , Price = 29,Category=categories[4],
                    Image="https://images.unsplash.com/photo-1585036156404-f11b0f784515?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=1868&q=80",
                }
            };


            foreach (Product p in products)
            {
                context.Product.Add(p);
            }
            context.SaveChanges();


            DateTime[] dateTimes = new DateTime[]
            {
                new DateTime(1997,01,02),
                new DateTime(1996,05,12),
                new DateTime(1994,11,01),
                new DateTime(1996,03,24),
                new DateTime(2021,05,10),
                new DateTime(2021,03,11),
                new DateTime(2021,06,07),
                new DateTime(2021,04,11)
            };

            var accounts = new Account[]
            {
                new Account{Username="roy@test.com",Password="1234",Gender=(Gender)1,Name="Roy",BirthDate=dateTimes[0], Registered = dateTimes[4], Role =(Role)0, Cart= new Cart() },
                new Account{Username="shoval@test.com",Password="1234",Gender=(Gender)1,Name="Shoval",BirthDate=dateTimes[1], Registered = dateTimes[5], Role =(Role)0, Cart= new Cart() },
                new Account{Username="or@test.com",Password="1234",Gender=(Gender)1,Name="Or",BirthDate=dateTimes[2], Registered = dateTimes[6], Role =(Role)0, Cart= new Cart() },
                new Account{Username="yarin@test.com",Password="1234",Gender=(Gender)0,Name="Yarin",BirthDate=dateTimes[3], Registered = dateTimes[7], Role =(Role)0, Cart= new Cart() },
            };

            foreach (Account a in accounts)
            {
                context.Account.Add(a);
            }

            context.SaveChanges();

            var contacts = new Contact[]
            {
                new Contact{Name="shoval",Email="shoval@test.com",Body="hdcdscidcber",Subject="i love u"},
                new Contact{Name="or",Email="or@test.com",Body="ovndrjncdkzsnckesd",Subject="yes"},
                new Contact{Name="yrain",Email="yarin@test.com",Body="odnfksdnvifvn",Subject="qQSXJWQOSXJOISA"},
                new Contact{Name="roy",Email="roy@test.com",Body="wusiwxhnsnxcdslxcnl",Subject="mfkvmweashjcv"}
            };
            foreach (Contact c in contacts)
            {
                context.Contact.Add(c);
            }
            context.SaveChanges();

            var orders = new Order[]
            {
                new Order{Country = "Israel", City = "Herzelia", Address = "Malchei Yehuda 30", PostalCode = "2128373" ,PhoneNumber = "0542045596", TotalPrice= 1000, Delivery = (Delivery)0, OrderTime = dateTimes[4] },
                new Order{Country = "Israel", City = "Ganei Tiqva", Address = "Haprahim 16", PostalCode = "3274859" ,PhoneNumber = "0524456543", TotalPrice= 1200, Delivery = (Delivery)1, OrderTime = dateTimes[5]},
                new Order{Country = "Israel", City = "Rishon Lezion", Address = "Tamar 6", PostalCode = "7080100" ,PhoneNumber = "0546258943", TotalPrice= 900, Delivery = (Delivery)2, OrderTime = dateTimes[6]},
                new Order{Country = "Israel", City = "Hod HaSharon", Address = "Haodem 9", PostalCode = "7536789" ,PhoneNumber = "0509876523", TotalPrice= 1300, Delivery = (Delivery)1, OrderTime = dateTimes[7]},

            };

            foreach (Order o in orders)

            {
                context.Order.Add(o);
            }

            context.SaveChanges();

            OrderItem[] orderItems = new OrderItem[]
                {
                new OrderItem{ Quantity=2, Product=products[0], Order=orders[0], Price=3455 },
                new OrderItem{ Quantity=1, Product=products[1], Order=orders[0],Price=43 },
                new OrderItem{ Quantity=1, Product=products[7], Order=orders[1], Price=4545 },
                new OrderItem{ Quantity=3, Product=products[3], Order=orders[2], Price=47778 },
                new OrderItem{ Quantity=1, Product=products[9], Order=orders[2], Price=438 },
                new OrderItem{ Quantity=1, Product=products[14], Order=orders[3], Price=8676 }
                };
            foreach (OrderItem oi in orderItems)

            {
                context.OrderItem.Add(oi);
            }

            context.SaveChanges();

        }        
    }
                
}

    

