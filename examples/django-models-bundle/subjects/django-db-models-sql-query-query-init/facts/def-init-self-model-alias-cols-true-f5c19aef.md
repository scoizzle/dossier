# Fact f5c19aef

Store id: 291e9ae4-f543-4b4e-a9cf-2a4a8fe89fe3

## Text

```text
def __init__(self, model, alias_cols=True)
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
- posted_at: `2026-11-09T23:44:58.5888150+00:00`

## Data

```json
{
  "end_line": 330,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 305,
  "symbol": "Query.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":305,"selector":"L305-L330","symbol":"Query.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 330,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 305,
    "symbol": "Query.__init__"
  },
  "id": "291e9ae4-f543-4b4e-a9cf-2a4a8fe89fe3",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:58.5888150+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 305,
        "selector": "L305-L330",
        "symbol": "Query.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "754cac1c-604b-47a1-be69-eb24e61445fb",
  "subject_name": "django/db/models/sql/query::Query.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, model, alias_cols=True)"
}
```
