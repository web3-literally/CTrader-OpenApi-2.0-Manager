using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Google.ProtocolBuffers;
namespace Open_API_Library
{
    public class OpenApiMessagesFactory
    {
        uint lastMessagePayloadType = 0;
        ByteString lastMessagePayload = null;

        #region Building Proto messages from Byte array methods
        public ProtoMessage GetMessage(byte[] msg)
        {
            var _msg = ProtoMessage.CreateBuilder().MergeFrom(msg).Build();
            lastMessagePayloadType = _msg.PayloadType;
            lastMessagePayload = _msg.Payload;
            return _msg;
        }
        public uint GetPayloadType(byte[] msg = null)
        {
            if (msg != null)
                GetMessage(msg);
            return lastMessagePayloadType;
        }
        public ByteString GetPayload(byte[] msg = null)
        {
            if (msg != null)
                GetMessage(msg);
            return lastMessagePayload;
        }
        //public ProtoOAPingReq GetPingRequest(byte[] msg = null)
        //{
        //    return ProtoOAPingReq.CreateBuilder().MergeFrom(GetPayload(msg)).Build();
        //}
        //public ProtoOAPingRes GetPingResponse(byte[] msg = null)
        //{
        //    return ProtoOAPingRes.CreateBuilder().MergeFrom(GetPayload(msg)).Build();
        //}
        public ProtoHeartbeatEvent GetHeartbeatEvent(byte[] msg = null)
        {
            return ProtoHeartbeatEvent.CreateBuilder().MergeFrom(GetPayload(msg)).Build();
        }
        public ProtoErrorRes GetErrorResponse(byte[] msg = null)
        {
            return ProtoErrorRes.CreateBuilder().MergeFrom(GetPayload(msg)).Build();
        }
        public ProtoOAApplicationAuthReq GetApplicationAuthorizationRequest(byte[] msg = null)
        {
            return ProtoOAApplicationAuthReq.CreateBuilder().MergeFrom(GetPayload(msg)).Build();
        }
        public ProtoOAApplicationAuthRes GetApplicationAuthorizationResponse(byte[] msg = null)
        {
             return ProtoOAApplicationAuthRes.CreateBuilder().MergeFrom(GetPayload(msg)).Build();
        }
        public ProtoOAAccountAuthReq GetAccountAuthorizationRequest(byte[] msg = null)
        {
            return ProtoOAAccountAuthReq.CreateBuilder().MergeFrom(GetPayload(msg)).Build();
        }
        public ProtoOAAccountAuthRes GetAccountAuthorizationResponse(byte[] msg = null)
        {
            return ProtoOAAccountAuthRes.CreateBuilder().MergeFrom(GetPayload(msg)).Build();
        }
        //public ProtoOASubscribeForTradingEventsReq GetSubscribeForTradingEventsRequest(byte[] msg = null)
        //{
        //    return ProtoOASubscribeForTradingEventsReq.CreateBuilder().MergeFrom(GetPayload(msg)).Build();
        //}
        //public ProtoOASubscribeForTradingEventsRes GetSubscribeForTradingEventsResponse(byte[] msg = null)
        //{
        //    return ProtoOASubscribeForTradingEventsRes.CreateBuilder().MergeFrom(GetPayload(msg)).Build();
        //}
        //public ProtoOAUnsubscribeFromTradingEventsReq GetUnsubscribeForTradingEventsRequest(byte[] msg = null)
        //{
        //    return ProtoOAUnsubscribeFromTradingEventsReq.CreateBuilder().MergeFrom(GetPayload(msg)).Build();
        //}
        //public ProtoOAUnsubscribeFromTradingEventsRes GetUnsubscribeForTradingEventsResponse(byte[] msg = null)
        //{
        //    return ProtoOAUnsubscribeFromTradingEventsRes.CreateBuilder().MergeFrom(GetPayload(msg)).Build();
        //}
        //public ProtoOAGetSubscribedAccountsReq GetAllSubscriptionsForTradingEventsRequest(byte[] msg = null)
        //{
        //    return ProtoOAGetSubscribedAccountsReq.CreateBuilder().MergeFrom(GetPayload(msg)).Build();
        //}
        //public ProtoOAGetSubscribedAccountsRes GetAllSubscriptionsForTradingEventsResponse(byte[] msg = null)
        //{
        //    return ProtoOAGetSubscribedAccountsRes.CreateBuilder().MergeFrom(GetPayload(msg)).Build();
        //}
        public ProtoOAExecutionEvent GetExecutionEvent(byte[] msg = null)
        {
            return ProtoOAExecutionEvent.CreateBuilder().MergeFrom(GetPayload(msg)).Build();
        }
        public ProtoOANewOrderReq GetCreateOrderRequest(byte[] msg = null)
        {
            return ProtoOANewOrderReq.CreateBuilder().MergeFrom(GetPayload(msg)).Build();
        }
        public ProtoOACancelOrderReq GetCancelOrderRequest(byte[] msg = null)
        {
            return ProtoOACancelOrderReq.CreateBuilder().MergeFrom(GetPayload(msg)).Build();
        }
        public ProtoOAClosePositionReq GetClosePositionRequest(byte[] msg = null)
        {
            return ProtoOAClosePositionReq.CreateBuilder().MergeFrom(GetPayload(msg)).Build();
        }
        public ProtoOAAmendPositionSLTPReq GetAmendPositionStopLossTakeProfitRequest(byte[] msg = null)
        {
            return ProtoOAAmendPositionSLTPReq.CreateBuilder().MergeFrom(GetPayload(msg)).Build();
        }
        public ProtoOAAmendOrderReq GetAmendOrderRequest(byte[] msg = null)
        {
            return ProtoOAAmendOrderReq.CreateBuilder().MergeFrom(GetPayload(msg)).Build();
        }
        public ProtoOASubscribeSpotsReq GetSubscribeForSpotsRequest(byte[] msg = null)
        {
            return ProtoOASubscribeSpotsReq.CreateBuilder().MergeFrom(GetPayload(msg)).Build();
        }
        public ProtoOASubscribeSpotsRes GetSubscribeForSpotsResponse(byte[] msg = null)
        {
            return ProtoOASubscribeSpotsRes.CreateBuilder().MergeFrom(GetPayload(msg)).Build();
        }
        //public ProtoOAGetSpotSubscriptionReq GetGetSpotSubscriptionRequest(byte[] msg = null)
        //{
        //    return ProtoOAGetSpotSubscriptionReq.CreateBuilder().MergeFrom(GetPayload(msg)).Build();
        //}
        //public ProtoOAGetSpotSubscriptionRes GetGetSpotSubscriptionResponse(byte[] msg = null)
        //{
        //    return ProtoOAGetSpotSubscriptionRes.CreateBuilder().MergeFrom(GetPayload(msg)).Build();
        //}
        //public ProtoOAGetAllSpotSubscriptionsReq GetGetAllSpotSubscriptionsRequest(byte[] msg = null)
        //{
        //    return ProtoOAGetAllSpotSubscriptionsReq.CreateBuilder().MergeFrom(GetPayload(msg)).Build();
        //}
        //public ProtoOAGetAllSpotSubscriptionsRes GetGetAllSpotSubscriptionsResponse(byte[] msg = null)
        //{
        //    return ProtoOAGetAllSpotSubscriptionsRes.CreateBuilder().MergeFrom(GetPayload(msg)).Build();
        //}
        public ProtoOASpotEvent GetSpotEvent(byte[] msg = null)
        {
            return ProtoOASpotEvent.CreateBuilder().MergeFrom(GetPayload(msg)).Build();
        }
        #endregion

        #region Creating new Proto messages with parameters specified
        public ProtoMessage CreateMessage(uint payloadType, ByteString payload = null, string clientMsgId = null)
        {
            var protoMsg = ProtoMessage.CreateBuilder();
            protoMsg.PayloadType = payloadType;
            if (payload != null)
                protoMsg.SetPayload(payload);
            if (clientMsgId != null)
                protoMsg.SetClientMsgId(clientMsgId);

            return protoMsg.Build();
        }
        public ProtoMessage CreateMessage(ProtoMessage.Builder messageBuilder, string clientMsgId = null)
        {
            return CreateMessage(messageBuilder.PayloadType, messageBuilder.Build().ToByteString(), clientMsgId);
        }
      
        public ProtoMessage CreateVersionRequest(string clientMsgId = null)
        {
            var _msg = ProtoOAVersionReq.CreateBuilder();
            return CreateMessage((uint)_msg.PayloadType, _msg.Build().ToByteString(), clientMsgId);
        }
        public ProtoMessage CreateVersionResponse(string clientMsgId = null)
        {
            return CreateMessage((uint)ProtoOAPayloadType.PROTO_OA_VERSION_RES, ProtoOAApplicationAuthRes.CreateBuilder().Build().ToByteString(), clientMsgId);
        }
        public ProtoMessage CreateHeartbeatEvent(string clientMsgId = null)
        {
            return CreateMessage((uint)ProtoPayloadType.HEARTBEAT_EVENT, ProtoHeartbeatEvent.CreateBuilder().Build().ToByteString(), clientMsgId);
        }
        public ProtoMessage CreateAppAuthorizationRequest(string clientId, string clientSecret, string clientMsgId = null)
        {
            var _msg = ProtoOAApplicationAuthReq.CreateBuilder();
            _msg.SetClientId(clientId);
            _msg.SetClientSecret(clientSecret);
            return CreateMessage((uint)_msg.PayloadType, _msg.Build().ToByteString(), clientMsgId);
        }
        public ProtoMessage CreateAppAuthorizationResponse(string clientMsgId = null)
        {
            return CreateMessage((uint)ProtoOAPayloadType.PROTO_OA_APPLICATION_AUTH_RES, ProtoOAApplicationAuthRes.CreateBuilder().Build().ToByteString(), clientMsgId);
        }
        public ProtoMessage CreateAccAuthorizationRequest(string token, long accountId, string clientMsgId = null)
        {
            var _msg = ProtoOAAccountAuthReq.CreateBuilder();
            _msg.SetAccessToken(token);
            _msg.SetCtidTraderAccountId(accountId);            
            return CreateMessage((uint)_msg.PayloadType, _msg.Build().ToByteString(), clientMsgId);
        }   
        public ProtoMessage CreateAccAuthorizationResponse(string clientMsgId = null)
        {
            return CreateMessage((uint)ProtoOAPayloadType.PROTO_OA_ACCOUNT_AUTH_RES, ProtoOAAccountAuthRes.CreateBuilder().Build().ToByteString(), clientMsgId);
        }
        public ProtoMessage CreateAssetClassListRequest(long accountId, string clientMsgId = null)
        {
            var _msg = ProtoOAAssetClassListReq.CreateBuilder();
            _msg.SetCtidTraderAccountId(accountId);
            return CreateMessage((uint)_msg.PayloadType, _msg.Build().ToByteString(), clientMsgId);
        }
        
        public ProtoMessage CreateAssetClassListResponse(string clientMsgId = null)
        {
            return CreateMessage((uint)ProtoOAPayloadType.PROTO_OA_ASSET_LIST_RES, ProtoOAApplicationAuthRes.CreateBuilder().Build().ToByteString(), clientMsgId);
        }
        public ProtoMessage CreateDealsListRequest(long accountId, long from,long to, string clientMsgId = null)
        {
            var _msg = ProtoOADealListReq.CreateBuilder();            
            _msg.SetCtidTraderAccountId(accountId);
            _msg.SetFromTimestamp(from);
            _msg.SetToTimestamp(to);
            return CreateMessage((uint)_msg.PayloadType, _msg.Build().ToByteString(), clientMsgId);
        }
        public ProtoMessage CreateDealsListResponse(string clientMsgId = null)
        {
            return CreateMessage((uint)ProtoOAPayloadType.PROTO_OA_DEAL_LIST_RES, ProtoOADealListRes.CreateBuilder().Build().ToByteString(), clientMsgId);
        }
        public ProtoMessage CreateReconcileRequest(long accountId, string clientMsgId = null)
        {
            var _msg = ProtoOAReconcileReq.CreateBuilder();
            _msg.SetCtidTraderAccountId(accountId);
            return CreateMessage((uint)_msg.PayloadType, _msg.Build().ToByteString(), clientMsgId);
        }
        public ProtoMessage CreateReconcileResponse(string clientMsgId = null)
        {
            return CreateMessage((uint)ProtoOAPayloadType.PROTO_OA_RECONCILE_RES, ProtoOAReconcileRes.CreateBuilder().Build().ToByteString(), clientMsgId);
        }
        public ProtoMessage CreateCashflowHistoryRequest(long accountId, long from,long to, string clientMsgId = null)
        {
            var _msg = ProtoOACashFlowHistoryListReq.CreateBuilder();
            _msg.SetCtidTraderAccountId(accountId);
            _msg.SetFromTimestamp(from);
            _msg.SetToTimestamp(to);
            return CreateMessage((uint)_msg.PayloadType, _msg.Build().ToByteString(), clientMsgId);
        }
        public ProtoMessage CreateCashflowHistoryResponse(string clientMsgId = null)
        {
            return CreateMessage((uint)ProtoOAPayloadType.PROTO_OA_CASH_FLOW_HISTORY_LIST_RES, ProtoOACashFlowHistoryListRes.CreateBuilder().Build().ToByteString(), clientMsgId);
        }
        public ProtoMessage CreateAccountListRequest(string token, string clientMsgId = null)
        {
            var _msg = ProtoOAGetAccountListByAccessTokenReq.CreateBuilder();
            _msg.SetAccessToken(token);   
            return CreateMessage((uint)_msg.PayloadType, _msg.Build().ToByteString(), clientMsgId);
        }
        public ProtoMessage CreateAccountListResponse(string clientMsgId = null)
        {
            return CreateMessage((uint)ProtoOAPayloadType.PROTO_OA_GET_ACCOUNTS_BY_ACCESS_TOKEN_RES, ProtoOAGetAccountListByAccessTokenRes.CreateBuilder().Build().ToByteString(), clientMsgId);
        }
        public ProtoMessage CreateTraderRequest(long accountID, string clientMsgId = null)
        {
            var _msg = ProtoOATraderReq.CreateBuilder();
            _msg.SetCtidTraderAccountId(accountID);
            return CreateMessage((uint)_msg.PayloadType, _msg.Build().ToByteString(), clientMsgId);
        }
        public ProtoMessage CreateTraderResponse(string clientMsgId = null)
        {
            return CreateMessage((uint)ProtoOAPayloadType.PROTO_OA_TRADER_RES, ProtoOATraderRes.CreateBuilder().Build().ToByteString(), clientMsgId);
        }
        public ProtoMessage CreateSymbolsListRequest(long accountId, string clientMsgId = null)
        {
            var _msg = ProtoOASymbolsListReq.CreateBuilder();
            _msg.SetCtidTraderAccountId(accountId);
            return CreateMessage((uint)_msg.PayloadType, _msg.Build().ToByteString(), clientMsgId);
        }
        public ProtoMessage CreateSymbolsListResponse(string clientMsgId = null)
        {
            return CreateMessage((uint)ProtoOAPayloadType.PROTO_OA_SYMBOLS_LIST_RES, ProtoOASymbolsListRes.CreateBuilder().Build().ToByteString(), clientMsgId);
        }
        public ProtoMessage CreateSymbolByIdRequest(long accountId, string clientMsgId = null)
        {
            var _msg = ProtoOASymbolByIdReq.CreateBuilder();
            _msg.SetCtidTraderAccountId(accountId);
            _msg.AddSymbolId(1);
            _msg.AddSymbolId(2);
            _msg.AddSymbolId(3);
            return CreateMessage((uint)_msg.PayloadType, _msg.Build().ToByteString(), clientMsgId);
        }
        public ProtoMessage CreateSymbolsListRes(string clientMsgId = null)
        {
            return CreateMessage((uint)ProtoOAPayloadType.PROTO_OA_SYMBOL_BY_ID_RES, ProtoOASymbolByIdRes.CreateBuilder().Build().ToByteString(), clientMsgId);
        }
        public ProtoMessage CreateTrendbarsRequest(long accountId, int symbolId, long from, long to, ProtoOATrendbarPeriod period, string clientMsgId = null)
        {
            var _msg = ProtoOAGetTrendbarsReq.CreateBuilder();
            _msg.SetCtidTraderAccountId(accountId);
            _msg.SetSymbolId(symbolId);
            _msg.SetFromTimestamp(from);
            _msg.SetToTimestamp(to);
            _msg.SetPeriod(period);
            return CreateMessage((uint)_msg.PayloadType, _msg.Build().ToByteString(), clientMsgId);
        }
        public ProtoMessage CreateTrendbarsResponse(string clientMsgId = null)
        {
            return CreateMessage((uint)ProtoOAPayloadType.PROTO_OA_GET_TRENDBARS_RES, ProtoOAGetTrendbarsRes.CreateBuilder().Build().ToByteString(), clientMsgId);
        }
        public ProtoMessage CreateTickDataRequest(long accountId, int symbolId, long from, long to, ProtoOAQuoteType type, string clientMsgId = null)
        {            
            var _msg = ProtoOAGetTickDataReq.CreateBuilder();
            _msg.SetCtidTraderAccountId(accountId);
            _msg.SetSymbolId(symbolId);
            _msg.SetType(type);
            _msg.SetFromTimestamp(from);
            _msg.SetToTimestamp(to);
            return CreateMessage((uint)_msg.PayloadType, _msg.Build().ToByteString(), clientMsgId);
        }
        public ProtoMessage CreateTickDataResponse(string clientMsgId = null)
        {
            return CreateMessage((uint)ProtoOAPayloadType.PROTO_OA_GET_TICKDATA_RES, ProtoOAGetTickDataRes.CreateBuilder().Build().ToByteString(), clientMsgId);
        }
        public ProtoMessage CreateExecutionEvent(ProtoOAExecutionType executionType, ProtoOAOrder order, ProtoOAPosition position = null, string reasonCode = null, string clientMsgId = null)
        {
            var _msg = ProtoOAExecutionEvent.CreateBuilder();
            _msg.SetExecutionType(executionType);
            _msg.SetOrder(order);
            if (position != null)
                _msg.SetPosition(position);
            return CreateMessage((uint)_msg.PayloadType, _msg.Build().ToByteString(), clientMsgId);
        }
        public ProtoMessage CreateExecutionEvent(ProtoOAExecutionType executionType, ProtoOAOrder.Builder order, ProtoOAPosition.Builder position = null, string reasonCode = null, string clientMsgId = null)
        {
            return CreateExecutionEvent(executionType, order.Build(), position == null ? null : position.Build(), reasonCode, clientMsgId);
        }
        public ProtoMessage CreateMarketOrderRequest(long accountId, string accessToken, int symbolId, ProtoOATradeSide tradeSide, long volume, string label = null, string clientMsgId = null)
        {
            var _msg = ProtoOANewOrderReq.CreateBuilder();
            _msg.SetCtidTraderAccountId(accountId);
            _msg.SetSymbolId(symbolId);
            _msg.SetOrderType(ProtoOAOrderType.MARKET);
            _msg.SetTradeSide(tradeSide);
            _msg.SetVolume(volume);
            _msg.SetComment("TradingApiTest.CreateMarketOrderRequest");
            if (!string.IsNullOrEmpty(label)) _msg.SetLabel(label);
            return CreateMessage((uint)_msg.PayloadType, _msg.Build().ToByteString(), clientMsgId);
        }
        public ProtoMessage CreateMarketRangeOrderRequest(long accountId, string accessToken, int symbolId, ProtoOATradeSide tradeSide, long volume, double baseSlippagePrice, int slippageInPoints, string label = null, string clientMsgId = null)
        {
            var _msg = ProtoOANewOrderReq.CreateBuilder(); ;
            _msg.SetCtidTraderAccountId(accountId);
            _msg.SetSymbolId(symbolId);
            _msg.SetOrderType(ProtoOAOrderType.MARKET_RANGE);
            _msg.SetTradeSide(tradeSide);
            _msg.SetVolume(volume);
            _msg.SetBaseSlippagePrice(baseSlippagePrice);
            _msg.SetSlippageInPoints(slippageInPoints);
            _msg.SetComment("TradingApiTest.CreateMarketRangeOrderRequest");
            if (!string.IsNullOrEmpty(label)) _msg.SetLabel(label);
            return CreateMessage((uint)_msg.PayloadType, _msg.Build().ToByteString(), clientMsgId);
        }
        public ProtoMessage CreateLimitOrderRequest(long accountId, string accessToken, int symbolId, ProtoOATradeSide tradeSide, long volume, double limitPrice, double takeProfitPrice, double stopLossPrice, string label = null, string clientMsgId = null)
        {
            var _msg = ProtoOANewOrderReq.CreateBuilder(); ;
            _msg.SetCtidTraderAccountId(accountId);
            _msg.SetSymbolId(symbolId);
            _msg.SetOrderType(ProtoOAOrderType.LIMIT);
            _msg.SetTradeSide(tradeSide);
            _msg.SetVolume(volume);
            _msg.SetLimitPrice(limitPrice);
            if (takeProfitPrice > 0) _msg.SetTakeProfit(takeProfitPrice);
            if (stopLossPrice > 0) _msg.SetStopLoss(stopLossPrice);
            _msg.SetComment("TradingApiTest.CreateLimitOrderRequest");
            if (!string.IsNullOrEmpty(label)) _msg.SetLabel(label);
            return CreateMessage((uint)_msg.PayloadType, _msg.Build().ToByteString(), clientMsgId);
        }
        public ProtoMessage CreateStopOrderRequest(long accountId, string accessToken, int symbolId, ProtoOATradeSide tradeSide, long volume, double stopPrice, double takeProfitPrice, double stopLossPrice, string label = null, string clientMsgId = null)
        {
            var _msg = ProtoOANewOrderReq.CreateBuilder(); 
            _msg.SetCtidTraderAccountId(accountId);
            _msg.SetSymbolId(symbolId);
            _msg.SetOrderType(ProtoOAOrderType.STOP);
            _msg.SetTradeSide(tradeSide);
            _msg.SetVolume(volume);
            _msg.SetStopPrice(stopPrice);
            if (takeProfitPrice > 0) _msg.SetTakeProfit(takeProfitPrice);
            if (stopLossPrice > 0) _msg.SetStopLoss(stopLossPrice);
            _msg.SetComment("TradingApiTest.CreateStopOrderRequest");
            if (!string.IsNullOrEmpty(label)) _msg.SetLabel(label);
            return CreateMessage((uint)_msg.PayloadType, _msg.Build().ToByteString(), clientMsgId);
        }
        public ProtoMessage CreateStopLimitOrderRequest(long accountId, string accessToken, int symbolId, ProtoOATradeSide tradeSide, long volume, double stopPrice, int slippageInPoints, double takeProfitPrice, double stopLossPrice, string label = null, string clientMsgId = null)
        {
            var _msg = ProtoOANewOrderReq.CreateBuilder(); ;
            _msg.SetCtidTraderAccountId(accountId);
            _msg.SetSymbolId(symbolId);
            _msg.SetOrderType(ProtoOAOrderType.STOP_LIMIT);
            _msg.SetTradeSide(tradeSide);
            _msg.SetVolume(volume);
            _msg.SetSlippageInPoints(slippageInPoints);
            _msg.SetStopPrice(stopPrice);
            if (takeProfitPrice > 0) _msg.SetTakeProfit(takeProfitPrice);
            if (stopLossPrice > 0) _msg.SetStopLoss(stopLossPrice);
            _msg.SetComment("TradingApiTest.CreateStopLimitOrderRequest");
            if (!string.IsNullOrEmpty(label)) _msg.SetLabel(label);
            return CreateMessage((uint)_msg.PayloadType, _msg.Build().ToByteString(), clientMsgId);
        }
        public ProtoMessage CreateCancelOrderRequest(long accountId, string accessToken, long orderId, string clientMsgId = null)
        {
            var _msg = ProtoOACancelOrderReq.CreateBuilder();
            _msg.SetCtidTraderAccountId(accountId);
            _msg.SetOrderId(orderId);
            return CreateMessage((uint)_msg.PayloadType, _msg.Build().ToByteString(), clientMsgId);
        }
        public ProtoMessage CreateClosePositionRequest(long accountId, string accessToken, long positionId, long volume, string clientMsgId = null)
        {
            var _msg = ProtoOAClosePositionReq.CreateBuilder();
            _msg.SetCtidTraderAccountId(accountId);
            _msg.SetPositionId(positionId);
            _msg.SetVolume(volume);
            return CreateMessage((uint)_msg.PayloadType, _msg.Build().ToByteString(), clientMsgId);
        }
        public ProtoMessage CreateAmendPositionStopLossRequest(long accountId, string accessToken, long positionId, double stopLossPrice, string clientMsgId = null)
        {
            var _msg = ProtoOAAmendPositionSLTPReq.CreateBuilder();
            _msg.SetCtidTraderAccountId(accountId);
            _msg.SetPositionId(positionId);
            _msg.SetStopLoss(stopLossPrice);
            return CreateMessage((uint)_msg.PayloadType, _msg.Build().ToByteString(), clientMsgId);
        }
        
        public ProtoMessage CreateAmendPositionTakeProfitRequest(long accountId, string accessToken, long positionId, double takeProfitPrice, string clientMsgId = null)
        {
            var _msg = ProtoOAAmendPositionSLTPReq.CreateBuilder();
            _msg.SetCtidTraderAccountId(accountId);
            _msg.SetPositionId(positionId);
            _msg.SetTakeProfit(takeProfitPrice);
            return CreateMessage((uint)_msg.PayloadType, _msg.Build().ToByteString(), clientMsgId);
        }
        public ProtoMessage CreateAmendPositionStopLossTakeProfitRequest(long accountId, string accessToken, long positionId, double stopLossPrice, double takeProfitPrice, string clientMsgId = null)
        {
            var _msg = ProtoOAAmendPositionSLTPReq.CreateBuilder();
            _msg.SetCtidTraderAccountId(accountId);
            _msg.SetPositionId(positionId);
            if (stopLossPrice > 0) _msg.SetStopLoss(stopLossPrice);
            if (takeProfitPrice > 0) _msg.SetTakeProfit(takeProfitPrice);
            return CreateMessage((uint)_msg.PayloadType, _msg.Build().ToByteString(), clientMsgId);
        }
        public ProtoMessage CreateAmendPositionProtectionRequest(long accountId, string accessToken, long positionId, double stopLossPrice, double takeProfitPrice, string clientMsgId = null)
        {
            var _msg = ProtoOAAmendPositionSLTPReq.CreateBuilder();
            _msg.SetCtidTraderAccountId(accountId);
            _msg.SetPositionId(positionId);
            _msg.SetStopLoss(stopLossPrice);
            _msg.SetTakeProfit(takeProfitPrice);
            return CreateMessage((uint)_msg.PayloadType, _msg.Build().ToByteString(), clientMsgId);
        }
        public ProtoMessage CreateAmendLimitOrderRequest(long accountId, string accessToken, long orderId, double limitPrice, double takeProfit = 0, double stopLoss = 0, string clientMsgId = null)
        {
            var _msg = ProtoOAAmendOrderReq.CreateBuilder();
            _msg.SetCtidTraderAccountId(accountId);
            _msg.SetOrderId(orderId);
            _msg.SetLimitPrice(limitPrice);
            if (takeProfit > 0) _msg.SetTakeProfit(takeProfit);
            if (stopLoss > 0) _msg.SetStopLoss(stopLoss);
            return CreateMessage((uint)_msg.PayloadType, _msg.Build().ToByteString(), clientMsgId);
        }
        public ProtoMessage CreateAmendStopOrderRequest(long accountId, string accessToken, long orderId, double stopPrice, double takeProfit = 0, double stopLoss = 0, string clientMsgId = null)
        {
            var _msg = ProtoOAAmendOrderReq.CreateBuilder();
            _msg.SetCtidTraderAccountId(accountId);
            _msg.SetOrderId(orderId);
            _msg.SetStopPrice(stopPrice);
            if (takeProfit > 0) _msg.SetTakeProfit(takeProfit);
            if (stopLoss > 0) _msg.SetStopLoss(stopLoss);
            return CreateMessage((uint)_msg.PayloadType, _msg.Build().ToByteString(), clientMsgId);
        }
        
        public ProtoMessage CreateSubscribeForSpotsRequest(long accountId, int symbolId, string clientMsgId = null)
        {
            var _msg = ProtoOASubscribeSpotsReq.CreateBuilder();
            _msg.SetCtidTraderAccountId(accountId);
            _msg.AddSymbolId(symbolId);
            return CreateMessage((uint)_msg.PayloadType, _msg.Build().ToByteString(), clientMsgId);
        }
        public ProtoMessage CreateSubscribeForSpotsResponse(uint accountId, string clientMsgId = null)
        {
            var _msg = ProtoOASubscribeSpotsRes.CreateBuilder();
            _msg.SetCtidTraderAccountId(accountId);
            return CreateMessage((uint)_msg.PayloadType, _msg.Build().ToByteString(), clientMsgId);
        }
        public ProtoMessage CreateUnsubscribeFromSpotsRequest(long accountId,int symbolId, string clientMsgId = null)
        {
            var _msg = ProtoOAUnsubscribeSpotsReq.CreateBuilder();
            _msg.SetCtidTraderAccountId(accountId);
            _msg.AddSymbolId(symbolId);
            return CreateMessage((uint)_msg.PayloadType, _msg.Build().ToByteString(), clientMsgId);
        }
        #endregion

        #region Creating new Proto messages Builders
        //public ProtoOAGetAllSpotSubscriptionsRes.Builder CreateGetAllSpotSubscriptionsResponseBuilder(string clientMsgId = null)
        //{
        //    return ProtoOAGetAllSpotSubscriptionsRes.CreateBuilder();
        //}
        public ProtoOASpotEvent.Builder CreateSpotEventBuilder(uint subscriptionId, string symbolName, string clientMsgId = null)
        {
            return ProtoOASpotEvent.CreateBuilder();
        }
        #endregion
    }
}
