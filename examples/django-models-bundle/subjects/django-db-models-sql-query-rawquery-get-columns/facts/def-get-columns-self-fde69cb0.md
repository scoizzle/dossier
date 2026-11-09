# Fact fde69cb0

Store id: a7f93adf-542e-4ce0-9bf5-e6dda65cf39f

## Text

```text
def get_columns(self)
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
- posted_at: `2026-11-09T23:44:58.5515280+00:00`

## Data

```json
{
  "end_line": 180,
  "entity_kind": "method",
  "parent": "RawQuery",
  "start_line": 176,
  "symbol": "RawQuery.get_columns"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":176,"selector":"L176-L180","symbol":"RawQuery.get_columns"}`

## Referenced by

None.

## Subject

[django/db/models/sql/query::RawQuery.get_columns](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 180,
    "entity_kind": "method",
    "parent": "RawQuery",
    "start_line": 176,
    "symbol": "RawQuery.get_columns"
  },
  "id": "a7f93adf-542e-4ce0-9bf5-e6dda65cf39f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:58.5515280+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 176,
        "selector": "L176-L180",
        "symbol": "RawQuery.get_columns"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "84cfcc60-4266-4607-a5a6-b9decc57f87b",
  "subject_name": "django/db/models/sql/query::RawQuery.get_columns",
  "tags": [
    "entity:method"
  ],
  "text": "def get_columns(self)"
}
```
