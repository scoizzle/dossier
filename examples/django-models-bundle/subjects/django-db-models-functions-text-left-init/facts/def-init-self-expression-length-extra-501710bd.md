# Fact 501710bd

Store id: 434d2f7a-825e-4176-a2ab-3e557db8f102

## Text

```text
def __init__(self, expression, length, **extra)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:47.1051250+00:00`

## Data

```json
{
  "end_line": 167,
  "entity_kind": "method",
  "parent": "Left",
  "start_line": 159,
  "symbol": "Left.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/text.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":159,"selector":"L159-L167","symbol":"Left.__init__"}`

## Items

```json
[
  {
    "text": "expression: the name of a field, or an expression returning a string length: the number of characters to return from the start of the string",
    "locator": {
      "line": 160
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/functions/text::Left.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 167,
    "entity_kind": "method",
    "parent": "Left",
    "start_line": 159,
    "symbol": "Left.__init__"
  },
  "id": "434d2f7a-825e-4176-a2ab-3e557db8f102",
  "items": [
    {
      "locator": {
        "line": 160
      },
      "text": "expression: the name of a field, or an expression returning a string length: the number of characters to return from the start of the string"
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:47.1051250+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 159,
        "selector": "L159-L167",
        "symbol": "Left.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/text.py"
    }
  ],
  "status": "live",
  "subject_id": "55ea372a-1ed8-442b-90a4-53960e5f40b5",
  "subject_name": "django/db/models/functions/text::Left.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, expression, length, **extra)"
}
```
