//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web.Mvc;

//namespace MvcTreeView.Helpers
//{
//    public static class TreeViewHtmlHelper
//    {
//        /// <summary>
//        /// Create a TreeView of nodes starting from a root element
//        /// </summary>
//        /// <param name="rootItems">The root nodes to create</param>
//        /// <param name="childrenProperty">A lambda expression that returns the children nodes</param>
//        /// <param name="itemContent">A lambda expression defining the content in each tree node</param>
//        public static MvcHtmlString TreeView<T>(this HtmlHelper html, IEnumerable<T> rootItems, Func<T, IEnumerable<T>> childrenProperty, Func<T, string> itemContent)
//        {
//            return html.TreeView(rootItems, childrenProperty, itemContent, true, null);
//        }

//        /// <summary>
//        /// Create a TreeView of nodes starting from a root element
//        /// </summary>
//        /// <param name="rootItems">The root nodes to create</param>
//        /// <param name="childrenProperty">A lambda expression that returns the children nodes</param>
//        /// <param name="itemContent">A lambda expression defining the content in each tree node</param>
//        /// <param name="includeJavaScript">If true, output will automatically render the JavaScript to turn the ul into the treeview</param>    
//        public static MvcHtmlString TreeView<T>(this HtmlHelper html, IEnumerable<T> rootItems, Func<T, IEnumerable<T>> childrenProperty, Func<T, string> itemContent, bool includeJavaScript)
//        {
//            return html.TreeView(rootItems, childrenProperty, itemContent, includeJavaScript, null);
//        }

//        /// <summary>
//        /// Create a TreeView of nodes starting from a root element
//        /// </summary>
//        /// <param name="rootItems">The root nodes to create</param>
//        /// <param name="childrenProperty">A lambda expression that returns the children nodes</param>
//        /// <param name="itemContent">A lambda expression defining the content in each tree node</param>
//        /// <param name="emptyContent">Content to be rendered when the tree is empty</param>
//        /// <param name="includeJavaScript">If true, output will automatically into the JavaScript to turn the ul into the treeview</param>    
//        public static MvcHtmlString TreeView<T>(this HtmlHelper html, IEnumerable<T> rootItems, Func<T, IEnumerable<T>> childrenProperty, Func<T, string> itemContent, bool includeJavaScript, string emptyContent)
//        {
//            var listItems = rootItems.ToList();

//            var ul = new TagBuilder("ul");

//            if (listItems.Count() == 0)
//            {
//                var li = new TagBuilder("li") {InnerHtml = emptyContent};
//                ul.InnerHtml = li.ToString();
//            }

//            foreach (var item in listItems)
//            {
//                RenderLi(ul, item, itemContent);
//                AppendChildren(ul, item, childrenProperty, itemContent);
//            }

//            return new MvcHtmlString(ul.ToString());
//        }

//        private static void AppendChildren<T>(TagBuilder ul, T root, Func<T, IEnumerable<T>> childrenProperty, Func<T, string> itemContent)
//        {
//            var children = childrenProperty(root).ToList();
//            if (children.Count() == 0)
//            {
//                return;
//            }

//            var innerUl = new TagBuilder("ul");
//            foreach (T item in children)
//            {
//                RenderLi(innerUl, item, itemContent);
//                AppendChildren(innerUl, item, childrenProperty, itemContent);
//            }

//            ul.InnerHtml += innerUl.ToString();
//        }

//        private static void RenderLi<T>(TagBuilder ul, T item, Func<T, string> itemContent)
//        {
//            var li = new TagBuilder("li")
//                         {
//                             InnerHtml = itemContent(item)
//                         };

//            ul.InnerHtml += li.ToString();
//        }
//    }
//}