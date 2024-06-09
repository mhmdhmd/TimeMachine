﻿using FluentAssertions;

namespace TimeMachine.Tests
{
    public class MonthlyDateTests
    {
        [Fact]
        public void Init_ShouldCreateMonthlyDate()
        {
            // Arrange
            int year = 2023;
            Month month = Month.Jan;
            Day day = Day.First;

            // Act
            var monthlyDate = MonthlyDate.Init(year, month, day);

            // Assert
            monthlyDate.Year.Should().Be(year);
            monthlyDate.Month.Should().Be(month);
            monthlyDate.Day.Should().Be(day);
        }

        [Fact]
        public void OnDay_ShouldSetDayOfMonth()
        {
            // Arrange
            var monthlyDate = MonthlyDate.Init(2023, Month.Jan, Day.First);
            Day newDay = Day.Tenth;

            // Act
            var updatedDate = monthlyDate.OnDay(newDay);

            // Assert
            updatedDate.Day.Should().Be(newDay);
        }

        [Fact]
        public void AtYear_ShouldSetYear()
        {
            // Arrange
            var monthlyDate = MonthlyDate.Init(2023, Month.Jan, Day.First);
            int newYear = 2024;

            // Act
            var updatedDate = monthlyDate.AtYear(newYear);

            // Assert
            updatedDate.Year.Should().Be(newYear);
        }

        [Fact]
        public void MonthsFromNow_ShouldReturnUpdatedMonthlyDate()
        {
            // Arrange
            var monthlyDate = MonthlyDate.Init(2023, Month.Jan, Day.First);
            int months = 5;
            var expectedDate = monthlyDate.LetsGo().AddMonths(months);

            // Act
            var newMonthlyDate = monthlyDate.MonthsFromNow(months);

            // Assert
            newMonthlyDate.Year.Should().Be(expectedDate.Year);
            newMonthlyDate.Month.Should().Be((Month)expectedDate.Month);
            newMonthlyDate.Day.Should().Be(monthlyDate.Day);
        }

        [Fact]
        public void MonthsAgo_ShouldReturnUpdatedMonthlyDate()
        {
            // Arrange
            var monthlyDate = MonthlyDate.Init(2023, Month.Jan, Day.First);
            int months = 5;
            var expectedDate = monthlyDate.LetsGo().AddMonths(-months);

            // Act
            var newMonthlyDate = monthlyDate.MonthsAgo(months);

            // Assert
            newMonthlyDate.Year.Should().Be(expectedDate.Year);
            newMonthlyDate.Month.Should().Be((Month)expectedDate.Month);
            newMonthlyDate.Day.Should().Be(monthlyDate.Day);
        }

        [Fact]
        public void InMonth_ShouldReturnUpdatedMonthlyDate()
        {
            // Arrange
            var monthlyDate = MonthlyDate.Init(2023, Month.Jan, Day.First);
            Month newMonth = Month.Dec;

            // Act
            var newMonthlyDate = monthlyDate.InMonth(newMonth);

            // Assert
            newMonthlyDate.Year.Should().Be(monthlyDate.Year);
            newMonthlyDate.Month.Should().Be(newMonth);
            newMonthlyDate.Day.Should().Be(monthlyDate.Day);
        }

        [Fact]
        public void DaysFromNow_ShouldReturnUpdatedMonthlyDate()
        {
            // Arrange
            var monthlyDate = MonthlyDate.Init(2023, Month.Jan, Day.First);
            int days = 10;
            var expectedDate = monthlyDate.LetsGo().AddDays(days);

            // Act
            var newMonthlyDate = monthlyDate.DaysFromNow(days);

            // Assert
            newMonthlyDate.Year.Should().Be(expectedDate.Year);
            newMonthlyDate.Month.Should().Be((Month)expectedDate.Month);
            newMonthlyDate.Day.Should().Be((Day)expectedDate.Day);
        }

        [Fact]
        public void DaysAgo_ShouldReturnUpdatedMonthlyDate()
        {
            // Arrange
            var monthlyDate = MonthlyDate.Init(2023, Month.Jan, Day.First);
            int days = 10;
            var expectedDate = monthlyDate.LetsGo().AddDays(-days);

            // Act
            var newMonthlyDate = monthlyDate.DaysAgo(days);

            // Assert
            newMonthlyDate.Year.Should().Be(expectedDate.Year);
            newMonthlyDate.Month.Should().Be((Month)expectedDate.Month);
            newMonthlyDate.Day.Should().Be((Day)expectedDate.Day);
        }
    }
}
