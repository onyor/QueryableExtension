using Newtonsoft.Json;
using System.Reflection;

namespace QueryableExtension.Extensions
{
    public static class ClassExtension
    {
        public static void ChangeMethod(User onyore)
        {
            var test = onyore.xGetMemberValue("City.District.Neighborhood.Name");
            Console.WriteLine("test: " + test);
        }


        public static T xCloneObj<T>(this T source)
        {
            var seria = JsonConvert.SerializeObject(source);
            return JsonConvert.DeserializeObject<T>(seria);
        }

        public static object xGetMemberValue(this object self, string name)
        {
            object result = null;
            PropertyInfo prop = null;
            string[] nameList = name.Split(".");
            if (name.Contains("."))
                foreach (var item in nameList)
                    if (!(nameList[nameList.Length - 1] == item))
                    {
                        self = self.xGetMemberValue(item);
                    }
                    else
                        name = nameList[nameList.Length - 1];

            var lastType = self.GetType();
            prop = lastType.GetProperty(name);
            var value = prop != null ? prop.GetValue(self) : null;
            result = value != null ? value : null;

            return result;
        }

    }
}
