# Fact 8731a8e3

Store id: 155ce4b9-9623-49ce-bf1c-5efc3ef1c9d9

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
- posted_at: `2026-11-09T23:44:59.8337190+00:00`

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
  "id": "155ce4b9-9623-49ce-bf1c-5efc3ef1c9d9",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:59.8337190+00:00"
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
  "subject_id": "123d7e47-c457-44c7-9d32-9d36786d5a38",
  "subject_name": "django/db/models/sql/where::ExtraWhere",
  "tags": [
    "entity:class"
  ],
  "text": "class ExtraWhere"
}
```
