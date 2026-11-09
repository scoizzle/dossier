# Fact 40785409

Store id: f000c17d-d107-4fd8-a88d-3c8ff776b40d

## Text

```text
def values(self, *fields, **expressions)
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
- posted_at: `2026-11-09T22:39:49.5777210+00:00`

## Data

```json
{
  "end_line": 1563,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 1559,
  "symbol": "QuerySet.values"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1559,"selector":"L1559-L1563","symbol":"QuerySet.values"}`

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet.values](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1563,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 1559,
    "symbol": "QuerySet.values"
  },
  "id": "f000c17d-d107-4fd8-a88d-3c8ff776b40d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.5777210+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1559,
        "selector": "L1559-L1563",
        "symbol": "QuerySet.values"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "d1311633-5f74-48e8-b02a-c1ca59febae8",
  "subject_name": "django/db/models/query::QuerySet.values",
  "tags": [
    "entity:method"
  ],
  "text": "def values(self, *fields, **expressions)"
}
```
