# Fact 8731a8e3

Store id: fb136a5c-d10f-4407-ac5c-64a0f0a6efad

## Text

```text
class ExtraWhere
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
- posted_at: `2026-11-09T22:39:51.9887890+00:00`

## Data

```json
{
  "end_line": 345,
  "entity_kind": "class",
  "parent": "where",
  "start_line": 334,
  "symbol": "ExtraWhere"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/where.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":334,"selector":"L334-L345","symbol":"ExtraWhere"}`

## Referenced by

None.

## Subject

[django/db/models/sql/where::ExtraWhere](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 345,
    "entity_kind": "class",
    "parent": "where",
    "start_line": 334,
    "symbol": "ExtraWhere"
  },
  "id": "fb136a5c-d10f-4407-ac5c-64a0f0a6efad",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:51.9887890+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 334,
        "selector": "L334-L345",
        "symbol": "ExtraWhere"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/where.py"
    }
  ],
  "status": "live",
  "subject_id": "1ab0866a-973d-4283-b2ab-84c158e7edae",
  "subject_name": "django/db/models/sql/where::ExtraWhere",
  "tags": [
    "entity:class"
  ],
  "text": "class ExtraWhere"
}
```
