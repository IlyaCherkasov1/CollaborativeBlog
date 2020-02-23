namespace Home2
{
    interface ISwitchetable
    {
        bool On{ get; set; }
        bool Off{ get; set; }
        bool On1();
        bool Off1();
        bool IsOn();

    }
}
