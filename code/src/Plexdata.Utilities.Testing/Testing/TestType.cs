/*
 * MIT License
 * 
 * Copyright (c) 2022 plexdata.de
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
 */

using System;

namespace Plexdata.Utilities.Testing
{
    /// <summary>
    /// Provides a list of test names.
    /// </summary>
    /// <remarks>
    /// This class provides a list of test names that can be used as test category names.
    /// </remarks>
    public static class TestType
    {
        #region Microsoft Test Types

        /// <summary>
        /// The name for unit tests.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Unit tests are the most basic tests and are designed to ensure 
        /// the basic functionality of a software component. Such tests are 
        /// usually performed for a single class by replacing any underlying 
        /// components by so-called <i>Mocks</i>.
        /// </para>
        /// </remarks>
        public const String UnitTest = "UnitTest";

        /// <summary>
        /// The name for integration tests.
        /// </summary>
        /// <remarks>
        /// <para>
        /// In contrast to unit tests, integration test are usually used to ensure 
        /// a combined functionality. This usually means that a test unit is not 
        /// cut off from the underlying components.
        /// </para>
        /// </remarks>
        public const String IntegrationTest = "IntegrationTest";

        /// <summary>
        /// The name for performance tests.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Performance tests usually capture the time it takes certain parts of 
        /// a program to run. Performance tests are a great way to catch a code 
        /// change that slows down an application.
        /// </para>
        /// </remarks>
        public const String PerformanceTest = "PerformanceTest";

        /// <summary>
        /// The name for load tests.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Load tests can be similar to performance testing, but focus more on using 
        /// an application at scale. For example, how does an application perform with 
        /// 1,000 users using it, 10,000 users, and so on. Load tests help determine 
        /// if an application is slowing down or throwing exceptions when under stress.
        /// </para>
        /// </remarks>
        public const String LoadTest = "LoadTest";

        /// <summary>
        /// The name for acceptance tests.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Acceptance tests can guide towards the business desired outcome. If for 
        /// example a customer gave a list of criteria for an application, acceptance 
        /// tests can be written that only pass after all of those criteria are met. 
        /// </para>
        /// </remarks>
        public const String AcceptanceTest = "AcceptanceTest";

        /// <summary>
        /// The name for user interface tests.
        /// </summary>
        /// <remarks>
        /// <para>
        /// UI tests can directly test the user interface interactions of an application. 
        /// UI tests are meant to mimic an actual user clicking and interacting with an 
        /// application, and to test if the UI response is correct.
        /// </para>
        /// </remarks>
        public const String UiTest = "UiTest";

        #endregion

        #region Other Test Types

        /// <summary>
        /// The name for system tests.
        /// </summary>
        /// <remarks>
        /// <para>
        /// System tests is types of testing where for example tester evaluates the whole 
        /// system against the specified requirements.
        /// </para>
        /// </remarks>
        public const String SystemTest = "SystemTest";

        /// <summary>
        /// The name for security tests.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Security tests are done to check how secure an application is from internal 
        /// and/or external threats. This testing includes how much software is secure 
        /// from malicious programs, viruses and how secure and strong the authorization
        /// and authentication processes are.
        /// </para>
        /// </remarks>
        public const String SecurityTest = "SecurityTest";

        /// <summary>
        /// The name for compatibility tests.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Compatibility tests ensures that an application can run on different configuration, 
        /// different databases, different browsers, and their versions, and so on.
        /// </para>
        /// </remarks>
        public const String CompatibilityTest = "CompatibilityTest";

        /// <summary>
        /// The name for regression tests.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Regression tests are used to ensure that previously developed and tested software 
        /// still performs after a change.
        /// </para>
        /// </remarks>
        public const String RegressionTest = "RegressionTest";

        #endregion
    }
}
