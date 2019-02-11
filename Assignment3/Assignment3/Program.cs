using System;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            YearlyMember yearlyMember = new YearlyMember("yearlyMember", "yearlyMemberAddress", "yearlyMemberPhone", 500);
            LifeTimeMember lifeTimeMember = new LifeTimeMember("lifeTimeMember", "lifeTimeMemberAddress", "lifeTimeMemberPhone", 10000);

            Console.WriteLine(yearlyMember.ToString());
            PrintMemberInformation(yearlyMember);

            Console.WriteLine(lifeTimeMember.ToString());
            PrintMemberInformation(lifeTimeMember);
        }

        private static void PrintMemberInformation(Member member)
        {
            Console.WriteLine(member.ToString());
        }
    }
}
