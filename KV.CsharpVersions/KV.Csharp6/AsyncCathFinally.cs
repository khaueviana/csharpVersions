﻿using System;
using System.Threading.Tasks;

namespace KV.Csharp6
{
    public static class AsyncCathFinally
    {
        public static async void Execute()
        {
            ExampleAsyncClass obj = new ExampleAsyncClass();

            try
            {
                await obj.ExecuteAsync();
            }
            catch (Exception ex)
            {
                await obj.Error(ex);
            }
            finally
            {
                await obj.Finally();
            }
        }
    }

    public class ExampleAsyncClass
    {
        public async Task<int> ExecuteAsync()
        {
            int x = 10 + 1;

            return x;
        }

        public async Task<string> Error(Exception error)
        {
            return "Error";
        }

        public async Task<string> Finally()
        {
            return "Finally";
        }
    }
}
