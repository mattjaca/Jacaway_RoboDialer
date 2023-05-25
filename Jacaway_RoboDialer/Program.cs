// Matthew Jacaway
// IT 112
/* Notes: I'm still unclear what you wanted us to do with phonetype.
 * I didn't know if you wanted us to output it or not
 */
// Behaviors: None


namespace Jacaway_RoboDialer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Phone[] numbers = new Phone[10];
            numbers[0] = new HomePhone("CompuTest", "(303) 985-5060", " ,1");                      
            numbers[1] = new CellPhone("Curtis Manufacturing", "(603) 532-4123", " ,2");
            numbers[2] = new HomePhone("Data Functions", "(800) 876-2524", " ,1");
            numbers[3] = new HomePhone("Donnay Repair", "(708) 397-3330", " ,1");
            numbers[4] = new HomePhone("ErgoNomic Inc", "(360) 434-3894", " ,1");
            numbers[5] = new HomePhone("ErgoSource", "(800) 969-4374", " ,1");
            numbers[6] = new CellPhone("Fox Bay Industries", "(800) 874-8527", " ,2");
            numbers[7] = new CellPhone("Glare-Guard", "(800) 545-6254", " ,2");
            numbers[8] = new CellPhone("Hazard Comm Specialists", "(407) 783-6641", " ,2");
            numbers[9] = new CellPhone("Komfort Support", "(714) 472-4409", " ,2");


            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(numbers[i].Dial().ToString());
            }
        }
    }
}