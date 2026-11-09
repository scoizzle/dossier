# Fact ad378b34

Store id: 80daace5-b16c-4fb0-95e2-346fb97ca6c1

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
- posted_at: `2026-11-09T23:44:49.6928720+00:00`

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
  "id": "80daace5-b16c-4fb0-95e2-346fb97ca6c1",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.6928720+00:00"
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
  "subject_id": "2eac95b4-17b9-4f91-a0c1-1f33ce9c42ad",
  "subject_name": "django/db/models/expressions::RowRange",
  "tags": [
    "entity:class"
  ],
  "text": "class RowRange(WindowFrame)"
}
```
