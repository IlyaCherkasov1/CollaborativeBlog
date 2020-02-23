using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxAnalaizer
{
    class BoxAnalizer
    {
        BoxParser bp;
        Box[] boxes;
        public BoxAnalizer()
        {
            bp = new BoxParser();
            boxes = bp.GetBox();
        }
        public int GetAllWeigth()
        {
            return boxes.Sum(x => x.Weight);
        }
        public string PopularName()
        {
            var names = boxes.Select(x => x.Name);
            return names
                .Distinct()
                .Select(x => new { name = x, count = names.Count(y => y == x) })
                .OrderByDescending(x => x.count)
                .ElementAt(0).name.ToString();
               
        }
        public void PrintAllWeightFromName()
        {
            for (InBox name = 0; name <(InBox) Enum.GetNames(typeof(InBox)).Length; name++)
            {
                Console.WriteLine($"общие вес по {name} = {boxes.Where(x=>x.Name == name).Sum(x=>x.Weight)}");
            }
        }
    }
}
