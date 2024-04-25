using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using BlazorApp1.CarModels;
using System.Diagnostics;

namespace BlazorApp1.Mapping
{
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    public class CarDetailMap : IEntityTypeConfiguration<CarDetail>
    {
        public void Configure(EntityTypeBuilder<CarDetail> builder)
        {
            builder.HasData(
                 new CarDetail { CarId = 1001, Tag = "180", Finas = "X294-01019", Vin = "4JGGM2BB6PA000131", AdasBool = true }, //, Id = 1001 },
                      new CarDetail { CarId = 1002, Tag = "181", Finas = "X167-04607", Vin = "4JGFF8HB5NA357779", HeadUnit = "X00.0", AdasBool = true }, //, Id = 1002 },
                      new CarDetail { CarId = 1003, Tag = "182", Finas = "X296-01198", Vin = "4JGDM2DB4RA003435", HeadUnit = "X00.0", AdasBool = true }, //, Id = 1003 },
                      new CarDetail { CarId = 1004, Tag = "183", Finas = "X167-06625", Vin = "4JGFF8FE9RA844776", HeadUnit = "X00.0", AdasBool = true }, //, Id = 1004 },
                      new CarDetail { CarId = 1005, Tag = "184", Finas = "X294-01471", Vin = "4JGGM1CB8RA000790", HeadUnit = "X00.0", AdasBool = true }, //, Id = 1005 },
                      new CarDetail { CarId = 1006, Tag = "185", Finas = "Z296-01209", Vin = "4JGDX5FB2RA003388", HeadUnit = "X00.0", AdasBool = true }, //, Id = 1006 },
                      new CarDetail { CarId = 1007, Tag = "186", Finas = "X296-01210", Vin = "4JGDM4EB5RA003437", HeadUnit = "X00.0", AdasBool = true }, //, Id = 1007 },
                      new CarDetail { CarId = 1008, Tag = "187", Finas = "X167-06656", Vin = "4JGFF5KE1RA844775", HeadUnit = "X00.0", AdasBool = true }, //, Id = 1008 },
                      new CarDetail { CarId = 1009, Tag = "188", Finas = "X294-01457", Vin = "4JGGM5DB8RA001590", HeadUnit = "X00.0", AdasBool = true }, //, Id = 1009 },
                      new CarDetail { CarId = 1010, Tag = "189", Finas = "X296-00421", Vin = "4JGDM4EB6PA000351", HeadUnit = "X00.0", AdasBool = true }, //, Id = 1010 },
                      new CarDetail { CarId = 1011, Tag = "190", Finas = "X296-00395", Vin = "4JGDM2DB9PA000205", HeadUnit = "X00.0", AdasBool = true }, //, Id = 1011 },
                      new CarDetail { CarId = 1012, Tag = "191", Finas = "X167-06686", Vin = "4JGFF8HB1RA844774", HeadUnit = "X00.0", AdasBool = true }, //, Id = 1012 },
                      new CarDetail { CarId = 1013, Tag = "192", Finas = "X294-01532", Vin = "4JGGM2BB2RA000792", HeadUnit = "X00.0", AdasBool = true }, //, Id = 1013 },
                      new CarDetail { CarId = 1014, Tag = "193", Finas = "X296-00702", Vin = "4JGDM2EB1PU000194", HeadUnit = "X00.0", AdasBool = true }, //, Id = 1014 },
                      new CarDetail { CarId = 1015, Tag = "195", Finas = "V167-06463", Vin = "4JGFB4GB3RA809370", HeadUnit = "X00.0", AdasBool = true }, //, Id = 1015 },
                      new CarDetail { CarId = 1016, Tag = "196", Finas = "Z296-01192", Vin = "4JGDX5FB9RA003386", HeadUnit = "X00.0", AdasBool = true }, //, Id = 1016 },
                      new CarDetail { CarId = 1017, Tag = "197", Finas = "C167-06461", Vin = "4JGFD8KB4RA809371", HeadUnit = "X00.0", AdasBool = true }, //, Id = 1017 },
                      new CarDetail { CarId = 1018, Tag = "198", Finas = "V167-06567", Vin = "4JGFB4GB1PA883660", HeadUnit = "X00.0", AdasBool = true }, //, Id = 1018 },
                      new CarDetail { CarId = 1019, Tag = "199", Finas = "X294-01456", Vin = "4JGGM5DBXRA001588", HeadUnit = "X00.0", AdasBool = true }, //, Id = 1019 },
                      new CarDetail { CarId = 1020, Tag = "288", Finas = "X296-00848", Vin = "4JGDM4EB7PA000701", HeadUnit = "X00.0", AdasBool = true }, //, Id = 1020 },
                      new CarDetail { CarId = 1021, Tag = "638", Finas = "V297-02377", Vin = "W1KCG4EB4PA019834", HeadUnit = "X00.0", AdasBool = true }, //, Id = 1021 },
                      new CarDetail { CarId = 1022, Tag = "651", Finas = "W206-01531", Vin = "W1KAF4GB9NR000041", HeadUnit = "X00.0", AdasBool = true }, //, Id = 1022 },
                      new CarDetail { CarId = 1023, Tag = "652", Finas = "V297-01008", Vin = "W1KCG4EB7NA000823", HeadUnit = "X00.0", AdasBool = true }, //, Id = 1023 },
                      new CarDetail { CarId = 1024, Tag = "653", Finas = "A118-01377", Vin = "W1K5J5EB8RN368913", HeadUnit = "X00.0", AdasBool = true }, //, Id = 1024 },
                      new CarDetail { CarId = 1025, Tag = "654", Finas = "V297-01062", Vin = "W1KCG2EB8NA003265", HeadUnit = "X00.0", AdasBool = true }, //, Id = 1025 },
                      new CarDetail { CarId = 1026, Tag = "655", Finas = "V223-05154", Vin = "W1K6G8CB9RA200096", HeadUnit = "X00.0", AdasBool = true }, //, Id = 1026 },
                      new CarDetail { CarId = 1027, Tag = "657", Finas = "X254-02459", Vin = "W1NKM4GB3PF001221", HeadUnit = "X00.0", AdasBool = true }, //, Id = 1027 },
                      new CarDetail { CarId = 1028, Tag = "658", Finas = "V295-01073", Vin = "W1KEG2BB5NF000498", HeadUnit = "X00.0", AdasBool = true }, //, Id = 1028 },
                      new CarDetail { CarId = 1029, Tag = "659", Finas = "V295-01074", Vin = "W1KEG2BB7NF000499", HeadUnit = "X00.0", AdasBool = true }, //, Id = 1029 },
                      new CarDetail { CarId = 1030, Tag = "660", Finas = "Z223-05153", Vin = "W1K6X7GB9RA203259", HeadUnit = "X00.0", AdasBool = true }, //, Id = 1030 },
                      new CarDetail { CarId = 1031, Tag = "661", Finas = "N295-01333", Vin = "W1KEG5DB3PF005779", HeadUnit = "X00.0", AdasBool = true }, //, Id = 1031 },
                      new CarDetail { CarId = 1032, Tag = "662", Finas = "X243-01749", Vin = "W1N9M1DB3RN027408", HeadUnit = "X00.0", AdasBool = true }, //, Id = 1032 },
                      new CarDetail { CarId = 1033, Tag = "663", Finas = "V223-04879", Vin = "W1K6G8CB5PA159432", HeadUnit = "X00.0", AdasBool = true }, //, Id = 1033 },
                      new CarDetail { CarId = 1034, Tag = "664", Finas = "V297-01298", Vin = "W1KCG4EB6NA000411", HeadUnit = "X00.0", AdasBool = true }, //, Id = 1034 },
                      new CarDetail { CarId = 1035, Tag = "665", Finas = "A238-02435", Vin = "W1K1K6BB7PF185712", HeadUnit = "X00.0", AdasBool = true }, //, Id = 1035 },
                      new CarDetail { CarId = 1036, Tag = "666", Finas = "W214-01098", Vin = "W1KLF4HB7RA000650", HeadUnit = "X00.0", AdasBool = true }, //, Id = 1036 },
                      new CarDetail { CarId = 1037, Tag = "668", Finas = "X294-00461", Vin = "4JGGM1CB5PA000386", HeadUnit = "X00.0", AdasBool = true }, //, Id = 1037 },
                      new CarDetail { CarId = 1038, Tag = "669", Finas = "X296-00322", Vin = "4JGDM2DB2PA000031", HeadUnit = "X00.0", AdasBool = true }, //, Id = 1038 },
                      new CarDetail { CarId = 1039, Tag = "670", Finas = "V295-00503", Vin = "W1KEG2BB5PF000620", HeadUnit = "X00.0", AdasBool = true } //, Id = 1039 }

                              );
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}
