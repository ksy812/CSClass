using System;
namespace CSClass3205
{
    /// <summary>
    /// 자동차 주차장 입차, 출차 시간 등을 지정하는 클래스입니다.
    /// </summary>
    class Car
    {
        int carNumber;
        DateTime inTime;
        DateTime outTime;

        /// <summary>
        /// 뭔가 입력받고 출력합니다
        /// </summary>
        /// <param name="foo">뭔가 매개변수</param>
        /// <returns>뭔가 리턴값</returns>
        public int some(int foo)
        {
            return foo * 10;
        }

        /// <summary>
        /// 자동차 입차 시간을 지정합니다.
        /// </summary>
        public void SetInTime()
        {
            this.inTime = DateTime.Now;
        }

        /// <summary>
        /// 자동차 출차 시간을 지정합니다.
        /// </summary>
        public void SetOutTime()
        {
            this.outTime = DateTime.Now;
        }
    }
}