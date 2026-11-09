# Fact fad02d69

Store id: e0237600-2024-467c-90e4-d607dd06e837

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
- posted_at: `2026-11-09T22:39:48.1052780+00:00`

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
  "id": "e0237600-2024-467c-90e4-d607dd06e837",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:48.1052780+00:00"
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
  "subject_id": "e1bbc459-9152-455d-a18a-bd9ede7dda75",
  "subject_name": "django/db/models/lookups::Exact.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self, compiler, connection)"
}
```
