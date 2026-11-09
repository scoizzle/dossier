# Fact 0871ca27

Store id: 0f0c08c0-91da-43dc-995b-b11522e7eb4d

## Text

```text
class ConcatPair(Func)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:47.0742310+00:00`

## Data

```json
{
  "end_line": 122,
  "entity_kind": "class",
  "parent": "text",
  "start_line": 68,
  "symbol": "ConcatPair"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/text.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":68,"selector":"L68-L122","symbol":"ConcatPair"}`

## Items

```json
[
  {
    "text": "Concatenate two arguments together. This is used by `Concat` because not all backend databases support more than two arguments.",
    "locator": {
      "line": 69
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/functions/text::ConcatPair](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 122,
    "entity_kind": "class",
    "parent": "text",
    "start_line": 68,
    "symbol": "ConcatPair"
  },
  "id": "0f0c08c0-91da-43dc-995b-b11522e7eb4d",
  "items": [
    {
      "locator": {
        "line": 69
      },
      "text": "Concatenate two arguments together. This is used by `Concat` because not all backend databases support more than two arguments."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:47.0742310+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 68,
        "selector": "L68-L122",
        "symbol": "ConcatPair"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/text.py"
    }
  ],
  "status": "live",
  "subject_id": "66a2ae94-1530-4fd8-810b-d50ed4f28277",
  "subject_name": "django/db/models/functions/text::ConcatPair",
  "tags": [
    "entity:class"
  ],
  "text": "class ConcatPair(Func)"
}
```
