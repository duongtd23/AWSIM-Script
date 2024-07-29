//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.13.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from ../grammar/AWSIMScriptGrammar.g4 by ANTLR 4.13.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="AWSIMScriptGrammarParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.13.1")]
[System.CLSCompliant(false)]
public interface IAWSIMScriptGrammarListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="AWSIMScriptGrammarParser.scenario"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterScenario([NotNull] AWSIMScriptGrammarParser.ScenarioContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AWSIMScriptGrammarParser.scenario"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitScenario([NotNull] AWSIMScriptGrammarParser.ScenarioContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AWSIMScriptGrammarParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatement([NotNull] AWSIMScriptGrammarParser.StatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AWSIMScriptGrammarParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatement([NotNull] AWSIMScriptGrammarParser.StatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AWSIMScriptGrammarParser.assignmentStm"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAssignmentStm([NotNull] AWSIMScriptGrammarParser.AssignmentStmContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AWSIMScriptGrammarParser.assignmentStm"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAssignmentStm([NotNull] AWSIMScriptGrammarParser.AssignmentStmContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AWSIMScriptGrammarParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpression([NotNull] AWSIMScriptGrammarParser.ExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AWSIMScriptGrammarParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpression([NotNull] AWSIMScriptGrammarParser.ExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AWSIMScriptGrammarParser.function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunction([NotNull] AWSIMScriptGrammarParser.FunctionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AWSIMScriptGrammarParser.function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunction([NotNull] AWSIMScriptGrammarParser.FunctionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AWSIMScriptGrammarParser.argumentList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterArgumentList([NotNull] AWSIMScriptGrammarParser.ArgumentListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AWSIMScriptGrammarParser.argumentList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitArgumentList([NotNull] AWSIMScriptGrammarParser.ArgumentListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AWSIMScriptGrammarParser.arrayExp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterArrayExp([NotNull] AWSIMScriptGrammarParser.ArrayExpContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AWSIMScriptGrammarParser.arrayExp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitArrayExp([NotNull] AWSIMScriptGrammarParser.ArrayExpContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AWSIMScriptGrammarParser.positionExp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPositionExp([NotNull] AWSIMScriptGrammarParser.PositionExpContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AWSIMScriptGrammarParser.positionExp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPositionExp([NotNull] AWSIMScriptGrammarParser.PositionExpContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AWSIMScriptGrammarParser.lanePositionExp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLanePositionExp([NotNull] AWSIMScriptGrammarParser.LanePositionExpContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AWSIMScriptGrammarParser.lanePositionExp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLanePositionExp([NotNull] AWSIMScriptGrammarParser.LanePositionExpContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AWSIMScriptGrammarParser.routeExp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRouteExp([NotNull] AWSIMScriptGrammarParser.RouteExpContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AWSIMScriptGrammarParser.routeExp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRouteExp([NotNull] AWSIMScriptGrammarParser.RouteExpContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AWSIMScriptGrammarParser.variableExp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVariableExp([NotNull] AWSIMScriptGrammarParser.VariableExpContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AWSIMScriptGrammarParser.variableExp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVariableExp([NotNull] AWSIMScriptGrammarParser.VariableExpContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AWSIMScriptGrammarParser.spawnDelayOptionExp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSpawnDelayOptionExp([NotNull] AWSIMScriptGrammarParser.SpawnDelayOptionExpContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AWSIMScriptGrammarParser.spawnDelayOptionExp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSpawnDelayOptionExp([NotNull] AWSIMScriptGrammarParser.SpawnDelayOptionExpContext context);
}