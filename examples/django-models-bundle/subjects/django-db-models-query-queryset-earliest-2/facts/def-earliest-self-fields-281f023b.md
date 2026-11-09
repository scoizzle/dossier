# Fact 281f023b

Store id: fbf8e0d4-2d46-4c5d-afa3-66efb5b6452c

## Text

```text
def earliest(self, *fields)
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
- posted_at: `2026-11-09T23:44:55.9404030+00:00`

## Data

```json
{
  "end_line": 1204,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 1201,
  "symbol": "QuerySet.earliest"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1201,"selector":"L1201-L1204","symbol":"QuerySet.earliest"}`

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet.earliest](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1204,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 1201,
    "symbol": "QuerySet.earliest"
  },
  "id": "fbf8e0d4-2d46-4c5d-afa3-66efb5b6452c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.9404030+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1201,
        "selector": "L1201-L1204",
        "symbol": "QuerySet.earliest"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "d4df75f2-b9b5-4ca4-8cc6-ba7b4ee783a0",
  "subject_name": "django/db/models/query::QuerySet.earliest",
  "tags": [
    "entity:method"
  ],
  "text": "def earliest(self, *fields)"
}
```
