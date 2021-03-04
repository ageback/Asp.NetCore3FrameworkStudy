﻿using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;

namespace helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            Host.CreateDefaultBuilder()
                .ConfigureWebHostDefaults(webHostBuilder => webHostBuilder
                    .UseUrls("http://0.0.0.0:3721;https://0.0.0.0:9527")
                    // 注册处理请求的中间件
                    .Configure(app => app.Run(
                        context => context.Response.WriteAsync("Hello World.")
                    )))
                    .Build()
                    .Run();
        }
    }
}
