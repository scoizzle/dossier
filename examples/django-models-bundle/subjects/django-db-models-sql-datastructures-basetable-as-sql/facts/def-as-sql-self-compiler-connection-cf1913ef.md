# Fact cf1913ef

Store id: d5eb295b-d467-4f58-8ccc-9728bc0d52cc

## Text

```text
def as_sql(self, compiler, connection)
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
- posted_at: `2026-11-09T22:39:51.0180700+00:00`

## Data

```json
{
  "end_line": 205,
  "entity_kind": "method",
  "parent": "BaseTable",
  "start_line": 197,
  "symbol": "BaseTable.as_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/datastructures.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":197,"selector":"L197-L205","symbol":"BaseTable.as_sql"}`

## Referenced by

None.

## Subject

[django/db/models/sql/datastructures::BaseTable.as_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 205,
    "entity_kind": "method",
    "parent": "BaseTable",
    "start_line": 197,
    "symbol": "BaseTable.as_sql"
  },
  "id": "d5eb295b-d467-4f58-8ccc-9728bc0d52cc",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:51.0180700+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 197,
        "selector": "L197-L205",
        "symbol": "BaseTable.as_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/datastructures.py"
    }
  ],
  "status": "live",
  "subject_id": "d2e50fbf-c093-4e9f-b642-f81b44ecbdf5",
  "subject_name": "django/db/models/sql/datastructures::BaseTable.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self, compiler, connection)"
}
```
