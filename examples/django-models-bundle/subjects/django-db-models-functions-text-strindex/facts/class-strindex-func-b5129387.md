# Fact b5129387

Store id: 8348271a-2c22-4ccc-a898-61d2d163b18e

## Text

```text
class StrIndex(Func)
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
- posted_at: `2026-11-09T23:44:54.1565050+00:00`

## Data

```json
{
  "end_line": 342,
  "entity_kind": "class",
  "parent": "text",
  "start_line": 330,
  "symbol": "StrIndex"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/text.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":330,"selector":"L330-L342","symbol":"StrIndex"}`

## Items

```json
[
  {
    "text": "Return a positive integer corresponding to the 1-indexed position of the first occurrence of a substring inside another string, or 0 if the substring is not found.",
    "locator": {
      "line": 331
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/functions/text::StrIndex](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 342,
    "entity_kind": "class",
    "parent": "text",
    "start_line": 330,
    "symbol": "StrIndex"
  },
  "id": "8348271a-2c22-4ccc-a898-61d2d163b18e",
  "items": [
    {
      "locator": {
        "line": 331
      },
      "text": "Return a positive integer corresponding to the 1-indexed position of the first occurrence of a substring inside another string, or 0 if the substring is not found."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:54.1565050+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 330,
        "selector": "L330-L342",
        "symbol": "StrIndex"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/text.py"
    }
  ],
  "status": "live",
  "subject_id": "5213eacd-5e28-40da-a940-f7ae3a7be51c",
  "subject_name": "django/db/models/functions/text::StrIndex",
  "tags": [
    "entity:class"
  ],
  "text": "class StrIndex(Func)"
}
```
