var __aspxCalendarWeekCount = 6;
var __aspxCalendarMsPerDay = 86400000;
var __aspxActiveCalendar = null;
ASPxClientCalendar = _aspxCreateClass(ASPxClientEdit, {
    constructor: function (name) {
        this.constructor.prototype.constructor.call(this, name);
        this.SelectionChanging = new ASPxClientEvent();
        this.SelectionChanged = new ASPxClientEvent();
        this.VisibleMonthChanged = new ASPxClientEvent();
        this.isMouseDown = false;
        this.forceMouseDown = false;
        this.selection = new ASPxClientCalendarSelection();
        this.selectionTransaction = null;
        this.selectionStartDate = null;
        this.selectionPrevStartDate = null;
        this.lastSelectedDate = null;
        this.selectionCtrl = false;
        this.selectionByWeeks = false;
        this.nodeCache = {};
        this.titleFormatter = null;
        this.visibleDate = new Date();
        this.firstDayOfWeek = 0;
        this.columns = 1;
        this.rows = 1;
        this.enableFast = true;
        this.enableMulti = false;
        this.minDate = null;
        this.maxDate = null;
        this.customDraw = false;
        this.showWeekNumbers = true;
        this.showDayHeaders = true;
        this.isDateEditCalendar = false;
        this.sizingConfig.allowSetHeight = false;
        this.isDateChangingByKeyboard = false;
        this.MainElementClick = new ASPxClientEvent();
    },
    Initialize: function () {
        this.selectionTransaction = new ASPxClientCalendarSelectionTransaction(this);
        this.selectionPrevStartDate = this.selection.GetFirstDate();
        this.SaveClientState();
        ASPxClientEdit.prototype.Initialize.call(this);
    },
    InlineInitialize: function () {
        this.CreateViews();
        if (this.enableFast)
            this.fastNavigation = new ASPxClientCalendarFastNavigation(this);
        this.InitSpecialKeyboardHandling();
        this.MakeDisabledStateItems();
        ASPxClientEdit.prototype.InlineInitialize.call(this);
    },
    MakeDisabledStateItems: function () {
        for (var key in this.views) {
            var view = this.views[key];
            if (view.constructor != ASPxClientCalendarView) continue;
            view.MakeDisabledStateItems();
        }
    },
    FindInputElement: function () {
        return this.GetChild("_KBS");
    },
    FindStateInputElement: function () {
        return _aspxGetElementById(this.name + "_STATE");
    },
    GetClearButton: function () {
        return this.GetChild("_BC");
    },
    GetTodayButton: function () {
        return this.GetChild("_BT");
    },
    GetValue: function () {
        return this.selection.GetFirstDate();
    },
    GetValueString: function () {
        var value = this.GetValue();
        return value == null ? null : _aspxGetInvariantDateStringCustom(value);
    },
    SetValue: function (date) {

//        var d = null
//        if (date!=null)
//         d =   new Date(date.getFullYear()-543, date.getMonth(), date.getDay(), date.getHours(), date.getMinutes(), date.getSeconds(), date.getMilliseconds())
        if (date != null)
            this.SetVisibleDate(date);

        this.SetSelectedDate(date);
    },
    GetFastNavigation: function () {
        return this.fastNavigation;
    },
    GetViewKey: function (row, column) {
        return row + "x" + column;
    },
    GetView: function (row, column) {
        var key = this.GetViewKey(row, column);
        return this.views[key];
    },
    CreateViews: function () {
        this.views = {};
        var key;
        for (var row = 0; row < this.rows; row++) {
            for (var col = 0; col < this.columns; col++) {
                key = this.GetViewKey(row, col);
                var view = new ASPxClientCalendarView(this, row, col);
                view.Initialize();
                this.views[key] = view;
            }
        }
    },
    IsFastNavigationActive: function () {
        if (_aspxIsExists(this.fastNavigation))
            return this.fastNavigation.GetPopup().IsVisible();
        return false;
    },
    IsDateSelected: function (date) {
        return this.selection.Contains(date);
    },
    IsDateVisible: function (date) {
        var startDate = ASPxClientCalendar.CloneDate(this.GetView(0, 0).visibleDate);
        startDate.setDate(1);
        var endDate = ASPxClientCalendar.CloneDate(this.GetView(this.rows - 1, this.columns - 1).visibleDate);
        endDate.setDate(ASPxClientCalendar.GetDaysInMonth(endDate.getMonth(), endDate.getFullYear()));
        return (date >= startDate) && (date < endDate);
    },
    IsDateWeekend: function (date) {
        var day = date.getDay();
        return day == 0 || day == 6;
    },
    IsMultiView: function () {
        return this.columns > 1 || this.rows > 1;
    },
    IsDateInRange: function (date) {
        return date == null ||
   ((this.minDate == null || date >= this.minDate) &&
    (this.maxDate == null || date <= this.maxDate));
    },
    GetCachedElementById: function (id) {
        if (!_aspxIsExistsElement(this.nodeCache[id]))
            this.nodeCache[id] = _aspxGetElementById(id);
        return this.nodeCache[id];
    },
    ShowLoadingPanel: function () {
        var element = this.GetMainElement();
        var divElement = element.parentNode;
        this.CreateLoadingDiv(divElement, element);
        this.CreateLoadingPanelWithAbsolutePosition(divElement, element);
    },
    Update: function () {
        if (this.customDraw) {
            if (this.callBack) {
                this.ShowLoadingPanel();
                this.CreateCallback("UPDATE");
            }
            else {
                this.SendPostBack("");
            }
        }
        else {
            this.UpdateInternal();
        }
    },
    UpdateInternal: function () {
        for (var key in this.views) {
            var view = this.views[key];
            if (view.constructor != ASPxClientCalendarView) continue;
            view.Update();
        }
    },
    ApplySelectionByDiff: function (selection, save) {
        var toShow = [];
        var toHide = [];
        var dates = selection.GetDates();
        var oldDates = this.selection.GetDates();
        var date;
        for (var i = 0; i < dates.length; i++) {
            date = dates[i];
            if (!this.selection.Contains(date))
                toShow.push(date);
        }
        for (var i = 0; i < oldDates.length; i++) {
            date = oldDates[i];
            if (!selection.Contains(date))
                toHide.push(date);
        }
        for (var key in this.views) {
            var view = this.views[key];
            if (view.constructor != ASPxClientCalendarView) continue;
            view.UpdateSelection(toHide, false);
            view.UpdateSelection(toShow, true);
        }
        this.selection.Assign(selection);
        if (save)
            this.SaveClientState();
    },
    ImportEtalonStyle: function (info, suffix) {
        var cell = this.GetEtalonStyleCell(suffix);
        if (_aspxIsExistsElement(cell))
            info.Import(cell);
    },
    GetEtalonStyleCell: function (name) {
        return this.GetCachedElementById(this.name + "_EC_" + name);
    },
    SaveClientState: function () {
        var element = this.FindStateInputElement();
        if (element != null) {
            var state = _aspxGetInvariantDateStringCustom(this.visibleDate);
            if (this.selection.count > 0)
                state += ":" + this.FormatDates(this.selection.GetDates(), ":");
            element.value = state;
        }
    },
    FormatDates: function (dates, separator) {
        var result = "";
        for (var i = 0; i < dates.length; i++) {
            if (result.length > 0)
                result += separator;
            result += _aspxGetInvariantDateStringCustom(dates[i]);
        }
        return result;
    },
    InitializeKeyHandlers: function () {
        this.AddKeyDownHandler(ASPxKey.Enter, "OnEnter");
        this.AddKeyDownHandler(ASPxKey.Esc, "OnEscape");
        this.AddKeyDownHandler(ASPxKey.PageUp, "OnPageUp");
        this.AddKeyDownHandler(ASPxKey.PageDown, "OnPageDown");
        this.AddKeyDownHandler(ASPxKey.End, "OnEndKeyDown");
        this.AddKeyDownHandler(ASPxKey.Home, "OnHomeKeyDown");
        this.AddKeyDownHandler(ASPxKey.Left, "OnArrowLeft");
        this.AddKeyDownHandler(ASPxKey.Right, "OnArrowRight");
        this.AddKeyDownHandler(ASPxKey.Up, "OnArrowUp");
        this.AddKeyDownHandler(ASPxKey.Down, "OnArrowDown");
    },
    OnArrowUp: function (evt) {
        if (this.IsFastNavigationActive())
            this.GetFastNavigation().OnArrowUp(evt);
        else if (!this.readOnly) {
            var newDate = this.GetNearestDayForToday();
            if (_aspxIsExists(this.lastSelectedDate))
                newDate = ASPxClientCalendar.GetPrevWeekDate(this.lastSelectedDate);
            this.CorrectVisibleMonth(newDate, false);
            this.DoKeyboardSelection(newDate, evt.shiftKey);
        }
        return true;
    },
    OnArrowDown: function (evt) {
        if (this.IsFastNavigationActive())
            this.GetFastNavigation().OnArrowDown(evt);
        else if (!this.readOnly) {
            var newDate = this.GetNearestDayForToday();
            if (_aspxIsExists(this.lastSelectedDate))
                newDate = ASPxClientCalendar.GetNextWeekDate(this.lastSelectedDate);
            this.CorrectVisibleMonth(newDate, true);
            this.DoKeyboardSelection(newDate, evt.shiftKey);
        }
        return true;
    },
    OnArrowLeft: function (evt) {
        if (this.IsFastNavigationActive())
            this.GetFastNavigation().OnArrowLeft(evt);
        else if (!this.readOnly) {
            var newDate = this.GetNearestDayForToday();
            if (_aspxIsExists(this.lastSelectedDate))
                newDate = ASPxClientCalendar.GetTomorrowDate(this.lastSelectedDate);
            this.CorrectVisibleMonth(newDate, false);
            this.DoKeyboardSelection(newDate, evt.shiftKey);
        }
        return true;
    },
    OnArrowRight: function (evt) {
        if (this.IsFastNavigationActive())
            this.GetFastNavigation().OnArrowRight(evt);
        else if (!this.readOnly) {
            var newDate = this.GetNearestDayForToday();
            if (_aspxIsExists(this.lastSelectedDate))
                newDate = ASPxClientCalendar.GetYesterDate(this.lastSelectedDate);
            this.CorrectVisibleMonth(newDate, true);
            this.DoKeyboardSelection(newDate, evt.shiftKey);
        }
        return true;
    },
    OnCallback: function (result) {
        _aspxSetInnerHtml(this.GetMainElement().parentNode, result);
    },
    OnPageUp: function (evt) {
        if (this.IsFastNavigationActive())
            this.GetFastNavigation().OnPageUp(evt);
        else if (!this.readOnly) {
            var newDate = this.GetNearestDayForToday();
            if (_aspxIsExists(this.lastSelectedDate)) {
                if (evt.ctrlKey)
                    newDate = ASPxClientCalendar.GetPrevYearDate(this.lastSelectedDate);
                else
                    newDate = ASPxClientCalendar.GetPrevMonthDate(this.lastSelectedDate);
            }
            this.CorrectVisibleMonth(newDate, false);
            this.DoKeyboardSelection(newDate);
        }
        return true;
    },
    OnPageDown: function (evt) {
        if (this.IsFastNavigationActive())
            this.GetFastNavigation().OnPageDown(evt);
        else if (!this.readOnly) {
            var newDate = this.GetNearestDayForToday();
            if (_aspxIsExists(this.lastSelectedDate)) {
                if (evt.ctrlKey)
                    newDate = ASPxClientCalendar.GetNextYearDate(this.lastSelectedDate);
                else
                    newDate = ASPxClientCalendar.GetNextMonthDate(this.lastSelectedDate);
            }
            this.CorrectVisibleMonth(newDate, true);
            this.DoKeyboardSelection(newDate);
        }
        return true;
    },
    OnEndKeyDown: function (evt) {
        if (!this.readOnly && !this.IsFastNavigationActive()) {
            var newDate = this.GetNearestDayForToday();
            if (_aspxIsExists(this.lastSelectedDate))
                newDate = ASPxClientCalendar.CloneDate(this.lastSelectedDate);
            newDate = ASPxClientCalendar.GetLastDayInMonthDate(newDate);
            this.CorrectVisibleMonth(newDate, false);
            this.DoKeyboardSelection(newDate, evt.shiftKey);
        }
        return true;
    },
    OnHomeKeyDown: function (evt) {
        if (!this.readOnly && !this.IsFastNavigationActive()) {
            var newDate = this.GetNearestDayForToday();
            if (_aspxIsExists(this.lastSelectedDate))
                newDate = ASPxClientCalendar.CloneDate(this.lastSelectedDate);
            newDate = ASPxClientCalendar.GetFirstDayInMonthDate(newDate);
            this.CorrectVisibleMonth(newDate, false);
            this.DoKeyboardSelection(newDate, evt.shiftKey);
        }
        return true;
    },
    OnEnter: function () {
        if (this.IsFastNavigationActive())
            this.GetFastNavigation().OnEnter();
        return true;
    },
    OnEscape: function () {
        if (this.IsFastNavigationActive())
            this.GetFastNavigation().OnEscape();
        return true;
    },
    OnShiftMonth: function (offset) {
        if (offset) {
            var date = ASPxClientCalendar.AddMonths(this.visibleDate, offset);
            this.OnVisibleMonthChanged(date);
        }
    },
    OnDayMouseDown: function (date, shift, ctrl, byWeeks) {
        this.isMouseDown = true;
        this.selectionByWeeks = byWeeks;
        this.selectionTransaction.Start();
        if (this.enableMulti) {
            if (ctrl) {
                this.selectionCtrl = true;
                this.selectionTransaction.CopyFromBackup();
            } else
                this.selectionCtrl = false;
            if (shift && _aspxIsExists(this.selectionPrevStartDate)) {
                this.selectionStartDate = this.selectionPrevStartDate;
                this.selectionTransaction.selection.AddRange(this.selectionStartDate, date);
                if (byWeeks)
                    this.selectionTransaction.selection.AddWeek(date);
            } else {
                this.selectionStartDate = date;
                this.selectionPrevStartDate = date;
                if (byWeeks)
                    this.selectionTransaction.selection.AddWeek(date);
                else
                    this.selectionTransaction.selection.Add(date);
            }
        } else
            this.selectionTransaction.selection.Add(date);
        this.ApplySelectionByDiff(this.selectionTransaction.selection, false);
    },
    OnDayMouseOver: function (date) {
        if (this.enableMulti) {
            if (this.selectionCtrl)
                this.selectionTransaction.CopyFromBackup();
            else
                this.selectionTransaction.selection.Clear();
            this.selectionTransaction.selection.AddRange(this.selectionStartDate, date);
            if (this.selectionByWeeks) {
                this.selectionTransaction.selection.AddWeek(date);
                this.selectionTransaction.selection.AddWeek(this.selectionStartDate);
            }
        } else {
            this.selectionTransaction.selection.Clear();
            this.selectionTransaction.selection.Add(date);
        }
        this.ApplySelectionByDiff(this.selectionTransaction.selection, false);
    },
    OnDayMouseUp: function (date) {
        if (!__aspxIE && this.isMouseDown)
            this.OnMainElementClick();
        this.isMouseDown = false;
        if (this.enableMulti && this.selectionCtrl && this.selectionTransaction.backup.Contains(date) &&
   ASPxClientCalendar.AreDatesEqual(date, this.selectionStartDate)) {
            if (this.selectionByWeeks)
                this.selectionTransaction.selection.RemoveWeek(date);
            else
                this.selectionTransaction.selection.Remove(date);
        }
        this.lastSelectedDate = ASPxClientCalendar.CloneDate(date);
        this.OnSelectionChanging();
    },
    OnTodayClick: function () {
        var now = new Date();
        var date = new Date(now.getFullYear(), now.getMonth(), now.getDate());
        if (this.IsDateInRange(date)) {
            this.selectionTransaction.Start();
            this.selectionTransaction.selection.Add(date);
            this.OnSelectionChanging();
            if (!ASPxClientCalendar.AreDatesOfSameMonth(date, this.visibleDate))
                this.OnVisibleMonthChanged(date);
        }
    },
    OnClearClick: function () {
        this.selectionTransaction.Start();
        this.OnSelectionChanging();
        this.selectionStartDate = null;
        this.selectionPrevStartDate = null;
        this.lastSelectedDate = null;
    },
    OnSelectMonth: function (row, column) {
        var txn = this.selectionTransaction;
        txn.Start();
        var date = ASPxClientCalendar.CloneDate(this.GetView(row, column).visibleDate);
        date.setDate(1);
        do {
            if (this.IsDateInRange(date))
                txn.selection.Add(date);
            date = ASPxClientCalendar.AddDays(date, 1);
        } while (date.getDate() > 1);
        this.OnSelectionChanging();
    },
    OnTitleClick: function (row, column) {
        this.fastNavigation.activeView = this.GetView(row, column);
        this.fastNavigation.Prepare();
        this.fastNavigation.Show();
    },
    OnMainElementClick: function () {
        this.MainElementClick.FireEvent(this);
    },
    OnSelectionChanging: function () {
        if (!this.SelectionChanging.IsEmpty()) {
            var args = new ASPxClientCalendarSelectionEventArgs(false, this.selectionTransaction.selection);
            this.SelectionChanging.FireEvent(this, args);
        }
        var changed = this.selectionTransaction.IsChanged();
        this.selectionTransaction.Commit();
        if (changed)
            this.OnValueChanged();
    },
    OnVisibleMonthChanged: function (date) {
        var offsetInternal = ASPxClientCalendar.GetOffsetInMonths(this.visibleDate, date);
        this.SetVisibleDate(date);
        var processOnServer = this.RaiseVisibleMonthChanged(offsetInternal);
        if (processOnServer)
            this.SendPostBackInternal("");
    },
    OnSelectionCancelled: function () {
        this.isMouseDown = false;
        this.selectionTransaction.Rollback();
    },
    RaiseValueChangedEvent: function () {
        var processOnServer = ASPxClientEdit.prototype.RaiseValueChangedEvent.call(this);
        processOnServer = this.RaiseSelectionChanged(processOnServer);
        return processOnServer;
    },
    SetVisibleDate: function (date) {
        var old = this.visibleDate;
        this.visibleDate = date;
        this.SaveClientState();
        if (!ASPxClientCalendar.AreDatesOfSameMonth(date, old)) {
            this.Update();
        }
    },
    SetSelectedDate: function (date) {
        if (this.IsDateInRange(date)) {
            var selection = new ASPxClientCalendarSelection();
            if (date != null) {
                selection.Add(date);
                this.lastSelectedDate = ASPxClientCalendar.CloneDate(date);
            }
            this.ApplySelectionByDiff(selection, true);
        }
    },
    CorrectVisibleMonth: function (newDate, isForwardDirection) {
        var offset = ASPxClientCalendar.GetOffsetInMonths(this.visibleDate, newDate);
        if (this.IsMultiView() && offset != 0) {
            var view = isForwardDirection ? this.GetView(this.rows - 1, this.columns - 1) :
            this.GetView(0, 0);
            offset = this.IsDateVisible(newDate) ? 0 :
       ASPxClientCalendar.GetOffsetInMonths(view.visibleDate, newDate);
        }
        if (!this.IsDateInRange(newDate))
            offset = 0;
        if (offset != 0)
            this.OnShiftMonth(offset);
    },
    DoKeyboardSelection: function (date, shift) {
        if (this.IsDateInRange(date)) {
            this.isDateChangingByKeyboard = true;
            this.selectionTransaction.Start();
            if (this.enableMulti && shift && _aspxIsExists(this.selectionStartDate))
                this.selectionTransaction.selection.AddRange(this.selectionStartDate, date);
            else {
                this.selectionTransaction.selection.Add(date);
                this.selectionStartDate = date;
            }
            this.lastSelectedDate = ASPxClientCalendar.CloneDate(date);
            this.OnSelectionChanging();
            this.isDateChangingByKeyboard = false;
        }
    },
    GetNearestDayForToday: function () {
        var now = new Date();
        var ret = new Date(now.getFullYear(), now.getMonth(), now.getDate());
        if (_aspxIsExists(this.minDate) && !this.IsDateInRange(ret))
            ret = ASPxClientCalendar.CloneDate(this.minDate);
        return ret;
    },
    UseDelayedSpecialFocus: function () {
        return true;
    },
    GetDelayedSpecialFocusTriggers: function () {
        var list = ASPxClientEdit.prototype.GetDelayedSpecialFocusTriggers.call(this);
        if (this.enableFast)
            list.push(this.GetFastNavigation().GetPopup().GetWindowElement(-1));
        return list;
    },
    GetSelectedDate: function () {
        return this.GetValue();
    },
    GetVisibleDate: function () {
        return this.visibleDate;
    },
    SelectDate: function (date) {
        if (_aspxIsExists(date)) {
            this.selection.Add(date);
            this.Update();
        }
    },
    SelectRange: function (start, end) {
        if (_aspxIsExists(start) && _aspxIsExists(end)) {
            this.selection.AddRange(start, end);
            this.Update();
        }
    },
    DeselectDate: function (date) {
        if (_aspxIsExists(date)) {
            this.selection.Remove(date);
            this.Update();
        }
    },
    DeselectRange: function (start, end) {
        if (_aspxIsExists(start) && _aspxIsExists(end)) {
            this.selection.RemoveRange(start, end);
            this.Update();
        }
    },
    ClearSelection: function () {
        this.selection.Clear();
        this.Update();
    },
    GetSelectedDates: function () {
        return this.selection.GetDates();
    },
    RaiseSelectionChanged: function (processOnServer) {
        if (!this.SelectionChanged.IsEmpty()) {
            var args = new ASPxClientProcessingModeEventArgs(processOnServer);
            this.SelectionChanged.FireEvent(this, args);
            processOnServer = args.processOnServer;
        }
        return processOnServer;
    },
    RaiseVisibleMonthChanged: function (offsetInternal) {
        var processOnServer = this.autoPostBack;
        if (!this.VisibleMonthChanged.IsEmpty()) {
            var args = new ASPxClientProcessingModeEventArgs(processOnServer);
            args.offsetInternal = offsetInternal;
            this.VisibleMonthChanged.FireEvent(this, args);
            processOnServer = args.processOnServer;
        }
        return processOnServer;
    },
    ChangeEnabledAttributes: function (enabled) {
        _aspxChangeDocumentEventsMethod(enabled)("mouseup", aspxCalDocMouseUp);
        _aspxChangeEventsMethod(enabled)(this.GetMainElement(), "click", new Function("aspxCalMainElemClick('" + this.name + "');"));
        var inputElement = this.GetInputElement();
        if (_aspxIsExists(inputElement))
            this.ChangeSpecialInputEnabledAttributes(inputElement, _aspxChangeEventsMethod(enabled));
        var btnElement = this.GetTodayButton();
        if (_aspxIsExists(btnElement))
            this.ChangeButtonEnabledAttributes(btnElement, _aspxChangeAttributesMethod(enabled));
        btnElement = this.GetClearButton();
        if (_aspxIsExists(btnElement))
            this.ChangeButtonEnabledAttributes(btnElement, _aspxChangeAttributesMethod(enabled));
        for (var key in this.views) {
            var view = this.views[key];
            if (view.constructor != ASPxClientCalendarView) continue;
            view.ChangeEnabledAttributes(enabled);
        }
    },
    ChangeEnabledStateItems: function (enabled) {
        aspxGetStateController().SetElementEnabled(this.GetMainElement(), enabled);
        var btnElement = this.GetTodayButton();
        if (_aspxIsExists(btnElement))
            aspxGetStateController().SetElementEnabled(btnElement, enabled);
        btnElement = this.GetClearButton();
        if (_aspxIsExists(btnElement))
            aspxGetStateController().SetElementEnabled(btnElement, enabled);
        for (var key in this.views) {
            var view = this.views[key];
            if (view.constructor != ASPxClientCalendarView) continue;
            view.ChangeEnabledStateItems(enabled);
        }
        this.UpdateInternal();
    },
    ChangeButtonEnabledAttributes: function (element, method) {
        method(element, "onclick");
        method(element, "ondblclick");
    },
    GetMinDate: function () {
        return this.minDate;
    },
    SetMinDate: function (date) {
        this.minDate = date;
        this.Update();
    },
    GetMaxDate: function () {
        return this.maxDate;
    },
    SetMaxDate: function (date) {
        this.maxDate = date;
        this.Update();
    }
});
ASPxClientCalendar.Cast = ASPxClientControl.Cast;
ASPxClientCalendar.AreDatesEqual = function (date1, date2) {
    if (date1 == date2)
        return true;
    if (!date1 || !date2)
        return false;
    return date1.getFullYear() == date2.getFullYear() && date1.getMonth() == date2.getMonth() && date1.getDate() == date2.getDate();
}
ASPxClientCalendar.AreDatesOfSameMonth = function (date1, date2) {
    if (!date1 || !date2)
        return false;
    return date1.getFullYear() == date2.getFullYear() && date1.getMonth() == date2.getMonth();
}
ASPxClientCalendar.GetUTCTime = function (date) {
    return Date.UTC(date.getFullYear(), date.getMonth(), date.getDate());
}
ASPxClientCalendar.GetFirstDayOfYear = function (date) {
    return new Date(date.getFullYear(), 0, 1);
}
ASPxClientCalendar.GetDayOfYear = function (date) {
    var ms = ASPxClientCalendar.GetUTCTime(date) -
  ASPxClientCalendar.GetUTCTime(ASPxClientCalendar.GetFirstDayOfYear(date));
    return 1 + Math.floor(ms / __aspxCalendarMsPerDay);
}
ASPxClientCalendar.GetISO8601WeekOfYear = function (date) {
    var firstDate = new Date(date.getFullYear(), 0, 1);
    var firstDayOfWeek = firstDate.getDay();
    if (firstDayOfWeek == 0)
        firstDayOfWeek = 7;
    var daysInFirstWeek = 8 - firstDayOfWeek;
    var lastDate = new Date(date.getFullYear(), 11, 31);
    var lastDayOfWeek = lastDate.getDay();
    if (lastDayOfWeek == 0)
        lastDayOfWeek = 7;
    var daysInLastWeek = 8 - lastDayOfWeek;
    var fullWeeks = Math.ceil((ASPxClientCalendar.GetDayOfYear(date) - daysInFirstWeek) / 7);
    var result = fullWeeks;
    if (daysInFirstWeek > 3)
        result++;
    var isThursday = firstDayOfWeek == 4 || lastDayOfWeek == 4;
    if (result > 52 && !isThursday)
        result = 1;
    if (result == 0)
        return ASPxClientCalendar.GetISO8601WeekOfYear(new Date(date.getFullYear() - 1, 11, 31));
    return result;
}
ASPxClientCalendar.GetNextWeekDate = function (date) {
    var ret = new Date(date.getTime());
    var newDay = date.getDate() + 7;
    ret.setDate(newDay);
    return ret;
}
ASPxClientCalendar.GetPrevWeekDate = function (date) {
    var ret = new Date(date.getTime());
    var newDay = date.getDate() - 7;
    ret.setDate(newDay);
    return ret;
}
ASPxClientCalendar.GetTomorrowDate = function (date) {
    var ret = new Date(date.getTime());
    ret.setDate(ret.getDate() - 1);
    return ret;
}
ASPxClientCalendar.GetYesterDate = function (date) {
    var ret = new Date(date.getTime());
    ret.setDate(ret.getDate() + 1);
    return ret;
}
ASPxClientCalendar.GetNextMonthDate = function (date) {
    var ret = new Date(date.getTime());
    var maxDateInNextMonth = ASPxClientCalendar.GetDaysInMonth(ret.getMonth() + 1, ret.getFullYear());
    if (ret.getDate() > maxDateInNextMonth)
        ret.setDate(maxDateInNextMonth);
    ret.setMonth(ret.getMonth() + 1);
    return ret;
}
ASPxClientCalendar.GetNextYearDate = function (date) {
    var ret = new Date(date.getTime());
    var maxDateInPrevYearMonth = ASPxClientCalendar.GetDaysInMonth(ret.getMonth(), ret.getFullYear() + 1);
    if (ret.getDate() > maxDateInPrevYearMonth)
        ret.setDate(maxDateInPrevYearMonth);
    ret.setFullYear(ret.getFullYear() + 1);
    return ret;
}
ASPxClientCalendar.GetPrevMonthDate = function (date) {
    var ret = new Date(date.getTime());
    var maxDateInPrevMonth = ASPxClientCalendar.GetDaysInMonth(ret.getMonth() - 1, ret.getFullYear());
    if (ret.getDate() > maxDateInPrevMonth)
        ret.setDate(maxDateInPrevMonth);
    ret.setMonth(ret.getMonth() - 1);
    return ret;
}
ASPxClientCalendar.GetPrevYearDate = function (date) {
    var ret = new Date(date.getTime());
    var maxDateInPrevYearMonth = ASPxClientCalendar.GetDaysInMonth(ret.getMonth(), ret.getFullYear() - 1);
    if (ret.getDate() > maxDateInPrevYearMonth)
        ret.setDate(maxDateInPrevYearMonth);
    ret.setFullYear(ret.getFullYear() - 1);
    return ret;
}
ASPxClientCalendar.GetFirstDayInMonthDate = function (date) {
    var ret = new Date(date.getTime());
    ret.setDate(1);
    return ret;
}
ASPxClientCalendar.GetLastDayInMonthDate = function (date) {
    var ret = new Date(date.getTime());
    var maxDateInYearMonth = ASPxClientCalendar.GetDaysInMonth(ret.getMonth(), ret.getFullYear());
    ret.setDate(maxDateInYearMonth);
    return ret;
}
ASPxClientCalendar.AddDays = function (date, count) {
    var newDate = ASPxClientCalendar.CloneDate(date);
    newDate.setUTCDate(count + newDate.getUTCDate());
    ASPxClientCalendar.FixTimezoneGap(date, newDate);
    return newDate;
}
ASPxClientCalendar.AddMonths = function (date, count) {
    var newDate = ASPxClientCalendar.CloneDate(date);
    newDate.setMonth(count + newDate.getMonth());
    ASPxClientCalendar.FixTimezoneGap(date, newDate);
    if (newDate.getDate() < date.getDate())
        newDate = ASPxClientCalendar.AddDays(newDate, -newDate.getDate());
    return newDate;
}
ASPxClientCalendar.CloneDate = function (date) {
    var cloned = new Date();
    cloned.setTime(date.getTime());
    return cloned;
}
ASPxClientCalendar.GetDecadeStartYear = function (year) {
    return 10 * Math.floor(year / 10);
}
ASPxClientCalendar.GetDaysInRange = function (start, end) {
    return 1 + (ASPxClientCalendar.GetUTCTime(end) - ASPxClientCalendar.GetUTCTime(start)) / __aspxCalendarMsPerDay;
};
ASPxClientCalendar.GetDaysInMonth = function (month, year) {
    var d = new Date(year, month + 1, 0);
    return d.getDate();
};
ASPxClientCalendar.GetOffsetInMonths = function (start, end) {
    return end.getMonth() - start.getMonth() + 12 * (end.getFullYear() - start.getFullYear());
};
ASPxClientCalendar.FixTimezoneGap = function (oldDate, newDate) {
    var diff = newDate.getHours() - oldDate.getHours();
    if (diff == 0)
        return;
    var sign = (diff == 1 || diff == -23) ? -1 : 1;
    var trial = new Date(newDate.getTime() + sign * 3600000);
    if (sign > 0 || trial.getDate() == newDate.getDate())
        newDate.setTime(trial.getTime());
};
ASPxClientCalendarSelection = _aspxCreateClass(null, {
    constructor: function () {
        this.dates = {};
        this.count = 0;
    },
    Assign: function (source) {
        this.Clear();
        for (var key in source.dates) {
            var item = source.dates[key];
            if (item.constructor != Date) continue;
            this.Add(item);
        }
    },
    Clear: function () {
        if (this.count > 0) {
            this.dates = {};
            this.count = 0;
        }
    },
    Equals: function (selection) {
        if (this.count != selection.count)
            return false;
        for (var key in this.dates) {
            if (this.dates[key].constructor != Date) continue;
            if (!selection.ContainsKey(key))
                return false;
        }
        return true;
    },
    Contains: function (date) {
        var key = this.GetKey(date);
        return this.ContainsKey(key);
    },
    ContainsKey: function (key) {
        return _aspxIsExists(this.dates[key]);
    },
    Add: function (date) {
        var key = this.GetKey(date);
        if (!this.ContainsKey(key)) {
            this.dates[key] = ASPxClientCalendar.CloneDate(date);
            this.count++;
        }
    },
    AddArray: function (dates) {
        for (var i = 0; i < dates.length; i++)
            this.Add(dates[i]);
    },
    AddRange: function (start, end) {
        if (end < start) {
            this.AddRange(end, start);
            return;
        }
        var count = ASPxClientCalendar.GetDaysInRange(start, end);
        var date = ASPxClientCalendar.CloneDate(start);
        for (var i = 0; i < count; i++) {
            this.Add(date);
            date = ASPxClientCalendar.AddDays(date, 1);
        }
    },
    AddWeek: function (startDate) {
        this.AddRange(startDate, ASPxClientCalendar.AddDays(startDate, 6));
    },
    Remove: function (date) {
        var key = this.GetKey(date);
        if (this.ContainsKey(key)) {
            delete this.dates[key];
            this.count--;
        }
    },
    RemoveArray: function (dates) {
        for (var i = 0; i < dates.length; i++)
            this.Remove(dates[i]);
    },
    RemoveRange: function (start, end) {
        if (end < start) {
            this.RemoveRange(end, start);
            return;
        }
        var count = ASPxClientCalendar.GetDaysInRange(start, end);
        var date = ASPxClientCalendar.CloneDate(start);
        for (var i = 0; i < count; i++) {
            this.Remove(date);
            date = ASPxClientCalendar.AddDays(date, 1);
        }
    },
    RemoveWeek: function (startDate) {
        this.RemoveRange(startDate, ASPxClientCalendar.AddDays(startDate, 6));
    },
    GetDates: function () {
        var result = [];
        for (var key in this.dates) {
            var item = this.dates[key];
            if (item.constructor != Date) continue;
            result.push(ASPxClientCalendar.CloneDate(item));
        }
        return result;
    },
    GetFirstDate: function () {
        if (this.count == 0)
            return null;
        for (var key in this.dates) {
            var item = this.dates[key];
            if (item.constructor != Date) continue;
            return ASPxClientCalendar.CloneDate(item);
        }
        return null;
    },
    GetKey: function (date) {
        return _aspxGetInvariantDateStringCustom(date);
    }
});
ASPxClientCalendarSelectionTransaction = _aspxCreateClass(null, {
    constructor: function (calendar) {
        this.calendar = calendar;
        this.isActive = false;
        this.backup = new ASPxClientCalendarSelection();
        this.selection = new ASPxClientCalendarSelection;
    },
    Start: function () {
        if (this.isActive)
            this.Rollback();
        this.backup.Assign(this.calendar.selection);
        this.selection.Clear();
        this.isActive = true;
        __aspxActiveCalendar = this.calendar;
    },
    Commit: function () {
        this.calendar.ApplySelectionByDiff(this.selection, true);
        this.Reset();
    },
    Rollback: function () {
        this.calendar.ApplySelectionByDiff(this.backup);
        this.Reset();
    },
    Reset: function () {
        this.backup.Clear();
        this.selection.Clear();
        this.isActive = false;
        __aspxActiveCalendar = null;
    },
    CopyFromBackup: function () {
        this.selection.Assign(this.backup);
    },
    IsChanged: function () {
        return !this.backup.Equals(this.selection);
    }
});
ASPxClientCalendarView = _aspxCreateClass(null, {
    constructor: function (calendar, row, column) {
        this.row = row;
        this.column = column;
        this.calendar = calendar;
        var temp = column + row;
        this.isLowBoundary = temp == 0;
        this.isHighBoundary = temp == calendar.rows + calendar.columns - 2;
        this.visibleDate = null;
        this.startDate = null;
        this.dayFunctions = {};
        this.dayFunctionsWithWeekSelection = {};
    },
    Initialize: function () {
        this.dayCellCache = {};
        this.dayStyleCache = {};
        this.UpdateDate();
        this.UpdateSelection(this.calendar.selection.GetDates(), true);
        var cell = this.GetMonthCell();
        if (_aspxIsExistsElement(cell))
            _aspxPreventElementDragAndSelect(cell, false);
    },
    AttachMouseEvents: function (eventMethod, styleMethod) {
        var index;
        var cell;
        if (this.calendar.showDayHeaders) {
            var headCells = this.GetMonthTable().rows[0].cells;
            var dayNameIndex = 0;
            if (this.calendar.showWeekNumbers) {
                dayNameIndex++;
                cell = headCells[0];
                if (this.calendar.enableMulti) {
                    eventMethod(cell, "click",
      new Function("aspxCalSelectMonth('" + this.calendar.name + "', " + this.row + ", " + this.column + ")"));
                    styleMethod(cell, "cursor", _aspxGetPointerCursor());
                }
                this.AttachCancelSelect(eventMethod, cell);
            }
            for (var j = 0; j < 7; j++)
                this.AttachCancelSelect(eventMethod, headCells[dayNameIndex++]);
        }
        for (var i = 0; i < __aspxCalendarWeekCount; i++) {
            if (this.calendar.showWeekNumbers) {
                cell = this.GetWeekNumberCell(i);
                if (this.calendar.enableMulti)
                    this.AttachDayMouseEvents(eventMethod, cell, this.GetDayMouseEventFunction(7 * i, true));
                else
                    this.AttachCancelSelect(eventMethod, cell);
            }
            var date;
            for (var j = 0; j < 7; j++) {
                index = i * 7 + j;
                cell = this.GetDayCell(index);
                date = this.GetDateByIndex(index);
                if (!this.calendar.enableMulti && this.IsDateVisible(date) && this.calendar.IsDateInRange(date)) {
                    if (!cell.style.cursor || cell.style.cursor == _aspxGetPointerCursor())
                        styleMethod(cell, "cursor", _aspxGetPointerCursor());
                }
                this.AttachDayMouseEvents(eventMethod, cell, this.GetDayMouseEventFunction(index, false));
            }
        }
    },
    AttachDayMouseEvents: function (method, cell, handler) {
        var types = ["down", "up", "over"];
        for (var i = 0; i < types.length; i++)
            method(cell, "mouse" + types[i], handler);
    },
    AttachCancelSelect: function (method, element) {
        method(element, "mouseup", aspxCalCancelSelect);
    },
    GetDayMouseEventFunction: function (index, selectWeeks) {
        var hash = selectWeeks ? this.dayFunctionsWithWeekSelection : this.dayFunctions;
        if (!_aspxIsExists(hash[index]))
            hash[index] = new Function("e", "aspxCalDayMouseEvt('" + this.calendar.name + "', " + this.row + ", " + this.column + ", " + index + ", e, " + selectWeeks + ");");
        return hash[index];
    },
    UpdateDate: function () {
        this.visibleDate = ASPxClientCalendar.AddMonths(this.calendar.visibleDate,
   this.row * this.calendar.columns + this.column);
        var date = ASPxClientCalendar.CloneDate(this.visibleDate);
        date.setDate(1);
        var offset = date.getDay() - this.calendar.firstDayOfWeek;
        if (offset < 0)
            offset += 7;
        this.startDate = ASPxClientCalendar.AddDays(date, -offset);
    },
    GetDateByIndex: function (index) {
        return ASPxClientCalendar.AddDays(this.startDate, index);
    },
    GetIndexByDate: function (date) {
        return ASPxClientCalendar.GetDaysInRange(this.startDate, date) - 1;
    },
    IsDateOtherMonth: function (date) {
        if (date == null)
            return false;
        return date.getMonth() != this.visibleDate.getMonth() ||
   date.getFullYear() != this.visibleDate.getFullYear();
    },
    GetDayCell: function (index) {
        if (_aspxIsExists(this.dayCellCache[index]))
            return this.dayCellCache[index];
        var mt = this.GetMonthTable();
        var colIndex = index % 7;
        var rowIndex = (index - colIndex) / 7;
        if (this.calendar.showDayHeaders)
            rowIndex++;
        if (this.calendar.showWeekNumbers)
            colIndex++;
        var cell = mt.rows[rowIndex].cells[colIndex];
        this.dayCellCache[index] = cell;
        return cell;
    },
    GetMonthTable: function () {
        return this.GetCachedElementById("mt");
    },
    GetMonthCell: function () {
        return this.GetCachedElementById("mc");
    },
    GetWeekNumberCell: function (index) {
        if (this.calendar.showDayHeaders)
            index++;
        return this.GetMonthTable().rows[index].cells[0];
    },
    GetPrevYearCell: function () {
        return this.GetCachedElementById("PYC");
    },
    GetPrevMonthCell: function () {
        return this.GetCachedElementById("PMC");
    },
    GetTitleCell: function () {
        return this.GetCachedElementById("TC");
    },
    GetTitleElement: function () {
        return this.GetCachedElementById("T");
    },
    GetNextMonthCell: function () {
        return this.GetCachedElementById("NMC");
    },
    GetNextYearCell: function () {
        return this.GetCachedElementById("NYC");
    },
    Update: function () {
        this.dayStyleCache = {};
        this.UpdateDate();
        this.UpdateDays();
        this.UpdateTitle();
        this.UpdateSelection(this.calendar.selection.GetDates(), true);
    },
    UpdateDays: function () {
        var date = ASPxClientCalendar.CloneDate(this.startDate);
        var offset = this.calendar.firstDayOfWeek - 1;
        if (offset < 0)
            offset += 7;
        var weekNumber = ASPxClientCalendar.GetISO8601WeekOfYear(ASPxClientCalendar.AddDays(date, offset));
        var cell;
        for (var i = 0; i < __aspxCalendarWeekCount; i++) {
            if (this.calendar.showWeekNumbers)
                this.GetWeekNumberCell(i).innerHTML = (weekNumber < 10 ? "0" : "") + weekNumber.toString();
            for (var j = 0; j < 7; j++) {
                cell = this.GetDayCell(i * 7 + j);
                cell.innerHTML = this.IsDateVisible(date) ? date.getDate() : "&nbsp;";
                this.ApplyDayCellStyle(cell, date);
                date = ASPxClientCalendar.AddDays(date, 1);
            }
            if (++weekNumber > 52)
                weekNumber = ASPxClientCalendar.GetISO8601WeekOfYear(ASPxClientCalendar.AddDays(date, offset));
        }
    },
    UpdateTitle: function () {
        var el = this.GetTitleElement();
        if (!el) return;
        if (!this.titleFormatter) {
            this.titleFormatter = new ASPxDateFormatter();
            this.titleFormatter.SetFormatString(__aspxCultureInfo.yearMonth);
        }
        el.innerHTML = this.titleFormatter.Format(this.visibleDate);
    },
    UpdateSelection: function (dates, showSelection) {
        var index;
        var maxIndex = 7 * __aspxCalendarWeekCount - 1;
        for (var i = 0; i < dates.length; i++) {
            index = this.GetIndexByDate(dates[i]);
            if (index < 0 || index > maxIndex || !this.IsDateVisible(dates[i]))
                continue;
            this.ApplySelectionToCell(index, showSelection);
        }
    },
    ApplySelectionToCell: function (index, showSelection) {
        var cell = this.GetDayCell(index);
        if (showSelection) {
            var info;
            if (!_aspxIsExists(this.dayStyleCache[index])) {
                var backup = new ASPxClientCalendarStyleInfo();
                backup.Import(cell);
                this.dayStyleCache[index] = backup;
                info = backup.Clone();
            } else
                info = this.dayStyleCache[index].Clone();
            this.calendar.ImportEtalonStyle(info, "DS");
        } else
            info = this.dayStyleCache[index];
        info.Apply(cell);
    },
    ApplyDayCellStyle: function (cell, date) {
        cell.style.cursor = "";
        var cal = this.calendar;
        var info = new ASPxClientCalendarStyleInfo();
        var needPointer = false;
        cal.ImportEtalonStyle(info, "D");
        if (this.IsDateVisible(date)) {
            if (cal.IsDateWeekend(date))
                cal.ImportEtalonStyle(info, "DW");
            if (this.IsDateOtherMonth(date))
                cal.ImportEtalonStyle(info, "DA");
            if (!cal.IsDateInRange(date))
                cal.ImportEtalonStyle(info, "DO");
            if (ASPxClientCalendar.AreDatesEqual(new Date(), date))
                cal.ImportEtalonStyle(info, "DT");
            if (!cal.clientEnabled)
                cal.ImportEtalonStyle(info, "DD");
            else if (!cal.enableMulti)
                needPointer = true;
        }
        info.Apply(cell);
        if (needPointer)
            _aspxSetPointerCursor(cell);
    },
    GetIDPostfix: function () {
        return "_" + this.row.toString() + "x" + this.column.toString();
    },
    GetCachedElementById: function (postfix) {
        if (this.calendar.IsMultiView())
            postfix += this.GetIDPostfix();
        return this.calendar.GetCachedElementById(this.calendar.name + "_" + postfix);
    },
    IsDateVisible: function (date) {
        var result = !this.calendar.IsMultiView() || !this.IsDateOtherMonth(date);
        if (!result) {
            result = result || this.isLowBoundary && date <= this.visibleDate ||
    this.isHighBoundary && date >= this.visibleDate;
        }
        return result;
    },
    MakeDisabledStateItems: function () {
        var cells = this.GetAuxCells();
        for (var i = 0; i < cells.length; i++)
            this.AddAuxDisabledStateItem(cells[i], this.GetAuxId(i));
        var element = this.GetTitleCell();
        if (_aspxIsExists(element))
            this.AddHeaderDisabledStateItem(element);
        var element = this.GetTitleElement();
        if (_aspxIsExists(element))
            this.AddHeaderDisabledStateItem(element);
    },
    AddAuxDisabledStateItem: function (element, id) {
        var cell = this.calendar.GetEtalonStyleCell("DD");
        element.id = id;
        aspxGetStateController().AddDisabledItem(id, cell.className, cell.style.cssText, null, null, null);
    },
    AddHeaderDisabledStateItem: function (element) {
        var cell = this.calendar.GetEtalonStyleCell("DD");
        aspxGetStateController().AddDisabledItem(element.id, cell.className, cell.style.cssText, null, null, null);
    },
    ChangeEnabledAttributes: function (enabled) {
        var element = this.GetPrevYearCell();
        if (_aspxIsExists(element))
            this.ChangeButtonEnabledAttributes(element, _aspxChangeAttributesMethod(enabled));
        var element = this.GetPrevMonthCell();
        if (_aspxIsExists(element))
            this.ChangeButtonEnabledAttributes(element, _aspxChangeAttributesMethod(enabled));
        var element = this.GetTitleElement();
        if (_aspxIsExists(element)) {
            this.ChangeButtonEnabledAttributes(element, _aspxChangeAttributesMethod(enabled));
            this.ChangeTitleElementEnabledAttributes(element, _aspxChangeStyleAttributesMethod(enabled));
        }
        var element = this.GetNextMonthCell();
        if (_aspxIsExists(element))
            this.ChangeButtonEnabledAttributes(element, _aspxChangeAttributesMethod(enabled));
        var element = this.GetNextYearCell();
        if (_aspxIsExists(element))
            this.ChangeButtonEnabledAttributes(element, _aspxChangeAttributesMethod(enabled));
        if (this.calendar.enabled && !this.calendar.readOnly)
            this.AttachMouseEvents(_aspxChangeEventsMethod(enabled), _aspxInitiallyChangeStyleAttributesMethod(enabled));
    },
    ChangeEnabledStateItems: function (enabled) {
        this.SetAuxCellsEnabled(enabled);
        this.SetHeaderCellsEnabled(enabled);
    },
    ChangeTitleElementEnabledAttributes: function (element, method) {
        method(element, "cursor");
    },
    ChangeButtonEnabledAttributes: function (element, method) {
        method(element, "onclick");
        method(element, "ondblclick");
    },
    SetAuxCellsEnabled: function (enabled) {
        var cells = this.GetAuxCells();
        for (var i = 0; i < cells.length; i++)
            aspxGetStateController().SetElementEnabled(cells[i], enabled);
    },
    SetHeaderCellsEnabled: function (enabled) {
        var element = this.GetPrevYearCell();
        if (_aspxIsExists(element))
            aspxGetStateController().SetElementEnabled(element, enabled);
        var element = this.GetPrevMonthCell();
        if (_aspxIsExists(element))
            aspxGetStateController().SetElementEnabled(element, enabled);
        var element = this.GetTitleCell();
        if (_aspxIsExists(element))
            aspxGetStateController().SetElementEnabled(element, enabled);
        var element = this.GetTitleElement();
        if (_aspxIsExists(element))
            aspxGetStateController().SetElementEnabled(element, enabled);
        var element = this.GetNextMonthCell();
        if (_aspxIsExists(element))
            aspxGetStateController().SetElementEnabled(element, enabled);
        var element = this.GetNextYearCell();
        if (_aspxIsExists(element))
            aspxGetStateController().SetElementEnabled(element, enabled);
    },
    GetAuxCells: function () {
        if (this.auxCells == null) {
            this.auxCells = [];
            var table = this.GetMonthTable();
            for (var i = 0; i < table.rows.length; i++) {
                var row = table.rows[i];
                if (i == 0 && this.calendar.showDayHeaders) {
                    for (var j = 0; j < row.cells.length; j++)
                        this.auxCells.push(row.cells[j]);
                }
                if (i > 0 && this.calendar.showWeekNumbers)
                    this.auxCells.push(row.cells[0]);
            }
        }
        return this.auxCells;
    },
    GetAuxId: function (index) {
        return this.calendar.name + "_AUX_" + this.row + "_" + this.column + "_" + index;
    }
});
ASPxClientCalendarFastNavigation = _aspxCreateClass(null, {
    constructor: function (calendar) {
        this.calendar = calendar;
        this.activeMonth = -1;
        this.activeYear = -1;
        this.startYear = -1;
        this.activeView = null;
        this.InitializeUI();
    },
    InitializeUI: function () {
        var item;
        var prefix = this.GetId();
        for (var m = 0; m < 12; m++) {
            item = this.GetMonthItem(m);
            if (!_aspxIsExistsElement(item))
                break;
            item.id = prefix + "_M" + m;
            _aspxAttachEventToElement(item, "click", new Function("aspxCalFNMClick('" + this.calendar.name + "', " + m + ")"));
        }
        for (var i = 0; i < 10; i++) {
            item = this.GetYearItem(i);
            if (!_aspxIsExistsElement(item))
                break;
            item.id = prefix + "_Y" + i;
            _aspxAttachEventToElement(item, "click", new Function("aspxCalFNYClick('" + this.calendar.name + "', " + i + ")"));
        }
        _aspxAttachEventToElement(this.GetPopup().GetWindowElement(-1), "click", new Function("aspxCalMainElemClick('" + this.calendar.name + "')"));
    },
    Show: function () {
        this.GetPopup().ShowAtElement(this.activeView.GetTitleElement());
    },
    Hide: function () {
        this.GetPopup().Hide();
    },
    SetMonth: function (month) {
        if (month != this.activeMonth) {
            var prevCell = this.GetMonthItem(this.activeMonth);
            var cell = this.GetMonthItem(month);
            if (_aspxIsExistsElement(prevCell))
                this.ApplyItemStyle(prevCell, false, "M");
            this.ApplyItemStyle(cell, true, "M");
            this.activeMonth = month;
        }
    },
    ShiftMonth: function (offset) {
        var month = (this.activeMonth + offset) % 12;
        month = (month < 0) ? month + 12 : month;
        this.SetMonth(month);
    },
    SetYear: function (year) {
        var startYear = Math.floor(year / 10) * 10;
        this.SetStartYear(startYear);
        this.SetYearIndex(year - startYear);
    },
    SetYearIndex: function (index) {
        var prevIndex = this.activeYear - this.startYear;
        if (index != prevIndex) {
            var prevCell = this.GetYearItem(prevIndex);
            if (_aspxIsExistsElement(prevCell))
                this.ApplyItemStyle(prevCell, false, "Y");
            var cell = this.GetYearItem(index);
            this.ApplyItemStyle(cell, true, "Y");
            this.activeYear = index + this.startYear;
        }
    },
    SetStartYear: function (year) {
        if (this.startYear == year) return;
        this.startYear = year;
        this.PrepareYearList();
    },
    ShiftYear: function (offset) {
        this.SetYear(this.activeYear + offset);
    },
    ShiftStartYear: function (offset) {
        this.SetStartYear(this.startYear + offset);
    },
    ApplyChanges: function () {
        this.GetPopup().Hide();
        var offset = ASPxClientCalendar.GetOffsetInMonths(this.calendar.visibleDate, new Date(this.activeYear, this.activeMonth, 1));
        offset -= this.activeView.row * this.calendar.columns + this.activeView.column;
        if (offset != 0) {
            var date = ASPxClientCalendar.AddMonths(this.calendar.visibleDate, offset);
            this.calendar.OnVisibleMonthChanged(date);
        }
        this.calendar.OnMainElementClick();
    },
    CancelChanges: function () {
        this.GetPopup().Hide();
        this.calendar.OnMainElementClick();
    },
    Prepare: function () {
        var date = this.activeView.visibleDate;
        this.activeYear = date.getFullYear();
        this.activeMonth = date.getMonth();
        this.startYear = ASPxClientCalendar.GetDecadeStartYear(this.activeYear);
        this.PrepareMonthList();
        this.PrepareYearList();
    },
    PrepareMonthList: function () {
        var item;
        for (var month = 0; month < 12; month++) {
            item = this.GetMonthItem(month);
            if (item == null)
                return;
            this.ApplyItemStyle(item, month == this.activeMonth, "M");
        }
    },
    PrepareYearList: function () {
        var year = this.startYear;
        var item;
        for (var index = 0; index < 10; index++) {
            item = this.GetYearItem(index);
            if (item == null)
                return;
            item.innerHTML = year+543;
            this.ApplyItemStyle(item, year == this.activeYear, "Y");
            year++;
        }
    },
    GetMonthItem: function (month) {
        var t = this.GetCachedElementById("m");
        if (!_aspxIsExistsElement(t))
            return null;
        var colIndex = month % 4;
        var rowIndex = (month - colIndex) / 4;
        return t.rows[rowIndex].cells[colIndex];
    },
    GetYearItem: function (index) {
        var t = this.GetCachedElementById("y");
        if (!_aspxIsExistsElement(t) || index < 0 || index > 9)
            return null;
        var colIndex = index % 5;
        var rowIndex = (index - colIndex) / 5;
        if (rowIndex == 0)
            colIndex++;
        return t.rows[rowIndex].cells[colIndex];
    },
    GetPopup: function () {
        return aspxGetControlCollection().Get(this.GetId());
    },
    ApplyItemStyle: function (item, isSelected, type) {
        var info = new ASPxClientCalendarStyleInfo();
        this.calendar.ImportEtalonStyle(info, "FN" + type);
        if (isSelected)
            this.calendar.ImportEtalonStyle(info, "FN" + type + "S");
        info.Apply(item);
    },
    GetCachedElementById: function (postfix) {
        return this.calendar.GetCachedElementById(this.GetId() + "_" + postfix);
    },
    GetId: function () {
        return this.calendar.name + "_FNP";
    },
    OnArrowUp: function (evt) {
        if (!evt.shiftKey)
            this.ShiftYear(-5);
        else
            this.ShiftMonth(-4);
    },
    OnArrowDown: function (evt) {
        if (!evt.shiftKey)
            this.ShiftYear(5);
        else
            this.ShiftMonth(4);
    },
    OnArrowLeft: function (evt) {
        if (!evt.shiftKey)
            this.ShiftYear(-1);
        else
            this.ShiftMonth(-1);
    },
    OnArrowRight: function (evt) {
        if (!evt.shiftKey)
            this.ShiftYear(1);
        else
            this.ShiftMonth(1);
    },
    OnPageUp: function (evt) {
        this.ShiftYear(-10);
    },
    OnPageDown: function (evt) {
        this.ShiftYear(10);
    },
    OnEnter: function () {
        this.ApplyChanges();
    },
    OnEscape: function () {
        this.CancelChanges();
    },
    OnMonthClick: function (month) {
        this.SetMonth(month);
    },
    OnYearClick: function (index) {
        this.SetYearIndex(index);
    },
    OnYearShuffle: function (offset) {
        this.ShiftStartYear(offset);
    },
    OnOkClick: function () {
        this.ApplyChanges();
    },
    OnCancelClick: function () {
        this.CancelChanges();
    }
});
ASPxClientCalendarStyleInfo = _aspxCreateClass(null, {
    constructor: function () {
        this.className = "";
        this.cssText = "";
    },
    Clone: function () {
        var clone = new ASPxClientCalendarStyleInfo();
        clone.className = this.className;
        clone.cssText = this.cssText;
        return clone;
    },
    Apply: function (element) {
        if (element.className != this.className)
            element.className = this.className;
        if (element._style != this.cssText) {
            element.style.cssText = this.cssText;
            element._style = this.cssText;
        }
    },
    Import: function (element) {
        if (element.className.length > 0) {
            if (this.className.length > 1)
                this.className += " ";
            this.className += element.className;
        }
        var cssText = element.style.cssText;
        if (cssText.length > 0) {
            var pos = cssText.length - 1;
            while (pos > -1 && cssText.charAt(pos) == " ")
                --pos;
            if (cssText.charAt(pos) != ";")
                cssText += ";";
            this.cssText += cssText;
        }
    }
});
ASPxClientCalendarSelectionEventArgs = _aspxCreateClass(ASPxClientProcessingModeEventArgs, {
    constructor: function (processOnServer, selection) {
        this.constructor.prototype.constructor.call(this, processOnServer);
        this.selection = selection;
    }
});
function aspxCalShiftMonth(name, monthOffset) {
    if (monthOffset != 0) {
        var edit = aspxGetControlCollection().Get(name);
        if (edit != null) {
            edit.OnShiftMonth(monthOffset);
        }
    }
}
function aspxCalDayMouseEvt(name, row, column, index, e, byWeeks) {
    var cal = aspxGetControlCollection().Get(name);
    if (cal != null) {
        var view = cal.GetView(row, column);
        var date = view.GetDateByIndex(index);
        if (byWeeks)
            date = ASPxClientCalendar.AddDays(date, cal.firstDayOfWeek - date.getDay());
        var allowed = cal.IsDateInRange(date) && (view.IsDateVisible(date) || byWeeks);
        switch (e.type) {
            case "mousedown":
                if (allowed && _aspxGetIsLeftButtonPressed(e))
                    cal.OnDayMouseDown(date, e.shiftKey, e.ctrlKey, byWeeks);
                break;
            case "mouseover":
                if (allowed) {
                    if (cal.forceMouseDown)
                        cal.OnDayMouseDown(date, false, false, false);
                    else if (cal.isMouseDown)
                        cal.OnDayMouseOver(date);
                }
                break;
            case "mouseup":
                if (cal.isMouseDown) {
                    if (allowed)
                        cal.OnDayMouseUp(date);
                    else
                        cal.OnSelectionCancelled();
                }
                break;
        }
    }
}
function aspxCalTodayClick(name) {
    var edit = aspxGetControlCollection().Get(name);
    if (edit != null)
        edit.OnTodayClick();
}
function aspxCalClearClick(name) {
    var edit = aspxGetControlCollection().Get(name);
    if (edit != null)
        edit.OnClearClick();
}
function aspxCalSelectMonth(name, row, column) {
    var edit = aspxGetControlCollection().Get(name);
    if (edit != null)
        edit.OnSelectMonth(row, column);
}
function aspxCalTitleClick(name, row, column) {
    var edit = aspxGetControlCollection().Get(name);
    if (edit != null)
        edit.OnTitleClick(row, column);
}
function aspxCalFNMClick(name, month) {
    var edit = aspxGetControlCollection().Get(name);
    if (edit != null)
        edit.fastNavigation.OnMonthClick(month);
}
function aspxCalFNYClick(name, index) {
    var edit = aspxGetControlCollection().Get(name);
    if (edit != null)
        edit.fastNavigation.OnYearClick(index);
}
function aspxCalFNYShuffle(name, offset) {
    var edit = aspxGetControlCollection().Get(name);
    if (edit != null)
        edit.fastNavigation.OnYearShuffle(offset);
}
function aspxCalFNBClick(name, action) {
    var edit = aspxGetControlCollection().Get(name);
    if (edit != null) {
        switch (action) {
            case "ok":
                edit.fastNavigation.OnOkClick();
                break;
            case "cancel":
                edit.fastNavigation.OnCancelClick();
                break;
        }
    }
}
function aspxCalMainElemClick(name) {
    var edit = aspxGetControlCollection().Get(name);
    if (edit != null)
        edit.OnMainElementClick();
}
function aspxCalDocMouseUp(evt) {
    var target = _aspxGetEventSource(evt);
    if (__aspxActiveCalendar != null && _aspxIsExistsElement(target)) {
        __aspxActiveCalendar.forceMouseDown = false;
        if (__aspxActiveCalendar.isMouseDown) {
            for (var key in __aspxActiveCalendar.views) {
                var view = __aspxActiveCalendar.views[key];
                if (view.constructor != ASPxClientCalendarView) continue;
                var monthCell = view.GetMonthCell();
                var parent = target.parentNode;
                while (_aspxIsExistsElement(parent)) {
                    if (parent == monthCell)
                        return;
                    parent = parent.parentNode;
                }
            }
            __aspxActiveCalendar.OnSelectionCancelled();
        }
        __aspxActiveCalendar = null;
    }
}
function aspxCalCancelSelect() {
    if (__aspxActiveCalendar != null) {
        __aspxActiveCalendar.forceMouseDown = false;
        __aspxActiveCalendar.OnSelectionCancelled();
    }
}
function _aspxGetInvariantDateStringCustom(date) {
    if (!date)
        return "01/01/0001";
    var day = date.getDate();
    var month = date.getMonth() + 1;
    var year = date.getFullYear();
    var result = "";
    if (month < 10)
        result += "0";
    result += month.toString() + "/";
    if (day < 10)
        result += "0";
    result += day.toString() + "/";
    if (year < 1000)
        result += "0";
 //   year = year + 543;
    result += year.toString();
    return result;
}
