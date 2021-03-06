﻿<%@ WebHandler Language="C#" Class="index_html" %>

using System;
using System.Web;
using System.Linq;

using Ivony.Fluent;
using Ivony.Html;
using Ivony.Html.Web;
using Ivony.Html.Styles;
using Ivony.Html.Forms;
using Ivony.Html.Forms.Validation;
using Ivony.Html.Web.Mvc;

using DatabaseModel;


public class index_html : ViewHandler<IQueryable<Task>>
{

  protected override void ProcessDocument()
  {
    Document.FindSingle( "form" ).SetAttribute( "action", Url.Action( "Add" ) );




  }



  private void BindTaskItem( Task task, IHtmlElement taskElement )
  {
    taskElement.Elements( "span" ).Single().InnerText( task.Title );

    taskElement.Find( "a" ).SetAttribute( "_taskId", task.ID.ToString() );

    if ( task.Completed )
    {
      taskElement.Style( ".finished;" );
      taskElement.Find( "a[action=complete]" ).Remove();
    }
    else
    {
      taskElement.Find( "a[action=revert]" ).Remove();
    }
  }
}