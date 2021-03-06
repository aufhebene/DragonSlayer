using System.Collections;
using NUnit.Framework;
using Unity.RecordedTesting;
using Unity.RecordedTesting.TestTools;
using UnityEngine.TestTools;

namespace GeneratedRecordedTests
{
    /// <summary>
    /// These tests were generated by Unity Automated QA for the recording: "Recordings/recording-2021-05-07-T13-59-33.json"
    /// You can regenerate this file from the Unity Editor Menu: Automated QA > Generate Recorded Tests
    /// </summary>
    public class RecordedTest_recording_2021_05_07_T13_59_33 : RecordedTestSuite
    {
        /// <summary>
        /// Asserts that the recording can successfully play through to the end. 
        /// </summary>
        [UnityTest]
        [RecordedTest("Recordings/recording-2021-05-07-T13-59-33.json")]
        public IEnumerator CanPlayToEnd()
        {
            yield return RecordedTesting.TestPlayToEnd();
            Assert.IsTrue(true);
        }
    }
}
