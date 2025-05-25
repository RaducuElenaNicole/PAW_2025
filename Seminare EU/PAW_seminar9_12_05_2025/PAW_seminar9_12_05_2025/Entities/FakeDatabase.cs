using PAW_seminar9_12_05_2025.Entities;
using PAW_seminar9_12_05_2025.Entities;
using System;
using System.Collections.Generic;

namespace PAW_seminar9_12_05_2025.Entities
{
    public static class FakeDatabase
    {
        public static List<Company> Companies = new List<Company>()
        {
            new Company() { Id = 1, Name = "Google" },
            new Company() { Id = 2, Name = "OpenAI"}
        };

        public static List<Stock> Stocks = new List<Stock>() {
            new Stock() {
                CompanyId = 1,
                Date = DateTime.Now.AddDays(-5),
                Open = 59,
                Close = 72,
                Low = 51,
                High = 76
            },
            new Stock() {
                CompanyId = 2,
                Date = DateTime.Now.AddDays(-4),
                Open = 72,
                Close = 81,
                Low = 72,
                High = 102
            },
            new Stock() {
                CompanyId = 1,
                Date = DateTime.Now.AddDays(-3),
                Open = 81,
                Close = 63,
                Low = 41,
                High = 83
            },
            new Stock() {
                CompanyId = 2,
                Date = DateTime.Now.AddDays(-2),
                Open = 63,
                Close = 53,
                Low = 24,
                High = 68
            },
            new Stock() {
                CompanyId = 1,
                Date = DateTime.Now.AddDays(-1),
                Open = 53,
                Close = 59,
                Low = 48,
                High = 67
            },
            new Stock() {
                CompanyId = 1,
                Date = DateTime.Now,
                Open = 59,
                Close = 103,
                Low = 59,
                High = 103
            },
            new Stock() {
                CompanyId = 2,
                Date = DateTime.Now.AddDays(-5),
                Open = 59,
                Close = 72,
                Low = 51,
                High = 76
            }
        };
    }
}
