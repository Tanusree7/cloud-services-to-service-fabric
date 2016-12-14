﻿namespace Tailspin.AnswerAnalysisService.QueueHandlers
{
    using Tailspin.Web.Survey.Shared.Stores.AzureStorage;
    public static class QueueHandler
    {
        public static QueueHandler<T> For<T>(IAzureQueue<T> queue) where T : AzureQueueMessage
        {
            return QueueHandler<T>.For(queue);
        }
    }
}