
WsHttpBinding 适用于互联网，客户端支持任意平台调用

有点
1.安全性高

缺点：
1.不支持回调


元数据发布,元数据发布有两种方式:
1.
<behaviors>
    <serviceBehaviors>
        <behavior name="mybeahavior">
            <serviceMetadata />
        </behavior>
    </serviceBehaviors>
</behaviors>

<endpoint address="mex" binding="mexHttpBinding" contract="IMetadataExchange"></endpoint>

http://localhost:port/mex
2.
<behaviors>
    <serviceBehaviors>
        <behavior name="mybeahavior">
            <serviceMetadata httpGetEnabled="true" />
        </behavior>
    </serviceBehaviors>
</behaviors>

对象管理
1.Single      只有一个实例，在服务端启动时创建
2.PreCall     每次调用，都创建新实例
3.PreSessoin  每个新回话，创建新实例

