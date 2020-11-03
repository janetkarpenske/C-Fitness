using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace FitnessClient.Models
{
  public class Workout
  {
    public int WorkoutId { get; set; }
    public ICollection<Exercise> Exercises { get; }

    public virtual ApplicationUser User { get; set; } //allows user to create custom exercise when logged in.

    public static List<Exercise> GetExercises()
    {
      var apiCallTask = ApiHelper.GetAll(); //gives list of every possible exercise
      var result = apiCallTask.Result;

      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<Exercise> exerciseList = JsonConvert.DeserializeObject<List<Exercise>>(jsonResponse.ToString());
      return exerciseList;
    }
    public static List<Exercise> GetExercisesEasy() //gives a list of 10 easy exercises
    {
      var apiCallTask = ApiHelper.GetAll();
      var result = apiCallTask.Result;
      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<Exercise> exerciseList = JsonConvert.DeserializeObject<List<Exercise>>(jsonResponse.ToString());
      var sortedList = exerciseList.OrderBy(si => si.Difficulty).Take(10).ToList();
      return sortedList;
    }
    public static List<Exercise> GetExercisesHard() //gives a list of 10 hard exercises
    {
      var apiCallTask = ApiHelper.GetAll();
      var result = apiCallTask.Result;
      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<Exercise> exerciseList = JsonConvert.DeserializeObject<List<Exercise>>(jsonResponse.ToString());
      var sortedList = exerciseList.OrderBy(si => si.Difficulty).Reverse().Take(12).ToList();
      return sortedList;
    }
    public static List<Exercise> GetExercisesMedium() //gives a list of 12 medium exercises
    {
      var apiCallTask = ApiHelper.GetAll();
      var result = apiCallTask.Result;
      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<Exercise> exerciseList = JsonConvert.DeserializeObject<List<Exercise>>(jsonResponse.ToString());
      var sortedList = exerciseList.OrderBy(si => si.Difficulty).Skip(5).Take(12).ToList();
      return sortedList;
    }



    // get one exercise
    public static Exercise GetDetails(int id)
    {
      var apiCallTask = ApiHelper.Get(id);
      var result = apiCallTask.Result;

      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      Exercise exercise = JsonConvert.DeserializeObject<Exercise>(jsonResponse.ToString());
      return exercise;
    }
      public static void Post(Exercise exercise)
      {
        string jsonExercise = JsonConvert.SerializeObject(exercise);
        var apiCallTask = ApiHelper.Post(jsonExercise);
      }
      public static void Put(Exercise exercise)      {
        string jsonExercise = JsonConvert.SerializeObject(exercise);
        var apiCallTask = ApiHelper.Put(exercise.ExerciseId, jsonExercise);
      }
      public static void Delete(int id)
      {
        var apiCallTask = ApiHelper.Delete(id);
      }
  }
}   