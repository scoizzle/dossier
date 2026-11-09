# Fact fad02d69

Store id: b269e277-2526-4d68-ae4f-8b945b553e40

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
- posted_at: `2026-11-09T23:32:03.2569420+00:00`

## Data

```json
{
  "end_line": 410,
  "entity_kind": "method",
  "parent": "Exact",
  "start_line": 396,
  "symbol": "Exact.as_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":396,"selector":"L396-L410","symbol":"Exact.as_sql"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::Exact.as_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 410,
    "entity_kind": "method",
    "parent": "Exact",
    "start_line": 396,
    "symbol": "Exact.as_sql"
  },
  "id": "b269e277-2526-4d68-ae4f-8b945b553e40",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:03.2569420+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 396,
        "selector": "L396-L410",
        "symbol": "Exact.as_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "6a161ea5-f50f-44d9-af44-c5a1e1e4113e",
  "subject_name": "django/db/models/lookups::Exact.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self, compiler, connection)"
}
```
