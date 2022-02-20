
using MetricLibrary.Enums;
using MetricLibrary.Interfaces;

namespace MetricLibrary
{
    public class MetricFactory
    {
        public static IMetric Convert(ImperialTypes type)
        {
            switch (type)
            {
                case ImperialTypes.Inches:
                    return new Inches();
                    break;
                case ImperialTypes.Foot:
                    return new Foot();
                    break;
                default:
                    return null;
                    break;
            }
        }
    }
}
