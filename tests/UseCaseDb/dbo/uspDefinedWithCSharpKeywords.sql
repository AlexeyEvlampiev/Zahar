CREATE PROCEDURE [dbo].[uspDefinedWithCSharpKeywords]
	@abstract INT, @as INT,   @base INT, @bool INT,
            @break INT,    @byte INT, @case INT, @catch INT,
            @char INT, @checked INT,  @class INT,   @const INT,
            @continue INT, @decimal INT,  @default INT,  @delegate INT,
            @do INT,   @double INT,  @else INT,  @enum INT,
            @event INT,   @explicit INT,    @extern INT, @false INT,
            @finally INT,  @fixed INT, @float INT,   @for INT,
            @foreach INT,  @goto INT, @if INT,   @implicit INT,
            @in INT,   @int INT, @interface INT,
            @internal INT, @is INT,   @lock INT, @long INT,
            @namespace INT,   @new INT,   @null INT, @object INT,
            @operator INT,    @out INT,  @override INT,
            @params INT,   @private INT, @protected INT, @public INT,
            @readonly INT, @ref INT,  @return INT,   @sbyte INT,
            @sealed INT, @short INT,  @sizeof INT,   @stackalloc INT,
            @static INT, @string INT, @struct INT,  @switch INT,
            @this INT,    @throw INT, @true INT, @try INT,
            @typeof INT,   @uint INT,    @ulong INT,   @unchecked INT,
            @unsafe INT, @ushort INT, @using INT,    @virtual INT,
            @void INT, @volatile INT, @while int
AS
BEGIN
	PRINT 'Test'
	RETURN 0
END
