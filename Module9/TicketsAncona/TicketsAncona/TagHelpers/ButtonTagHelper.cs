using Microsoft.AspNetCore.Razor.TagHelpers;

namespace TicketsAncona.TagHelpers
{
    public class ButtonTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            string newClasses = "btn btn-primary";
            string oldClasses = output.Attributes["class"]?.Value.ToString() ?? "";
            string classes = (string.IsNullOrEmpty(oldClasses)) ? newClasses : $"{oldClasses} {newClasses}";
            output.Attributes.SetAttribute("class", classes);
        }
    }
}
