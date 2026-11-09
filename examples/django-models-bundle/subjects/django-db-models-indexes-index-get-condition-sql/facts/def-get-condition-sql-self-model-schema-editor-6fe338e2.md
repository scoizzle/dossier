# Fact 6fe338e2

Store id: 78e2bcb6-4cd3-4442-9073-e4fee85ecc6a

## Text

```text
def _get_condition_sql(self, model, schema_editor)
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
- posted_at: `2026-11-09T23:32:02.9114060+00:00`

## Data

```json
{
  "end_line": 184,
  "entity_kind": "method",
  "parent": "Index",
  "start_line": 177,
  "symbol": "Index._get_condition_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/indexes.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":177,"selector":"L177-L184","symbol":"Index._get_condition_sql"}`

## Referenced by

None.

## Subject

[django/db/models/indexes::Index._get_condition_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 184,
    "entity_kind": "method",
    "parent": "Index",
    "start_line": 177,
    "symbol": "Index._get_condition_sql"
  },
  "id": "78e2bcb6-4cd3-4442-9073-e4fee85ecc6a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:02.9114060+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 177,
        "selector": "L177-L184",
        "symbol": "Index._get_condition_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/indexes.py"
    }
  ],
  "status": "live",
  "subject_id": "8f869c10-d546-47c7-88ed-db71d5f15965",
  "subject_name": "django/db/models/indexes::Index._get_condition_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def _get_condition_sql(self, model, schema_editor)"
}
```
