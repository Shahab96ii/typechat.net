﻿// Copyright (c) Microsoft. All rights reserved.

using System.Diagnostics.CodeAnalysis;

namespace Microsoft.TypeChat.Schema;

public struct VocabEntry : IComparable<VocabEntry>
{
    string _text;

    [JsonConstructor]
    public VocabEntry(string text)
    {
        _text = text;
    }

    public string Text => _text;

    public int CompareTo(VocabEntry other)
    {
        return _text.CompareTo(other._text);
    }

    public override bool Equals([NotNullWhen(true)] object? obj)
    {
        return base.Equals(obj);
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    public override string? ToString()
    {
        return _text;
    }

    public static implicit operator string(VocabEntry entry)
    {
        return entry._text;
    }
    public static implicit operator VocabEntry(string text)
    {
        return new VocabEntry(text);
    }
}
