﻿// <auto-generated />
using Fitness.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Fitness.Migrations
{
    [DbContext(typeof(FitnessContext))]
    partial class FitnessContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Fitness.Models.Exercise", b =>
                {
                    b.Property<int>("ExerciseId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Calories");

                    b.Property<string>("Difficulty");

                    b.Property<string>("Name");

                    b.Property<string>("Target");

                    b.Property<string>("Type");

                    b.HasKey("ExerciseId");

                    b.ToTable("Exercises");

                    b.HasData(
                        new
                        {
                            ExerciseId = 1,
                            Calories = 20,
                            Difficulty = "Medium",
                            Name = "Pushups",
                            Target = "Arms",
                            Type = "Strength"
                        },
                        new
                        {
                            ExerciseId = 2,
                            Calories = 20,
                            Difficulty = "Hard",
                            Name = "Diamond Pushups",
                            Target = "Arms",
                            Type = "Strength"
                        },
                        new
                        {
                            ExerciseId = 3,
                            Calories = 20,
                            Difficulty = "Easy",
                            Name = "Yoga Pushups",
                            Target = "Arms",
                            Type = "Strength"
                        },
                        new
                        {
                            ExerciseId = 4,
                            Calories = 20,
                            Difficulty = "Easy",
                            Name = "Bicep Curls",
                            Target = "Arms",
                            Type = "Strength"
                        },
                        new
                        {
                            ExerciseId = 5,
                            Calories = 20,
                            Difficulty = "Hard",
                            Name = "Tricep Kickbacks",
                            Target = "Arms",
                            Type = "Strength"
                        },
                        new
                        {
                            ExerciseId = 6,
                            Calories = 20,
                            Difficulty = "Hard",
                            Name = "Pullups",
                            Target = "Arms",
                            Type = "Strength"
                        },
                        new
                        {
                            ExerciseId = 7,
                            Calories = 20,
                            Difficulty = "Easy",
                            Name = "Arm Circles",
                            Target = "Arms",
                            Type = "Strength"
                        },
                        new
                        {
                            ExerciseId = 8,
                            Calories = 20,
                            Difficulty = "Medium",
                            Name = "Situps",
                            Target = "Abs",
                            Type = "Strength"
                        },
                        new
                        {
                            ExerciseId = 9,
                            Calories = 20,
                            Difficulty = "Medium",
                            Name = "Plank",
                            Target = "Abs",
                            Type = "Strength"
                        },
                        new
                        {
                            ExerciseId = 10,
                            Calories = 20,
                            Difficulty = "Medium",
                            Name = "Bicycle Crunches",
                            Target = "Abs",
                            Type = "Strength"
                        },
                        new
                        {
                            ExerciseId = 11,
                            Calories = 20,
                            Difficulty = "Medium",
                            Name = "Star Crunches",
                            Target = "Abs",
                            Type = "Strength"
                        },
                        new
                        {
                            ExerciseId = 12,
                            Calories = 20,
                            Difficulty = "Medium",
                            Name = "100's",
                            Target = "Abs",
                            Type = "Strength"
                        },
                        new
                        {
                            ExerciseId = 13,
                            Calories = 20,
                            Difficulty = "Medium",
                            Name = "Russian Twist",
                            Target = "Abs",
                            Type = "Strength"
                        },
                        new
                        {
                            ExerciseId = 14,
                            Calories = 20,
                            Difficulty = "Medium",
                            Name = "Oblique Crunches",
                            Target = "Abs",
                            Type = "Strength"
                        },
                        new
                        {
                            ExerciseId = 15,
                            Calories = 20,
                            Difficulty = "Medium",
                            Name = "Side Plank",
                            Target = "Abs",
                            Type = "Strength"
                        },
                        new
                        {
                            ExerciseId = 16,
                            Calories = 20,
                            Difficulty = "Medium",
                            Name = "Sumo Squats",
                            Target = "Legs",
                            Type = "Strength"
                        },
                        new
                        {
                            ExerciseId = 17,
                            Calories = 20,
                            Difficulty = "Medium",
                            Name = "Squats- Narrow Stance",
                            Target = "Legs",
                            Type = "Strength"
                        },
                        new
                        {
                            ExerciseId = 18,
                            Calories = 20,
                            Difficulty = "Medium",
                            Name = "Lunges",
                            Target = "Legs",
                            Type = "Strength"
                        },
                        new
                        {
                            ExerciseId = 19,
                            Calories = 20,
                            Difficulty = "Medium",
                            Name = "Lunges",
                            Target = "Legs",
                            Type = "Strength"
                        },
                        new
                        {
                            ExerciseId = 21,
                            Calories = 20,
                            Difficulty = "Medium",
                            Name = "Glute Kickbacks",
                            Target = "Glutes",
                            Type = "Strength"
                        },
                        new
                        {
                            ExerciseId = 22,
                            Calories = 20,
                            Difficulty = "Medium",
                            Name = "Fire Hydrants",
                            Target = "Glutes",
                            Type = "Strength"
                        },
                        new
                        {
                            ExerciseId = 23,
                            Calories = 20,
                            Difficulty = "Medium",
                            Name = "Frog Kicks",
                            Target = "Glutes",
                            Type = "Strength"
                        },
                        new
                        {
                            ExerciseId = 24,
                            Calories = 20,
                            Difficulty = "Medium",
                            Name = "Hip Thrusts",
                            Target = "Glutes",
                            Type = "Strength"
                        },
                        new
                        {
                            ExerciseId = 25,
                            Calories = 20,
                            Difficulty = "Easy",
                            Name = "Jumping Jacks",
                            Target = "Cardio",
                            Type = "Strength"
                        },
                        new
                        {
                            ExerciseId = 26,
                            Calories = 20,
                            Difficulty = "Easy",
                            Name = "Fly Jacks",
                            Target = "Cardio",
                            Type = "Strength"
                        },
                        new
                        {
                            ExerciseId = 27,
                            Calories = 20,
                            Difficulty = "Hard",
                            Name = "Lunge Jumps",
                            Target = "Cardio",
                            Type = "Strength"
                        },
                        new
                        {
                            ExerciseId = 28,
                            Calories = 20,
                            Difficulty = "Medium",
                            Name = "Mountain Climbers",
                            Target = "Cardio",
                            Type = "Strength"
                        },
                        new
                        {
                            ExerciseId = 29,
                            Calories = 20,
                            Difficulty = "Hard",
                            Name = "High-Knees",
                            Target = "Cardio",
                            Type = "Strength"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
