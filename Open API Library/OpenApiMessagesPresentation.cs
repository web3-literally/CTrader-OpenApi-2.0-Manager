using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Google.ProtocolBuffers;

namespace Connect_API.Trading
{
    public class OpenApiMessagesPresentation
    {
        static string ProtoMessageToString(ProtoMessage msg)
        {
            if (!msg.HasPayload)
                return "ERROR in ProtoMessage: Corrupted execution event, no payload found";
            var _str = "ProtoMessage{";
           switch ((ProtoPayloadType)msg.PayloadType)
            {
                case ProtoPayloadType.PROTO_MESSAGE:
                    var _msg = ProtoMessage.CreateBuilder().MergeFrom(msg.Payload).Build();
                    _str += ProtoMessageToString(_msg);
                    break;
            
                case ProtoPayloadType.HEARTBEAT_EVENT:
                    var _hb = ProtoHeartbeatEvent.CreateBuilder().MergeFrom(msg.Payload).Build();
                    _str += "Heartbeat";
                    break;
                case ProtoPayloadType.ERROR_RES:
                    var _err = ProtoErrorRes.CreateBuilder().MergeFrom(msg.Payload).Build();
                    _str += "ErrorResponse{errorCode:" + _err.ErrorCode + (_err.HasDescription ? ", description:" + _err.Description : "") + "}";
                    break;            
                default:
                    _str += OpenApiMessageToString(msg);
                    break;
            }
         
            _str += (msg.HasClientMsgId ? ", clientMsgId:" + msg.ClientMsgId : "") + "}";

            return _str;
        }
        static string OpenApiMessageToString(ProtoMessage msg)
        {
            switch ((ProtoOAPayloadType)msg.PayloadType)
            {
                case ProtoOAPayloadType.PROTO_OA_APPLICATION_AUTH_REQ:
                    var app_auth_req = ProtoOAApplicationAuthReq.CreateBuilder().MergeFrom(msg.Payload).Build();
                    return "AppAuthRequest{clientId:" + app_auth_req.ClientId + ", clientSecret:" + app_auth_req.ClientSecret + "}";
                case ProtoOAPayloadType.PROTO_OA_APPLICATION_AUTH_RES:
                    return "ApAuthResponse";
                case ProtoOAPayloadType.PROTO_OA_ACCOUNT_AUTH_REQ:
                    var acc_auth_req = ProtoOAAccountAuthReq.CreateBuilder().MergeFrom(msg.Payload).Build();
                    return "AccAuthRequest{CtidTraderAccountId:" + acc_auth_req.CtidTraderAccountId + "}";
                case ProtoOAPayloadType.PROTO_OA_ACCOUNT_AUTH_RES:
                    return "AccAuthResponse";
                case ProtoOAPayloadType.PROTO_OA_GET_ACCOUNTS_BY_ACCESS_TOKEN_REQ:
                    return "GetAccountsByAccessTokenReq";
                case ProtoOAPayloadType.PROTO_OA_GET_ACCOUNTS_BY_ACCESS_TOKEN_RES:
                    var accounts_list = ProtoOAGetAccountListByAccessTokenRes.CreateBuilder().MergeFrom(msg.Payload).Build();
                    var sbAccounts = new StringBuilder();
                    foreach (var account in accounts_list.CtidTraderAccountList)
                    {
                        sbAccounts.Append("ID: " + account.CtidTraderAccountId + (account.IsLive ? " Status: Live" + Environment.NewLine : " Status: Demo "+ Environment.NewLine));                       
                    }
                        return "GetAccountsByAccessTokenRes{" + sbAccounts.ToString() + "}";
                case ProtoOAPayloadType.PROTO_OA_TRADER_REQ:
                    return "PotoOATraderReq";
                case ProtoOAPayloadType.PROTO_OA_SYMBOLS_LIST_REQ:
                    return "GetSymbolsList";
                case ProtoOAPayloadType.PROTO_OA_SYMBOLS_LIST_RES:
                    var symbols_list = ProtoOASymbolsListRes.CreateBuilder().MergeFrom(msg.Payload).Build();
                    var sbSymbols = new StringBuilder();
                    foreach (var symbol in symbols_list.SymbolList)
                    {
                        sbSymbols.Append("ID: " + symbol.SymbolId + Environment.NewLine);
                        sbSymbols.Append("Name: " + symbol.SymbolName + Environment.NewLine);
                    }
                    return "Symbols{" + sbSymbols.ToString() + "}";
                case ProtoOAPayloadType.PROTO_OA_SYMBOL_BY_ID_REQ:
                    return "GetSymbolsById";
                case ProtoOAPayloadType.PROTO_OA_SYMBOL_BY_ID_RES:
                    var symbol_by_id_list = ProtoOASymbolByIdRes.CreateBuilder().MergeFrom(msg.Payload).Build();
                    var sbSymbolByID = new StringBuilder();
                    foreach (var symbol in symbol_by_id_list.SymbolList)
                    {
                        sbSymbolByID.Append("ID: " + symbol.SymbolId + Environment.NewLine);
                    }
                    return "Symbols{" + sbSymbolByID.ToString() + "}";
                case ProtoOAPayloadType.PROTO_OA_EXECUTION_EVENT:
                    return OpenApiExecEventsToString(msg);
                case ProtoOAPayloadType.PROTO_OA_DEAL_LIST_REQ:
                    return "DealListRequest{}";
                case ProtoOAPayloadType.PROTO_OA_DEAL_LIST_RES:
                    var deal_list = ProtoOADealListRes.CreateBuilder().MergeFrom(msg.Payload).Build();
                    var sbDeals = new StringBuilder();
                    foreach (var deal in deal_list.DealList)
                    {
                        sbDeals.Append("ID: " + deal.DealId + Environment.NewLine);
                        sbDeals.Append("Status: " + deal.DealStatus + Environment.NewLine);
                        sbDeals.Append("Volume: " + deal.Volume + Environment.NewLine);
                    }
                    return "DealList{"+ sbDeals.ToString()+"}";
                case ProtoOAPayloadType.PROTO_OA_RECONCILE_REQ:
                    return "ReconcileRequest{}";
                case ProtoOAPayloadType.PROTO_OA_RECONCILE_RES:
                    var reconcile_response = ProtoOAReconcileRes.CreateBuilder().MergeFrom(msg.Payload).Build();
                    var sbReconcile = new StringBuilder();
                    foreach (var order in reconcile_response.OrderList)
                    {
                        sbReconcile.Append("ID: " + order.OrderId + Environment.NewLine);
                        sbReconcile.Append("Status: " + order.OrderStatus + Environment.NewLine);
                        sbReconcile.Append("Volume: " + order.TradeData.Volume + Environment.NewLine);
                    }
                    foreach (var position in reconcile_response.PositionList)
                    {
                        sbReconcile.Append("ID: " + position.HasPositionId + Environment.NewLine);
                        sbReconcile.Append("Status: " + position.PositionStatus + Environment.NewLine);
                        sbReconcile.Append("Volume: " + position.TradeData.Volume + Environment.NewLine);
                    }
                    return "ReconcileList{" + sbReconcile.ToString() + "}";
                case ProtoOAPayloadType.PROTO_OA_CASH_FLOW_HISTORY_LIST_REQ:
                    return "CashFlowHistoryRequest{}";
                case ProtoOAPayloadType.PROTO_OA_CASH_FLOW_HISTORY_LIST_RES:
                    var cashflow_history = ProtoOACashFlowHistoryListRes.CreateBuilder().MergeFrom(msg.Payload).Build();
                    var sbDCashflow = new StringBuilder();
                    foreach (var entry in cashflow_history.DepositWithdrawList)
                    {
                        sbDCashflow.Append("ID: " + entry.BalanceHistoryId + Environment.NewLine);
                        sbDCashflow.Append("Type: " + entry.OperationType + Environment.NewLine);
                        sbDCashflow.Append("Delta: " + entry.Delta + Environment.NewLine);
                    }
                    return "CashFlowHistory{" + sbDCashflow.ToString() + "}";
                case ProtoOAPayloadType.PROTO_OA_GET_TRENDBARS_REQ:
                    return "GetTrendbarsRequest{}";
                case ProtoOAPayloadType.PROTO_OA_GET_TRENDBARS_RES:
                    var trendbar = ProtoOAGetTrendbarsRes.CreateBuilder().MergeFrom(msg.Payload).Build();
                    var sbTrendbar = new StringBuilder();
                    foreach (var entry in trendbar.TrendbarList)
                    {
                        sbTrendbar.Append("Open: " + entry.DeltaOpen + Environment.NewLine);
                        sbTrendbar.Append("High: " + entry.DeltaHigh + Environment.NewLine);
                        sbTrendbar.Append("Low: " + entry.Low + Environment.NewLine);
                        sbTrendbar.Append("Close: " + entry.DeltaClose + Environment.NewLine);
                        sbTrendbar.Append("Timestamp: " + entry.UtcTimestampInMinutes + Environment.NewLine);
                    }
                    return "Trendbars{" + sbTrendbar.ToString() + "}";
                case ProtoOAPayloadType.PROTO_OA_GET_TICKDATA_REQ:
                    return "GetTickDataRequest{}";
                case ProtoOAPayloadType.PROTO_OA_GET_TICKDATA_RES:
                    var tickData = ProtoOAGetTickDataRes.CreateBuilder().MergeFrom(msg.Payload).Build();
                    var sbTickData = new StringBuilder();
                    foreach (var entry in tickData.TickDataList)
                    {
                        sbTickData.Append("Tick: " + entry.Tick + " " + msg.ClientMsgId + Environment.NewLine);
                        sbTickData.Append("Timestamp: " + entry.Timestamp + Environment.NewLine);
                    }
                    return "Tick Data{" + sbTickData.ToString() + "}";
                case ProtoOAPayloadType.PROTO_OA_CANCEL_ORDER_REQ:
                    return "CancelOrderRequest{}";
                case ProtoOAPayloadType.PROTO_OA_NEW_ORDER_REQ:                                  
                    return "CreateOrderRequest{}";
                case ProtoOAPayloadType.PROTO_OA_CLOSE_POSITION_REQ:
                    return "ClosePositionRequest{}";
                case ProtoOAPayloadType.PROTO_OA_AMEND_ORDER_REQ:
                    return "AmendOrderRequest{}";
                case ProtoOAPayloadType.PROTO_OA_AMEND_POSITION_SLTP_REQ:
                    return "AmendPositionRequest{}";
                case ProtoOAPayloadType.PROTO_OA_SUBSCRIBE_SPOTS_REQ:
                    return "SubscribeForSpotsRequest{}";
                case ProtoOAPayloadType.PROTO_OA_SUBSCRIBE_SPOTS_RES:
                    return "SubscribeForSpotsResponse{}";
                case ProtoOAPayloadType.PROTO_OA_UNSUBSCRIBE_SPOTS_REQ:
                    return "UnsubscribeFromSpotsRequest{}";
                case ProtoOAPayloadType.PROTO_OA_UNSUBSCRIBE_SPOTS_RES:
                    return "UnsubscribeFromSpotsResponse{}";
                case ProtoOAPayloadType.PROTO_OA_SPOT_EVENT:
                    var _spot_event = ProtoOASpotEvent.CreateBuilder().MergeFrom(msg.Payload).Build();
                    return "SpotEvent{symbolId:" + _spot_event.SymbolId + ", bidPrice:" + (_spot_event.HasBid ? _spot_event.Bid.ToString() : "       ") + ", askPrice:" + (_spot_event.HasAsk ? _spot_event.Ask.ToString() : "       ") + "}";
                case ProtoOAPayloadType.PROTO_OA_ERROR_RES:
                    var _err = ProtoOAErrorRes.CreateBuilder().MergeFrom(msg.Payload).Build();                    
                    return "ErrorResponse{errorCode:" + _err.ErrorCode + (_err.HasDescription ? ", description:" + _err.Description : "") + "}";
                case ProtoOAPayloadType.PROTO_OA_ORDER_ERROR_EVENT:
                    var _orderErr = ProtoOAOrderErrorEvent.CreateBuilder().MergeFrom(msg.Payload).Build();
                    return "OrderErrorResponse{errorCode:" + _orderErr.ErrorCode + (_orderErr.HasDescription ? ", description:" + _orderErr.Description : "") + "}";
                default:
                    return "unknown";
            }
        }
        static string OpenApiExecutionTypeToString(ProtoOAExecutionType executionType)
        {
            switch (executionType)
            {
                case ProtoOAExecutionType.ORDER_ACCEPTED:
                    return "OrderAccepted";
                case ProtoOAExecutionType.ORDER_REPLACED:
                    return "OrderAmended";
                case ProtoOAExecutionType.ORDER_CANCEL_REJECTED:
                    return "OrderCancelRejected";
                case ProtoOAExecutionType.ORDER_CANCELLED:
                    return "OrderCancelled";
                case ProtoOAExecutionType.ORDER_EXPIRED:
                    return "OrderExpired";
                case ProtoOAExecutionType.ORDER_FILLED:
                    return "OrderFilled";
                case ProtoOAExecutionType.ORDER_REJECTED:
                    return "OrderRejected";
                default:
                    return "unknown";
            }
        }
        static string OpenApiExecEventsToString(ProtoMessage msg)
        {
            if ((ProtoOAPayloadType)msg.PayloadType != ProtoOAPayloadType.PROTO_OA_EXECUTION_EVENT)
                return "ERROR in OpenApiExecutionEvents: Wrong message type";

            if (!msg.HasPayload)
                return "ERROR in OpenApiExecutionEvents: Corrupted execution event, no payload found";

            var _msg = ProtoOAExecutionEvent.CreateBuilder().MergeFrom(msg.Payload).Build();
            var _str = OpenApiExecutionTypeToString(_msg.ExecutionType) + "{" +
                OpenApiOrderToString(_msg.Order) +
                (_msg.HasPosition ? ", " + OpenApiPositionToString(_msg.Position) : "") +
                (_msg.HasErrorCode ? ", errorCode:" + _msg.ErrorCode : "");

            return _str + "}";
        }
        static public string OpenApiOrderTypeToString(ProtoOAOrderType orderType)
        {
            switch (orderType)
            {
                case ProtoOAOrderType.LIMIT:
                    return "LIMIT";
                case ProtoOAOrderType.MARKET:
                    return "MARKET";
                case ProtoOAOrderType.MARKET_RANGE:
                    return "MARKET RANGE";                
                case ProtoOAOrderType.STOP:
                    return "STOP";
                default:
                    return "unknown";
            }
        }
        static public string TradeSideToString(ProtoOATradeSide tradeSide)
        {
            switch (tradeSide)
            {
                case ProtoOATradeSide.BUY:
                    return "BUY";
                case ProtoOATradeSide.SELL:
                    return "SELL";
                default:
                    return "unknown";
            }
        }
        static public string OpenApiOrderToString(ProtoOAOrder order)
        {
            var _str = "Order{orderId:" + order.OrderId.ToString() + ", orderType:" + OpenApiOrderTypeToString(order.OrderType);
            _str += ", tradeSide:" + TradeSideToString(order.TradeData.TradeSide);
            _str += ", symbolName:" + order.TradeData.SymbolId + ", requestedVolume:" + order.TradeData.Volume.ToString() + ", executedVolume:" + order.ExecutedVolume.ToString() + ", closingOrder:" +
                (order.ClosingOrder ? "TRUE" : "FALSE") +
                (order.HasExecutionPrice ? ", executionPrice:" + order.ExecutionPrice.ToString() : "") +
                (order.HasLimitPrice ? ", limitPrice:" + order.LimitPrice.ToString() : "") +
                (order.HasStopPrice ? ", stopPrice:" + order.StopPrice.ToString() : "") +
                (order.HasStopLoss ? ", stopLossPrice:" + order.StopLoss.ToString() : "") +
                (order.HasTakeProfit ? ", takeProfitPrice:" + order.TakeProfit.ToString() : "") +
                (order.HasBaseSlippagePrice ? ", baseSlippagePrice:" + order.BaseSlippagePrice.ToString() : "") +
                (order.HasSlippageInPoints ? ", slippageInPoints:" + order.SlippageInPoints.ToString() : "") +
                (order.HasRelativeStopLoss ? ", relativeStopLoss:" + order.RelativeStopLoss.ToString() : "") +
                (order.HasRelativeTakeProfit ? ", relativeTakeProfit:" + order.RelativeTakeProfit.ToString() : "") +
                (order.HasExpirationTimestamp ? ", expirationTimestamp:" + order.ExpirationTimestamp.ToString() : "") ;    
            return _str + "}";
        }
        static public string OpenApiPositionStatusToString(ProtoOAPositionStatus positionStatus)
        {
            switch (positionStatus)
            {
                case ProtoOAPositionStatus.POSITION_STATUS_CLOSED:
                    return "CLOSED";
                case ProtoOAPositionStatus.POSITION_STATUS_OPEN:
                    return "OPENED";
                default:
                    return "unknown";
            }
        }
        static public string OpenApiPositionToString(ProtoOAPosition position)
        {
            var _str = "Position{positionId:" + position.PositionId.ToString() + ", positionStatus:" + OpenApiPositionStatusToString(position.PositionStatus);
            _str += ", tradeSide:" + TradeSideToString(position.TradeData.TradeSide);
            _str += ", symbolId:" + position.TradeData.SymbolId + ", volume:" + position.TradeData.Volume.ToString() + ", Price:" + position.Price.ToString() + ", swap:" + position.Swap.ToString() +
                ", commission:" + position.Commission.ToString() + ", openTimestamp:" + position.TradeData.OpenTimestamp.ToString() +
                (position.HasStopLoss ? ", stopLossPrice:" + position.StopLoss.ToString() : "") +
                (position.HasTakeProfit ? ", takeProfitPrice:" + position.TakeProfit.ToString() : "");

            return _str + "}";
        }
        static public string OpenApiClosePositionDetails(ProtoOAClosePositionDetail closePositionDetails)
        {
            return "ClosePositionDetails{entryPrice:" + closePositionDetails.EntryPrice.ToString() +
                ", profit:" + closePositionDetails.GrossProfit.ToString() +
                ", swap:" + closePositionDetails.Swap.ToString() +
                ", commission:" + closePositionDetails.Commission.ToString() +
                ", balance:" + closePositionDetails.Balance.ToString() +
                (closePositionDetails.HasQuoteToDepositConversionRate ? ", quoteToDepositConversionRate:" + closePositionDetails.QuoteToDepositConversionRate.ToString() : "") +
                ", closedVolume:" + closePositionDetails.ClosedVolume.ToString() +           
                "}";
        }
        static public string ToString(ProtoMessage msg)
        {
            return ProtoMessageToString(msg);
        }
    }
}
