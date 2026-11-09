# Fact abb62ceb

Store id: 9ad40419-4b23-46f9-9809-f55c7fcb8a33

## Text

```text
def get_direct_rhs_sql(self, connection, rhs)
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
- posted_at: `2026-11-09T22:39:48.2265910+00:00`

## Data

```json
{
  "end_line": 745,
  "entity_kind": "method",
  "parent": "YearLookup",
  "start_line": 744,
  "symbol": "YearLookup.get_direct_rhs_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":744,"selector":"L744-L745","symbol":"YearLookup.get_direct_rhs_sql"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::YearLookup.get_direct_rhs_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 745,
    "entity_kind": "method",
    "parent": "YearLookup",
    "start_line": 744,
    "symbol": "YearLookup.get_direct_rhs_sql"
  },
  "id": "9ad40419-4b23-46f9-9809-f55c7fcb8a33",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:48.2265910+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 744,
        "selector": "L744-L745",
        "symbol": "YearLookup.get_direct_rhs_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "20ed1ef2-2277-4502-a0b7-5fae51c0c006",
  "subject_name": "django/db/models/lookups::YearLookup.get_direct_rhs_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def get_direct_rhs_sql(self, connection, rhs)"
}
```
