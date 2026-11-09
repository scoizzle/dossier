# Fact 1c417526

Store id: 1e3de124-e9d5-4269-8ab9-44d9a9dcc31b

## Text

```text
def db_parameters(self, connection)
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
- posted_at: `2026-11-09T23:44:50.0664340+00:00`

## Data

```json
{
  "end_line": 1328,
  "entity_kind": "method",
  "parent": "CharField",
  "start_line": 1325,
  "symbol": "CharField.db_parameters"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1325,"selector":"L1325-L1328","symbol":"CharField.db_parameters"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::CharField.db_parameters](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1328,
    "entity_kind": "method",
    "parent": "CharField",
    "start_line": 1325,
    "symbol": "CharField.db_parameters"
  },
  "id": "1e3de124-e9d5-4269-8ab9-44d9a9dcc31b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.0664340+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1325,
        "selector": "L1325-L1328",
        "symbol": "CharField.db_parameters"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "1743da21-b4f7-4b6a-b491-23f32f01c95b",
  "subject_name": "django/db/models/fields/__init__::CharField.db_parameters",
  "tags": [
    "entity:method"
  ],
  "text": "def db_parameters(self, connection)"
}
```
