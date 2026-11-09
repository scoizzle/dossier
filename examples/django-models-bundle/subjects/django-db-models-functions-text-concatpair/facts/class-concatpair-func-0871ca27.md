# Fact 0871ca27

Store id: 6e8af1ea-0eaf-40fb-82c5-ed908e1b0def

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
- posted_at: `2026-11-09T23:32:02.1597460+00:00`

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
  "id": "6e8af1ea-0eaf-40fb-82c5-ed908e1b0def",
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
    "posted_at": "2026-11-09T23:32:02.1597460+00:00"
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
  "subject_id": "df6facfb-ff43-4b1a-9d4f-82b22ed3eaba",
  "subject_name": "django/db/models/functions/text::ConcatPair",
  "tags": [
    "entity:class"
  ],
  "text": "class ConcatPair(Func)"
}
```
