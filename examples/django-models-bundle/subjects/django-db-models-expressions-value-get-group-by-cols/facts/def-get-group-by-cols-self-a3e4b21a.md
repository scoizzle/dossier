# Fact a3e4b21a

Store id: 74578628-57bb-4766-9d84-5c9c1d526d90

## Text

```text
def get_group_by_cols(self)
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
- posted_at: `2026-11-09T22:39:41.5963290+00:00`

## Data

```json
{
  "end_line": 1213,
  "entity_kind": "method",
  "parent": "Value",
  "start_line": 1212,
  "symbol": "Value.get_group_by_cols"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1212,"selector":"L1212-L1213","symbol":"Value.get_group_by_cols"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Value.get_group_by_cols](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1213,
    "entity_kind": "method",
    "parent": "Value",
    "start_line": 1212,
    "symbol": "Value.get_group_by_cols"
  },
  "id": "74578628-57bb-4766-9d84-5c9c1d526d90",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.5963290+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1212,
        "selector": "L1212-L1213",
        "symbol": "Value.get_group_by_cols"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "44b3b057-528c-471d-9e1e-2200c045235c",
  "subject_name": "django/db/models/expressions::Value.get_group_by_cols",
  "tags": [
    "entity:method"
  ],
  "text": "def get_group_by_cols(self)"
}
```
