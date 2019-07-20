using OmniSharp.Extensions.DebugAdapter.Protocol.Serialization;

namespace OmniSharp.Extensions.DebugAdapter.Protocol.Events
{
    public class SetExpressionResponse
    {
        /// <summary>
        /// The new value of the expression.
        /// </summary>
        public string value { get; set; }

        /// <summary>
        /// The optional type of the value.
        /// </summary>
        [Optional] public string type { get; set; }

        /// <summary>
        /// Properties of a value that can be used to determine how to render the result in the UI.
        /// </summary>
        [Optional] public VariablePresentationHint presentationHint { get; set; }

        /// <summary>
        /// If variablesReference is > 0, the value is structured and its children can be retrieved by passing variablesReference to the VariablesRequest.
        /// </summary>
        [Optional] public long? variablesReference { get; set; }

        /// <summary>
        /// The number of named child variables.
        /// The client can use this optional information to present the variables in a paged UI and fetch them in chunks.
        /// </summary>
        [Optional] public long? namedVariables { get; set; }

        /// <summary>
        /// The number of indexed child variables.
        /// The client can use this optional information to present the variables in a paged UI and fetch them in chunks.
        /// </summary>
        [Optional] public long? indexedVariables { get; set; }
    }

}