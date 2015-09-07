﻿using System;
using System.Xml.Linq;

namespace NerdSince1984.Syndication.Atom
{
  /// <summary>Represents information about the generator of an Atom feed or source.</summary>
  public class AtomGenerator : AtomNode
  {
    /// <summary>Initializes a new instance of the <see cref="AtomGenerator"/> class.</summary>
    public AtomGenerator()
    {
      this.Text = Resources.AtomGeneratorText;
      this.Uri = Resources.AtomGeneratorUri;
      this.Version = Resources.AtomGeneratorVersion;
    }

    /// <summary>Initializes a new instance of the <see cref="AtomGenerator"/> class from an <see cref="XElement"/>.</summary>
    /// <param name="element">An <see cref="XElement"/> to create the node from.</param>
    protected AtomGenerator(XElement element) : base(element) { }

    /// <summary>Gets or sets the text information about the generator.</summary>
    /// <returns>A <see cref="string"/> representing text information about the generator.</returns>
    public string Text
    {
      get { return (string)this.Element; }
      protected set { this.Element.SetValue(value); }
    }

    /// <summary>Gets or sets the URI of the generator.</summary>
    /// <returns>A <see cref="string"/> representing the URI of the generator.</returns>
    public string Uri
    {
      get { return (string)this.Element.Attribute("uri"); }
      protected set { this.Element.SetAttributeValue("uri", value); }
    }

    /// <summary>Gets or sets the version of the generator.</summary>
    /// <returns>A <see cref="string"/> representing the version of the generator.</returns>
    public string Version
    {
      get { return (string)this.Element.Attribute("version"); }
      protected set { this.Element.SetAttributeValue("version", value); }
    }

    /// <summary>Gets an <see cref="XName"/> representing the name of the underlying element.</summary>
    /// <returns>An <see cref="XName"/> representing the name of the underlying element. For <see cref="AtomGenerator"/>, this value is <see cref="AtomFeed.AtomNamespace"/> + "generator".</returns>
    protected override XName ElementName
    {
      get { return AtomNamespace + "generator"; }
    }

    /// <summary>Returns a <see cref="string"/> representing text information about the generator.</summary>
    /// <returns>A <see cref="string"/> representing text information about the generator.</returns>
    public override string ToString()
    {
      return this.Text;
    }

    /// <summary>Converts an <see cref="AtomGenerator"/> to a <see cref="string"/>.</summary>
    /// <param name="node">An <see cref="AtomGenerator"/> to convert to a <see cref="string"/>.</param>
    /// <returns>A <see cref="string"/> converted from the specified <see cref="AtomGenerator"/>.</returns>
    public static implicit operator string(AtomGenerator node)
    {
      return node == null ? null : node.Text;
    }

    /// <summary>Converts a <see cref="string"/> to an <see cref="AtomGenerator"/>.</summary>
    /// <param name="text">A <see cref="string"/> to convert to an <see cref="AtomGenerator"/>.</param>
    /// <returns>An <see cref="AtomGenerator"/> converted from the specified <see cref="string"/>.</returns>
    public static implicit operator AtomGenerator(XElement element)
    {
      return element == null ? null : new AtomGenerator(element);
    }
  }
}