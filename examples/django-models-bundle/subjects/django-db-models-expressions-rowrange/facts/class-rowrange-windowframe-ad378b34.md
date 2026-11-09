# Fact ad378b34

Store id: 838b20f5-301e-4d13-9ea8-169bdd99fb57

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
- posted_at: `2026-11-09T22:39:41.7915150+00:00`

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
  "id": "838b20f5-301e-4d13-9ea8-169bdd99fb57",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.7915150+00:00"
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
  "subject_id": "e157405e-536d-4c4f-a17a-6dbaa7a034c3",
  "subject_name": "django/db/models/expressions::RowRange",
  "tags": [
    "entity:class"
  ],
  "text": "class RowRange(WindowFrame)"
}
```
