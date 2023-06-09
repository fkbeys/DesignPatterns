namespace _05_FacadePattern
{

    public class SubsystemA
    {
        public string Work1()
        {
            return "A-1";
        }

        public string Work2()
        {
            return "A-2";
        }
    }

    public class SubsystemB
    {
        public string Work1()
        {
            return "B-1";
        }

        public string Work2()
        {
            return "B-2";
        }
    }

    public class SubsystemManagement
    {
        private readonly SubsystemA subsystemA;
        private readonly SubsystemB subsystemB;

        public SubsystemManagement(SubsystemA subsystemA, SubsystemB subsystemB)
        {
            this.subsystemA = subsystemA;
            this.subsystemB = subsystemB;
        }

        public string Work1()
        {
            var result= "Together-1:" + subsystemA.Work1() + subsystemB.Work1();
            return result;
        }

        public string Work2()
        {
            return "Together-2:" + subsystemA.Work2() + subsystemB.Work2();
        }

    }
}
