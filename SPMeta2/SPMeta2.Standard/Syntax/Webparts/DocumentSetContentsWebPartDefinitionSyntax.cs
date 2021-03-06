using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using SPMeta2.Definitions.Webparts;
using SPMeta2.Models;
using SPMeta2.Standard.Definitions.Webparts;
using SPMeta2.Syntax.Default;

namespace SPMeta2.Standard.Syntax
{

    [Serializable]
    [DataContract]
    public class DocumentSetContentsWebPartModelNode : WebPartModelNode
    {

    }

    public static class DocumentSetContentsWebPartDefinitionSyntax
    {
        #region methods

        public static TModelNode AddDocumentSetContentsWebPart<TModelNode>(this TModelNode model, DocumentSetContentsWebPartDefinition definition)
            where TModelNode : ModelNode, IWebpartHostModelNode, new()
        {
            return AddDocumentSetContentsWebPart(model, definition, null);
        }

        public static TModelNode AddDocumentSetContentsWebPart<TModelNode>(this TModelNode model, DocumentSetContentsWebPartDefinition definition,
            Action<DocumentSetContentsWebPartModelNode> action)
            where TModelNode : ModelNode, IWebpartHostModelNode, new()
        {
            return model.AddTypedDefinitionNode(definition, action);
        }

        #endregion

        #region array overload

        public static TModelNode AddDocumentSetContentsWebParts<TModelNode>(this TModelNode model, IEnumerable<DocumentSetContentsWebPartDefinition> definitions)
           where TModelNode : ModelNode, IWebpartHostModelNode, new()
        {
            foreach (var definition in definitions)
                model.AddDefinitionNode(definition);

            return model;
        }

        #endregion
    }
}
