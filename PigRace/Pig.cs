using System.Windows.Forms;

namespace PigRace
{
    class Pig
    {
        public string Name { get; set; }
        public PictureBox myPB { get; set; }
        // Side of the screen pig starts on
        public string StartingLocation { get; set; }
        // top or left coordinates where the pig starts
        public int StartingPosition { get; set; }
        public int FinishLine { get; set; }
        public bool Winner { get; set; }
        /// <summary>
        /// Moves the pig's picture box in the correct direction towards the finish line by adding on random numbers
        /// </summary>
        public void Run(int num)
        {
            // move pig down
            if (StartingLocation == "Top")
            {
                myPB.Top += num;
            }
            // move pig to the left
            if (StartingLocation == "Right")
            {
                myPB.Left -= num;
            }
            // move pig up
            if (StartingLocation == "Bottom")
            {
                myPB.Top -= num;
            }
            // move pig to the right
            if (StartingLocation == "Left")
            {
                myPB.Left += num;
            }
        }
    }
}
