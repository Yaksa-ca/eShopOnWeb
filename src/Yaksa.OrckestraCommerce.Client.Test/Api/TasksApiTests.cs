/*
 * Overture API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Yaksa.OrckestraCommerce.Client.Client;
using Yaksa.OrckestraCommerce.Client.Api;
// uncomment below to import models
//using Yaksa.OrckestraCommerce.Client.Model;

namespace Yaksa.OrckestraCommerce.Client.Test.Api
{
    /// <summary>
    ///  Class for testing TasksApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class TasksApiTests : IDisposable
    {
        private TasksApi instance;

        public TasksApiTests()
        {
            instance = new TasksApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of TasksApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' TasksApi
            //Assert.IsType<TasksApi>(instance);
        }

        /// <summary>
        /// Test AddOrUpdateScheduledTaskTriggerscheduledTaskGroupTaskNametriggersTriggerGroupTriggerNameCreate
        /// </summary>
        [Fact]
        public void AddOrUpdateScheduledTaskTriggerscheduledTaskGroupTaskNametriggersTriggerGroupTriggerNameCreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string taskGroup = null;
            //string taskName = null;
            //string triggerGroup = null;
            //string triggerName = null;
            //AddOrUpdateScheduledTaskTrigger body = null;
            //var response = instance.AddOrUpdateScheduledTaskTriggerscheduledTaskGroupTaskNametriggersTriggerGroupTriggerNameCreate(accept, taskGroup, taskName, triggerGroup, triggerName, body);
            //Assert.IsType<ScheduledTaskInfo>(response);
        }

        /// <summary>
        /// Test CancelTaskRequestTaskIdcancelPost
        /// </summary>
        [Fact]
        public void CancelTaskRequestTaskIdcancelPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string taskId = null;
            //Object body = null;
            //instance.CancelTaskRequestTaskIdcancelPost(accept, taskId, body);
        }

        /// <summary>
        /// Test DeleteAllScheduledTasksRequestscheduledallDelete
        /// </summary>
        [Fact]
        public void DeleteAllScheduledTasksRequestscheduledallDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //instance.DeleteAllScheduledTasksRequestscheduledallDelete(accept);
        }

        /// <summary>
        /// Test DeleteScheduledTaskRequestscheduledGroupNameDelete
        /// </summary>
        [Fact]
        public void DeleteScheduledTaskRequestscheduledGroupNameDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string group = null;
            //string name = null;
            //instance.DeleteScheduledTaskRequestscheduledGroupNameDelete(accept, group, name);
        }

        /// <summary>
        /// Test DeleteTaskInfoRequestTaskIdDelete
        /// </summary>
        [Fact]
        public void DeleteTaskInfoRequestTaskIdDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string taskId = null;
            //bool? force = null;
            //instance.DeleteTaskInfoRequestTaskIdDelete(accept, taskId, force);
        }

        /// <summary>
        /// Test GetAllScheduledTasksRequestscheduledallGet
        /// </summary>
        [Fact]
        public void GetAllScheduledTasksRequestscheduledallGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //var response = instance.GetAllScheduledTasksRequestscheduledallGet(accept);
            //Assert.IsType<List<ScheduledTaskInfo>>(response);
        }

        /// <summary>
        /// Test GetRequesterTasksInfoRequestGet
        /// </summary>
        [Fact]
        public void GetRequesterTasksInfoRequestGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string requester = null;
            //DateTime? lastModified = null;
            //List<string> filterTaskNames = null;
            //var response = instance.GetRequesterTasksInfoRequestGet(accept, requester, lastModified, filterTaskNames);
            //Assert.IsType<List<TaskInfo>>(response);
        }

        /// <summary>
        /// Test GetRunningScheduledTasksRequestscheduledrunningGet
        /// </summary>
        [Fact]
        public void GetRunningScheduledTasksRequestscheduledrunningGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //var response = instance.GetRunningScheduledTasksRequestscheduledrunningGet(accept);
            //Assert.IsType<List<RunningScheduledTaskInfo>>(response);
        }

        /// <summary>
        /// Test GetScheduledTaskRequestscheduledGroupNameGet
        /// </summary>
        [Fact]
        public void GetScheduledTaskRequestscheduledGroupNameGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string group = null;
            //string name = null;
            //var response = instance.GetScheduledTaskRequestscheduledGroupNameGet(accept, group, name);
            //Assert.IsType<ScheduledTaskInfo>(response);
        }

        /// <summary>
        /// Test GetTaskExecutionLogsRequestTaskIdlogsGet
        /// </summary>
        [Fact]
        public void GetTaskExecutionLogsRequestTaskIdlogsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string taskId = null;
            //var response = instance.GetTaskExecutionLogsRequestTaskIdlogsGet(accept, taskId);
            //Assert.IsType<List<TaskExecutionLogEntry>>(response);
        }

        /// <summary>
        /// Test GetTaskInfoRequestTaskIdGet
        /// </summary>
        [Fact]
        public void GetTaskInfoRequestTaskIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string taskId = null;
            //var response = instance.GetTaskInfoRequestTaskIdGet(accept, taskId);
            //Assert.IsType<TaskInfo>(response);
        }

        /// <summary>
        /// Test GetTasksInfoByCorrelationIdRequestbyCorrelationIdIdGet
        /// </summary>
        [Fact]
        public void GetTasksInfoByCorrelationIdRequestbyCorrelationIdIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string id = null;
            //var response = instance.GetTasksInfoByCorrelationIdRequestbyCorrelationIdIdGet(accept, id);
            //Assert.IsType<List<TaskInfo>>(response);
        }

        /// <summary>
        /// Test QueueActivityTaskRequestactivitiesTaskIdPost
        /// </summary>
        [Fact]
        public void QueueActivityTaskRequestactivitiesTaskIdPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string taskId = null;
            //QueueActivityTaskRequest body = null;
            //var response = instance.QueueActivityTaskRequestactivitiesTaskIdPost(accept, taskId, body);
            //Assert.IsType<TaskInfo>(response);
        }

        /// <summary>
        /// Test QueueWorkflowTaskRequestworkflowsTaskIdPost
        /// </summary>
        [Fact]
        public void QueueWorkflowTaskRequestworkflowsTaskIdPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string taskId = null;
            //QueueWorkflowTaskRequest body = null;
            //var response = instance.QueueWorkflowTaskRequestworkflowsTaskIdPost(accept, taskId, body);
            //Assert.IsType<TaskInfo>(response);
        }

        /// <summary>
        /// Test RemoveScheduledTaskTriggerRequestscheduledTaskGroupTaskNametriggersTriggerGroupTriggerNameDelete
        /// </summary>
        [Fact]
        public void RemoveScheduledTaskTriggerRequestscheduledTaskGroupTaskNametriggersTriggerGroupTriggerNameDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string taskGroup = null;
            //string taskName = null;
            //string triggerGroup = null;
            //string triggerName = null;
            //var response = instance.RemoveScheduledTaskTriggerRequestscheduledTaskGroupTaskNametriggersTriggerGroupTriggerNameDelete(accept, taskGroup, taskName, triggerGroup, triggerName);
            //Assert.IsType<ScheduledTaskInfo>(response);
        }

        /// <summary>
        /// Test ScheduleTaskActivityRequestscheduledactivitiesGroupNamePost
        /// </summary>
        [Fact]
        public void ScheduleTaskActivityRequestscheduledactivitiesGroupNamePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string group = null;
            //string name = null;
            //ScheduleTaskActivityRequest body = null;
            //var response = instance.ScheduleTaskActivityRequestscheduledactivitiesGroupNamePost(accept, group, name, body);
            //Assert.IsType<ScheduledTaskInfo>(response);
        }

        /// <summary>
        /// Test ScheduleTaskWorkflowRequestscheduledworkflowsGroupNamePost
        /// </summary>
        [Fact]
        public void ScheduleTaskWorkflowRequestscheduledworkflowsGroupNamePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string group = null;
            //string name = null;
            //ScheduleTaskWorkflowRequest body = null;
            //var response = instance.ScheduleTaskWorkflowRequestscheduledworkflowsGroupNamePost(accept, group, name, body);
            //Assert.IsType<ScheduledTaskInfo>(response);
        }
    }
}
