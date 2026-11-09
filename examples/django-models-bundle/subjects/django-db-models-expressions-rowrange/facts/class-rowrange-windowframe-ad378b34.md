# Fact ad378b34

Store id: 41713a10-393b-4c77-a8c3-da0b7e6ccf5a

## Text

```text
class RowRange(WindowFrame)
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
- posted_at: `2026-11-09T23:31:56.0378810+00:00`

## Data

```json
{
  "end_line": 2228,
  "entity_kind": "class",
  "parent": "expressions",
  "start_line": 2224,
  "symbol": "RowRange"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2224,"selector":"L2224-L2228","symbol":"RowRange"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::RowRange](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2228,
    "entity_kind": "class",
    "parent": "expressions",
    "start_line": 2224,
    "symbol": "RowRange"
  },
  "id": "41713a10-393b-4c77-a8c3-da0b7e6ccf5a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.0378810+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2224,
        "selector": "L2224-L2228",
        "symbol": "RowRange"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "75bdafa9-f8a5-42aa-9e35-26dd885ab8e5",
  "subject_name": "django/db/models/expressions::RowRange",
  "tags": [
    "entity:class"
  ],
  "text": "class RowRange(WindowFrame)"
}
```
