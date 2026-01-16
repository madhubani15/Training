namespace LPU_Exceptions
{
    /// <summary>
    /// custom exception class created for LPU Management System
    /// By Mandabi Mandal on Date 29/12/2025 at 11:34 AM
    /// </summary>
    public class LPUException : Exception
    {
        public LPUException() :base() { 
        
        }

        public LPUException(string ErrorMsg) : base(ErrorMsg) { 
        
        }
    }
}
