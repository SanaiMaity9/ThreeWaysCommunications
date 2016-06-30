namespace ThreeWayCommunication
{
    class Connection{
        public  bool CheckConnection(int x, int y, int r) {
        return x*x + y*y <= r*r;
        }
    }
}