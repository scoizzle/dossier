# Fact 2ca93469

Store id: d1ea6616-7f83-4104-b582-72ce12bad5f8

## Text

```text
def __init__(self, expression, pos, length=None, **extra)
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
- posted_at: `2026-11-09T22:39:47.2084990+00:00`

## Data

```json
{
  "end_line": 361,
  "entity_kind": "method",
  "parent": "Substr",
  "start_line": 349,
  "symbol": "Substr.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/text.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":349,"selector":"L349-L361","symbol":"Substr.__init__"}`

## Items

```json
[
  {
    "text": "expression: the name of a field, or an expression returning a string pos: an integer > 0, or an expression returning an integer length: an optional number of characters to return",
    "locator": {
      "line": 350
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/functions/text::Substr.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 361,
    "entity_kind": "method",
    "parent": "Substr",
    "start_line": 349,
    "symbol": "Substr.__init__"
  },
  "id": "d1ea6616-7f83-4104-b582-72ce12bad5f8",
  "items": [
    {
      "locator": {
        "line": 350
      },
      "text": "expression: the name of a field, or an expression returning a string pos: an integer > 0, or an expression returning an integer length: an optional number of characters to return"
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:47.2084990+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 349,
        "selector": "L349-L361",
        "symbol": "Substr.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/text.py"
    }
  ],
  "status": "live",
  "subject_id": "58dff103-fc54-48d2-aaea-a3b9646337c0",
  "subject_name": "django/db/models/functions/text::Substr.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, expression, pos, length=None, **extra)"
}
```
