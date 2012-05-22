﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Interpreter.intermediate;
using Interpreter.intermediate.ICodeImplementation;

namespace Interpreter.frontend.pascal.parsers
{
    public class CompoundStatementParser : StatementParser
    {
        public CompoundStatementParser(PascalParserTD parent) : base(parent)
        {
        }

        // Parse a compound statement.
        public ICodeNode Parse(Token token)
        {
            token = nextToken();

            // Create the compound node.
            ICodeNode compoundNode = ICodeFactory.CreateICodeNode(ICodeNodeTypeImplementation.COMPOUND);

            // Parse the statement list terminated by the END token.
            StatementParser statementParser = new StatementParser(this);
            statementParser.ParseList(token, compoundNode, PascalTokenType.END, PascalErrorCode.MISSING_END);

            return compoundNode;
        }
    }
}
